USE [���p�G�q��]
GO

SELECT * FROM [dbo].[�ӫ~�b�w�ƶq]

SELECT b.�t�ӦW��, c.�ӫ~�����W��, d.�ӫ~�W��, a.�ӫ~�ƶq
FROM [dbo].[�ӫ~�b�w�ƶq] a
INNER JOIN [dbo].[�t�ӦC��] b ON b.�t��ID = a.�t��ID
INNER JOIN [dbo].[�ӫ~�����C��] c ON c.�ӫ~����ID = a.�ӫ~����ID
INNER JOIN [dbo].[�ӫ~�C��] d ON d.�t��ID = a.�t��ID AND d.�ӫ~����ID = a.�ӫ~����ID AND d.�ӫ~ID = a.�ӫ~ID

--DELETE FROM [dbo].[�ӫ~�b�w�ƶq]