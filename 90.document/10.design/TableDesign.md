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
    *id : varchar(10)
    --

}

entity "m_material_category" as mc {

}

entity "m_material" as m {

}

entity "m_cocktail" as c {

}

entity "m_cocktail_recipi" as cr {

}

entity "user_material" as um {

}
@enduml
```