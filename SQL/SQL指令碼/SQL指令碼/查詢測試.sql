-- 商品資料
SELECT * FROM [dbo].[廠商列表]
SELECT * FROM [dbo].[商品類型列表]
SELECT * FROM [dbo].[商品列表]

-- 進貨相關
SELECT * FROM [dbo].[進貨單列表]
SELECT * FROM [dbo].[進貨單明細]
SELECT a.進貨單編號, c.廠商名稱, d.商品類型名稱, e.商品名稱, a.商品數量, b.進貨日期, e.進貨價, (e.進貨價 * a.商品數量) AS 小計
FROM [dbo].[進貨單明細] a
JOIN [dbo].[進貨單列表] b ON b.進貨單編號 = a.進貨單編號
INNER JOIN [dbo].[廠商列表] c ON c.廠商ID = b.廠商ID
JOIN [dbo].[商品類型列表] d ON d.商品類型ID = a.商品類型ID
JOIN [dbo].[商品列表] e ON e.廠商ID = b.廠商ID AND e.商品類型ID = d.商品類型ID AND e.商品ID = a.商品ID

-- 庫存相關
SELECT * FROM [dbo].[商品在庫數量]
SELECT b.廠商名稱, c.商品類型名稱, d.商品名稱, a.商品數量
FROM [dbo].[商品在庫數量] a
INNER JOIN [dbo].[廠商列表] b ON b.廠商ID = a.廠商ID
INNER JOIN [dbo].[商品類型列表] c ON c.商品類型ID = a.商品類型ID
INNER JOIN [dbo].[商品列表] d ON d.廠商ID = a.廠商ID AND d.商品類型ID = a.商品類型ID AND d.商品ID = a.商品ID

SELECT b.廠商名稱, SUM(a.商品數量) AS 全部商品數量
FROM [dbo].[商品在庫數量] a
LEFT JOIN [dbo].[廠商列表] b ON b.廠商ID = a.廠商ID
GROUP BY b.廠商名稱

SELECT b.廠商名稱, c.商品類型名稱, SUM(a.商品數量) AS 同商品類型數量
FROM [dbo].[商品在庫數量] a
LEFT JOIN [dbo].[廠商列表] b ON b.廠商ID = a.廠商ID
LEFT JOIN [dbo].[商品類型列表] c ON c.商品類型ID = a.商品類型ID
GROUP BY b.廠商名稱, c.商品類型名稱

--清除進貨資料順序
DELETE FROM [dbo].[商品在庫數量]
DELETE FROM [dbo].[進貨單明細]
DELETE FROM [dbo].[進貨單列表]

--清除商品資料順序
DELETE FROM [dbo].[商品列表]
DELETE FROM [dbo].[商品類型列表]
DELETE FROM [dbo].[廠商列表]


