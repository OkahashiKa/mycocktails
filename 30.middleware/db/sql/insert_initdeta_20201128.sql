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