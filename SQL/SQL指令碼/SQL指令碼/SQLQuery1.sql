USE [普雷二電玩]
GO

--查詢識別屬性最後值
SELECT @@IDENTITY
FROM [dbo].[進貨單列表]
-- 重置Table識別屬性值
DBCC CHECKIDENT(進貨單列表, RESEED , 0 )

INSERT INTO [dbo].[進貨單列表]
           ([廠商ID], [進貨日期])
     VALUES
           (1, GETDATE())
GO

--查詢
SELECT * FROM [dbo].[進貨單列表]

