USE [���p�G�q��]
GO

--���p�G�x��H�c
--play2sev@gmail.com
--���A���W��:smtp.gmail.com
--�q�T��s��:587
--PW:zxcv90-=
--���ε{��PW:jcnkynchqsdmrdkk

-- ���üƫe����0��6��
Select RIGHT(REPLICATE('0',6)  + CAST( (Round(RAND() * 1000000, 0)) as NVARCHAR), 6) AS 'RAM'

-- �s�W�ϥΪ̦C��
CREATE PROC dbo.Insert�ϥΪ̦C��
@LoginID nvarchar(20),@LoginPW nvarchar(20),@IsAdmin smallint,
@Email nvarchar(100), @IsCheck tinyint = 0
AS
	INSERT INTO [dbo].[�ϥΪ̦C��]
           ([LoginID], [LoginPW], [IsAdmin], [Email], [IsCheck])
     VALUES
           (@LoginID, @LoginPW, @IsAdmin, @Email, @IsCheck)
GO

-- �ϥΪ̵n�J���� BY PW
CREATE PROC dbo.�ϥΪ�LoginByPW
@LoginID nvarchar(20),@LoginPW nvarchar(20), 
@IsAdmin smallint OUTPUT, @IsCheck tinyint OUTPUT
AS
	IF NOT EXISTS
	(
		SELECT * FROM �ϥΪ̦C��  
		WHERE LoginID = @LoginID
		AND LoginPW = @LoginPW
	)
	BEGIN
		SET @IsAdmin = -1
		SET @IsCheck = 0	
	END
	ELSE
	BEGIN	
		SELECT @IsAdmin = IsAdmin, @IsCheck = IsCheck  
		FROM [dbo].[�ϥΪ̦C��] 
		WHERE LoginID = @LoginID
		AND LoginPW = @LoginPW
		
		IF(@IsCheck = 0)
		BEGIN
			UPDATE [dbo].[�ϥΪ̦C��]
			SET [CheckCode] = RIGHT(REPLICATE('0',6)  + CAST( (Round(RAND() * 1000000, 0)) as NVARCHAR), 6)
			WHERE LoginID = @LoginID

			EXEC Mail_CheckCode @LoginID
		END
	END
GO

CREATE PROC dbo.Mail_CheckCode
@LoginID nvarchar(20)
AS
	DECLARE @BODY nvarchar(MAX)	
	SET @BODY = '<table><tr><td>�������ҽX�� ' + CAST((SELECT CheckCode FROM �ϥΪ̦C��	WHERE LoginID= @LoginID) AS nvarchar(10)) + '</td></tr></table>'	

	EXEC msdb.dbo.sp_send_dbmail
         @body_format= 'HTML',
         @profile_name = '���p�G�x��H�c',
         @recipients = 'shanshonc@gmail.com', --�����
         --@body = "<table><tr><td>�������ҽX��</td></tr></table>",--����
		 @body = @BODY,--����
         --@query='SELECT getdate()',  --�٥i�H�U�d�ߦ��@
		 @subject = '�������ҽX';--�D��=tilte
GO

CREATE PROC dbo.�ϥΪ�LoginByCheckCode
@LoginID nvarchar(20), @CheckCode nvarchar(6)
AS
	IF NOT EXISTS
	(
		SELECT * FROM �ϥΪ̦C��  
		WHERE LoginID = @LoginID
		AND CheckCode = @CheckCode
	)
	RETURN 0

	UPDATE �ϥΪ̦C�� SET IsCheck = 1
	WHERE LoginID = @LoginID
	AND CheckCode = @CheckCode
GO

CREATE PROC dbo.���mCheckCode
@IsAdmin smallint = -1, @LoginID nvarchar(20) = ''
AS
	DECLARE @SQL nvarchar(500)

	SET @SQL = 'UPDATE [�ϥΪ̦C��] 
	            SET IsCheck = 0, CheckCode = '''' 
				WHERE 1 = 1'

	IF @IsAdmin >= 0
	BEGIN
		SET @SQL = @SQL + ' AND IsAdmin = ' + '''' + CAST(@IsAdmin AS nvarchar(2))+ '''' 
	END

	IF @LoginID <> ''
	BEGIN
		SET @SQL = @SQL + ' AND LoginID = ' + '''' + @LoginID + ''''
	END

	EXEC sp_sqlexec @SQL	
GO

ALTER PROC dbo.Update�ϥΪ�PW
@LoginID nvarchar(20),@LoginPW nvarchar(20) = ''
AS
	IF NOT EXISTS
	(
		SELECT * FROM �ϥΪ̦C��
		WHERE LoginID = @LoginID
	)
	RETURN	

	UPDATE [dbo].[�ϥΪ̦C��]
	SET [LoginPW] = @LoginPW
	WHERE LoginID = @LoginID

	IF @LoginPW = ''
	BEGIN
		EXEC ���mCheckCode -1, @LoginID

		UPDATE [dbo].[�ϥΪ̦C��]
		SET [CheckCode] = RIGHT(REPLICATE('0',6)  + CAST( (Round(RAND() * 1000000, 0)) as NVARCHAR), 6)
		WHERE LoginID = @LoginID

		EXEC Mail_CheckCode @LoginID
	END
GO


-- �s�W�t�ӦC����
CREATE PROC dbo.Insert�t�ӦC��
@�t��ID tinyint, @�t�ӦW�� nvarchar(50),
@�Τ@�s�� nvarchar(10) = '', @�N��H�m�W nvarchar(50) = '', @�ꥻ�`�B decimal(15, 2) = 0,
@�p���q�� nvarchar(20) = '', @��ܻP�_ varchar(1) = 'y' 
AS
	IF EXISTS
	(
		SELECT * FROM [dbo].[�t�ӦC��]
		WHERE [�t��ID] = @�t��ID
		OR [�t�ӦW��] = @�t�ӦW��
	)
	RETURN
	
	INSERT INTO [dbo].[�t�ӦC��]
			([�t��ID], [�t�ӦW��], [�Τ@�s��] ,[�N��H�m�W], [�ꥻ�`�B], [�p���q��], [��ܻP�_])
	VALUES
			(@�t��ID, @�t�ӦW��, @�Τ@�s��, @�N��H�m�W, @�ꥻ�`�B,@�p���q��, @��ܻP�_)
GO
-- �ק�t�ӦC����(�ק�t�ӦW��/�Τ@�s��/�N��H�m�W/�ꥻ�`�B/�p���q��/��ܻP�_)
CREATE PROC dbo.Update�t�ӦC��
@�t��ID tinyint, @�t�ӦW�� nvarchar(50),
@�Τ@�s�� nvarchar(10) = '', @�N��H�m�W nvarchar(50) = '', @�ꥻ�`�B decimal(15, 2) = 0,
@�p���q�� nvarchar(20) = '', @��ܻP�_ varchar(1) = 'y'
AS	
	IF NOT EXISTS
	(
		SELECT * FROM [dbo].[�t�ӦC��]
		WHERE [�t��ID] = @�t��ID
	)
	RETURN

	IF EXISTS
	(
		SELECT * FROM [dbo].[�t�ӦC��]
		WHERE [�t�ӦW��] = @�t�ӦW��
	)
	RETURN
	
	UPDATE [dbo].[�t�ӦC��]
	SET [�t��ID] = @�t��ID ,[�t�ӦW��] = @�t�ӦW�� ,[�Τ@�s��] = @�Τ@�s��, [�N��H�m�W] = @�N��H�m�W,
	    [�ꥻ�`�B] = @�ꥻ�`�B, [�p���q��] = @�p���q��, [��ܻP�_] = @��ܻP�_
	WHERE [�t��ID] = @�t��ID
GO
--�R���t�ӦC����
CREATE PROC dbo.Delete�t�ӦC��
@�t��ID tinyint
AS
	IF NOT EXISTS
	(
		SELECT * FROM [dbo].[�t�ӦC��]
		WHERE [�t��ID] = @�t��ID
	)
	RETURN

	IF EXISTS
	(
		SELECT * FROM [dbo].[�ӫ~�C��]
		WHERE [�t��ID] = @�t��ID
	)
	RETURN

	DELETE FROM [dbo].[�t�ӦC��]
	WHERE [�t��ID] = @�t��ID
GO

-- �s�W�ӫ~�������
CREATE PROC dbo.Insert�ӫ~�����C��
@�ӫ~����ID tinyint, @�ӫ~�����W�� nvarchar(30)
AS
	IF EXISTS
	(
		SELECT * FROM [dbo].[�ӫ~�����C��]
		WHERE [�ӫ~����ID] = @�ӫ~����ID
		OR [�ӫ~�����W��] = @�ӫ~�����W��
	)
	RETURN
	
	INSERT INTO [dbo].[�ӫ~�����C��]
        ([�ӫ~����ID], [�ӫ~�����W��])
	VALUES
        (@�ӫ~����ID, @�ӫ~�����W��)	
GO
-- �ק�ӫ~�������(�ק�ӫ~�����W��)
CREATE PROC dbo.Update�ӫ~�����C��
@�ӫ~����ID tinyint, @�ӫ~�����W�� nvarchar(30)
AS
	IF NOT EXISTS
	(
		SELECT * FROM [dbo].[�ӫ~�����C��]
		WHERE [�ӫ~����ID] = @�ӫ~����ID
	)
	RETURN

	IF EXISTS
	(
		SELECT * FROM [dbo].[�ӫ~�����C��]
		WHERE [�ӫ~�����W��] = @�ӫ~�����W��
	)
	RETURN
	
	UPDATE [dbo].[�ӫ~�����C��]
	SET [�ӫ~�����W��] = @�ӫ~�����W��
	WHERE [�ӫ~����ID] = @�ӫ~����ID	
GO
--�R���ӫ~�������
CREATE PROC dbo.Delete�ӫ~�����C��
@�ӫ~����ID tinyint
AS
	IF NOT EXISTS
	(
		SELECT * FROM [dbo].[�ӫ~�����C��]
		WHERE [�ӫ~����ID] = @�ӫ~����ID
	)
	RETURN

	IF EXISTS
	(
		SELECT * FROM [dbo].[�ӫ~�C��]
		WHERE [�ӫ~����ID] = @�ӫ~����ID
	)
	RETURN

	DELETE FROM [dbo].[�ӫ~�����C��]
	WHERE [�ӫ~����ID] = @�ӫ~����ID
GO

-- �s�W�ӫ~�C����
CREATE PROC dbo.Insert�ӫ~�C��
@�t��ID tinyint, @�ӫ~����ID tinyint, @�ӫ~ID smallint, 
@�ӫ~�W�� nvarchar(50), @�i�f�� decimal(10, 2), @�s��� decimal(10, 2)
AS
	IF EXISTS
	(
		SELECT * FROM [dbo].[�ӫ~�C��]
		WHERE [�t��ID] = @�t��ID
		AND [�ӫ~����ID] = @�ӫ~����ID
		AND [�ӫ~ID] = @�ӫ~ID
	)
	RETURN

	INSERT INTO [dbo].[�ӫ~�C��]
           ([�t��ID], [�ӫ~����ID], [�ӫ~ID], [�ӫ~�W��], [�i�f��], [�s���])
    VALUES
           (@�t��ID, @�ӫ~����ID, @�ӫ~ID, @�ӫ~�W��, @�i�f��, @�s���)
GO
-- �ק�ӫ~�C����(�ק�ӫ~�W��/�i�f��/�s���)
CREATE PROC dbo.Update�ӫ~�C��
@�t��ID tinyint, @�ӫ~����ID tinyint, @�ӫ~ID smallint, 
@�ӫ~�W�� nvarchar(50), @�i�f�� decimal(10, 2), @�s��� decimal(10, 2)
AS
	IF NOT EXISTS
	(
		SELECT * FROM [dbo].[�ӫ~�C��]
		WHERE [�t��ID] = @�t��ID
		AND [�ӫ~����ID] = @�ӫ~����ID
		AND [�ӫ~ID] = @�ӫ~ID
	)
	RETURN	

	UPDATE [dbo].[�ӫ~�C��]
	SET [�ӫ~�W��] = @�ӫ~�W��, [�i�f��] = @�i�f��, [�s���] = @�s���
	WHERE [�t��ID] = @�t��ID
	AND [�ӫ~����ID] = @�ӫ~����ID
	AND [�ӫ~ID] = @�ӫ~ID
GO
--�R���ӫ~�C����
CREATE PROC dbo.Delete�ӫ~�C��
@�t��ID tinyint, @�ӫ~����ID tinyint, @�ӫ~ID smallint 
AS
	IF NOT EXISTS
	(
		SELECT * FROM [dbo].[�ӫ~�C��]
		WHERE [�t��ID] = @�t��ID
		AND [�ӫ~����ID] = @�ӫ~����ID
		AND [�ӫ~ID] = @�ӫ~ID
	)
	RETURN

	DELETE FROM [dbo].[�ӫ~�C��]
	WHERE [�t��ID] = @�t��ID
	AND [�ӫ~����ID] = @�ӫ~����ID
	AND [�ӫ~ID] = @�ӫ~ID
GO

-- �s�W�w�s�a�I�C����
CREATE PROC dbo.Insert�w�s�a�I�C��
@�a�IID int, @�w�s�a�I nvarchar(50), @�a�} nvarchar(100) = ''
AS
	IF EXISTS
	(
		SELECT * FROM [dbo].[�w�s�a�I�C��]
		WHERE [�w�s�a�IID] = @�a�IID
		OR [�w�s�a�I] = @�w�s�a�I
	)
	RETURN
	
	INSERT INTO [dbo].[�w�s�a�I�C��]
			([�w�s�a�IID], [�w�s�a�I], [�a�}])
	VALUES
			(@�a�IID, @�w�s�a�I, @�a�})
GO
-- �ק�w�s�a�I�C����(�ק�w�s�a�I/�a�})
CREATE PROC dbo.Update�w�s�a�I�C��
@�a�IID int, @�w�s�a�I nvarchar(50), @�a�} nvarchar(100) = ''
AS	
	IF NOT EXISTS
	(
		SELECT * FROM [dbo].[�w�s�a�I�C��]
		WHERE [�w�s�a�IID] = @�a�IID
	)
	RETURN

	IF EXISTS
	(
		SELECT * FROM [dbo].[�w�s�a�I�C��]
		WHERE [�w�s�a�I] = @�w�s�a�I
	)
	RETURN
	
	UPDATE [dbo].[�w�s�a�I�C��]
	SET [�w�s�a�I] = @�w�s�a�I, [�a�}] = @�a�}
	WHERE [�w�s�a�IID] = @�a�IID
GO
--�R���w�s�a�I�C����
CREATE PROC dbo.Delete�w�s�a�I�C��
@�a�IID int
AS
	IF NOT EXISTS
	(
		SELECT * FROM [dbo].[�w�s�a�I�C��]
		WHERE [�w�s�a�IID] = @�a�IID
	)
	RETURN
	
	IF EXISTS
	(
		SELECT * FROM [dbo].[�i�f��C��]
		WHERE [�w�s�a�IID] = @�a�IID
	)
	RETURN

	DELETE FROM [dbo].[�w�s�a�I�C��]
	WHERE [�w�s�a�IID] = @�a�IID
GO

-- �s�W�i�f��C����
CREATE PROC dbo.Insert�i�f��C��
@�i�f��s�� int, @�t��ID tinyint, @�w�s�a�IID int,
@�i�f��� datetime, @���ӵ��� tinyint
AS
	IF NOT EXISTS
	(
		SELECT * FROM [dbo].[�t�ӦC��]
		WHERE [�t��ID] = @�t��ID
	)
	RETURN

	IF EXISTS
	(
		SELECT * FROM [dbo].[�i�f��C��]
		WHERE �i�f��s�� = @�i�f��s��
	)
	RETURN
	
	INSERT INTO [dbo].[�i�f��C��]
           ([�i�f��s��],[�t��ID], [�w�s�a�IID], [�i�f���], [���ӵ���])
    VALUES
           (@�i�f��s��, @�t��ID, @�w�s�a�IID, @�i�f���, @���ӵ���)
GO
-- �ק�i�f��C����(�ק� �w�s�a�IID/�i�f���/���ӵ���)
CREATE PROC dbo.Update�i�f��C��
@�i�f��s�� int, @�w�s�a�IID int, @�i�f��� datetime, @���ӵ��� tinyint
AS
	IF NOT EXISTS
	(
		SELECT * FROM [dbo].[�i�f��C��]
		WHERE �i�f��s�� = @�i�f��s��
	)
	RETURN

	IF NOT EXISTS
	(
		SELECT * FROM [dbo].[�w�s�a�I�C��]
		WHERE [�w�s�a�IID] = @�w�s�a�IID
	)
	RETURN	

	UPDATE [dbo].[�i�f��C��]
	SET [�w�s�a�IID] = @�w�s�a�IID, [�i�f���] = @�i�f���, [���ӵ���] = @���ӵ���
	WHERE �i�f��s�� = @�i�f��s��
GO
--�R���i�f��C����
CREATE PROC dbo.Delete�i�f��C��
@�i�f��s�� int
AS
	IF NOT EXISTS
	(
		SELECT * FROM [dbo].[�i�f��C��]
		WHERE �i�f��s�� = @�i�f��s��
	)
	RETURN

	IF EXISTS
	(
		SELECT * FROM [dbo].[�i�f�����]
		WHERE �i�f��s�� = @�i�f��s��
	)
	RETURN

	DELETE FROM [dbo].[�i�f��C��]
	WHERE �i�f��s�� = @�i�f��s��
GO

-- �s�W�i�f����Ӹ��
CREATE PROC dbo.Insert�i�f�����
@�i�f��s�� int, @�ӫ~����ID tinyint, @�ӫ~ID smallint, @�ӫ~�ƶq smallint,
@�i�f���� decimal(15, 2) = 0, @�Ƶ� nvarchar(300) = '�L' 
AS
	DECLARE @�t��ID tinyint
	DECLARE @�i�f�� decimal(10, 2)

	IF NOT EXISTS
	(
		SELECT * FROM [dbo].[�i�f��C��]
		WHERE �i�f��s�� = @�i�f��s��
	)
	RETURN

	IF EXISTS
	(
		SELECT * FROM [dbo].[�i�f�����]
		WHERE [�i�f��s��] = @�i�f��s��
		  AND [�ӫ~����ID] = @�ӫ~����ID
		  AND [�ӫ~ID] = @�ӫ~ID	
	)
	RETURN
	
	SET @�t��ID = (SELECT �t��ID FROM [�i�f��C��] WHERE �i�f��s�� = @�i�f��s��)
	SET @�i�f�� =
	(
		SELECT [�i�f��] 
		FROM [dbo].[�ӫ~�C��] a
		WHERE a.�t��ID = @�t��ID
		AND a.�ӫ~����ID = @�ӫ~����ID
		AND a.�ӫ~ID = @�ӫ~ID
	)
	IF @�i�f�� IS NULL
	RETURN	

	--�a�J�ѼƬ�0�� �۰ʭp��i�f����
	IF @�i�f���� = 0
	BEGIN
		SET @�i�f���� = @�i�f�� * @�ӫ~�ƶq
	END
	
	INSERT INTO [dbo].[�i�f�����]
           ([�i�f��s��],[�ӫ~����ID], [�ӫ~ID], [�ӫ~�ƶq],[�i�f����],[�Ƶ�])
    VALUES
           (@�i�f��s��, @�ӫ~����ID, @�ӫ~ID, @�ӫ~�ƶq, @�i�f����, @�Ƶ�)
GO

-- �ק�i�f����Ӹ��(�ק� �ӫ~�ƶq/�i�f����/�Ƶ�)
CREATE PROC dbo.Update�i�f�����
@�i�f��s�� int, @�ӫ~����ID tinyint, @�ӫ~ID smallint, 
@�ӫ~�ƶq smallint, @�i�f���� decimal(15, 2) = 0, @�Ƶ� nvarchar(300) = '�L' 
AS
	DECLARE @�t��ID tinyint
	DECLARE @�i�f�� decimal(10, 2)

	--IF NOT EXISTS
	--(
	--	SELECT * FROM [dbo].[�i�f��C��]
	--	WHERE �i�f��s�� = @�i�f��s��
	--)
	--RETURN

	IF NOT EXISTS
	(
		SELECT * FROM [dbo].[�i�f�����]
		 WHERE [�i�f��s��] = @�i�f��s��
		   AND [�ӫ~����ID] = @�ӫ~����ID
		   AND [�ӫ~ID] = @�ӫ~ID	
	)
	RETURN
	
	SET @�t��ID = (SELECT �t��ID FROM [�i�f��C��] WHERE �i�f��s�� = @�i�f��s��)
	SET @�i�f�� =
	(
		SELECT [�i�f��] 
		FROM [dbo].[�ӫ~�C��] a
		WHERE a.�t��ID = @�t��ID
		AND a.�ӫ~����ID = @�ӫ~����ID
		AND a.�ӫ~ID = @�ӫ~ID
	)
	IF @�i�f�� IS NULL
	RETURN	

	--�a�J�ѼƬ�0�� �۰ʭp��i�f����
	IF @�i�f���� = 0
	BEGIN
		SET @�i�f���� = @�i�f�� * @�ӫ~�ƶq
	END

	UPDATE [dbo].[�i�f�����]
	SET [�ӫ~�ƶq] = @�ӫ~�ƶq, [�i�f����] = @�i�f����, [�Ƶ�] = @�Ƶ�
	WHERE [�i�f��s��] = @�i�f��s��
	  AND [�ӫ~����ID] = @�ӫ~����ID
	  AND [�ӫ~ID] = @�ӫ~ID
GO
--�R���i�f����Ӹ��
ALTER PROC dbo.Delete�i�f�����
@�i�f��s�� int, @�ӫ~����ID tinyint, @�ӫ~ID smallint 
AS
	DECLARE @�t��ID tinyint
	DECLARE @�i�f�� decimal(10, 2)

	--IF NOT EXISTS
	--(
	--	SELECT * FROM [dbo].[�i�f��C��]
	--	WHERE �i�f��s�� = @�i�f��s��
	--)
	--RETURN

	IF NOT EXISTS
	(
		SELECT * FROM [dbo].[�i�f�����]
		 WHERE [�i�f��s��] = @�i�f��s��
		   AND [�ӫ~����ID] = @�ӫ~����ID
		   AND [�ӫ~ID] = @�ӫ~ID	
	)
	RETURN

	DELETE FROM [dbo].[�i�f�����]
	WHERE [�i�f��s��] = @�i�f��s��
		   AND [�ӫ~����ID] = @�ӫ~����ID
		   AND [�ӫ~ID] = @�ӫ~ID	
GO