USE [普雷二電玩]
GO

--建立連線方式
SET NUMERIC_ROUNDABORT OFF;
SET ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, ARITHABORT,
  QUOTED_IDENTIFIER, ANSI_NULLS ON;
GO

-- 改使用函式fn_商品列表取得
--建立 VIEW v總合商品列表(WITH SCHEMABINDING：可建立索引)
--CREATE VIEW dbo.v總合商品列表	
--WITH SCHEMABINDING
--AS
--	SELECT a.廠商ID, b.廠商名稱, a.商品類型ID, c.商品類型名稱, a.商品ID, a.商品名稱, a.進貨價, a.零售價 
--	FROM [dbo].[商品列表] a
--	INNER JOIN [dbo].[廠商列表] b ON b.[廠商ID] = a.[廠商ID]
--	INNER JOIN [dbo].[商品類型列表] c ON c.商品類型ID = a.商品類型ID	
--GO
---- 建立 總合商品列表 的索引
--CREATE UNIQUE CLUSTERED INDEX IDX_IDS
--  ON dbo.v總合商品列表(廠商ID, 商品類型ID, 商品ID);
--GO
--SELECT * FROM [dbo].[v總合商品列表]

--建立 VIEW v綜合庫存列表(WITH SCHEMABINDING：可建立索引)
CREATE VIEW [dbo].[v綜合庫存列表]
--WITH SCHEMABINDING
AS
	SELECT	a.庫存地點ID,b.庫存地點, a.廠商ID, c.廠商名稱, c.統一編號, a.商品類型ID, d.商品類型名稱, a.商品ID, e.商品名稱,
			a.商品數量, e.進貨價, e.零售價, b.地址   		
	FROM 商品在庫數量 a
	INNER JOIN 庫存地點列表 b ON b.庫存地點ID = a.庫存地點ID
	INNER JOIN 廠商列表 c ON c.廠商ID = a.廠商ID
	INNER JOIN 商品類型列表 d ON d.商品類型ID = a.商品類型ID
	INNER JOIN 商品列表 e ON e.廠商ID = a.廠商ID AND e.商品類型ID = a.商品類型ID AND e.商品ID = a.商品ID

GO
-- 建立 總合商品列表 的索引
--CREATE UNIQUE CLUSTERED INDEX IDX_IDS
--  ON dbo.v綜合庫存列表 (庫存地點ID);
--GO
SELECT * FROM [dbo].[v綜合庫存列表]

--建立 VIEW v綜合庫存列表
CREATE VIEW v總商品庫存表
AS
SELECT 商品類型名稱,商品名稱 ,SUM(商品數量) AS 總庫存量
FROM 商品在庫數量 a JOIN 商品列表 b ON a.商品ID=b.商品ID
JOIN 商品類型列表 c ON b.商品類型ID=c.商品類型ID
WHERE a.商品類型ID = c.商品類型ID AND a.商品ID=b.商品ID
GROUP BY 商品類型名稱,商品名稱
GO
SELECT * FROM [dbo].[v總商品庫存表]


