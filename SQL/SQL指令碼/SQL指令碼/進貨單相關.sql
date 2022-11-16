USE [普雷二電玩]
GO

-- 建立 TRIGGER，當進貨單明細有新增時，自動增加數量至表中對應商品
ALTER TRIGGER 明細新增
ON [dbo].[進貨單明細]
FOR INSERT
AS
	--自動更新 商品在庫數量
	IF EXISTS	
	(		
		SELECT a.* FROM [dbo].[商品在庫數量] a	
		INNER JOIN inserted i ON i .商品類型ID = a.商品類型ID AND i.商品ID = a.商品ID
		INNER JOIN [dbo].[進貨單列表] b ON b.進貨單編號 = i.進貨單編號 AND b.庫存地點ID = a.庫存地點ID
		WHERE a.廠商ID = b.廠商ID
	)
	BEGIN	--有資料時更新數量	
		UPDATE [dbo].[商品在庫數量] SET [商品數量] = a.商品數量 + i.商品數量
		FROM [dbo].[商品在庫數量] a
		INNER JOIN inserted i ON i .商品類型ID = a.商品類型ID AND i.商品ID = a.商品ID
		INNER JOIN [dbo].[進貨單列表] b ON b.進貨單編號 = i.進貨單編號
		WHERE a.廠商ID = b.廠商ID
	END
	ELSE	--尚未有初筆資料時新增	
	BEGIN
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

--查詢識別屬性最後值
--SELECT @@IDENTITY
-- 重置Table識別屬性值
--DBCC CHECKIDENT(進貨單列表, RESEED , 0 )

-- 建立進貨單列表及明細資料
INSERT INTO [dbo].[進貨單列表]
           ([進貨單編號],[廠商ID], [庫存地點ID], [進貨日期], [明細筆數])
     VALUES
           (1,1,1, '2022-09-22',2)
GO
INSERT INTO [dbo].[進貨單明細]
           ([進貨單編號],[商品類型ID],[商品ID],[商品數量])
     VALUES
           (1,1,1,100)
GO
INSERT INTO [dbo].[進貨單明細]
           ([進貨單編號],[商品類型ID],[商品ID],[商品數量])
     VALUES
           (1,1,2,200)
GO

INSERT INTO [dbo].[進貨單列表]
           ([進貨單編號],[廠商ID], [庫存地點ID], [進貨日期], [明細筆數])
     VALUES
           (2, 2, 2, '2022-10-23', 2)
GO
INSERT INTO [dbo].[進貨單明細]
           ([進貨單編號],[商品類型ID],[商品ID],[商品數量])
     VALUES
           (2,1,1,50)
GO

INSERT INTO [dbo].[進貨單明細]
           ([進貨單編號],[商品類型ID],[商品ID],[商品數量])
     VALUES
           (2,1,2,100)
GO

--查詢
SELECT * FROM [dbo].[進貨單列表]
SELECT * FROM [dbo].[進貨單明細]
SELECT * FROM [dbo].[商品在庫數量]

SELECT a.進貨單編號, a.廠商ID, b.廠商名稱, a.庫存地點ID, c.庫存地點, a.明細筆數, a.進貨成本
FROM [dbo].[進貨單列表] a
JOIN [dbo].[廠商列表] b ON b.廠商ID = a.廠商ID
JOIN [dbo].[庫存地點列表] c ON c.庫存地點ID = a.庫存地點ID

SELECT a.進貨單編號, c.商品類型名稱, d.商品名稱, a.商品數量, b.進貨日期
FROM [dbo].[進貨單明細] a
JOIN [dbo].[進貨單列表] b ON b.進貨單編號 = a.進貨單編號
JOIN [dbo].[商品類型列表] c ON c.商品類型ID = a.商品類型ID
JOIN [dbo].[商品列表] d ON d.廠商ID = b.廠商ID AND d.商品類型ID = c.商品類型ID AND d.商品ID = a.商品ID

DELETE FROM [dbo].[商品在庫數量]
DELETE FROM [dbo].[進貨單明細]
DELETE FROM [dbo].[進貨單列表]










