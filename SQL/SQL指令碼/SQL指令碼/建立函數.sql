USE [���p�G�q��]
GO

--���o �ϥΪ̦C�� ��ܤW�ק����W�٬�����
SELECT [LoginID]	AS �ϥΪ�ID
      ,[LoginPW]	AS �K�X
	  , [IsAdmin]
      ,(CASE WHEN [IsAdmin] = 1 THEN '��' ELSE '�L' END) AS �޲z�v��
      ,[Email]
      ,[IsCheck]
	  ,(CASE WHEN [IsCheck] = 1 THEN '�O' ELSE '�_' END) AS �w����
      ,[CheckCode]	AS ���ҽX
FROM [dbo].[�ϥΪ̦C��]
GO
CREATE FUNCTION fn_�ϥΪ̦C��()
RETURNS TABLE
AS RETURN
(
	SELECT [LoginID]	AS �ϥΪ�ID
		  ,[LoginPW]	AS �K�X
	     , [IsAdmin]
         ,(CASE WHEN [IsAdmin] = 1 THEN '��' ELSE '�L' END) AS �޲z�v��
         ,[Email]
         ,[IsCheck]
	     ,(CASE WHEN [IsCheck] = 1 THEN '�O' ELSE '�_' END) AS �w����
         ,[CheckCode]	AS ���ҽX
	FROM [dbo].[�ϥΪ̦C��]
)
GO
SELECT * FROM fn_�ϥΪ̦C��()

--���o �i�f��C�� Join �t�ӦC��/�w�s�a�I�C�� �p�X���
SELECT a.�i�f��s��, a.�t��ID, b.�t�ӦW��, a.�w�s�a�IID, c.�w�s�a�I, a.�i�f���, a.���ӵ���, a.�i�f����
FROM [dbo].[�i�f��C��] a
JOIN [dbo].[�t�ӦC��] b ON b.�t��ID = a.�t��ID
JOIN [dbo].[�w�s�a�I�C��] c ON c.�w�s�a�IID = a.�w�s�a�IID
GO
CREATE FUNCTION fn_�i�f��C��()
RETURNS TABLE
AS RETURN
(
	SELECT a.�i�f��s��, a.�t��ID, b.�t�ӦW��, a.�w�s�a�IID, c.�w�s�a�I, a.�i�f���, a.���ӵ���, a.�i�f����
	FROM [dbo].[�i�f��C��] a
	JOIN [dbo].[�t�ӦC��] b ON b.�t��ID = a.�t��ID
	JOIN [dbo].[�w�s�a�I�C��] c ON c.�w�s�a�IID = a.�w�s�a�IID
)
GO
SELECT * FROM fn_�i�f��C��()
ORDER BY �i�f��s��


--���o �i�f����� Join �i�f��C��/�ӫ~�����C��/�ӫ~�C�� �p�X���
SELECT a.�i�f��s��, a.�ӫ~����ID, c.�ӫ~�����W��, a.�ӫ~ID, d.�ӫ~�W��, a.�ӫ~�ƶq, d.�i�f��, a.�i�f����, a.�Ƶ�
FROM [dbo].[�i�f�����] a
JOIN [dbo].[�i�f��C��] b ON b.�i�f��s�� = a.�i�f��s��
JOIN [dbo].[�ӫ~�����C��] c ON c.�ӫ~����ID = a.�ӫ~����ID
JOIN [dbo].[�ӫ~�C��] d ON d.�t��ID = b.�t��ID AND d.�ӫ~����ID = c.�ӫ~����ID AND d.�ӫ~ID = a.�ӫ~ID
GO
CREATE FUNCTION fn_�i�f�����()
RETURNS TABLE
AS RETURN
(
	SELECT a.�i�f��s��, a.�ӫ~����ID, c.�ӫ~�����W��, a.�ӫ~ID, d.�ӫ~�W��, a.�ӫ~�ƶq, d.�i�f��, a.�i�f����, a.�Ƶ�
	FROM [dbo].[�i�f�����] a
	JOIN [dbo].[�i�f��C��] b ON b.�i�f��s�� = a.�i�f��s��
	JOIN [dbo].[�ӫ~�����C��] c ON c.�ӫ~����ID = a.�ӫ~����ID
	JOIN [dbo].[�ӫ~�C��] d ON d.�t��ID = b.�t��ID AND d.�ӫ~����ID = c.�ӫ~����ID AND d.�ӫ~ID = a.�ӫ~ID
)
GO
SELECT * FROM fn_�i�f�����()
ORDER BY �i�f��s��

--���o �ӫ~�C�� Join �t�ӦC��/�ӫ~�����C�� �p�X���
SELECT a.�t��ID, b.�t�ӦW��, a.�ӫ~����ID, c.�ӫ~�����W��, a.�ӫ~ID, a.�ӫ~�W��, a.�i�f��, a.�s��� 
FROM [dbo].[�ӫ~�C��] a
INNER JOIN [dbo].[�t�ӦC��] b ON b.[�t��ID] = a.[�t��ID]
INNER JOIN [dbo].[�ӫ~�����C��] c ON c.�ӫ~����ID = a.�ӫ~����ID
GO
CREATE FUNCTION fn_�ӫ~�C��()
RETURNS TABLE
AS RETURN
(
	SELECT a.�t��ID, b.�t�ӦW��, a.�ӫ~����ID, c.�ӫ~�����W��, a.�ӫ~ID, a.�ӫ~�W��, a.�i�f��, a.�s��� 
	FROM [dbo].[�ӫ~�C��] a
	INNER JOIN [dbo].[�t�ӦC��] b ON b.[�t��ID] = a.[�t��ID]
	INNER JOIN [dbo].[�ӫ~�����C��] c ON c.�ӫ~����ID = a.�ӫ~����ID
)
GO
SELECT * FROM fn_�ӫ~�C��()
ORDER BY �t��ID

--fn_�w�s�C��
SELECT	a.�w�s�a�IID,b.�w�s�a�I, a.�t��ID , c.�t�ӦW��, a.�ӫ~����ID, d.�ӫ~�����W��, a.�ӫ~ID, e.�ӫ~�W��,
a.�ӫ~�ƶq, e.�i�f��, e.�s��� 		
FROM �ӫ~�b�w�ƶq a
INNER JOIN �w�s�a�I�C�� b ON b.�w�s�a�IID = a.�w�s�a�IID
INNER JOIN �t�ӦC�� c ON c.�t��ID = a.�t��ID
INNER JOIN �ӫ~�����C�� d ON d.�ӫ~����ID = a.�ӫ~����ID
INNER JOIN �ӫ~�C�� e ON e.�t��ID = a.�t��ID AND e.�ӫ~����ID = a.�ӫ~����ID AND e.�ӫ~ID = a.�ӫ~ID
GO
CREATE FUNCTION fn_�w�s�C��()
RETURNS TABLE
AS RETURN
(
	SELECT	a.�w�s�a�IID,b.�w�s�a�I, a.�t��ID, c.�t�ӦW��, c.�Τ@�s��, a.�ӫ~����ID, d.�ӫ~�����W��, a.�ӫ~ID, e.�ӫ~�W��,
			a.�ӫ~�ƶq, e.�i�f��, e.�s���, b.�a�}  
			FROM �ӫ~�b�w�ƶq a
			INNER JOIN �w�s�a�I�C�� b ON b.�w�s�a�IID = a.�w�s�a�IID
			INNER JOIN �t�ӦC�� c ON c.�t��ID = a.�t��ID
			INNER JOIN �ӫ~�����C�� d ON d.�ӫ~����ID = a.�ӫ~����ID
			INNER JOIN �ӫ~�C�� e ON e.�t��ID = a.�t��ID AND e.�ӫ~����ID = a.�ӫ~����ID AND e.�ӫ~ID = a.�ӫ~ID
)
GO
SELECT * FROM fn_�w�s�C��()
ORDER BY �w�s�a�IID

--fn_�`�ӫ~�w�s��()
SELECT �ӫ~�����W��,�ӫ~�W�� ,SUM(�ӫ~�ƶq) AS �`�w�s�q
FROM �ӫ~�b�w�ƶq a 
JOIN �ӫ~�C�� b ON a.�ӫ~ID=b.�ӫ~ID
JOIN �ӫ~�����C�� c ON b.�ӫ~����ID=c.�ӫ~����ID
WHERE a.�ӫ~����ID = c.�ӫ~����ID AND a.�ӫ~ID=b.�ӫ~ID
GROUP BY �ӫ~�����W��,�ӫ~�W��

CREATE FUNCTION fn_�`�ӫ~�w�s��()
RETURNS TABLE
AS RETURN
(
	--SELECT �ӫ~�����W��,�ӫ~�W�� ,SUM(�ӫ~�ƶq) AS �`�w�s�q
	--FROM �ӫ~�b�w�ƶq a 
	--JOIN �ӫ~�C�� b ON a.�ӫ~ID=b.�ӫ~ID
	--JOIN �ӫ~�����C�� c ON b.�ӫ~����ID=c.�ӫ~����ID
	--WHERE a.�ӫ~����ID = c.�ӫ~����ID AND a.�ӫ~ID=b.�ӫ~ID
	--GROUP BY �ӫ~�����W��,�ӫ~�W��

	SELECT b.�ӫ~�����W��, �ӫ~�W�� ,SUM(�ӫ~�ƶq) AS �`�w�s�q
	FROM �ӫ~�b�w�ƶq a 
	JOIN �ӫ~�����C�� b ON b.�ӫ~����ID = a.�ӫ~����ID
	JOIN �ӫ~�C�� c ON c.�ӫ~ID = a.�ӫ~ID AND c.�ӫ~����ID = a.�ӫ~����ID AND c.�t��ID = a.�t��ID
	GROUP BY �ӫ~�����W��,�ӫ~�W��
)
GO
SELECT * FROM fn_�`�ӫ~�w�s��()

--fn_�ӫ~�b�w�ƶq�[�`
CREATE FUNCTION fn_�ӫ~�b�w�ƶq�[�`(@�w�s�a�IID int, @�t��ID tinyint, @�ӫ~����ID tinyint, @�ӫ~ID smallint)
RETURNS int
BEGIN
	DECLARE @�ӫ~�ƶq int
	SET @�ӫ~�ƶq = 
		(
			SELECT SUM(a.�ӫ~�ƶq)
			FROM
			(
				SELECT a.�i�f��s��, a.�w�s�a�IID, a.�t��ID, b.�ӫ~����ID, b.�ӫ~ID, b.�ӫ~�ƶq
				FROM [dbo].[�i�f��C��] a
				INNER JOIN [dbo].[�i�f�����] b ON b.�i�f��s�� = a.�i�f��s��
			) AS a
			WHERE a.�w�s�a�IID = @�w�s�a�IID
			AND �t��ID =@�t��ID
			AND �ӫ~����ID =@�ӫ~����ID
			AND �ӫ~ID = @�ӫ~ID
		)

	IF @�ӫ~�ƶq IS NULL
	BEGIN
		SET @�ӫ~�ƶq=0
	END


	RETURN @�ӫ~�ƶq
END
SELECT dbo.fn_�ӫ~�b�w�ƶq�[�`(1, 1, 1, 1) AS 'ADD�ƶq'













--