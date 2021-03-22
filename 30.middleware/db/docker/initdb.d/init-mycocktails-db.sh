#!/bin/bash
set -e

psql -v ON_ERROR_STOP=1 -U "$POSTGRES_USER" <<-EOSQL
    CREATE USER "${DBADMIN}";
    CREATE DATABASE "${DBNAME}";
    GRANT ALL PRIVILEGES ON DATABASE "${DBNAME}" TO "${DBADMIN}";
EOSQL

psql -d ${DBNAME} -f /docker-entrypoint-initdb.d/mycocktails_db.ddl
psql -d ${DBNAME} -f /docker-entrypoint-initdb.d/mycocktails_db.dml
psql -d ${DBNAME} -c 'ALTER DATABASE "mycocktails_db" SET timezone TO 'JAPAN';'