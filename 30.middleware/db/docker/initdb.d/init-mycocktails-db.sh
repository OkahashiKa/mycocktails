#!/bin/bash
set -e

psql -v ON_ERROR_STOP=1 -U "$POSTGRES_USER" <<-EOSQL
    CREATE USER ${DBUSER};
    CREATE DATABASE ${DBNAME};
    GRANT ALL PRIVILEGES ON DATABASE ${DBNAME} TO ${DBADMIN};
EOSQL

psql -d ${DBNAME} -f /docker-entrypoint-initdb.d/mycocktails_db.ddl
psql -d ${DBNAME} -f /docker-entrypoint-initdb.d/mycocktails_db.dml
psql -d ${DBNAME} -c 'ALTER DATABASE "ZasekiDB" SET timezone TO 'JAPAN';'



psql -v ON_ERROR_STOP=1 --username postgres <<-EOSQL
    CREATE USER test_user;
    CREATE DATABASE test_db;
    GRANT ALL PRIVILEGES ON DATABASE test_db TO test_user;
EOSQL