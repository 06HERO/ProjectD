USE [���p�G�q��]
GO

--�d���ѧO�ݩʳ̫��
SELECT @@IDENTITY
FROM [dbo].[�i�f��C��]
-- ���mTable�ѧO�ݩʭ�
DBCC CHECKIDENT(�i�f��C��, RESEED , 0 )

INSERT INTO [dbo].[�i�f��C��]
           ([�t��ID], [�i�f���])
     VALUES
           (1, GETDATE())
GO

--�d��
SELECT * FROM [dbo].[�i�f��C��]

