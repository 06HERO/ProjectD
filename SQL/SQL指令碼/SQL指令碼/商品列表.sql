USE [���p�G�q��]
GO

--�s�W���~ ����/�D��/PlayStation 5 �Ʀ쪩(1/1/1)
INSERT INTO [dbo].[�ӫ~�C��]
           ([�t��ID]
           ,[�ӫ~����ID]
           ,[�ӫ~ID]
           ,[�ӫ~�W��]
           ,[�i�f��]
           ,[�s���])
     VALUES
           (1
           ,1
           ,1
           ,'PlayStation 5 �Ʀ쪩'
           ,10200
           ,14580)
GO

--�s�W���~ ����/�D��/PlayStation 5 �Ʀ쪩(1/1/2)
INSERT INTO [dbo].[�ӫ~�C��]
           ([�t��ID]
           ,[�ӫ~����ID]
           ,[�ӫ~ID]
           ,[�ӫ~�W��]
           ,[�i�f��]
           ,[�s���])
     VALUES
           (1
           ,1
           ,2
           ,'PlayStation 5 ���Ъ�'
           ,12300
           ,17580)
GO

--�s�W���~ ���Ѱ�/�D��/Nintendo Switch �D��(2/1/1)
INSERT INTO [dbo].[�ӫ~�C��]
           ([�t��ID]
           ,[�ӫ~����ID]
           ,[�ӫ~ID]
           ,[�ӫ~�W��]
           ,[�i�f��]
           ,[�s���])
     VALUES
           (2
           ,1
           ,1
           ,'Nintendo Switch �D��'
           ,5100
           ,7280)
GO

--�s�W���~ ���Ѱ�/�D��/Nintendo Switch OLED�D�� �D��(2/1/2)
INSERT INTO [dbo].[�ӫ~�C��]
           ([�t��ID]
           ,[�ӫ~����ID]
           ,[�ӫ~ID]
           ,[�ӫ~�W��]
           ,[�i�f��]
           ,[�s���])
     VALUES
           (2
           ,1
           ,2
           ,'Nintendo Switch OLED�D��'
           ,7000
           ,9980)
GO

--�s�W���~ �L�n/�D��/'Xbox Series S �D��(3/1/1)
INSERT INTO [dbo].[�ӫ~�C��]
           ([�t��ID]
           ,[�ӫ~����ID]
           ,[�ӫ~ID]
           ,[�ӫ~�W��]
           ,[�i�f��]
           ,[�s���])
     VALUES
           (3
           ,1
           ,1
           ,'Xbox Series S �D��'
           ,6600
           ,9480)
GO

-- �L�n/�D��/Xbox Series X �D��(3/1/2)
INSERT INTO [dbo].[�ӫ~�C��]
           ([�t��ID]
           ,[�ӫ~����ID]
           ,[�ӫ~ID]
           ,[�ӫ~�W��]
           ,[�i�f��]
           ,[�s���])
     VALUES
           (3
           ,1
           ,2
           ,'Xbox Series X �D��'
           ,10700
           ,15380)
GO

--�d�ߩҦ��ӫ~
SELECT a.�t��ID, b.�t�ӦW��, a.�ӫ~����ID, c.�ӫ~�����W��, a.�ӫ~ID, a.�ӫ~�W��, a.�i�f��, a.�s��� 
FROM [dbo].[�ӫ~�C��] a
LEFT JOIN [dbo].[�t�ӦC��] b ON b.[�t��ID] = a.[�t��ID]
LEFT JOIN [dbo].[�ӫ~�����C��] c ON c.�ӫ~����ID = a.�ӫ~����ID
ORDER BY [�t��ID]