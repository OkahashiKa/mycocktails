# Function list
## 実装したい機能（夢）
- ログイン
- 今あるカクテルの材料を登録しておくと作れるカクテルのリストが見られる機能。
- レシピを登録できる機能。
- レシピをシェアし、他の人のレシピを確認する機能。（SNSっぽくする？）
  - SNSっぽくするならレシピに対してコメントやいいねをつけられる機能。

## 実装予定の機能(現実)
|機能ID|機能名|機能概要|画面ID|画面名|APIID|API名|
|---|---|---|---|---|---|---|
|FUSR001|サインアップ|アカウントの新規登録を行う|SUSR002|アカウント登録画面|AUSR001|ユーザ情報登録|
|FUSR002|サインイン|ログインを行う|SUSR001|ログイン画面|AMTL005|ログイン|
|FUSR003|サインアウト|ログアウトを行う|SUSR001|ログイン画面|AMTL006|ログアウト|
|FUSR004|パスワード再設定|パスワードの再設定を行う|SUSR003|パスワード再設定画面|AMTL004|パスワード再発行|
|FUSR005|ユーザ情報表示|登録済みアカウント情報を表示する|SUSR004|プロフィール画面|AUSR002|ユーザー情報取得|
|FUSR006|ユーザ情報更新|登録済みアカウント情報の更新を行う|SUSR005|プロフィール編集画面|AUSR003|ユーザ情報更新|
|FMTL001|材料登録|材料マスタ情報の登録を行う|SMST001|材料登録画面|AMTL001, AMTL002|材料情報登録, 材料情報一括登録|
|FMTL002|材料表示|登録済み材料マスタ情報を表示する|SMST002|材料管理画面|AMTL003, AMTL004|材料情報取得, 材料情報全件取得|
|FMTL003|材料更新|登録済み材料マスタ情報の更新を行う|SMST002|材料管理画面|AMTL005, AMTL006|材料情報更新, 材料情報一括更新|
|FMTL004|材料削除|登録済み材料マスタ情報の削除を行う|SMST002|材料管理画面|AMTL007, AMTL008|材料情報削除, 材料情報一括削除|
|FMTL005|現在の材料登録|ユーザーごとに現在家にあるカクテル材料を登録する|SMTL003|現在の材料管理画面|AMTL009|ユーザ材料情報登録|
|FMTL006|現在の材料表示|ユーザーごとの家にあるカクテル材料を表示する|SMTL003|現在の材料管理画面|AMTL010|ユーザ材料情報全件取得|
|FMTL007|現在の材料削除|ユーザーごとの家にあるカクテル材料を削除する|SMTL003|現在の材料管理画面|AMTL011|ユーザ材料削除|
|FCTL001|カクテル登録|カクテルマスタ情報の登録を行う|SCTL001|カクテル登録画面|ACTL001, ACTL002|カクテル情報登録, カクテル情報一括登録|
|FCTL002|カクテル表示|登録済みカクテルマスタ情報を表示する|SCTL002|カクテル管理画面|ACTL003, ACTL004|カクテル情報取得, カクテル情報全件取得|
|FCTL003|カクテル編集|登録済みカクテルマスタ情報の編集を行う|SCTL002|カクテル管理画面|ACTL005, ACTL006|カクテル情報更新, カクテル情報一括更新|
|FCTL004|カクテル削除|登録済みカクテルマスタ情報の削除を行う|SCTL002|カクテル管理画面|ACTL007, ACTL008|カクテル情報削除, カクテル情報一括削除|
|FCTL005|カクテル検索|入力された条件からカクテルを検索する|SCTL003|カクテル検索画面|ACTL009|カクテル検索|
|FCTL006|作成可能カクテル検索|材料リストから作れるカクテルを検索する|STOP001|トップ画面|ACTL009|カクテル検索|
||||||||
