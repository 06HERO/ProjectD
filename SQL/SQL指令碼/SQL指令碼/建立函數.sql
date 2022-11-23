USE [普雷二電玩]
GO

--取得 使用者列表 顯示上修改欄位名稱為中文
SELECT [LoginID]	AS 使用者ID
      ,[LoginPW]	AS 密碼
	  , [IsAdmin]
      ,(CASE WHEN [IsAdmin] = 1 THEN '有' ELSE '無' END) AS 管理權限
      ,[Email]
      ,[IsCheck]
	  ,(CASE WHEN [IsCheck] = 1 THEN '是' ELSE '否' END) AS 已驗證
      ,[CheckCode]	AS 驗證碼
FROM [dbo].[使用者列表]
GO
CREATE FUNCTION fn_使用者列表()
RETURNS TABLE
AS RETURN
(
	SELECT [LoginID]	AS 使用者ID
		  ,[LoginPW]	AS 密碼
	     , [IsAdmin]
         ,(CASE WHEN [IsAdmin] = 1 THEN '有' ELSE '無' END) AS 管理權限
         ,[Email]
         ,[IsCheck]
	     ,(CASE WHEN [IsCheck] = 1 THEN '是' ELSE '否' END) AS 已驗證
         ,[CheckCode]	AS 驗證碼
	FROM [dbo].[使用者列表]
)
GO
SELECT * FROM fn_使用者列表()

--取得 進貨單列表 Join 廠商列表/庫存地點列表 聯合資料
SELECT a.進貨單編號, a.廠商ID, b.廠商名稱, a.庫存地點ID, c.庫存地點, a.進貨日期, a.明細筆數, a.進貨成本
FROM [dbo].[進貨單列表] a
JOIN [dbo].[廠商列表] b ON b.廠商ID = a.廠商ID
JOIN [dbo].[庫存地點列表] c ON c.庫存地點ID = a.庫存地點ID
GO
CREATE FUNCTION fn_進貨單列表()
RETURNS TABLE
AS RETURN
(
	SELECT a.進貨單編號, a.廠商ID, b.廠商名稱, a.庫存地點ID, c.庫存地點, a.進貨日期, a.明細筆數, a.進貨成本
	FROM [dbo].[進貨單列表] a
	JOIN [dbo].[廠商列表] b ON b.廠商ID = a.廠商ID
	JOIN [dbo].[庫存地點列表] c ON c.庫存地點ID = a.庫存地點ID
)
GO
SELECT * FROM fn_進貨單列表()
ORDER BY 進貨單編號


--取得 進貨單明細 Join 進貨單列表/商品類型列表/商品列表 聯合資料
SELECT a.進貨單編號, a.商品類型ID, c.商品類型名稱, a.商品ID, d.商品名稱, a.商品數量, d.進貨價, a.進貨成本, a.備註
FROM [dbo].[進貨單明細] a
JOIN [dbo].[進貨單列表] b ON b.進貨單編號 = a.進貨單編號
JOIN [dbo].[商品類型列表] c ON c.商品類型ID = a.商品類型ID
JOIN [dbo].[商品列表] d ON d.廠商ID = b.廠商ID AND d.商品類型ID = c.商品類型ID AND d.商品ID = a.商品ID
GO
CREATE FUNCTION fn_進貨單明細()
RETURNS TABLE
AS RETURN
(
	SELECT a.進貨單編號, a.商品類型ID, c.商品類型名稱, a.商品ID, d.商品名稱, a.商品數量, d.進貨價, a.進貨成本, a.備註
	FROM [dbo].[進貨單明細] a
	JOIN [dbo].[進貨單列表] b ON b.進貨單編號 = a.進貨單編號
	JOIN [dbo].[商品類型列表] c ON c.商品類型ID = a.商品類型ID
	JOIN [dbo].[商品列表] d ON d.廠商ID = b.廠商ID AND d.商品類型ID = c.商品類型ID AND d.商品ID = a.商品ID
)
GO
SELECT * FROM fn_進貨單明細()
ORDER BY 進貨單編號

--取得 商品列表 Join 廠商列表/商品類型列表 聯合資料
SELECT a.廠商ID, b.廠商名稱, a.商品類型ID, c.商品類型名稱, a.商品ID, a.商品名稱, a.進貨價, a.零售價 
FROM [dbo].[商品列表] a
INNER JOIN [dbo].[廠商列表] b ON b.[廠商ID] = a.[廠商ID]
INNER JOIN [dbo].[商品類型列表] c ON c.商品類型ID = a.商品類型ID
GO
CREATE FUNCTION fn_商品列表()
RETURNS TABLE
AS RETURN
(
	SELECT a.廠商ID, b.廠商名稱, a.商品類型ID, c.商品類型名稱, a.商品ID, a.商品名稱, a.進貨價, a.零售價 
	FROM [dbo].[商品列表] a
	INNER JOIN [dbo].[廠商列表] b ON b.[廠商ID] = a.[廠商ID]
	INNER JOIN [dbo].[商品類型列表] c ON c.商品類型ID = a.商品類型ID
)
GO
SELECT * FROM fn_商品列表()
ORDER BY 廠商ID

--fn_庫存列表
SELECT	a.庫存地點ID,b.庫存地點, a.廠商ID , c.廠商名稱, a.商品類型ID, d.商品類型名稱, a.商品ID, e.商品名稱,
a.商品數量, e.進貨價, e.零售價 		
FROM 商品在庫數量 a
INNER JOIN 庫存地點列表 b ON b.庫存地點ID = a.庫存地點ID
INNER JOIN 廠商列表 c ON c.廠商ID = a.廠商ID
INNER JOIN 商品類型列表 d ON d.商品類型ID = a.商品類型ID
INNER JOIN 商品列表 e ON e.廠商ID = a.廠商ID AND e.商品類型ID = a.商品類型ID AND e.商品ID = a.商品ID
GO
CREATE FUNCTION fn_庫存列表()
RETURNS TABLE
AS RETURN
(
	SELECT	a.庫存地點ID,b.庫存地點, a.廠商ID, c.廠商名稱, c.統一編號, a.商品類型ID, d.商品類型名稱, a.商品ID, e.商品名稱,
			a.商品數量, e.進貨價, e.零售價, b.地址  
			FROM 商品在庫數量 a
			INNER JOIN 庫存地點列表 b ON b.庫存地點ID = a.庫存地點ID
			INNER JOIN 廠商列表 c ON c.廠商ID = a.廠商ID
			INNER JOIN 商品類型列表 d ON d.商品類型ID = a.商品類型ID
			INNER JOIN 商品列表 e ON e.廠商ID = a.廠商ID AND e.商品類型ID = a.商品類型ID AND e.商品ID = a.商品ID
)
GO
SELECT * FROM fn_庫存列表()
ORDER BY 庫存地點ID

--fn_總商品庫存表()
SELECT 商品類型名稱,商品名稱 ,SUM(商品數量) AS 總庫存量
FROM 商品在庫數量 a 
JOIN 商品列表 b ON a.商品ID=b.商品ID
JOIN 商品類型列表 c ON b.商品類型ID=c.商品類型ID
WHERE a.商品類型ID = c.商品類型ID AND a.商品ID=b.商品ID
GROUP BY 商品類型名稱,商品名稱

CREATE FUNCTION fn_總商品庫存表()
RETURNS TABLE
AS RETURN
(
	--SELECT 商品類型名稱,商品名稱 ,SUM(商品數量) AS 總庫存量
	--FROM 商品在庫數量 a 
	--JOIN 商品列表 b ON a.商品ID=b.商品ID
	--JOIN 商品類型列表 c ON b.商品類型ID=c.商品類型ID
	--WHERE a.商品類型ID = c.商品類型ID AND a.商品ID=b.商品ID
	--GROUP BY 商品類型名稱,商品名稱

	SELECT b.商品類型名稱, 商品名稱 ,SUM(商品數量) AS 總庫存量
	FROM 商品在庫數量 a 
	JOIN 商品類型列表 b ON b.商品類型ID = a.商品類型ID
	JOIN 商品列表 c ON c.商品ID = a.商品ID AND c.商品類型ID = a.商品類型ID AND c.廠商ID = a.廠商ID
	GROUP BY 商品類型名稱,商品名稱
)
GO
SELECT * FROM fn_總商品庫存表()

--fn_商品在庫數量加總
CREATE FUNCTION fn_商品在庫數量加總(@庫存地點ID int, @廠商ID tinyint, @商品類型ID tinyint, @商品ID smallint)
RETURNS int
BEGIN
	DECLARE @商品數量 int
	SET @商品數量 = 
		(
			SELECT SUM(a.商品數量)
			FROM
			(
				SELECT a.進貨單編號, a.庫存地點ID, a.廠商ID, b.商品類型ID, b.商品ID, b.商品數量
				FROM [dbo].[進貨單列表] a
				INNER JOIN [dbo].[進貨單明細] b ON b.進貨單編號 = a.進貨單編號
			) AS a
			WHERE a.庫存地點ID = @庫存地點ID
			AND 廠商ID =@廠商ID
			AND 商品類型ID =@商品類型ID
			AND 商品ID = @商品ID
		)

	IF @商品數量 IS NULL
	BEGIN
		SET @商品數量=0
	END


	RETURN @商品數量
END
SELECT dbo.fn_商品在庫數量加總(1, 1, 1, 1) AS 'ADD數量'













--