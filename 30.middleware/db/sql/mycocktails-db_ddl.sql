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
    id INTEGER NOT NULL,
    name VARCHAR(100),
    create_at TIMESTAMP,
    update_at TIMESTAMP,
    PRIMARY KEY(id)
);

CREATE TABLE m_material (
    id INTEGER NOT NULL,
    name VARCHAR(100),
    category_id INTEGER NOT NULL,
    create_at TIMESTAMP,
    update_at TIMESTAMP,
    PRIMARY KEY(id),
    FOREIGN KEY(category_id) REFERENCES m_material_category(id)
);

CREATE TABLE m_cocktail (
    id INTEGER NOT NULL,
    name VARCHAR(100),
    remarks VARCHAR(1000),
    image BYTEA,
    create_at TIMESTAMP,
    update_at TIMESTAMP,
    PRIMARY KEY(id)
);

CREATE TABLE t_cocktail_material (
    cocktail_id INTEGER NOT NULL,
    material_id INTEGER NOT NULL,
    quantity INTEGER,
    create_at TIMESTAMP,
    update_at TIMESTAMP,
    PRIMARY KEY(cocktail_id, material_id),
    FOREIGN KEY(cocktail_id) REFERENCES m_cocktail(id),
    FOREIGN KEY(material_id) REFERENCES m_material(id)
);