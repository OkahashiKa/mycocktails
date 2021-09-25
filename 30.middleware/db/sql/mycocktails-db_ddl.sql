-- SQLServer
CREATE TABLE m_material_category (
    id INTEGER NOT NULL,
    name NVARCHAR(100),
    create_at DATETIME,
    update_at DATETIME,
    PRIMARY KEY(id)
);

CREATE TABLE m_material (
    id INTEGER NOT NULL,
    name NVARCHAR(100),
    category_id INTEGER NOT NULL,
    create_at DATETIME,
    update_at DATETIME,
    PRIMARY KEY(id),
    FOREIGN KEY(category_id) REFERENCES m_material_category(id)
);

CREATE TABLE m_cocktail (
    id INTEGER NOT NULL,
    name NVARCHAR(100),
    create_at DATETIME,
    update_at DATETIME,
    PRIMARY KEY(id)
);

CREATE TABLE t_cocktail_material (
    cocktail_id INTEGER NOT NULL,
    material_id INTEGER NOT NULL,
    create_at DATETIME,
    update_at DATETIME,
    PRIMARY KEY(cocktail_id, material_id),
    FOREIGN KEY(cocktail_id) REFERENCES m_cocktail(id),
    FOREIGN KEY(material_id) REFERENCES m_material(id)
);


-- PostgresSQL
CREATE TABLE m_material_category (
    id SERIAL NOT NULL,
    name VARCHAR(100) NOT NULL,
    create_at TIMESTAMP NOT NULL,
    update_at TIMESTAMP NOT NULL,
    PRIMARY KEY(id)
);

CREATE TABLE m_material (
    id SERIAL NOT NULL,
    name VARCHAR(100) NOT NULL,
    category_id INTEGER NOT NULL,
    create_at TIMESTAMP NOT NULL,
    update_at TIMESTAMP NOT NULL,
    PRIMARY KEY(id),
    FOREIGN KEY(category_id) REFERENCES m_material_category(id)
);

CREATE TABLE m_cocktail (
    id SERIAL NOT NULL,
    name VARCHAR(100) NOT NULL,
    remarks VARCHAR(1000),
    image BYTEA,
    create_at TIMESTAMP NOT NULL,
    update_at TIMESTAMP NOT NULL,
    PRIMARY KEY(id)
);

CREATE TABLE m_cocktail_recipi (
    cocktail_id INTEGER NOT NULL,
    material_id INTEGER NOT NULL,
    quantity INTEGER NOT NULL,
    create_at TIMESTAMP NOT NULL,
    update_at TIMESTAMP NOT NULL,
    PRIMARY KEY(cocktail_id, material_id),
    FOREIGN KEY(cocktail_id) REFERENCES m_cocktail(id),
    FOREIGN KEY(material_id) REFERENCES m_material(id)
);

CREATE TABLE m_role (
    id SERIAL NOT NULL,
    name VARCHAR(10) NOT NULL,
    create_at TIMESTAMP NOT NULL,
    update_at TIMESTAMP NOT NULL,
    PRIMARY KEY(id)
);

CREATE TABLE m_user (
    id VARCHAR(100) NOT NULL,
    password VARCHAR(100) NOT NULL,
    mail VARCHAR(100),
    role_id INTEGER NOT NULL,
    favo_cocktail_id INTEGER,
    create_at TIMESTAMP NOT NULL,
    update_at TIMESTAMP NOT NULL,
    PRIMARY KEY(id),
    FOREIGN KEY(role_id) REFERENCES m_role(id),
    FOREIGN KEY(favo_cocktail_id) REFERENCES m_cocktail(id)
);

CREATE TABLE user_material (
    user_id VARCHAR(100) NOT NULL,
    material_id INTEGER NOT NULL,
    create_at TIMESTAMP NOT NULL,
    update_at TIMESTAMP NOT NULL,
    delete_at TIMESTAMP,
    PRIMARY KEY(user_id, material_id)
);