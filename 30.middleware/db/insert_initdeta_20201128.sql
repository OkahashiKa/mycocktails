-- SQLServer
-- insert m_material_category deta.
INSERT INTO [dbo].[m_material_category] VALUES (1, N'スピッツ', GETDATE(), GETDATE());
INSERT INTO [dbo].[m_material_category] VALUES (2, N'リキュール', GETDATE(), GETDATE());
INSERT INTO [dbo].[m_material_category] VALUES (3, N'ワイン', GETDATE(), GETDATE());
INSERT INTO [dbo].[m_material_category] VALUES (4, N'ジュース', GETDATE(), GETDATE());
INSERT INTO [dbo].[m_material_category] VALUES (5, N'炭酸飲料', GETDATE(), GETDATE());
INSERT INTO [dbo].[m_material_category] VALUES (6, N'シロップ', GETDATE(), GETDATE());
INSERT INTO [dbo].[m_material_category] VALUES (7, N'その他', GETDATE(), GETDATE());

-- insert m_material deta.
INSERT INTO [dbo].[m_material] VALUES (1, N'ジン', 1, GETDATE(), GETDATE());
INSERT INTO [dbo].[m_material] VALUES (2, N'ウォッカ', 1, GETDATE(), GETDATE());
INSERT INTO [dbo].[m_material] VALUES (3, N'ラム', 1, GETDATE(), GETDATE());
INSERT INTO [dbo].[m_material] VALUES (4, N'テキーラ', 1, GETDATE(), GETDATE());
INSERT INTO [dbo].[m_material] VALUES (5, N'カシス', 2, GETDATE(), GETDATE());
INSERT INTO [dbo].[m_material] VALUES (6, N'ピーチ', 2, GETDATE(), GETDATE());
INSERT INTO [dbo].[m_material] VALUES (7, N'ライチ', 2, GETDATE(), GETDATE());
INSERT INTO [dbo].[m_material] VALUES (8, N'カルーア', 2, GETDATE(), GETDATE());
INSERT INTO [dbo].[m_material] VALUES (9, N'赤ワイン', 3, GETDATE(), GETDATE());
INSERT INTO [dbo].[m_material] VALUES (10, N'白ワイン', 3, GETDATE(), GETDATE());
INSERT INTO [dbo].[m_material] VALUES (11, N'ロゼ', 3, GETDATE(), GETDATE());
INSERT INTO [dbo].[m_material] VALUES (12, N'ヴェルモット', 3, GETDATE(), GETDATE());
INSERT INTO [dbo].[m_material] VALUES (13, N'オレンジジュース', 4, GETDATE(), GETDATE());
INSERT INTO [dbo].[m_material] VALUES (14, N'レモンジュース', 4, GETDATE(), GETDATE());
INSERT INTO [dbo].[m_material] VALUES (15, N'ライムジュース', 4, GETDATE(), GETDATE());
INSERT INTO [dbo].[m_material] VALUES (16, N'グレープフルーツジュース', 4, GETDATE(), GETDATE());
INSERT INTO [dbo].[m_material] VALUES (17, N'ソーダ', 5, GETDATE(), GETDATE());
INSERT INTO [dbo].[m_material] VALUES (18, N'トニックウォーター', 5, GETDATE(), GETDATE());
INSERT INTO [dbo].[m_material] VALUES (19, N'ニンジャエール', 5, GETDATE(), GETDATE());
INSERT INTO [dbo].[m_material] VALUES (20, N'コーラ', 5, GETDATE(), GETDATE());
INSERT INTO [dbo].[m_material] VALUES (21, N'ガムシロップ', 6, GETDATE(), GETDATE());
INSERT INTO [dbo].[m_material] VALUES (22, N'オリーブ', 7, GETDATE(), GETDATE());
INSERT INTO [dbo].[m_material] VALUES (23, N'ミント', 7, GETDATE(), GETDATE());
INSERT INTO [dbo].[m_material] VALUES (24, N'ミルク', 7, GETDATE(), GETDATE());

-- insert m_cocktail deta.
INSERT INTO [dbo].[m_cocktail]  VALUES (1, N'ジントニック', GETDATE(), GETDATE());
INSERT INTO [dbo].[m_cocktail]  VALUES (2, N'マティーニ', GETDATE(), GETDATE());
INSERT INTO [dbo].[m_cocktail]  VALUES (3, N'スクリュードライバー', GETDATE(), GETDATE());
INSERT INTO [dbo].[m_cocktail]  VALUES (4, N'モスコミュール', GETDATE(), GETDATE());
INSERT INTO [dbo].[m_cocktail]  VALUES (5, N'カシスソーダ', GETDATE(), GETDATE());
INSERT INTO [dbo].[m_cocktail]  VALUES (6, N'カシスオレンジ', GETDATE(), GETDATE());
INSERT INTO [dbo].[m_cocktail]  VALUES (7, N'ファジーネーブル', GETDATE(), GETDATE());
INSERT INTO [dbo].[m_cocktail]  VALUES (8, N'カルーアミルク', GETDATE(), GETDATE());
INSERT INTO [dbo].[m_cocktail]  VALUES (9, N'カーディナル', GETDATE(), GETDATE());
INSERT INTO [dbo].[m_cocktail]  VALUES (10, N'キール', GETDATE(), GETDATE());
INSERT INTO [dbo].[m_cocktail]  VALUES (11, N'スプリッツァー', GETDATE(), GETDATE());

-- insert t_cocktail_material deta.
INSERT INTO t_cocktail_material  VALUES (1, 1, GETDATE(), GETDATE());
INSERT INTO t_cocktail_material  VALUES (1, 18, GETDATE(), GETDATE());
INSERT INTO t_cocktail_material  VALUES (2, 1, GETDATE(), GETDATE());
INSERT INTO t_cocktail_material  VALUES (2, 12, GETDATE(), GETDATE());
INSERT INTO t_cocktail_material  VALUES (2, 22, GETDATE(), GETDATE());
INSERT INTO t_cocktail_material  VALUES (3, 2, GETDATE(), GETDATE());
INSERT INTO t_cocktail_material  VALUES (3, 13, GETDATE(), GETDATE());
INSERT INTO t_cocktail_material  VALUES (4, 2, GETDATE(), GETDATE());
INSERT INTO t_cocktail_material  VALUES (4, 15, GETDATE(), GETDATE());
INSERT INTO t_cocktail_material  VALUES (4, 19, GETDATE(), GETDATE());
INSERT INTO t_cocktail_material  VALUES (5, 5, GETDATE(), GETDATE());
INSERT INTO t_cocktail_material  VALUES (5, 17, GETDATE(), GETDATE());
INSERT INTO t_cocktail_material  VALUES (6, 5, GETDATE(), GETDATE());
INSERT INTO t_cocktail_material  VALUES (6, 13, GETDATE(), GETDATE());
INSERT INTO t_cocktail_material  VALUES (7, 6, GETDATE(), GETDATE());
INSERT INTO t_cocktail_material  VALUES (7, 13, GETDATE(), GETDATE());
INSERT INTO t_cocktail_material  VALUES (8, 8, GETDATE(), GETDATE());
INSERT INTO t_cocktail_material  VALUES (8, 24, GETDATE(), GETDATE());
INSERT INTO t_cocktail_material  VALUES (9, 9, GETDATE(), GETDATE());
INSERT INTO t_cocktail_material  VALUES (9, 5, GETDATE(), GETDATE());
INSERT INTO t_cocktail_material  VALUES (10, 10, GETDATE(), GETDATE());
INSERT INTO t_cocktail_material  VALUES (10, 5, GETDATE(), GETDATE());
INSERT INTO t_cocktail_material  VALUES (11, 10, GETDATE(), GETDATE());
INSERT INTO t_cocktail_material  VALUES (11, 17, GETDATE(), GETDATE());

-- PostgresSQL
-- insert m_material_category deta.
INSERT INTO m_material_category VALUES (1, 'スピッツ', NOW(), NOW());
INSERT INTO m_material_category VALUES (2, 'リキュール', NOW(), NOW());
INSERT INTO m_material_category VALUES (3, 'ワイン', NOW(), NOW());
INSERT INTO m_material_category VALUES (4, 'ジュース', NOW(), NOW());
INSERT INTO m_material_category VALUES (5, '炭酸飲料', NOW(), NOW());
INSERT INTO m_material_category VALUES (6, 'シロップ', NOW(), NOW());
INSERT INTO m_material_category VALUES (7, 'その他', NOW(), NOW());

-- insert m_material deta.
INSERT INTO m_material VALUES (1, 'ジン', 1, NOW(), NOW());
INSERT INTO m_material VALUES (2, 'ウォッカ', 1, NOW(), NOW());
INSERT INTO m_material VALUES (3, 'ラム', 1, NOW(), NOW());
INSERT INTO m_material VALUES (4, 'テキーラ', 1, NOW(), NOW());
INSERT INTO m_material VALUES (5, 'カシス', 2, NOW(), NOW());
INSERT INTO m_material VALUES (6, 'ピーチ', 2, NOW(), NOW());
INSERT INTO m_material VALUES (7, 'ライチ', 2, NOW(), NOW());
INSERT INTO m_material VALUES (8, 'カルーア', 2, NOW(), NOW());
INSERT INTO m_material VALUES (9, '赤ワイン', 3, NOW(), NOW());
INSERT INTO m_material VALUES (10, '白ワイン', 3, NOW(), NOW());
INSERT INTO m_material VALUES (11, 'ロゼ', 3, NOW(), NOW());
INSERT INTO m_material VALUES (12, 'ヴェルモット', 3, NOW(), NOW());
INSERT INTO m_material VALUES (13, 'オレンジジュース', 4, NOW(), NOW());
INSERT INTO m_material VALUES (14, 'レモンジュース', 4, NOW(), NOW());
INSERT INTO m_material VALUES (15, 'ライムジュース', 4, NOW(), NOW());
INSERT INTO m_material VALUES (16, 'グレープフルーツジュース', 4, NOW(), NOW());
INSERT INTO m_material VALUES (17, 'ソーダ', 5, NOW(), NOW());
INSERT INTO m_material VALUES (18, 'トニックウォーター', 5, NOW(), NOW());
INSERT INTO m_material VALUES (19, 'ニンジャエール', 5, NOW(), NOW());
INSERT INTO m_material VALUES (20, 'コーラ', 5, NOW(), NOW());
INSERT INTO m_material VALUES (21, 'ガムシロップ', 6, NOW(), NOW());
INSERT INTO m_material VALUES (22, 'オリーブ', 7, NOW(), NOW());
INSERT INTO m_material VALUES (23, 'ミント', 7, NOW(), NOW());
INSERT INTO m_material VALUES (24, 'ミルク', 7, NOW(), NOW());

-- insert m_cocktail deta.
INSERT INTO m_cocktail  VALUES (1, 'ジントニック', NOW(), NOW());
INSERT INTO m_cocktail  VALUES (2, 'マティーニ', NOW(), NOW());
INSERT INTO m_cocktail  VALUES (3, 'スクリュードライバー', NOW(), NOW());
INSERT INTO m_cocktail  VALUES (4, 'モスコミュール', NOW(), NOW());
INSERT INTO m_cocktail  VALUES (5, 'カシスソーダ', NOW(), NOW());
INSERT INTO m_cocktail  VALUES (6, 'カシスオレンジ', NOW(), NOW());
INSERT INTO m_cocktail  VALUES (7, 'ファジーネーブル', NOW(), NOW());
INSERT INTO m_cocktail  VALUES (8, 'カルーアミルク', NOW(), NOW());
INSERT INTO m_cocktail  VALUES (9, 'カーディナル', NOW(), NOW());
INSERT INTO m_cocktail  VALUES (10, 'キール', NOW(), NOW());
INSERT INTO m_cocktail  VALUES (11, 'スプリッツァー', NOW(), NOW());

-- insert t_cocktail_material deta.
INSERT INTO t_cocktail_material  VALUES (1, 1, NOW(), NOW());
INSERT INTO t_cocktail_material  VALUES (1, 18, NOW(), NOW());
INSERT INTO t_cocktail_material  VALUES (2, 1, NOW(), NOW());
INSERT INTO t_cocktail_material  VALUES (2, 12, NOW(), NOW());
INSERT INTO t_cocktail_material  VALUES (2, 22, NOW(), NOW());
INSERT INTO t_cocktail_material  VALUES (3, 2, NOW(), NOW());
INSERT INTO t_cocktail_material  VALUES (3, 13, NOW(), NOW());
INSERT INTO t_cocktail_material  VALUES (4, 2, NOW(), NOW());
INSERT INTO t_cocktail_material  VALUES (4, 15, NOW(), NOW());
INSERT INTO t_cocktail_material  VALUES (4, 19, NOW(), NOW());
INSERT INTO t_cocktail_material  VALUES (5, 5, NOW(), NOW());
INSERT INTO t_cocktail_material  VALUES (5, 17, NOW(), NOW());
INSERT INTO t_cocktail_material  VALUES (6, 5, NOW(), NOW());
INSERT INTO t_cocktail_material  VALUES (6, 13, NOW(), NOW());
INSERT INTO t_cocktail_material  VALUES (7, 6, NOW(), NOW());
INSERT INTO t_cocktail_material  VALUES (7, 13, NOW(), NOW());
INSERT INTO t_cocktail_material  VALUES (8, 8, NOW(), NOW());
INSERT INTO t_cocktail_material  VALUES (8, 24, NOW(), NOW());
INSERT INTO t_cocktail_material  VALUES (9, 9, NOW(), NOW());
INSERT INTO t_cocktail_material  VALUES (9, 5, NOW(), NOW());
INSERT INTO t_cocktail_material  VALUES (10, 10, NOW(), NOW());
INSERT INTO t_cocktail_material  VALUES (10, 5, NOW(), NOW());
INSERT INTO t_cocktail_material  VALUES (11, 10, NOW(), NOW());
INSERT INTO t_cocktail_material  VALUES (11, 17, NOW(), NOW());