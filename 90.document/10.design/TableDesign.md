# Table Design
## table list
|テーブル論理名|テーブル物理名|M/T区分|概要|
|---|---|---|---|
|m_user|ユーザーマスタ|M|ユーザーのマスタテーブル|
|m_role|権限マスタ|M|権限のマスタテーブル|
|m_user_role|ユーザー権限マスタ|M|ユーザー権限のマスタテーブル|
|m_material_category|材料カテゴリマスタ|M|材料カテゴリのマスタテーブル|
|m_material|材料マスタ|M|材料のマスタテーブル|
|m_cocktail|カクテルマスタ|M|カクテルのマスタテーブル|
|m_recipi|レシピマスタ|M|レシピのマスタテーブル|
|user_material|ユーザー材料|T|ユーザーごとの材料情報を格納するテーブル|


## ER
``` plantuml
@startuml
entity "m_user" as u {
    *id: varchar(10) *
    --
    password: varchar(100) *
    mail: varchar(100) *
    role_id: integer <<FK>> *
    favo_cocktail_id: integer <<FK>>
    create_at: timestamp *
    update_at: timestamp *
}

entity "m_role" as r {
    *id: serial *
    --
    name: varchar(10) *
    create_at: timestamp *
    update_at: timestamp *
}

entity "m_material_category" as mc {
    *id: serial *
    --
    name: varchar(100) *
    create_at: timestamp *
    update_at: timestamp *
}

entity "m_material" as m {
    *id:  serial *
    --
    name: varchar(100) *
    category_id: integer <<FK>> *
    create_at: timestamp *
    update_at: timestamp *
}

entity "m_cocktail" as c {
    *id: serial *
    --
    name: varchar(100) *
    remark: varchar(1000)
    image: bytea
    create_at: timestamp *
    update_at: timestamp *
}

entity "m_cocktail_recipi" as cr {
    *cocktail_id: integer <<FK>> *
    *material_id: integer <<FK>> *
    --
    quantity: integer *
    create_at: timestamp *
    update_at: timestamp *
}

entity "user_material" as um {
    *user_id: integer <<FK>> *
    *material_id: integer <<FK>> *
    --
    create_at: timestamp *
    update_at: timestamp *
    delete_at: timestamp
}

u }|..|| r
u ||..o{ um
m ||..o{ um
m }|..|| mc
m ||..o{ cr
c ||..|{ cr

@enduml
```