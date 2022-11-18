USE [���p�G�q��]
GO

SELECT * FROM [dbo].[�ϥΪ̦C��]
--DELETE FROM [dbo].[�ϥΪ̦C��]

-- �s�W�ϥΪ̦C��
EXEC Insert�ϥΪ̦C�� 'HERO','hero1208', 1, 'shanshonc@gmail.com', 1
EXEC Insert�ϥΪ̦C�� 'user','1234', 0, 'shanshonc@gmail.com',0
EXEC Insert�ϥΪ̦C�� 'user2','1234', 0, 'shanshonc@gmail.com'

-- �ϥΪ̵n�J����
DECLARE @IsAdmin tinyint
EXEC �ϥΪ�LoginByEntity 'HERO','hero1208' , @IsAdmin OUTPUT
SELECT @IsAdmin

DECLARE @IsAdmin smallint 
DECLARE @IsCheck tinyint
EXEC �ϥΪ�LoginByPW 'HERO','hero1208' , @IsAdmin OUTPUT, @IsCheck OUTPUT
SELECT @IsAdmin, @IsCheck
-- eMail Mail_CheckCode
EXEC Mail_CheckCode 'HERO'

-- �ϥΪ̵n�J�ˬd���ҽX
EXEC �ϥΪ�LoginByCheckCode 'user', 774997

-- �M���ϥΪ�����n�J���A
EXEC ���mCheckCode 0
EXEC ���mCheckCode -1, 'HERO'
EXEC ���mCheckCode

--��s�K�X
EXEC Update�ϥΪ�PW 'user'
EXEC Update�ϥΪ�PW 'user', '12345'

-- �s�W�t�ӦC����
EXEC Insert�t�ӦC�� 1,'�x�W�����ѥ��������q SONY', '23529362', '�d�����T (Yuzo Chiba)', 10000000
EXEC Insert�t�ӦC�� 2,'����ӥ��Ѱ󭻴䦳�����q Nintendo', '90682097', '�Q���E�� (Matsumoto Hiroyuki)', 5000000, NULL
EXEC Insert�t�ӦC�� 3,'�x�W�L�n�ѥ��������q MICROSOFT', '23525730', '�u�ߦ� (Keith R. Dolliver)',10000000, '', 'Y'

--�ק�t�ӦC����(�ק�t�ӦW��)
EXEC Update�t�ӦC�� 1,'����SONY', '23529362', '�d�����T (Yuzo Chiba)', 10000000, 3939889, 'n'
-- �R���t�ӦC����
EXEC Delete�t�ӦC�� 1

-- �s�W�ӫ~�������
EXEC Insert�ӫ~�����C�� 1, '�D��'
EXEC Insert�ӫ~�����C�� 2, '�C���n��'
-- �ק�ӫ~�������(�ק�ӫ~�����W��)
EXEC Update�ӫ~�����C�� 1, '�D���W��'
-- �R���t�ӦC����
EXEC Delete�ӫ~�����C�� 1

-- �s�W�ӫ~���
EXEC Insert�ӫ~�C�� 1, 1, 1, 'PlayStation 5 �Ʀ쪩', 10200, 14580
EXEC Insert�ӫ~�C�� 1, 1, 2, 'PlayStation 5 ���Ъ�', 12300, 17580
EXEC Insert�ӫ~�C�� 1, 2, 1, '�ԯ��G�ѯ����� God of War Ragnarok', 1000, 1990

EXEC Insert�ӫ~�C�� 2, 1, 1, 'Nintendo Switch �D��', 5100, 7280
EXEC Insert�ӫ~�C�� 2, 1, 2, 'Nintendo Switch OLED�D��', 7000, 9980
EXEC Insert�ӫ~�C�� 2, 2, 1, '�����ԹP 3 Splatoon 3', 780, 1490

EXEC Insert�ӫ~�C�� 3, 1, 1, 'Xbox Series S �D��', 6600, 9480
EXEC Insert�ӫ~�C�� 3, 1 ,2, 'Xbox Series X �D��', 10700, 15380
EXEC Insert�ӫ~�C�� 3, 2, 1, 'NBA 2K23 ���媩', 990, 1990

-- �ק�ӫ~����(�ק�ӫ~�W��)
EXEC Update�ӫ~�C�� 3, 2, 1, 'NBA 2K23 ���ت�', 990, 2390

--�R���ӫ~�C����
EXEC Delete�ӫ~�C�� 3, 2, 1

-- �s�W�w�s�a�I�C����
EXEC Insert�w�s�a�I�C�� 1, '�x�_�ܮw', '�L�f'
EXEC Insert�w�s�a�I�C�� 2, '�x���ܮw'
EXEC Insert�w�s�a�I�C�� 3, '�����ܮw'

-- �ק�w�s�a�I�C����(�ק�w�s�a�I)
EXEC Update�w�s�a�I�C�� 1, '�s�_�ܮw', '����'

--�R���w�s�a�I�C����
EXEC Delete�w�s�a�I�C�� 1

-- �إ߶i�f��C��
EXEC Insert�i�f��C�� 1, 1, 1, '2022-09-22', 2
EXEC Insert�i�f��C�� 2, 2, 2, '2022-10-23', 2
EXEC Insert�i�f��C�� 3, 3, 3, '2022-11-01', 2

-- �ק�i�f��C����(�ק� �w�s�a�IID/�i�f���/���ӵ���)
EXEC Update�i�f��C�� 1, 3, '2022-09-23', 3
EXEC Update�i�f��C�� 2, 1, '2022-10-20', 1
EXEC Update�i�f��C�� 3, 2, '2022-11-10', 2

--�R���i�f��C����
EXEC Delete�i�f��C�� 1
EXEC Delete�i�f��C�� 2
EXEC Delete�i�f��C�� 3

-- �إ߶i�f�����
EXEC Insert�i�f����� 1,1,1,100
EXEC Insert�i�f����� 1,1,2,200,10000000,'��ʿ�J�i�f����'
EXEC Insert�i�f����� 1,2,1,300,NULL,'�i�f����������J' 

EXEC Insert�i�f����� 2,1,1,200
EXEC Insert�i�f����� 2,1,2,400
EXEC Insert�i�f����� 2,2,1,100

EXEC Insert�i�f����� 3,1,1,50
EXEC Insert�i�f����� 3,1,2,100
EXEC Insert�i�f����� 3,2,1,300

-- �ק�i�f����Ӹ��(�ק� �ӫ~�ƶq/�i�f����/�Ƶ�)
EXEC Update�i�f����� 1,1,1,90, 1000000, '�令��ʿ�J�i�f����'
EXEC Update�i�f����� 1,1,2,200,0, '�令�۰ʭp��i�f����'
EXEC Update�i�f����� 1,2,1,300,0

--�R���i�f����Ӹ��
EXEC Delete�i�f����� 1,1,1

EXEC Insert�i�f��C�� 4, 1, 1, '2022-09-22', 1
EXEC Insert�i�f����� 4,1,1,30

--�d��
-- �򩳸��
SELECT * FROM [dbo].[�ϥΪ̦C��]
SELECT * FROM [dbo].[�t�ӦC��]
SELECT * FROM [dbo].[�ӫ~�����C��]
SELECT * FROM [dbo].[�ӫ~�C��]
SELECT * FROM fn_�ӫ~�C��()
SELECT * FROM [dbo].[�w�s�a�I�C��]
SELECT * FROM [dbo].[�g�P�ӦC��]
--�i�f�����
SELECT * FROM [dbo].[�i�f��C��]
SELECT * FROM [dbo].[�i�f�����]
SELECT * FROM [dbo].[�ӫ~�b�w�ƶq]
SELECT * FROM fn_�i�f��C��()
SELECT * FROM fn_�i�f�����()
SELECT * FROM fn_�w�s�C��()
--�X�f�����
SELECT * FROM [dbo].[�X�f��C��]
SELECT * FROM [dbo].[�X�f�����]

-- �d���˵���
SELECT * FROM [dbo].[v��X�w�s�C��]
ORDER BY [�w�s�a�IID]

--���� STRING_AGG
SELECT [�t��ID] , STRING_AGG([�ӫ~����ID], '/') AS �ӫ~����ID, STRING_AGG([�ӫ~�W��], '/') AS �ӫ~�W��
FROM [dbo].[�ӫ~�C��]
GROUP BY [�t��ID] 

--�M���ӫ~��ƶ���
--DELETE FROM [dbo].[�w�s�a�I�C��]
--DELETE FROM [dbo].[�ӫ~�C��]
--DELETE FROM [dbo].[�ӫ~�����C��]
--DELETE FROM [dbo].[�t�ӦC��]
--DELETE FROM [dbo].[�ϥΪ̦C��]

--�M���i�f�������ƶ���
--DELETE FROM [dbo].[�ӫ~�b�w�ƶq]
--DELETE FROM [dbo].[�i�f�����]
--DELETE FROM [dbo].[�i�f��C��]

