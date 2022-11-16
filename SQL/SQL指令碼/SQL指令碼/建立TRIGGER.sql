USE [���p�G�q��]
GO

-- �إ� TRIGGER�A��i�f����Ӧ��s�W�ɡA�۰ʼW�[�ƶq�ܪ������ӫ~
CREATE TRIGGER ���ӷs�W
ON [dbo].[�i�f�����]
FOR INSERT
AS
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

	--�۰ʧ�s �ӫ~�b�w�ƶq
	IF EXISTS	
	(		
		SELECT a.* FROM [dbo].[�ӫ~�b�w�ƶq] a
		WHERE a.�w�s�a�IID = @�w�s�a�IID
		  AND a.�t��ID = @�t��ID
		  AND a.�ӫ~����ID = @�ӫ~����ID
		  AND a.�ӫ~ID = @�ӫ~ID
	)
	BEGIN	
		--����Ʈɧ�s�ƶq	
		--UPDATE [dbo].[�ӫ~�b�w�ƶq] SET [�ӫ~�ƶq] = a.�ӫ~�ƶq + i.�ӫ~�ƶq		
		--FROM [dbo].[�ӫ~�b�w�ƶq] a
		--INNER JOIN inserted i ON i .�ӫ~����ID = a.�ӫ~����ID AND i.�ӫ~ID = a.�ӫ~ID
		--INNER JOIN [dbo].[�i�f��C��] b ON b.�i�f��s�� = i.�i�f��s��
		--WHERE a.�t��ID = b.�t��ID

		--�۰ʭp�� �ӫ~�b�w�ƶq�[�`
		DECLARE @ADD�ƶq int
		SET @ADD�ƶq = dbo.fn_�ӫ~�b�w�ƶq�[�`(@�w�s�a�IID, @�t��ID, @�ӫ~����ID, @�ӫ~ID)		
		UPDATE [dbo].[�ӫ~�b�w�ƶq] SET [�ӫ~�ƶq] = @ADD�ƶq
		FROM [dbo].[�ӫ~�b�w�ƶq] a
		WHERE a.�w�s�a�IID = @�w�s�a�IID
		  AND a.�t��ID = @�t��ID
		  AND a.�ӫ~����ID = @�ӫ~����ID
		  AND a.�ӫ~ID = @�ӫ~ID
	END
	ELSE	--�|�����쵧��Ʈɷs�W	
	BEGIN		
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

-- �إ� TRIGGER�A��i�f����Ӧ��ק�ɡA�۰ʭק�ƶq�ܪ������ӫ~
CREATE TRIGGER ���ӧ�s
ON [dbo].[�i�f�����]
FOR UPDATE
AS
	-- �ӫ~�b�w�ƶq�L�������e�ɤ���s
	IF NOT EXISTS	
	(		
		SELECT a.* FROM [dbo].[�ӫ~�b�w�ƶq] a	
		INNER JOIN inserted i ON i .�ӫ~����ID = a.�ӫ~����ID AND i.�ӫ~ID = a.�ӫ~ID
		INNER JOIN [dbo].[�i�f��C��] b ON b.�i�f��s�� = i.�i�f��s�� AND b.�w�s�a�IID = a.�w�s�a�IID
		WHERE a.�t��ID = b.�t��ID
	)
	RETURN

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

	--����Ʈɧ�s�ƶq	
	--UPDATE [dbo].[�ӫ~�b�w�ƶq] SET [�ӫ~�ƶq] = a.�ӫ~�ƶq + (i.�ӫ~�ƶq - d.�ӫ~�ƶq)		
	--FROM [dbo].[�ӫ~�b�w�ƶq] a
	--INNER JOIN inserted i ON i .�ӫ~����ID = a.�ӫ~����ID AND i.�ӫ~ID = a.�ӫ~ID
	--INNER JOIN deleted d ON d.�ӫ~����ID = a.�ӫ~����ID AND d.�ӫ~ID = a.�ӫ~ID
	--INNER JOIN [dbo].[�i�f��C��] b ON b.�i�f��s�� = i.�i�f��s��
	--WHERE a.�t��ID = b.�t��ID

	--�۰ʭp�� �ӫ~�b�w�ƶq�[�`
	DECLARE @ADD�ƶq int
	SET @ADD�ƶq = dbo.fn_�ӫ~�b�w�ƶq�[�`(@�w�s�a�IID, @�t��ID, @�ӫ~����ID, @�ӫ~ID)
	UPDATE [dbo].[�ӫ~�b�w�ƶq] SET [�ӫ~�ƶq] = @ADD�ƶq
	FROM [dbo].[�ӫ~�b�w�ƶq] a
	WHERE a.�w�s�a�IID = @�w�s�a�IID
		AND a.�t��ID = @�t��ID
		AND a.�ӫ~����ID = @�ӫ~����ID
		AND a.�ӫ~ID = @�ӫ~ID

	--�۰ʭp�� �i�f��C��.�i�f����
	UPDATE [dbo].[�i�f��C��] SET [�i�f����] = a.�i�f����
	FROM 
	(
		SELECT SUM(a.�i�f����) AS �i�f���� 
		FROM [dbo].[�i�f�����] a
		INNER JOIN inserted i ON i.�i�f��s�� = a.�i�f��s��
	) AS a
GO

-- �إ� TRIGGER�A��i�f����Ӧ��ק�ɡA�۰ʭק�ƶq�ܪ������ӫ~
CREATE TRIGGER ���ӧR��
ON [dbo].[�i�f�����]
FOR DELETE
AS
	-- �ӫ~�b�w�ƶq�L�������e�ɤ���s
	IF NOT EXISTS	
	(		
		SELECT a.* FROM [dbo].[�ӫ~�b�w�ƶq] a	
		INNER JOIN deleted i ON i .�ӫ~����ID = a.�ӫ~����ID AND i.�ӫ~ID = a.�ӫ~ID
		INNER JOIN [dbo].[�i�f��C��] b ON b.�i�f��s�� = i.�i�f��s�� AND b.�w�s�a�IID = a.�w�s�a�IID
		WHERE a.�t��ID = b.�t��ID
	)
	RETURN

	DECLARE @�w�s�a�IID int
	DECLARE @�t��ID tinyint
	DECLARE @�ӫ~����ID tinyint
	DECLARE @�ӫ~ID smallint
	DECLARE @�ӫ~�ƶq int

	SET @�w�s�a�IID = (SELECT a.�w�s�a�IID FROM [�i�f��C��] a 
		            INNER JOIN deleted i ON i.�i�f��s�� = a.�i�f��s��)
	SET @�t��ID = (SELECT a.�t��ID FROM [�i�f��C��] a 
		            INNER JOIN deleted i ON i.�i�f��s�� = a.�i�f��s��)
	SET @�ӫ~����ID = (SELECT �ӫ~����ID FROM deleted)
	SET @�ӫ~ID = (SELECT �ӫ~ID FROM deleted)
	SET @�ӫ~�ƶq = (SELECT �ӫ~�ƶq FROM deleted)

	--����Ʈɧ�s�ƶq	
	--UPDATE [dbo].[�ӫ~�b�w�ƶq] SET [�ӫ~�ƶq] = a.�ӫ~�ƶq - d.�ӫ~�ƶq		
	--FROM [dbo].[�ӫ~�b�w�ƶq] a
	--INNER JOIN deleted d ON d.�ӫ~����ID = a.�ӫ~����ID AND d.�ӫ~ID = a.�ӫ~ID
	--INNER JOIN [dbo].[�i�f��C��] b ON b.�i�f��s�� = d.�i�f��s��
	--WHERE a.�t��ID = b.�t��ID

	--�۰ʭp�� �ӫ~�b�w�ƶq�[�`
	DECLARE @ADD�ƶq int
	SET @ADD�ƶq = dbo.fn_�ӫ~�b�w�ƶq�[�`(@�w�s�a�IID, @�t��ID, @�ӫ~����ID, @�ӫ~ID)
	UPDATE [dbo].[�ӫ~�b�w�ƶq] SET [�ӫ~�ƶq] = @ADD�ƶq
	FROM [dbo].[�ӫ~�b�w�ƶq] a
	WHERE a.�w�s�a�IID = @�w�s�a�IID
		AND a.�t��ID = @�t��ID
		AND a.�ӫ~����ID = @�ӫ~����ID
		AND a.�ӫ~ID = @�ӫ~ID

	--�۰ʭp�� �i�f��C��.�i�f����
	UPDATE [dbo].[�i�f��C��] SET [�i�f����] = a.�i�f����
	FROM 
	(
		SELECT SUM(a.�i�f����) AS �i�f���� 
		FROM [dbo].[�i�f�����] a
		INNER JOIN deleted i ON i.�i�f��s�� = a.�i�f��s��
	) AS a
GO