USE [普雷二電玩]
GO

--普雷二官方信箱
--play2sev@gmail.com
--伺服器名稱:smtp.gmail.com
--通訊埠編號:587
--PW:zxcv90-=
--應用程式PW:jcnkynchqsdmrdkk

-- 取亂數前面補0至6位
Select RIGHT(REPLICATE('0',6)  + CAST( (Round(RAND() * 1000000, 0)) as NVARCHAR), 6) AS 'RAM'

-- 新增使用者列表
CREATE PROC dbo.Insert使用者列表
@LoginID nvarchar(20),@LoginPW nvarchar(20),@IsAdmin smallint,
@Email nvarchar(100), @IsCheck tinyint = 0
AS
	INSERT INTO [dbo].[使用者列表]
           ([LoginID], [LoginPW], [IsAdmin], [Email], [IsCheck])
     VALUES
           (@LoginID, @LoginPW, @IsAdmin, @Email, @IsCheck)
GO

-- 使用者登入驗證 BY PW
CREATE PROC dbo.使用者LoginByPW
@LoginID nvarchar(20),@LoginPW nvarchar(20), 
@IsAdmin smallint OUTPUT, @IsCheck tinyint OUTPUT
AS
	IF NOT EXISTS
	(
		SELECT * FROM 使用者列表  
		WHERE LoginID = @LoginID
		AND LoginPW = @LoginPW
	)
	BEGIN
		SET @IsAdmin = -1
		SET @IsCheck = 0	
	END
	ELSE
	BEGIN	
		SELECT @IsAdmin = IsAdmin, @IsCheck = IsCheck  
		FROM [dbo].[使用者列表] 
		WHERE LoginID = @LoginID
		AND LoginPW = @LoginPW
		
		IF(@IsCheck = 0)
		BEGIN
			UPDATE [dbo].[使用者列表]
			SET [CheckCode] = RIGHT(REPLICATE('0',6)  + CAST( (Round(RAND() * 1000000, 0)) as NVARCHAR), 6)
			WHERE LoginID = @LoginID

			EXEC Mail_CheckCode @LoginID
		END
	END
GO

CREATE PROC dbo.Mail_CheckCode
@LoginID nvarchar(20)
AS
	DECLARE @BODY nvarchar(MAX)	
	SET @BODY = '<table><tr><td>今日驗證碼為 ' + CAST((SELECT CheckCode FROM 使用者列表	WHERE LoginID= @LoginID) AS nvarchar(10)) + '</td></tr></table>'	

	EXEC msdb.dbo.sp_send_dbmail
         @body_format= 'HTML',
         @profile_name = '普雷二官方信箱',
         @recipients = 'shanshonc@gmail.com', --收件者
         --@body = "<table><tr><td>今日驗證碼為</td></tr></table>",--內文
		 @body = @BODY,--內文
         --@query='SELECT getdate()',  --還可以下查詢式哦
		 @subject = '今日驗證碼';--主旨=tilte
GO

CREATE PROC dbo.使用者LoginByCheckCode
@LoginID nvarchar(20), @CheckCode nvarchar(6)
AS
	IF NOT EXISTS
	(
		SELECT * FROM 使用者列表  
		WHERE LoginID = @LoginID
		AND CheckCode = @CheckCode
	)
	RETURN 0

	UPDATE 使用者列表 SET IsCheck = 1
	WHERE LoginID = @LoginID
	AND CheckCode = @CheckCode
GO

CREATE PROC dbo.重置CheckCode
@IsAdmin smallint = -1, @LoginID nvarchar(20) = ''
AS
	DECLARE @SQL nvarchar(500)

	SET @SQL = 'UPDATE [使用者列表] 
	            SET IsCheck = 0, CheckCode = '''' 
				WHERE 1 = 1'

	IF @IsAdmin >= 0
	BEGIN
		SET @SQL = @SQL + ' AND IsAdmin = ' + '''' + CAST(@IsAdmin AS nvarchar(2))+ '''' 
	END

	IF @LoginID <> ''
	BEGIN
		SET @SQL = @SQL + ' AND LoginID = ' + '''' + @LoginID + ''''
	END

	EXEC sp_sqlexec @SQL	
GO

ALTER PROC dbo.Update使用者PW
@LoginID nvarchar(20),@LoginPW nvarchar(20) = ''
AS
	IF NOT EXISTS
	(
		SELECT * FROM 使用者列表
		WHERE LoginID = @LoginID
	)
	RETURN	

	UPDATE [dbo].[使用者列表]
	SET [LoginPW] = @LoginPW
	WHERE LoginID = @LoginID

	IF @LoginPW = ''
	BEGIN
		EXEC 重置CheckCode -1, @LoginID

		UPDATE [dbo].[使用者列表]
		SET [CheckCode] = RIGHT(REPLICATE('0',6)  + CAST( (Round(RAND() * 1000000, 0)) as NVARCHAR), 6)
		WHERE LoginID = @LoginID

		EXEC Mail_CheckCode @LoginID
	END
GO


-- 新增廠商列表資料
CREATE PROC dbo.Insert廠商列表
@廠商ID tinyint, @廠商名稱 nvarchar(50),
@統一編號 nvarchar(10) = '', @代表人姓名 nvarchar(50) = '', @資本總額 decimal(15, 2) = 0,
@聯絡電話 nvarchar(20) = '', @顯示與否 varchar(1) = 'y' 
AS
	IF EXISTS
	(
		SELECT * FROM [dbo].[廠商列表]
		WHERE [廠商ID] = @廠商ID
		OR [廠商名稱] = @廠商名稱
	)
	RETURN
	
	INSERT INTO [dbo].[廠商列表]
			([廠商ID], [廠商名稱], [統一編號] ,[代表人姓名], [資本總額], [聯絡電話], [顯示與否])
	VALUES
			(@廠商ID, @廠商名稱, @統一編號, @代表人姓名, @資本總額,@聯絡電話, @顯示與否)
GO
-- 修改廠商列表資料(修改廠商名稱/統一編號/代表人姓名/資本總額/聯絡電話/顯示與否)
CREATE PROC dbo.Update廠商列表
@廠商ID tinyint, @廠商名稱 nvarchar(50),
@統一編號 nvarchar(10) = '', @代表人姓名 nvarchar(50) = '', @資本總額 decimal(15, 2) = 0,
@聯絡電話 nvarchar(20) = '', @顯示與否 varchar(1) = 'y'
AS	
	IF NOT EXISTS
	(
		SELECT * FROM [dbo].[廠商列表]
		WHERE [廠商ID] = @廠商ID
	)
	RETURN

	IF EXISTS
	(
		SELECT * FROM [dbo].[廠商列表]
		WHERE [廠商名稱] = @廠商名稱
	)
	RETURN
	
	UPDATE [dbo].[廠商列表]
	SET [廠商ID] = @廠商ID ,[廠商名稱] = @廠商名稱 ,[統一編號] = @統一編號, [代表人姓名] = @代表人姓名,
	    [資本總額] = @資本總額, [聯絡電話] = @聯絡電話, [顯示與否] = @顯示與否
	WHERE [廠商ID] = @廠商ID
GO
--刪除廠商列表資料
CREATE PROC dbo.Delete廠商列表
@廠商ID tinyint
AS
	IF NOT EXISTS
	(
		SELECT * FROM [dbo].[廠商列表]
		WHERE [廠商ID] = @廠商ID
	)
	RETURN

	IF EXISTS
	(
		SELECT * FROM [dbo].[商品列表]
		WHERE [廠商ID] = @廠商ID
	)
	RETURN

	DELETE FROM [dbo].[廠商列表]
	WHERE [廠商ID] = @廠商ID
GO

-- 新增商品類型資料
CREATE PROC dbo.Insert商品類型列表
@商品類型ID tinyint, @商品類型名稱 nvarchar(30)
AS
	IF EXISTS
	(
		SELECT * FROM [dbo].[商品類型列表]
		WHERE [商品類型ID] = @商品類型ID
		OR [商品類型名稱] = @商品類型名稱
	)
	RETURN
	
	INSERT INTO [dbo].[商品類型列表]
        ([商品類型ID], [商品類型名稱])
	VALUES
        (@商品類型ID, @商品類型名稱)	
GO
-- 修改商品類型資料(修改商品類型名稱)
CREATE PROC dbo.Update商品類型列表
@商品類型ID tinyint, @商品類型名稱 nvarchar(30)
AS
	IF NOT EXISTS
	(
		SELECT * FROM [dbo].[商品類型列表]
		WHERE [商品類型ID] = @商品類型ID
	)
	RETURN

	IF EXISTS
	(
		SELECT * FROM [dbo].[商品類型列表]
		WHERE [商品類型名稱] = @商品類型名稱
	)
	RETURN
	
	UPDATE [dbo].[商品類型列表]
	SET [商品類型名稱] = @商品類型名稱
	WHERE [商品類型ID] = @商品類型ID	
GO
--刪除商品類型資料
CREATE PROC dbo.Delete商品類型列表
@商品類型ID tinyint
AS
	IF NOT EXISTS
	(
		SELECT * FROM [dbo].[商品類型列表]
		WHERE [商品類型ID] = @商品類型ID
	)
	RETURN

	IF EXISTS
	(
		SELECT * FROM [dbo].[商品列表]
		WHERE [商品類型ID] = @商品類型ID
	)
	RETURN

	DELETE FROM [dbo].[商品類型列表]
	WHERE [商品類型ID] = @商品類型ID
GO

-- 新增商品列表資料
CREATE PROC dbo.Insert商品列表
@廠商ID tinyint, @商品類型ID tinyint, @商品ID smallint, 
@商品名稱 nvarchar(50), @進貨價 decimal(10, 2), @零售價 decimal(10, 2)
AS
	IF EXISTS
	(
		SELECT * FROM [dbo].[商品列表]
		WHERE [廠商ID] = @廠商ID
		AND [商品類型ID] = @商品類型ID
		AND [商品ID] = @商品ID
	)
	RETURN

	INSERT INTO [dbo].[商品列表]
           ([廠商ID], [商品類型ID], [商品ID], [商品名稱], [進貨價], [零售價])
    VALUES
           (@廠商ID, @商品類型ID, @商品ID, @商品名稱, @進貨價, @零售價)
GO
-- 修改商品列表資料(修改商品名稱/進貨價/零售價)
CREATE PROC dbo.Update商品列表
@廠商ID tinyint, @商品類型ID tinyint, @商品ID smallint, 
@商品名稱 nvarchar(50), @進貨價 decimal(10, 2), @零售價 decimal(10, 2)
AS
	IF NOT EXISTS
	(
		SELECT * FROM [dbo].[商品列表]
		WHERE [廠商ID] = @廠商ID
		AND [商品類型ID] = @商品類型ID
		AND [商品ID] = @商品ID
	)
	RETURN	

	UPDATE [dbo].[商品列表]
	SET [商品名稱] = @商品名稱, [進貨價] = @進貨價, [零售價] = @零售價
	WHERE [廠商ID] = @廠商ID
	AND [商品類型ID] = @商品類型ID
	AND [商品ID] = @商品ID
GO
--刪除商品列表資料
CREATE PROC dbo.Delete商品列表
@廠商ID tinyint, @商品類型ID tinyint, @商品ID smallint 
AS
	IF NOT EXISTS
	(
		SELECT * FROM [dbo].[商品列表]
		WHERE [廠商ID] = @廠商ID
		AND [商品類型ID] = @商品類型ID
		AND [商品ID] = @商品ID
	)
	RETURN

	DELETE FROM [dbo].[商品列表]
	WHERE [廠商ID] = @廠商ID
	AND [商品類型ID] = @商品類型ID
	AND [商品ID] = @商品ID
GO

-- 新增庫存地點列表資料
CREATE PROC dbo.Insert庫存地點列表
@地點ID int, @庫存地點 nvarchar(50), @地址 nvarchar(100) = ''
AS
	IF EXISTS
	(
		SELECT * FROM [dbo].[庫存地點列表]
		WHERE [庫存地點ID] = @地點ID
		OR [庫存地點] = @庫存地點
	)
	RETURN
	
	INSERT INTO [dbo].[庫存地點列表]
			([庫存地點ID], [庫存地點], [地址])
	VALUES
			(@地點ID, @庫存地點, @地址)
GO
-- 修改庫存地點列表資料(修改庫存地點/地址)
CREATE PROC dbo.Update庫存地點列表
@地點ID int, @庫存地點 nvarchar(50), @地址 nvarchar(100) = ''
AS	
	IF NOT EXISTS
	(
		SELECT * FROM [dbo].[庫存地點列表]
		WHERE [庫存地點ID] = @地點ID
	)
	RETURN

	IF EXISTS
	(
		SELECT * FROM [dbo].[庫存地點列表]
		WHERE [庫存地點] = @庫存地點
	)
	RETURN
	
	UPDATE [dbo].[庫存地點列表]
	SET [庫存地點] = @庫存地點, [地址] = @地址
	WHERE [庫存地點ID] = @地點ID
GO
--刪除庫存地點列表資料
CREATE PROC dbo.Delete庫存地點列表
@地點ID int
AS
	IF NOT EXISTS
	(
		SELECT * FROM [dbo].[庫存地點列表]
		WHERE [庫存地點ID] = @地點ID
	)
	RETURN
	
	IF EXISTS
	(
		SELECT * FROM [dbo].[進貨單列表]
		WHERE [庫存地點ID] = @地點ID
	)
	RETURN

	DELETE FROM [dbo].[庫存地點列表]
	WHERE [庫存地點ID] = @地點ID
GO

-- 新增進貨單列表資料
CREATE PROC dbo.Insert進貨單列表
@進貨單編號 int, @廠商ID tinyint, @庫存地點ID int,
@進貨日期 datetime, @明細筆數 tinyint
AS
	IF NOT EXISTS
	(
		SELECT * FROM [dbo].[廠商列表]
		WHERE [廠商ID] = @廠商ID
	)
	RETURN

	IF EXISTS
	(
		SELECT * FROM [dbo].[進貨單列表]
		WHERE 進貨單編號 = @進貨單編號
	)
	RETURN
	
	INSERT INTO [dbo].[進貨單列表]
           ([進貨單編號],[廠商ID], [庫存地點ID], [進貨日期], [明細筆數])
    VALUES
           (@進貨單編號, @廠商ID, @庫存地點ID, @進貨日期, @明細筆數)
GO
-- 修改進貨單列表資料(修改 庫存地點ID/進貨日期/明細筆數)
CREATE PROC dbo.Update進貨單列表
@進貨單編號 int, @庫存地點ID int, @進貨日期 datetime, @明細筆數 tinyint
AS
	IF NOT EXISTS
	(
		SELECT * FROM [dbo].[進貨單列表]
		WHERE 進貨單編號 = @進貨單編號
	)
	RETURN

	IF NOT EXISTS
	(
		SELECT * FROM [dbo].[庫存地點列表]
		WHERE [庫存地點ID] = @庫存地點ID
	)
	RETURN	

	UPDATE [dbo].[進貨單列表]
	SET [庫存地點ID] = @庫存地點ID, [進貨日期] = @進貨日期, [明細筆數] = @明細筆數
	WHERE 進貨單編號 = @進貨單編號
GO
--刪除進貨單列表資料
CREATE PROC dbo.Delete進貨單列表
@進貨單編號 int
AS
	IF NOT EXISTS
	(
		SELECT * FROM [dbo].[進貨單列表]
		WHERE 進貨單編號 = @進貨單編號
	)
	RETURN

	IF EXISTS
	(
		SELECT * FROM [dbo].[進貨單明細]
		WHERE 進貨單編號 = @進貨單編號
	)
	RETURN

	DELETE FROM [dbo].[進貨單列表]
	WHERE 進貨單編號 = @進貨單編號
GO

-- 新增進貨單明細資料
CREATE PROC dbo.Insert進貨單明細
@進貨單編號 int, @商品類型ID tinyint, @商品ID smallint, @商品數量 smallint,
@進貨成本 decimal(15, 2) = 0, @備註 nvarchar(300) = '無' 
AS
	DECLARE @廠商ID tinyint
	DECLARE @進貨價 decimal(10, 2)

	IF NOT EXISTS
	(
		SELECT * FROM [dbo].[進貨單列表]
		WHERE 進貨單編號 = @進貨單編號
	)
	RETURN

	IF EXISTS
	(
		SELECT * FROM [dbo].[進貨單明細]
		WHERE [進貨單編號] = @進貨單編號
		  AND [商品類型ID] = @商品類型ID
		  AND [商品ID] = @商品ID	
	)
	RETURN
	
	SET @廠商ID = (SELECT 廠商ID FROM [進貨單列表] WHERE 進貨單編號 = @進貨單編號)
	SET @進貨價 =
	(
		SELECT [進貨價] 
		FROM [dbo].[商品列表] a
		WHERE a.廠商ID = @廠商ID
		AND a.商品類型ID = @商品類型ID
		AND a.商品ID = @商品ID
	)
	IF @進貨價 IS NULL
	RETURN	

	--帶入參數為0時 自動計算進貨成本
	IF @進貨成本 = 0
	BEGIN
		SET @進貨成本 = @進貨價 * @商品數量
	END
	
	INSERT INTO [dbo].[進貨單明細]
           ([進貨單編號],[商品類型ID], [商品ID], [商品數量],[進貨成本],[備註])
    VALUES
           (@進貨單編號, @商品類型ID, @商品ID, @商品數量, @進貨成本, @備註)
GO

-- 修改進貨單明細資料(修改 商品數量/進貨成本/備註)
CREATE PROC dbo.Update進貨單明細
@進貨單編號 int, @商品類型ID tinyint, @商品ID smallint, 
@商品數量 smallint, @進貨成本 decimal(15, 2) = 0, @備註 nvarchar(300) = '無' 
AS
	DECLARE @廠商ID tinyint
	DECLARE @進貨價 decimal(10, 2)

	--IF NOT EXISTS
	--(
	--	SELECT * FROM [dbo].[進貨單列表]
	--	WHERE 進貨單編號 = @進貨單編號
	--)
	--RETURN

	IF NOT EXISTS
	(
		SELECT * FROM [dbo].[進貨單明細]
		 WHERE [進貨單編號] = @進貨單編號
		   AND [商品類型ID] = @商品類型ID
		   AND [商品ID] = @商品ID	
	)
	RETURN
	
	SET @廠商ID = (SELECT 廠商ID FROM [進貨單列表] WHERE 進貨單編號 = @進貨單編號)
	SET @進貨價 =
	(
		SELECT [進貨價] 
		FROM [dbo].[商品列表] a
		WHERE a.廠商ID = @廠商ID
		AND a.商品類型ID = @商品類型ID
		AND a.商品ID = @商品ID
	)
	IF @進貨價 IS NULL
	RETURN	

	--帶入參數為0時 自動計算進貨成本
	IF @進貨成本 = 0
	BEGIN
		SET @進貨成本 = @進貨價 * @商品數量
	END

	UPDATE [dbo].[進貨單明細]
	SET [商品數量] = @商品數量, [進貨成本] = @進貨成本, [備註] = @備註
	WHERE [進貨單編號] = @進貨單編號
	  AND [商品類型ID] = @商品類型ID
	  AND [商品ID] = @商品ID
GO
--刪除進貨單明細資料
ALTER PROC dbo.Delete進貨單明細
@進貨單編號 int, @商品類型ID tinyint, @商品ID smallint 
AS
	DECLARE @廠商ID tinyint
	DECLARE @進貨價 decimal(10, 2)

	--IF NOT EXISTS
	--(
	--	SELECT * FROM [dbo].[進貨單列表]
	--	WHERE 進貨單編號 = @進貨單編號
	--)
	--RETURN

	IF NOT EXISTS
	(
		SELECT * FROM [dbo].[進貨單明細]
		 WHERE [進貨單編號] = @進貨單編號
		   AND [商品類型ID] = @商品類型ID
		   AND [商品ID] = @商品ID	
	)
	RETURN

	DELETE FROM [dbo].[進貨單明細]
	WHERE [進貨單編號] = @進貨單編號
		   AND [商品類型ID] = @商品類型ID
		   AND [商品ID] = @商品ID	
GO