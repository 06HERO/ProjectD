USE [普雷二電玩]
GO

--新增產品 索尼/主機/PlayStation 5 數位版(1/1/1)
INSERT INTO [dbo].[商品列表]
           ([廠商ID]
           ,[商品類型ID]
           ,[商品ID]
           ,[商品名稱]
           ,[進貨價]
           ,[零售價])
     VALUES
           (1
           ,1
           ,1
           ,'PlayStation 5 數位版'
           ,10200
           ,14580)
GO

--新增產品 索尼/主機/PlayStation 5 數位版(1/1/2)
INSERT INTO [dbo].[商品列表]
           ([廠商ID]
           ,[商品類型ID]
           ,[商品ID]
           ,[商品名稱]
           ,[進貨價]
           ,[零售價])
     VALUES
           (1
           ,1
           ,2
           ,'PlayStation 5 光碟版'
           ,12300
           ,17580)
GO

--新增產品 任天堂/主機/Nintendo Switch 主機(2/1/1)
INSERT INTO [dbo].[商品列表]
           ([廠商ID]
           ,[商品類型ID]
           ,[商品ID]
           ,[商品名稱]
           ,[進貨價]
           ,[零售價])
     VALUES
           (2
           ,1
           ,1
           ,'Nintendo Switch 主機'
           ,5100
           ,7280)
GO

--新增產品 任天堂/主機/Nintendo Switch OLED主機 主機(2/1/2)
INSERT INTO [dbo].[商品列表]
           ([廠商ID]
           ,[商品類型ID]
           ,[商品ID]
           ,[商品名稱]
           ,[進貨價]
           ,[零售價])
     VALUES
           (2
           ,1
           ,2
           ,'Nintendo Switch OLED主機'
           ,7000
           ,9980)
GO

--新增產品 微軟/主機/'Xbox Series S 主機(3/1/1)
INSERT INTO [dbo].[商品列表]
           ([廠商ID]
           ,[商品類型ID]
           ,[商品ID]
           ,[商品名稱]
           ,[進貨價]
           ,[零售價])
     VALUES
           (3
           ,1
           ,1
           ,'Xbox Series S 主機'
           ,6600
           ,9480)
GO

-- 微軟/主機/Xbox Series X 主機(3/1/2)
INSERT INTO [dbo].[商品列表]
           ([廠商ID]
           ,[商品類型ID]
           ,[商品ID]
           ,[商品名稱]
           ,[進貨價]
           ,[零售價])
     VALUES
           (3
           ,1
           ,2
           ,'Xbox Series X 主機'
           ,10700
           ,15380)
GO

--查詢所有商品
SELECT a.廠商ID, b.廠商名稱, a.商品類型ID, c.商品類型名稱, a.商品ID, a.商品名稱, a.進貨價, a.零售價 
FROM [dbo].[商品列表] a
LEFT JOIN [dbo].[廠商列表] b ON b.[廠商ID] = a.[廠商ID]
LEFT JOIN [dbo].[商品類型列表] c ON c.商品類型ID = a.商品類型ID
ORDER BY [廠商ID]