--
-- PostgreSQL database dump
--

-- Dumped from database version 13.4
-- Dumped by pg_dump version 13.4

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
-- Name: m_cocktail; Type: TABLE; Schema: public; Owner: postgress
--

CREATE TABLE public.m_cocktail (
    id integer NOT NULL,
    name character varying(100) NOT NULL,
    remarks character varying(1000),
    image bytea,
    create_at timestamp without time zone NOT NULL,
    update_at timestamp without time zone NOT NULL
);


ALTER TABLE public.m_cocktail OWNER TO postgress;

--
-- Name: m_cocktail_id_seq; Type: SEQUENCE; Schema: public; Owner: postgress
--

CREATE SEQUENCE public.m_cocktail_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.m_cocktail_id_seq OWNER TO postgress;

--
-- Name: m_cocktail_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgress
--

ALTER SEQUENCE public.m_cocktail_id_seq OWNED BY public.m_cocktail.id;


--
-- Name: m_cocktail_recipi; Type: TABLE; Schema: public; Owner: postgress
--

CREATE TABLE public.m_cocktail_recipi (
    cocktail_id integer NOT NULL,
    material_id integer NOT NULL,
    quantity integer NOT NULL,
    create_at timestamp without time zone NOT NULL,
    update_at timestamp without time zone NOT NULL
);


ALTER TABLE public.m_cocktail_recipi OWNER TO postgress;

--
-- Name: m_material; Type: TABLE; Schema: public; Owner: postgress
--

CREATE TABLE public.m_material (
    id integer NOT NULL,
    name character varying(100) NOT NULL,
    category_id integer NOT NULL,
    create_at timestamp without time zone NOT NULL,
    update_at timestamp without time zone NOT NULL
);


ALTER TABLE public.m_material OWNER TO postgress;

--
-- Name: m_material_category; Type: TABLE; Schema: public; Owner: postgress
--

CREATE TABLE public.m_material_category (
    id integer NOT NULL,
    name character varying(100) NOT NULL,
    create_at timestamp without time zone NOT NULL,
    update_at timestamp without time zone NOT NULL
);


ALTER TABLE public.m_material_category OWNER TO postgress;

--
-- Name: m_material_category_id_seq; Type: SEQUENCE; Schema: public; Owner: postgress
--

CREATE SEQUENCE public.m_material_category_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.m_material_category_id_seq OWNER TO postgress;

--
-- Name: m_material_category_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgress
--

ALTER SEQUENCE public.m_material_category_id_seq OWNED BY public.m_material_category.id;


--
-- Name: m_material_id_seq; Type: SEQUENCE; Schema: public; Owner: postgress
--

CREATE SEQUENCE public.m_material_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.m_material_id_seq OWNER TO postgress;

--
-- Name: m_material_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgress
--

ALTER SEQUENCE public.m_material_id_seq OWNED BY public.m_material.id;


--
-- Name: m_role; Type: TABLE; Schema: public; Owner: postgress
--

CREATE TABLE public.m_role (
    id integer NOT NULL,
    name character varying(10) NOT NULL,
    create_at timestamp without time zone NOT NULL,
    update_at timestamp without time zone NOT NULL
);


ALTER TABLE public.m_role OWNER TO postgress;

--
-- Name: m_role_id_seq; Type: SEQUENCE; Schema: public; Owner: postgress
--

CREATE SEQUENCE public.m_role_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.m_role_id_seq OWNER TO postgress;

--
-- Name: m_role_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgress
--

ALTER SEQUENCE public.m_role_id_seq OWNED BY public.m_role.id;


--
-- Name: m_user; Type: TABLE; Schema: public; Owner: postgress
--

CREATE TABLE public.m_user (
    id character varying(100) NOT NULL,
    password character varying(100) NOT NULL,
    mail character varying(100),
    role_id integer NOT NULL,
    favo_cocktail_id integer,
    create_at timestamp without time zone NOT NULL,
    update_at timestamp without time zone NOT NULL
);


ALTER TABLE public.m_user OWNER TO postgress;

--
-- Name: user_material; Type: TABLE; Schema: public; Owner: postgress
--

CREATE TABLE public.user_material (
    user_id character varying(100) NOT NULL,
    material_id integer NOT NULL,
    create_at timestamp without time zone NOT NULL,
    update_at timestamp without time zone NOT NULL,
    delete_at timestamp without time zone
);


ALTER TABLE public.user_material OWNER TO postgress;

--
-- Name: m_cocktail id; Type: DEFAULT; Schema: public; Owner: postgress
--

ALTER TABLE ONLY public.m_cocktail ALTER COLUMN id SET DEFAULT nextval('public.m_cocktail_id_seq'::regclass);


--
-- Name: m_material id; Type: DEFAULT; Schema: public; Owner: postgress
--

ALTER TABLE ONLY public.m_material ALTER COLUMN id SET DEFAULT nextval('public.m_material_id_seq'::regclass);


--
-- Name: m_material_category id; Type: DEFAULT; Schema: public; Owner: postgress
--

ALTER TABLE ONLY public.m_material_category ALTER COLUMN id SET DEFAULT nextval('public.m_material_category_id_seq'::regclass);


--
-- Name: m_role id; Type: DEFAULT; Schema: public; Owner: postgress
--

ALTER TABLE ONLY public.m_role ALTER COLUMN id SET DEFAULT nextval('public.m_role_id_seq'::regclass);


--
-- Name: m_cocktail m_cocktail_pkey; Type: CONSTRAINT; Schema: public; Owner: postgress
--

ALTER TABLE ONLY public.m_cocktail
    ADD CONSTRAINT m_cocktail_pkey PRIMARY KEY (id);


--
-- Name: m_cocktail_recipi m_cocktail_recipi_pkey; Type: CONSTRAINT; Schema: public; Owner: postgress
--

ALTER TABLE ONLY public.m_cocktail_recipi
    ADD CONSTRAINT m_cocktail_recipi_pkey PRIMARY KEY (cocktail_id, material_id);


--
-- Name: m_material_category m_material_category_pkey; Type: CONSTRAINT; Schema: public; Owner: postgress
--

ALTER TABLE ONLY public.m_material_category
    ADD CONSTRAINT m_material_category_pkey PRIMARY KEY (id);


--
-- Name: m_material m_material_pkey; Type: CONSTRAINT; Schema: public; Owner: postgress
--

ALTER TABLE ONLY public.m_material
    ADD CONSTRAINT m_material_pkey PRIMARY KEY (id);


--
-- Name: m_role m_role_pkey; Type: CONSTRAINT; Schema: public; Owner: postgress
--

ALTER TABLE ONLY public.m_role
    ADD CONSTRAINT m_role_pkey PRIMARY KEY (id);


--
-- Name: m_user m_user_pkey; Type: CONSTRAINT; Schema: public; Owner: postgress
--

ALTER TABLE ONLY public.m_user
    ADD CONSTRAINT m_user_pkey PRIMARY KEY (id);


--
-- Name: user_material user_material_pkey; Type: CONSTRAINT; Schema: public; Owner: postgress
--

ALTER TABLE ONLY public.user_material
    ADD CONSTRAINT user_material_pkey PRIMARY KEY (user_id, material_id);


--
-- Name: m_cocktail_recipi m_cocktail_recipi_cocktail_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgress
--

ALTER TABLE ONLY public.m_cocktail_recipi
    ADD CONSTRAINT m_cocktail_recipi_cocktail_id_fkey FOREIGN KEY (cocktail_id) REFERENCES public.m_cocktail(id);


--
-- Name: m_cocktail_recipi m_cocktail_recipi_material_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgress
--

ALTER TABLE ONLY public.m_cocktail_recipi
    ADD CONSTRAINT m_cocktail_recipi_material_id_fkey FOREIGN KEY (material_id) REFERENCES public.m_material(id);


--
-- Name: m_material m_material_category_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgress
--

ALTER TABLE ONLY public.m_material
    ADD CONSTRAINT m_material_category_id_fkey FOREIGN KEY (category_id) REFERENCES public.m_material_category(id);


--
-- Name: m_user m_user_favo_cocktail_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgress
--

ALTER TABLE ONLY public.m_user
    ADD CONSTRAINT m_user_favo_cocktail_id_fkey FOREIGN KEY (favo_cocktail_id) REFERENCES public.m_cocktail(id);


--
-- Name: m_user m_user_role_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgress
--

ALTER TABLE ONLY public.m_user
    ADD CONSTRAINT m_user_role_id_fkey FOREIGN KEY (role_id) REFERENCES public.m_role(id);


--
-- PostgreSQL database dump complete
--

