USE [普雷二電玩]
GO

SELECT * FROM [dbo].[商品在庫數量]

SELECT b.廠商名稱, c.商品類型名稱, d.商品名稱, a.商品數量
FROM [dbo].[商品在庫數量] a
INNER JOIN [dbo].[廠商列表] b ON b.廠商ID = a.廠商ID
INNER JOIN [dbo].[商品類型列表] c ON c.商品類型ID = a.商品類型ID
INNER JOIN [dbo].[商品列表] d ON d.廠商ID = a.廠商ID AND d.商品類型ID = a.商品類型ID AND d.商品ID = a.商品ID

--DELETE FROM [dbo].[商品在庫數量]