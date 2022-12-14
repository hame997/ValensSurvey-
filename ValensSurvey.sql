PGDMP     5    9            	    z           ValensSurvey    15.0    15.0                0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false                       0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false                       0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false                       1262    16398    ValensSurvey    DATABASE     ?   CREATE DATABASE "ValensSurvey" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'English_United States.1252';
    DROP DATABASE "ValensSurvey";
                postgres    false            ?            1259    16449 	   questions    TABLE     j   CREATE TABLE public.questions (
    id integer NOT NULL,
    survey_id integer NOT NULL,
    text text
);
    DROP TABLE public.questions;
       public         heap    postgres    false            ?            1259    16448    questions_id_seq    SEQUENCE     ?   CREATE SEQUENCE public.questions_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 '   DROP SEQUENCE public.questions_id_seq;
       public          postgres    false    219                       0    0    questions_id_seq    SEQUENCE OWNED BY     E   ALTER SEQUENCE public.questions_id_seq OWNED BY public.questions.id;
          public          postgres    false    218            ?            1259    16466    survey_managements    TABLE     x   CREATE TABLE public.survey_managements (
    user_id integer NOT NULL,
    survey_id integer NOT NULL,
    note text
);
 &   DROP TABLE public.survey_managements;
       public         heap    postgres    false            ?            1259    16440    surveys    TABLE     ?   CREATE TABLE public.surveys (
    id integer NOT NULL,
    title text,
    survey_start_and_end date,
    description text,
    create_by integer NOT NULL
);
    DROP TABLE public.surveys;
       public         heap    postgres    false            ?            1259    16439    surveys_id_seq    SEQUENCE     ?   CREATE SEQUENCE public.surveys_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 %   DROP SEQUENCE public.surveys_id_seq;
       public          postgres    false    217                       0    0    surveys_id_seq    SEQUENCE OWNED BY     A   ALTER SEQUENCE public.surveys_id_seq OWNED BY public.surveys.id;
          public          postgres    false    216            ?            1259    16409    users    TABLE     y   CREATE TABLE public.users (
    id integer NOT NULL,
    role integer NOT NULL,
    full_name text,
    password text
);
    DROP TABLE public.users;
       public         heap    postgres    false            ?            1259    16408    users_id_seq    SEQUENCE     ?   CREATE SEQUENCE public.users_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 #   DROP SEQUENCE public.users_id_seq;
       public          postgres    false    215                       0    0    users_id_seq    SEQUENCE OWNED BY     =   ALTER SEQUENCE public.users_id_seq OWNED BY public.users.id;
          public          postgres    false    214            u           2604    16452    questions id    DEFAULT     l   ALTER TABLE ONLY public.questions ALTER COLUMN id SET DEFAULT nextval('public.questions_id_seq'::regclass);
 ;   ALTER TABLE public.questions ALTER COLUMN id DROP DEFAULT;
       public          postgres    false    218    219    219            t           2604    16443 
   surveys id    DEFAULT     h   ALTER TABLE ONLY public.surveys ALTER COLUMN id SET DEFAULT nextval('public.surveys_id_seq'::regclass);
 9   ALTER TABLE public.surveys ALTER COLUMN id DROP DEFAULT;
       public          postgres    false    217    216    217            s           2604    16412    users id    DEFAULT     d   ALTER TABLE ONLY public.users ALTER COLUMN id SET DEFAULT nextval('public.users_id_seq'::regclass);
 7   ALTER TABLE public.users ALTER COLUMN id DROP DEFAULT;
       public          postgres    false    215    214    215                      0    16449 	   questions 
   TABLE DATA           8   COPY public.questions (id, survey_id, text) FROM stdin;
    public          postgres    false    219   ?                 0    16466    survey_managements 
   TABLE DATA           F   COPY public.survey_managements (user_id, survey_id, note) FROM stdin;
    public          postgres    false    220   ?                 0    16440    surveys 
   TABLE DATA           Z   COPY public.surveys (id, title, survey_start_and_end, description, create_by) FROM stdin;
    public          postgres    false    217   +                 0    16409    users 
   TABLE DATA           >   COPY public.users (id, role, full_name, password) FROM stdin;
    public          postgres    false    215   ?                  0    0    questions_id_seq    SEQUENCE SET     >   SELECT pg_catalog.setval('public.questions_id_seq', 9, true);
          public          postgres    false    218                       0    0    surveys_id_seq    SEQUENCE SET     <   SELECT pg_catalog.setval('public.surveys_id_seq', 8, true);
          public          postgres    false    216                       0    0    users_id_seq    SEQUENCE SET     ;   SELECT pg_catalog.setval('public.users_id_seq', 27, true);
          public          postgres    false    214            {           2606    16456    questions questions_pkey 
   CONSTRAINT     V   ALTER TABLE ONLY public.questions
    ADD CONSTRAINT questions_pkey PRIMARY KEY (id);
 B   ALTER TABLE ONLY public.questions DROP CONSTRAINT questions_pkey;
       public            postgres    false    219            }           2606    16470 *   survey_managements survey_managements_pkey 
   CONSTRAINT     x   ALTER TABLE ONLY public.survey_managements
    ADD CONSTRAINT survey_managements_pkey PRIMARY KEY (user_id, survey_id);
 T   ALTER TABLE ONLY public.survey_managements DROP CONSTRAINT survey_managements_pkey;
       public            postgres    false    220    220            y           2606    16447    surveys surveys_pkey 
   CONSTRAINT     R   ALTER TABLE ONLY public.surveys
    ADD CONSTRAINT surveys_pkey PRIMARY KEY (id);
 >   ALTER TABLE ONLY public.surveys DROP CONSTRAINT surveys_pkey;
       public            postgres    false    217            w           2606    16416    users users_pkey 
   CONSTRAINT     N   ALTER TABLE ONLY public.users
    ADD CONSTRAINT users_pkey PRIMARY KEY (id);
 :   ALTER TABLE ONLY public.users DROP CONSTRAINT users_pkey;
       public            postgres    false    215               9   x?3?4?,.)??K?2B0?L??4G0-LKN#N??r????????<?=... ]?v         7   x????????2?4Q??& ʈӐ???(3/??АӜ?/?,S!?(??+F??? ?p         G   x?3?,.)??K?4202?54?52??p??4Ɛ4CH???4?'i?O????cJ>??{jzbP"F??? "!;?         m   x?m?;
?@E?z?1??a#
"????+?X\???0???ö??2>?2??@)?R?<?]h??^??3???IL	S?D?S??{?D????^ԋzQ?O?N?????????>     