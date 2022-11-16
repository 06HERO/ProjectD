USE [普雷二電玩]
GO

-- 建立 TRIGGER，當進貨單明細有新增時，自動增加數量至表中對應商品
CREATE TRIGGER 明細新增
ON [dbo].[進貨單明細]
FOR INSERT
AS
	DECLARE @庫存地點ID int
	DECLARE @廠商ID tinyint
	DECLARE @商品類型ID tinyint
	DECLARE @商品ID smallint
	DECLARE @商品數量 int

	SET @庫存地點ID = (SELECT a.庫存地點ID FROM [進貨單列表] a 
		            INNER JOIN inserted i ON i.進貨單編號 = a.進貨單編號)
	SET @廠商ID = (SELECT a.廠商ID FROM [進貨單列表] a 
		            INNER JOIN inserted i ON i.進貨單編號 = a.進貨單編號)
	SET @商品類型ID = (SELECT 商品類型ID FROM Inserted)
	SET @商品ID = (SELECT 商品ID FROM Inserted)
	SET @商品數量 = (SELECT 商品數量 FROM Inserted)

	--自動更新 商品在庫數量
	IF EXISTS	
	(		
		SELECT a.* FROM [dbo].[商品在庫數量] a
		WHERE a.庫存地點ID = @庫存地點ID
		  AND a.廠商ID = @廠商ID
		  AND a.商品類型ID = @商品類型ID
		  AND a.商品ID = @商品ID
	)
	BEGIN	
		--有資料時更新數量	
		--UPDATE [dbo].[商品在庫數量] SET [商品數量] = a.商品數量 + i.商品數量		
		--FROM [dbo].[商品在庫數量] a
		--INNER JOIN inserted i ON i .商品類型ID = a.商品類型ID AND i.商品ID = a.商品ID
		--INNER JOIN [dbo].[進貨單列表] b ON b.進貨單編號 = i.進貨單編號
		--WHERE a.廠商ID = b.廠商ID

		--自動計算 商品在庫數量加總
		DECLARE @ADD數量 int
		SET @ADD數量 = dbo.fn_商品在庫數量加總(@庫存地點ID, @廠商ID, @商品類型ID, @商品ID)		
		UPDATE [dbo].[商品在庫數量] SET [商品數量] = @ADD數量
		FROM [dbo].[商品在庫數量] a
		WHERE a.庫存地點ID = @庫存地點ID
		  AND a.廠商ID = @廠商ID
		  AND a.商品類型ID = @商品類型ID
		  AND a.商品ID = @商品ID
	END
	ELSE	--尚未有初筆資料時新增	
	BEGIN		
		INSERT INTO [dbo].[商品在庫數量]
           ([庫存地點ID], [廠商ID] ,[商品類型ID] ,[商品ID],[商品數量])
		VALUES
           (@庫存地點ID, @廠商ID, @商品類型ID, @商品ID, @商品數量 )

		--INSERT INTO [dbo].[商品在庫數量]
		--SELECT @庫存地點ID AS 庫存地點ID, @廠商ID AS 廠商ID, Inserted.商品類型ID, inserted.商品ID, inserted.商品數量
		--FROM Inserted
	END
	 
	--自動加總 進貨單明細.進貨成本
	--DECLARE @進貨價 int
	--SET @進貨價 = (SELECT [進貨價] FROM [dbo].[商品列表] a
	--			   INNER JOIN inserted i ON i.商品類型ID = a.商品類型ID AND i.商品ID = a.商品ID
	--			   INNER JOIN [dbo].[進貨單列表] b ON b.進貨單編號 = i.進貨單編號 AND b.廠商ID = a.廠商ID)
	--UPDATE [dbo].[進貨單明細] SET [進貨成本] = (@進貨價 * a.商品數量)
	--FROM [dbo].[進貨單明細] a
	--INNER JOIN inserted i ON i.商品類型ID = a.商品類型ID AND i.商品ID = a.商品ID	

	--自動計算 進貨單列表.進貨成本
	UPDATE [dbo].[進貨單列表] SET [進貨成本] = a.進貨成本
	FROM 
	(
		SELECT SUM(a.進貨成本) AS 進貨成本 
		FROM [dbo].[進貨單明細] a
		INNER JOIN inserted i ON i.進貨單編號 = a.進貨單編號
	) AS a
GO

-- 建立 TRIGGER，當進貨單明細有修改時，自動修改數量至表中對應商品
CREATE TRIGGER 明細更新
ON [dbo].[進貨單明細]
FOR UPDATE
AS
	-- 商品在庫數量無對應內容時不更新
	IF NOT EXISTS	
	(		
		SELECT a.* FROM [dbo].[商品在庫數量] a	
		INNER JOIN inserted i ON i .商品類型ID = a.商品類型ID AND i.商品ID = a.商品ID
		INNER JOIN [dbo].[進貨單列表] b ON b.進貨單編號 = i.進貨單編號 AND b.庫存地點ID = a.庫存地點ID
		WHERE a.廠商ID = b.廠商ID
	)
	RETURN

	DECLARE @庫存地點ID int
	DECLARE @廠商ID tinyint
	DECLARE @商品類型ID tinyint
	DECLARE @商品ID smallint
	DECLARE @商品數量 int

	SET @庫存地點ID = (SELECT a.庫存地點ID FROM [進貨單列表] a 
		            INNER JOIN inserted i ON i.進貨單編號 = a.進貨單編號)
	SET @廠商ID = (SELECT a.廠商ID FROM [進貨單列表] a 
		            INNER JOIN inserted i ON i.進貨單編號 = a.進貨單編號)
	SET @商品類型ID = (SELECT 商品類型ID FROM Inserted)
	SET @商品ID = (SELECT 商品ID FROM Inserted)
	SET @商品數量 = (SELECT 商品數量 FROM Inserted)

	--有資料時更新數量	
	--UPDATE [dbo].[商品在庫數量] SET [商品數量] = a.商品數量 + (i.商品數量 - d.商品數量)		
	--FROM [dbo].[商品在庫數量] a
	--INNER JOIN inserted i ON i .商品類型ID = a.商品類型ID AND i.商品ID = a.商品ID
	--INNER JOIN deleted d ON d.商品類型ID = a.商品類型ID AND d.商品ID = a.商品ID
	--INNER JOIN [dbo].[進貨單列表] b ON b.進貨單編號 = i.進貨單編號
	--WHERE a.廠商ID = b.廠商ID

	--自動計算 商品在庫數量加總
	DECLARE @ADD數量 int
	SET @ADD數量 = dbo.fn_商品在庫數量加總(@庫存地點ID, @廠商ID, @商品類型ID, @商品ID)
	UPDATE [dbo].[商品在庫數量] SET [商品數量] = @ADD數量
	FROM [dbo].[商品在庫數量] a
	WHERE a.庫存地點ID = @庫存地點ID
		AND a.廠商ID = @廠商ID
		AND a.商品類型ID = @商品類型ID
		AND a.商品ID = @商品ID

	--自動計算 進貨單列表.進貨成本
	UPDATE [dbo].[進貨單列表] SET [進貨成本] = a.進貨成本
	FROM 
	(
		SELECT SUM(a.進貨成本) AS 進貨成本 
		FROM [dbo].[進貨單明細] a
		INNER JOIN inserted i ON i.進貨單編號 = a.進貨單編號
	) AS a
GO

-- 建立 TRIGGER，當進貨單明細有修改時，自動修改數量至表中對應商品
CREATE TRIGGER 明細刪除
ON [dbo].[進貨單明細]
FOR DELETE
AS
	-- 商品在庫數量無對應內容時不更新
	IF NOT EXISTS	
	(		
		SELECT a.* FROM [dbo].[商品在庫數量] a	
		INNER JOIN deleted i ON i .商品類型ID = a.商品類型ID AND i.商品ID = a.商品ID
		INNER JOIN [dbo].[進貨單列表] b ON b.進貨單編號 = i.進貨單編號 AND b.庫存地點ID = a.庫存地點ID
		WHERE a.廠商ID = b.廠商ID
	)
	RETURN

	DECLARE @庫存地點ID int
	DECLARE @廠商ID tinyint
	DECLARE @商品類型ID tinyint
	DECLARE @商品ID smallint
	DECLARE @商品數量 int

	SET @庫存地點ID = (SELECT a.庫存地點ID FROM [進貨單列表] a 
		            INNER JOIN deleted i ON i.進貨單編號 = a.進貨單編號)
	SET @廠商ID = (SELECT a.廠商ID FROM [進貨單列表] a 
		            INNER JOIN deleted i ON i.進貨單編號 = a.進貨單編號)
	SET @商品類型ID = (SELECT 商品類型ID FROM deleted)
	SET @商品ID = (SELECT 商品ID FROM deleted)
	SET @商品數量 = (SELECT 商品數量 FROM deleted)

	--有資料時更新數量	
	--UPDATE [dbo].[商品在庫數量] SET [商品數量] = a.商品數量 - d.商品數量		
	--FROM [dbo].[商品在庫數量] a
	--INNER JOIN deleted d ON d.商品類型ID = a.商品類型ID AND d.商品ID = a.商品ID
	--INNER JOIN [dbo].[進貨單列表] b ON b.進貨單編號 = d.進貨單編號
	--WHERE a.廠商ID = b.廠商ID

	--自動計算 商品在庫數量加總
	DECLARE @ADD數量 int
	SET @ADD數量 = dbo.fn_商品在庫數量加總(@庫存地點ID, @廠商ID, @商品類型ID, @商品ID)
	UPDATE [dbo].[商品在庫數量] SET [商品數量] = @ADD數量
	FROM [dbo].[商品在庫數量] a
	WHERE a.庫存地點ID = @庫存地點ID
		AND a.廠商ID = @廠商ID
		AND a.商品類型ID = @商品類型ID
		AND a.商品ID = @商品ID

	--自動計算 進貨單列表.進貨成本
	UPDATE [dbo].[進貨單列表] SET [進貨成本] = a.進貨成本
	FROM 
	(
		SELECT SUM(a.進貨成本) AS 進貨成本 
		FROM [dbo].[進貨單明細] a
		INNER JOIN deleted i ON i.進貨單編號 = a.進貨單編號
	) AS a
GO