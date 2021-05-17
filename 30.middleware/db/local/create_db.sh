#!/bin/bash
set -e

psql -v ON_ERROR_STOP=1 -U postgres <<-EOSQL
    DROP DATABASE mycocktails_db;
    CREATE USER "mycocktails_admin";
    CREATE DATABASE "mycocktails_db";
    GRANT ALL PRIVILEGES ON DATABASE "mycocktails_db" TO "mycocktails_admin";
EOSQL

psql -U postgres -d mycocktails_db -f /docker-entrypoint-initdb.d/mycocktails_db.ddl
psql -U postgres -d mycocktails_db -f /docker-entrypoint-initdb.d/mycocktails_db.dml
psql -U postgres -d mycocktails_db -c 'ALTER DATABASE "mycocktails_db" SET timezone TO "JAPAN";'