USE [���p�G�q��]
GO

--�إ߳s�u�覡
SET NUMERIC_ROUNDABORT OFF;
SET ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, ARITHABORT,
  QUOTED_IDENTIFIER, ANSI_NULLS ON;
GO

-- ��ϥΨ禡fn_�ӫ~�C����o
--�إ� VIEW v�`�X�ӫ~�C��(WITH SCHEMABINDING�G�i�إ߯���)
--CREATE VIEW dbo.v�`�X�ӫ~�C��	
--WITH SCHEMABINDING
--AS
--	SELECT a.�t��ID, b.�t�ӦW��, a.�ӫ~����ID, c.�ӫ~�����W��, a.�ӫ~ID, a.�ӫ~�W��, a.�i�f��, a.�s��� 
--	FROM [dbo].[�ӫ~�C��] a
--	INNER JOIN [dbo].[�t�ӦC��] b ON b.[�t��ID] = a.[�t��ID]
--	INNER JOIN [dbo].[�ӫ~�����C��] c ON c.�ӫ~����ID = a.�ӫ~����ID	
--GO
---- �إ� �`�X�ӫ~�C�� ������
--CREATE UNIQUE CLUSTERED INDEX IDX_IDS
--  ON dbo.v�`�X�ӫ~�C��(�t��ID, �ӫ~����ID, �ӫ~ID);
--GO
--SELECT * FROM [dbo].[v�`�X�ӫ~�C��]

--�إ� VIEW v��X�w�s�C��(WITH SCHEMABINDING�G�i�إ߯���)
CREATE VIEW [dbo].[v��X�w�s�C��]
--WITH SCHEMABINDING
AS
	SELECT	a.�w�s�a�IID,b.�w�s�a�I, a.�t��ID, c.�t�ӦW��, c.�Τ@�s��, a.�ӫ~����ID, d.�ӫ~�����W��, a.�ӫ~ID, e.�ӫ~�W��,
			a.�ӫ~�ƶq, e.�i�f��, e.�s���, b.�a�}   		
	FROM �ӫ~�b�w�ƶq a
	INNER JOIN �w�s�a�I�C�� b ON b.�w�s�a�IID = a.�w�s�a�IID
	INNER JOIN �t�ӦC�� c ON c.�t��ID = a.�t��ID
	INNER JOIN �ӫ~�����C�� d ON d.�ӫ~����ID = a.�ӫ~����ID
	INNER JOIN �ӫ~�C�� e ON e.�t��ID = a.�t��ID AND e.�ӫ~����ID = a.�ӫ~����ID AND e.�ӫ~ID = a.�ӫ~ID

GO
-- �إ� �`�X�ӫ~�C�� ������
--CREATE UNIQUE CLUSTERED INDEX IDX_IDS
--  ON dbo.v��X�w�s�C�� (�w�s�a�IID);
--GO
SELECT * FROM [dbo].[v��X�w�s�C��]

--�إ� VIEW v��X�w�s�C��
CREATE VIEW v�`�ӫ~�w�s��
AS
SELECT �ӫ~�����W��,�ӫ~�W�� ,SUM(�ӫ~�ƶq) AS �`�w�s�q
FROM �ӫ~�b�w�ƶq a JOIN �ӫ~�C�� b ON a.�ӫ~ID=b.�ӫ~ID
JOIN �ӫ~�����C�� c ON b.�ӫ~����ID=c.�ӫ~����ID
WHERE a.�ӫ~����ID = c.�ӫ~����ID AND a.�ӫ~ID=b.�ӫ~ID
GROUP BY �ӫ~�����W��,�ӫ~�W��
GO
SELECT * FROM [dbo].[v�`�ӫ~�w�s��]


