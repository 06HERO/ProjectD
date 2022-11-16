USE [普雷二電玩]
GO

INSERT INTO [dbo].[經銷商列表]
           ([經銷商ID] ,[經銷商名稱])
     VALUES
           (1 , '台北店')
GO
INSERT INTO [dbo].[經銷商列表]
           ([經銷商ID] ,[經銷商名稱])
     VALUES
           (2 , '林口店')
GO
INSERT INTO [dbo].[經銷商列表]
           ([經銷商ID] ,[經銷商名稱])
     VALUES
           (3 , '桃園店')
GO
INSERT INTO [dbo].[經銷商列表]
           ([經銷商ID] ,[經銷商名稱])
     VALUES
           (4 , '新竹店')
GO
INSERT INTO [dbo].[經銷商列表]
           ([經銷商ID] ,[經銷商名稱])
     VALUES
           (5 , '台中店')
GO
INSERT INTO [dbo].[經銷商列表]
           ([經銷商ID] ,[經銷商名稱])
     VALUES
           (6 , '台南店')
GO
INSERT INTO [dbo].[經銷商列表]
           ([經銷商ID] ,[經銷商名稱])
     VALUES
           (7 , '高雄店')
GO
INSERT INTO [dbo].[經銷商列表]
           ([經銷商ID] ,[經銷商名稱])
     VALUES
           (8 , '花蓮店')
GO
INSERT INTO [dbo].[經銷商列表]
           ([經銷商ID] ,[經銷商名稱])
     VALUES
           (9 , '台東店')
GO
INSERT INTO [dbo].[經銷商列表]
           ([經銷商ID] ,[經銷商名稱])
     VALUES
           (255 , '測試用')
GO

SELECT * FROM [dbo].[經銷商列表]

SELECT MAX([經銷商ID]) FROM [dbo].[經銷商列表]



