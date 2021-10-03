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
INSERT INTO m_material_category (name, create_at, update_at) VALUES ('スピッツ', NOW(), NOW());
INSERT INTO m_material_category (name, create_at, update_at) VALUES ('リキュール', NOW(), NOW());
INSERT INTO m_material_category (name, create_at, update_at) VALUES ('ワイン', NOW(), NOW());
INSERT INTO m_material_category (name, create_at, update_at) VALUES ('ジュース', NOW(), NOW());
INSERT INTO m_material_category (name, create_at, update_at) VALUES ('炭酸飲料', NOW(), NOW());
INSERT INTO m_material_category (name, create_at, update_at) VALUES ('シロップ', NOW(), NOW());
INSERT INTO m_material_category (name, create_at, update_at) VALUES ('その他', NOW(), NOW());

-- insert m_material deta.
INSERT INTO m_material (name, category_id, create_at, update_at)VALUES ('ジン', 1, NOW(), NOW());
INSERT INTO m_material (name, category_id, create_at, update_at)VALUES ('ウォッカ', 1, NOW(), NOW());
INSERT INTO m_material (name, category_id, create_at, update_at)VALUES ('ラム', 1, NOW(), NOW());
INSERT INTO m_material (name, category_id, create_at, update_at)VALUES ('テキーラ', 1, NOW(), NOW());
INSERT INTO m_material (name, category_id, create_at, update_at)VALUES ('カシス', 2, NOW(), NOW());
INSERT INTO m_material (name, category_id, create_at, update_at)VALUES ('ピーチ', 2, NOW(), NOW());
INSERT INTO m_material (name, category_id, create_at, update_at)VALUES ('ライチ', 2, NOW(), NOW());
INSERT INTO m_material (name, category_id, create_at, update_at)VALUES ('カルーア', 2, NOW(), NOW());
INSERT INTO m_material (name, category_id, create_at, update_at)VALUES ('赤ワイン', 3, NOW(), NOW());
INSERT INTO m_material (name, category_id, create_at, update_at)VALUES ('白ワイン', 3, NOW(), NOW());
INSERT INTO m_material (name, category_id, create_at, update_at)VALUES ('ロゼ', 3, NOW(), NOW());
INSERT INTO m_material (name, category_id, create_at, update_at)VALUES ('ヴェルモット', 3, NOW(), NOW());
INSERT INTO m_material (name, category_id, create_at, update_at)VALUES ('オレンジジュース', 4, NOW(), NOW());
INSERT INTO m_material (name, category_id, create_at, update_at)VALUES ('レモンジュース', 4, NOW(), NOW());
INSERT INTO m_material (name, category_id, create_at, update_at)VALUES ('ライムジュース', 4, NOW(), NOW());
INSERT INTO m_material (name, category_id, create_at, update_at)VALUES ('グレープフルーツジュース', 4, NOW(), NOW());
INSERT INTO m_material (name, category_id, create_at, update_at)VALUES ('ソーダ', 5, NOW(), NOW());
INSERT INTO m_material (name, category_id, create_at, update_at)VALUES ('トニックウォーター', 5, NOW(), NOW());
INSERT INTO m_material (name, category_id, create_at, update_at)VALUES ('ジンジャエール', 5, NOW(), NOW());
INSERT INTO m_material (name, category_id, create_at, update_at)VALUES ('コーラ', 5, NOW(), NOW());
INSERT INTO m_material (name, category_id, create_at, update_at)VALUES ('ガムシロップ', 6, NOW(), NOW());
INSERT INTO m_material (name, category_id, create_at, update_at)VALUES ('オリーブ', 7, NOW(), NOW());
INSERT INTO m_material (name, category_id, create_at, update_at)VALUES ('ミント', 7, NOW(), NOW());
INSERT INTO m_material (name, category_id, create_at, update_at)VALUES ('ミルク', 7, NOW(), NOW());

-- insert m_cocktail deta.
INSERT INTO m_cocktail (name, remarks, image, create_at, update_at) VALUES ('ジントニック', null, null, NOW(), NOW());
INSERT INTO m_cocktail (name, remarks, image, create_at, update_at) VALUES ('マティーニ', null, null, NOW(), NOW());
INSERT INTO m_cocktail (name, remarks, image, create_at, update_at) VALUES ('スクリュードライバー', null, null, NOW(), NOW());
INSERT INTO m_cocktail (name, remarks, image, create_at, update_at) VALUES ('モスコミュール', null, null, NOW(), NOW());
INSERT INTO m_cocktail (name, remarks, image, create_at, update_at) VALUES ('カシスソーダ', null, null, NOW(), NOW());
INSERT INTO m_cocktail (name, remarks, image, create_at, update_at) VALUES ('カシスオレンジ', null, null, NOW(), NOW());
INSERT INTO m_cocktail (name, remarks, image, create_at, update_at) VALUES ('ファジーネーブル', null, null, NOW(), NOW());
INSERT INTO m_cocktail (name, remarks, image, create_at, update_at) VALUES ('カルーアミルク', null, null, NOW(), NOW());
INSERT INTO m_cocktail (name, remarks, image, create_at, update_at) VALUES ('カーディナル', null, null, NOW(), NOW());
INSERT INTO m_cocktail (name, remarks, image, create_at, update_at) VALUES ('キール', null, null, NOW(), NOW());
INSERT INTO m_cocktail (name, remarks, image, create_at, update_at) VALUES ('スプリッツァー', null, null, NOW(), NOW());

-- insert m_cocktail_recipi deta.
INSERT INTO m_cocktail_recipi  VALUES (1, 1, 40, NOW(), NOW());
INSERT INTO m_cocktail_recipi  VALUES (1, 18, 120, NOW(), NOW());
INSERT INTO m_cocktail_recipi  VALUES (2, 1, 45, NOW(), NOW());
INSERT INTO m_cocktail_recipi  VALUES (2, 12, 15, NOW(), NOW());
INSERT INTO m_cocktail_recipi  VALUES (2, 22, 1, NOW(), NOW());
INSERT INTO m_cocktail_recipi  VALUES (3, 2, 40, NOW(), NOW());
INSERT INTO m_cocktail_recipi  VALUES (3, 13, 100, NOW(), NOW());
INSERT INTO m_cocktail_recipi  VALUES (4, 2, 45, NOW(), NOW());
INSERT INTO m_cocktail_recipi  VALUES (4, 15, 10, NOW(), NOW());
INSERT INTO m_cocktail_recipi  VALUES (4, 19, 120, NOW(), NOW());
INSERT INTO m_cocktail_recipi  VALUES (5, 5, 40, NOW(), NOW());
INSERT INTO m_cocktail_recipi  VALUES (5, 17, 120, NOW(), NOW());
INSERT INTO m_cocktail_recipi  VALUES (6, 5, 40, NOW(), NOW());
INSERT INTO m_cocktail_recipi  VALUES (6, 13, 120, NOW(), NOW());
INSERT INTO m_cocktail_recipi  VALUES (7, 6, 30, NOW(), NOW());
INSERT INTO m_cocktail_recipi  VALUES (7, 13, 30, NOW(), NOW());
INSERT INTO m_cocktail_recipi  VALUES (8, 8, 30, NOW(), NOW());
INSERT INTO m_cocktail_recipi  VALUES (8, 24, 90, NOW(), NOW());
INSERT INTO m_cocktail_recipi  VALUES (9, 9, 15, NOW(), NOW());
INSERT INTO m_cocktail_recipi  VALUES (9, 5, 45, NOW(), NOW());
INSERT INTO m_cocktail_recipi  VALUES (10, 10, 15, NOW(), NOW());
INSERT INTO m_cocktail_recipi  VALUES (10, 5, 45, NOW(), NOW());
INSERT INTO m_cocktail_recipi  VALUES (11, 10, 30, NOW(), NOW());
INSERT INTO m_cocktail_recipi  VALUES (11, 17, 20, NOW(), NOW());

-- insert m_role deta.
INSERT INTO m_role (name, create_at, update_at) VALUES ('admin', NOW(), NOW());
INSERT INTO m_role (name, create_at, update_at) VALUES ('user', NOW(), NOW());
INSERT INTO m_role (name, create_at, update_at) VALUES ('preminum', NOW(), NOW());

--insert m_user deta.
INSERT INTO m_user (id, password, mail, role_id, favo_cocktail_id, create_at, update_at) VALUES ('kazuki.okahashi', '22a7b27978ca8aec294b318f58570cf2887cd11f458fbe3bb3584f5bfa6986c2', 'okarians.302.dev@gmail.com', 1, null, NOW(), NOW());