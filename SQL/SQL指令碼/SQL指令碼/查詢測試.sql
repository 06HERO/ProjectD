-- �ӫ~���
SELECT * FROM [dbo].[�t�ӦC��]
SELECT * FROM [dbo].[�ӫ~�����C��]
SELECT * FROM [dbo].[�ӫ~�C��]

-- �i�f����
SELECT * FROM [dbo].[�i�f��C��]
SELECT * FROM [dbo].[�i�f�����]
SELECT a.�i�f��s��, c.�t�ӦW��, d.�ӫ~�����W��, e.�ӫ~�W��, a.�ӫ~�ƶq, b.�i�f���, e.�i�f��, (e.�i�f�� * a.�ӫ~�ƶq) AS �p�p
FROM [dbo].[�i�f�����] a
JOIN [dbo].[�i�f��C��] b ON b.�i�f��s�� = a.�i�f��s��
INNER JOIN [dbo].[�t�ӦC��] c ON c.�t��ID = b.�t��ID
JOIN [dbo].[�ӫ~�����C��] d ON d.�ӫ~����ID = a.�ӫ~����ID
JOIN [dbo].[�ӫ~�C��] e ON e.�t��ID = b.�t��ID AND e.�ӫ~����ID = d.�ӫ~����ID AND e.�ӫ~ID = a.�ӫ~ID

-- �w�s����
SELECT * FROM [dbo].[�ӫ~�b�w�ƶq]
SELECT b.�t�ӦW��, c.�ӫ~�����W��, d.�ӫ~�W��, a.�ӫ~�ƶq
FROM [dbo].[�ӫ~�b�w�ƶq] a
INNER JOIN [dbo].[�t�ӦC��] b ON b.�t��ID = a.�t��ID
INNER JOIN [dbo].[�ӫ~�����C��] c ON c.�ӫ~����ID = a.�ӫ~����ID
INNER JOIN [dbo].[�ӫ~�C��] d ON d.�t��ID = a.�t��ID AND d.�ӫ~����ID = a.�ӫ~����ID AND d.�ӫ~ID = a.�ӫ~ID

SELECT b.�t�ӦW��, SUM(a.�ӫ~�ƶq) AS �����ӫ~�ƶq
FROM [dbo].[�ӫ~�b�w�ƶq] a
LEFT JOIN [dbo].[�t�ӦC��] b ON b.�t��ID = a.�t��ID
GROUP BY b.�t�ӦW��

SELECT b.�t�ӦW��, c.�ӫ~�����W��, SUM(a.�ӫ~�ƶq) AS �P�ӫ~�����ƶq
FROM [dbo].[�ӫ~�b�w�ƶq] a
LEFT JOIN [dbo].[�t�ӦC��] b ON b.�t��ID = a.�t��ID
LEFT JOIN [dbo].[�ӫ~�����C��] c ON c.�ӫ~����ID = a.�ӫ~����ID
GROUP BY b.�t�ӦW��, c.�ӫ~�����W��

--�M���i�f��ƶ���
DELETE FROM [dbo].[�ӫ~�b�w�ƶq]
DELETE FROM [dbo].[�i�f�����]
DELETE FROM [dbo].[�i�f��C��]

--�M���ӫ~��ƶ���
DELETE FROM [dbo].[�ӫ~�C��]
DELETE FROM [dbo].[�ӫ~�����C��]
DELETE FROM [dbo].[�t�ӦC��]


