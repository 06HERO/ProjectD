USE [���p�G�q��]
GO

-- �إ� TRIGGER�A��i�f����Ӧ��s�W�ɡA�۰ʼW�[�ƶq�ܪ������ӫ~
ALTER TRIGGER ���ӷs�W
ON [dbo].[�i�f�����]
FOR INSERT
AS
	--�۰ʧ�s �ӫ~�b�w�ƶq
	IF EXISTS	
	(		
		SELECT a.* FROM [dbo].[�ӫ~�b�w�ƶq] a	
		INNER JOIN inserted i ON i .�ӫ~����ID = a.�ӫ~����ID AND i.�ӫ~ID = a.�ӫ~ID
		INNER JOIN [dbo].[�i�f��C��] b ON b.�i�f��s�� = i.�i�f��s�� AND b.�w�s�a�IID = a.�w�s�a�IID
		WHERE a.�t��ID = b.�t��ID
	)
	BEGIN	--����Ʈɧ�s�ƶq	
		UPDATE [dbo].[�ӫ~�b�w�ƶq] SET [�ӫ~�ƶq] = a.�ӫ~�ƶq + i.�ӫ~�ƶq
		FROM [dbo].[�ӫ~�b�w�ƶq] a
		INNER JOIN inserted i ON i .�ӫ~����ID = a.�ӫ~����ID AND i.�ӫ~ID = a.�ӫ~ID
		INNER JOIN [dbo].[�i�f��C��] b ON b.�i�f��s�� = i.�i�f��s��
		WHERE a.�t��ID = b.�t��ID
	END
	ELSE	--�|�����쵧��Ʈɷs�W	
	BEGIN
		DECLARE @�w�s�a�IID int
		DECLARE @�t��ID tinyint
		DECLARE @�ӫ~����ID tinyint
		DECLARE @�ӫ~ID smallint
		DECLARE @�ӫ~�ƶq int

		SET @�w�s�a�IID = (SELECT a.�w�s�a�IID FROM [�i�f��C��] a 
		               INNER JOIN inserted i ON i.�i�f��s�� = a.�i�f��s��)
		SET @�t��ID = (SELECT a.�t��ID FROM [�i�f��C��] a 
		               INNER JOIN inserted i ON i.�i�f��s�� = a.�i�f��s��)
		SET @�ӫ~����ID = (SELECT �ӫ~����ID FROM Inserted)
		SET @�ӫ~ID = (SELECT �ӫ~ID FROM Inserted)
		SET @�ӫ~�ƶq = (SELECT �ӫ~�ƶq FROM Inserted)
		
		INSERT INTO [dbo].[�ӫ~�b�w�ƶq]
           ([�w�s�a�IID], [�t��ID] ,[�ӫ~����ID] ,[�ӫ~ID],[�ӫ~�ƶq])
		VALUES
           (@�w�s�a�IID, @�t��ID, @�ӫ~����ID, @�ӫ~ID, @�ӫ~�ƶq )

		--INSERT INTO [dbo].[�ӫ~�b�w�ƶq]
		--SELECT @�w�s�a�IID AS �w�s�a�IID, @�t��ID AS �t��ID, Inserted.�ӫ~����ID, inserted.�ӫ~ID, inserted.�ӫ~�ƶq
		--FROM Inserted
	END
	 
	--�۰ʥ[�` �i�f�����.�i�f����
	--DECLARE @�i�f�� int
	--SET @�i�f�� = (SELECT [�i�f��] FROM [dbo].[�ӫ~�C��] a
	--			   INNER JOIN inserted i ON i.�ӫ~����ID = a.�ӫ~����ID AND i.�ӫ~ID = a.�ӫ~ID
	--			   INNER JOIN [dbo].[�i�f��C��] b ON b.�i�f��s�� = i.�i�f��s�� AND b.�t��ID = a.�t��ID)
	--UPDATE [dbo].[�i�f�����] SET [�i�f����] = (@�i�f�� * a.�ӫ~�ƶq)
	--FROM [dbo].[�i�f�����] a
	--INNER JOIN inserted i ON i.�ӫ~����ID = a.�ӫ~����ID AND i.�ӫ~ID = a.�ӫ~ID	

	--�۰ʭp�� �i�f��C��.�i�f����
	UPDATE [dbo].[�i�f��C��] SET [�i�f����] = a.�i�f����
	FROM 
	(
		SELECT SUM(a.�i�f����) AS �i�f���� 
		FROM [dbo].[�i�f�����] a
		INNER JOIN inserted i ON i.�i�f��s�� = a.�i�f��s��
	) AS a
GO

--�d���ѧO�ݩʳ̫��
--SELECT @@IDENTITY
-- ���mTable�ѧO�ݩʭ�
--DBCC CHECKIDENT(�i�f��C��, RESEED , 0 )

-- �إ߶i�f��C��Ω��Ӹ��
INSERT INTO [dbo].[�i�f��C��]
           ([�i�f��s��],[�t��ID], [�w�s�a�IID], [�i�f���], [���ӵ���])
     VALUES
           (1,1,1, '2022-09-22',2)
GO
INSERT INTO [dbo].[�i�f�����]
           ([�i�f��s��],[�ӫ~����ID],[�ӫ~ID],[�ӫ~�ƶq])
     VALUES
           (1,1,1,100)
GO
INSERT INTO [dbo].[�i�f�����]
           ([�i�f��s��],[�ӫ~����ID],[�ӫ~ID],[�ӫ~�ƶq])
     VALUES
           (1,1,2,200)
GO

INSERT INTO [dbo].[�i�f��C��]
           ([�i�f��s��],[�t��ID], [�w�s�a�IID], [�i�f���], [���ӵ���])
     VALUES
           (2, 2, 2, '2022-10-23', 2)
GO
INSERT INTO [dbo].[�i�f�����]
           ([�i�f��s��],[�ӫ~����ID],[�ӫ~ID],[�ӫ~�ƶq])
     VALUES
           (2,1,1,50)
GO

INSERT INTO [dbo].[�i�f�����]
           ([�i�f��s��],[�ӫ~����ID],[�ӫ~ID],[�ӫ~�ƶq])
     VALUES
           (2,1,2,100)
GO

--�d��
SELECT * FROM [dbo].[�i�f��C��]
SELECT * FROM [dbo].[�i�f�����]
SELECT * FROM [dbo].[�ӫ~�b�w�ƶq]

SELECT a.�i�f��s��, a.�t��ID, b.�t�ӦW��, a.�w�s�a�IID, c.�w�s�a�I, a.���ӵ���, a.�i�f����
FROM [dbo].[�i�f��C��] a
JOIN [dbo].[�t�ӦC��] b ON b.�t��ID = a.�t��ID
JOIN [dbo].[�w�s�a�I�C��] c ON c.�w�s�a�IID = a.�w�s�a�IID

SELECT a.�i�f��s��, c.�ӫ~�����W��, d.�ӫ~�W��, a.�ӫ~�ƶq, b.�i�f���
FROM [dbo].[�i�f�����] a
JOIN [dbo].[�i�f��C��] b ON b.�i�f��s�� = a.�i�f��s��
JOIN [dbo].[�ӫ~�����C��] c ON c.�ӫ~����ID = a.�ӫ~����ID
JOIN [dbo].[�ӫ~�C��] d ON d.�t��ID = b.�t��ID AND d.�ӫ~����ID = c.�ӫ~����ID AND d.�ӫ~ID = a.�ӫ~ID

DELETE FROM [dbo].[�ӫ~�b�w�ƶq]
DELETE FROM [dbo].[�i�f�����]
DELETE FROM [dbo].[�i�f��C��]










