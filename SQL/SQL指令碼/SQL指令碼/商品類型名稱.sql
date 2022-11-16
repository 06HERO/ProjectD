USE [普雷二電玩]
GO

--(主機)
INSERT INTO [dbo].[商品類型名稱]
           ([商品類型ID], [商品類型名稱])
     VALUES
           (1, '主機')
GO

--查詢
SELECT * FROM [dbo].[商品類型名稱]