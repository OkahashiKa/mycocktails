--
-- PostgreSQL database dump
--

-- Dumped from database version 12.5
-- Dumped by pg_dump version 12.5

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- Name: m_cocktail; Type: TABLE; Schema: public; Owner: mycocktails_admin
--

CREATE TABLE public.m_cocktail (
    id integer NOT NULL,
    name character varying(100),
    remarks character varying(1000),
    image bytea,
    create_at timestamp without time zone,
    update_at timestamp without time zone
);


ALTER TABLE public.m_cocktail OWNER TO mycocktails_admin;

--
-- Name: m_material; Type: TABLE; Schema: public; Owner: mycocktails_admin
--

CREATE TABLE public.m_material (
    id integer NOT NULL,
    name character varying(100),
    category_id integer NOT NULL,
    create_at timestamp without time zone,
    update_at timestamp without time zone
);


ALTER TABLE public.m_material OWNER TO mycocktails_admin;

--
-- Name: m_material_category; Type: TABLE; Schema: public; Owner: mycocktails_admin
--

CREATE TABLE public.m_material_category (
    id integer NOT NULL,
    name character varying(100),
    create_at timestamp without time zone,
    update_at timestamp without time zone
);


ALTER TABLE public.m_material_category OWNER TO mycocktails_admin;

--
-- Name: t_cocktail_material; Type: TABLE; Schema: public; Owner: mycocktails_admin
--

CREATE TABLE public.t_cocktail_material (
    cocktail_id integer NOT NULL,
    material_id integer NOT NULL,
    quantity integer,
    create_at timestamp without time zone,
    update_at timestamp without time zone
);


ALTER TABLE public.t_cocktail_material OWNER TO mycocktails_admin;

--
-- Name: m_cocktail m_cocktail_pkey; Type: CONSTRAINT; Schema: public; Owner: mycocktails_admin
--

ALTER TABLE ONLY public.m_cocktail
    ADD CONSTRAINT m_cocktail_pkey PRIMARY KEY (id);


--
-- Name: m_material_category m_material_category_pkey; Type: CONSTRAINT; Schema: public; Owner: mycocktails_admin
--

ALTER TABLE ONLY public.m_material_category
    ADD CONSTRAINT m_material_category_pkey PRIMARY KEY (id);


--
-- Name: m_material m_material_pkey; Type: CONSTRAINT; Schema: public; Owner: mycocktails_admin
--

ALTER TABLE ONLY public.m_material
    ADD CONSTRAINT m_material_pkey PRIMARY KEY (id);


--
-- Name: t_cocktail_material t_cocktail_material_pkey; Type: CONSTRAINT; Schema: public; Owner: mycocktails_admin
--

ALTER TABLE ONLY public.t_cocktail_material
    ADD CONSTRAINT t_cocktail_material_pkey PRIMARY KEY (cocktail_id, material_id);


--
-- Name: m_material m_material_category_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: mycocktails_admin
--

ALTER TABLE ONLY public.m_material
    ADD CONSTRAINT m_material_category_id_fkey FOREIGN KEY (category_id) REFERENCES public.m_material_category(id);


--
-- Name: t_cocktail_material t_cocktail_material_cocktail_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: mycocktails_admin
--

ALTER TABLE ONLY public.t_cocktail_material
    ADD CONSTRAINT t_cocktail_material_cocktail_id_fkey FOREIGN KEY (cocktail_id) REFERENCES public.m_cocktail(id);


--
-- Name: t_cocktail_material t_cocktail_material_material_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: mycocktails_admin
--

ALTER TABLE ONLY public.t_cocktail_material
    ADD CONSTRAINT t_cocktail_material_material_id_fkey FOREIGN KEY (material_id) REFERENCES public.m_material(id);


--
-- PostgreSQL database dump complete
--

