# postgres:12を使用
FROM postgres:12

# ロケール設定
RUN localedef -i ja_JP -c -f UTF-8 -A /usr/share/locale/locale.alias ja_JP.UTF-8
ENV LANG ja_JP.utf8

# 初期データ投入シェルのコピー
COPY /initdb.d /docker-entrypoint-initdb.d/