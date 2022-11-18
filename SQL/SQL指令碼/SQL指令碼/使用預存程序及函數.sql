USE [普雷二電玩]
GO

SELECT * FROM [dbo].[使用者列表]
--DELETE FROM [dbo].[使用者列表]

-- 新增使用者列表
EXEC Insert使用者列表 'HERO','hero1208', 1, 'shanshonc@gmail.com', 1
EXEC Insert使用者列表 'user','1234', 0, 'shanshonc@gmail.com',0
EXEC Insert使用者列表 'user2','1234', 0, 'shanshonc@gmail.com'

-- 使用者登入驗證
DECLARE @IsAdmin tinyint
EXEC 使用者LoginByEntity 'HERO','hero1208' , @IsAdmin OUTPUT
SELECT @IsAdmin

DECLARE @IsAdmin smallint 
DECLARE @IsCheck tinyint
EXEC 使用者LoginByPW 'HERO','hero1208' , @IsAdmin OUTPUT, @IsCheck OUTPUT
SELECT @IsAdmin, @IsCheck
-- eMail Mail_CheckCode
EXEC Mail_CheckCode 'HERO'

-- 使用者登入檢查驗證碼
EXEC 使用者LoginByCheckCode 'user', 774997

-- 清除使用者證驗登入狀態
EXEC 重置CheckCode 0
EXEC 重置CheckCode -1, 'HERO'
EXEC 重置CheckCode

--更新密碼
EXEC Update使用者PW 'user'
EXEC Update使用者PW 'user', '12345'

-- 新增廠商列表資料
EXEC Insert廠商列表 1,'台灣索尼股份有限公司 SONY', '23529362', '千葉雄三 (Yuzo Chiba)', 10000000
EXEC Insert廠商列表 2,'香港商任天堂香港有限公司 Nintendo', '90682097', '松本浩之 (Matsumoto Hiroyuki)', 5000000, NULL
EXEC Insert廠商列表 3,'台灣微軟股份有限公司 MICROSOFT', '23525730', '竇立佛 (Keith R. Dolliver)',10000000, '', 'Y'

--修改廠商列表資料(修改廠商名稱)
EXEC Update廠商列表 1,'索尼SONY', '23529362', '千葉雄三 (Yuzo Chiba)', 10000000, 3939889, 'n'
-- 刪除廠商列表資料
EXEC Delete廠商列表 1

-- 新增商品類型資料
EXEC Insert商品類型列表 1, '主機'
EXEC Insert商品類型列表 2, '遊戲軟體'
-- 修改商品類型資料(修改商品類型名稱)
EXEC Update商品類型列表 1, '主機名稱'
-- 刪除廠商列表資料
EXEC Delete商品類型列表 1

-- 新增商品資料
EXEC Insert商品列表 1, 1, 1, 'PlayStation 5 數位版', 10200, 14580
EXEC Insert商品列表 1, 1, 2, 'PlayStation 5 光碟版', 12300, 17580
EXEC Insert商品列表 1, 2, 1, '戰神：諸神黃昏 God of War Ragnarok', 1000, 1990

EXEC Insert商品列表 2, 1, 1, 'Nintendo Switch 主機', 5100, 7280
EXEC Insert商品列表 2, 1, 2, 'Nintendo Switch OLED主機', 7000, 9980
EXEC Insert商品列表 2, 2, 1, '斯普拉遁 3 Splatoon 3', 780, 1490

EXEC Insert商品列表 3, 1, 1, 'Xbox Series S 主機', 6600, 9480
EXEC Insert商品列表 3, 1 ,2, 'Xbox Series X 主機', 10700, 15380
EXEC Insert商品列表 3, 2, 1, 'NBA 2K23 中文版', 990, 1990

-- 修改商品類型(修改商品名稱)
EXEC Update商品列表 3, 2, 1, 'NBA 2K23 豪華版', 990, 2390

--刪除商品列表資料
EXEC Delete商品列表 3, 2, 1

-- 新增庫存地點列表資料
EXEC Insert庫存地點列表 1, '台北倉庫', '林口'
EXEC Insert庫存地點列表 2, '台中倉庫'
EXEC Insert庫存地點列表 3, '高雄倉庫'

-- 修改庫存地點列表資料(修改庫存地點)
EXEC Update庫存地點列表 1, '新北倉庫', '五股'

--刪除庫存地點列表資料
EXEC Delete庫存地點列表 1

-- 建立進貨單列表
EXEC Insert進貨單列表 1, 1, 1, '2022-09-22', 2
EXEC Insert進貨單列表 2, 2, 2, '2022-10-23', 2
EXEC Insert進貨單列表 3, 3, 3, '2022-11-01', 2

-- 修改進貨單列表資料(修改 庫存地點ID/進貨日期/明細筆數)
EXEC Update進貨單列表 1, 3, '2022-09-23', 3
EXEC Update進貨單列表 2, 1, '2022-10-20', 1
EXEC Update進貨單列表 3, 2, '2022-11-10', 2

--刪除進貨單列表資料
EXEC Delete進貨單列表 1
EXEC Delete進貨單列表 2
EXEC Delete進貨單列表 3

-- 建立進貨單明細
EXEC Insert進貨單明細 1,1,1,100
EXEC Insert進貨單明細 1,1,2,200,10000000,'手動輸入進貨成本'
EXEC Insert進貨單明細 1,2,1,300,NULL,'進貨成本先不輸入' 

EXEC Insert進貨單明細 2,1,1,200
EXEC Insert進貨單明細 2,1,2,400
EXEC Insert進貨單明細 2,2,1,100

EXEC Insert進貨單明細 3,1,1,50
EXEC Insert進貨單明細 3,1,2,100
EXEC Insert進貨單明細 3,2,1,300

-- 修改進貨單明細資料(修改 商品數量/進貨成本/備註)
EXEC Update進貨單明細 1,1,1,90, 1000000, '改成手動輸入進貨成本'
EXEC Update進貨單明細 1,1,2,200,0, '改成自動計算進貨成本'
EXEC Update進貨單明細 1,2,1,300,0

--刪除進貨單明細資料
EXEC Delete進貨單明細 1,1,1

EXEC Insert進貨單列表 4, 1, 1, '2022-09-22', 1
EXEC Insert進貨單明細 4,1,1,30

--查詢
-- 基底資料
SELECT * FROM [dbo].[使用者列表]
SELECT * FROM [dbo].[廠商列表]
SELECT * FROM [dbo].[商品類型列表]
SELECT * FROM [dbo].[商品列表]
SELECT * FROM fn_商品列表()
SELECT * FROM [dbo].[庫存地點列表]
SELECT * FROM [dbo].[經銷商列表]
--進貨單相關
SELECT * FROM [dbo].[進貨單列表]
SELECT * FROM [dbo].[進貨單明細]
SELECT * FROM [dbo].[商品在庫數量]
SELECT * FROM fn_進貨單列表()
SELECT * FROM fn_進貨單明細()
SELECT * FROM fn_庫存列表()
--出貨單相關
SELECT * FROM [dbo].[出貨單列表]
SELECT * FROM [dbo].[出貨單明細]

-- 查詢檢視表
SELECT * FROM [dbo].[v綜合庫存列表]
ORDER BY [庫存地點ID]

--應用 STRING_AGG
SELECT [廠商ID] , STRING_AGG([商品類型ID], '/') AS 商品類型ID, STRING_AGG([商品名稱], '/') AS 商品名稱
FROM [dbo].[商品列表]
GROUP BY [廠商ID] 

--清除商品資料順序
--DELETE FROM [dbo].[庫存地點列表]
--DELETE FROM [dbo].[商品列表]
--DELETE FROM [dbo].[商品類型列表]
--DELETE FROM [dbo].[廠商列表]
--DELETE FROM [dbo].[使用者列表]

--清除進貨單相關資料順序
--DELETE FROM [dbo].[商品在庫數量]
--DELETE FROM [dbo].[進貨單明細]
--DELETE FROM [dbo].[進貨單列表]

