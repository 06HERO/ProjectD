USE [普雷二電玩]
GO

--索尼(1)
INSERT INTO [dbo].[廠商列表]
           ([廠商ID], [廠商名稱])
     VALUES
           (1,'索尼')
GO

--任天堂(2)
INSERT INTO [dbo].[廠商列表]
           ([廠商ID], [廠商名稱])
     VALUES
           (2, '任天堂')
GO

--微軟(3)
INSERT INTO [dbo].[廠商列表]
           ([廠商ID], [廠商名稱])
     VALUES
           (3,'微軟')
GO

--查詢
SELECT * FROM [dbo].[廠商列表]
