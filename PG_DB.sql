PGDMP                   
    {            TES    16.0    16.0 
    �           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            �           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            �           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            �           1262    16563    TES    DATABASE        CREATE DATABASE "TES" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'Indonesian_Indonesia.1252';
    DROP DATABASE "TES";
                postgres    false            �            1259    16570    Movies    TABLE       CREATE TABLE public."Movies" (
    "Id" integer NOT NULL,
    "Title" text NOT NULL,
    "Description" text,
    "Rating" numeric NOT NULL,
    "Image" text,
    "Create_at" timestamp with time zone NOT NULL,
    "Update_at" timestamp with time zone NOT NULL
);
    DROP TABLE public."Movies";
       public         heap    postgres    false            �            1259    16564    __EFMigrationsHistory    TABLE     �   CREATE TABLE public."__EFMigrationsHistory" (
    "MigrationId" character varying(150) NOT NULL,
    "ProductVersion" character varying(32) NOT NULL
);
 +   DROP TABLE public."__EFMigrationsHistory";
       public         heap    postgres    false            �          0    16570    Movies 
   TABLE DATA           m   COPY public."Movies" ("Id", "Title", "Description", "Rating", "Image", "Create_at", "Update_at") FROM stdin;
    public          postgres    false    216   �
       �          0    16564    __EFMigrationsHistory 
   TABLE DATA           R   COPY public."__EFMigrationsHistory" ("MigrationId", "ProductVersion") FROM stdin;
    public          postgres    false    215   �                  2606    16568 .   __EFMigrationsHistory PK___EFMigrationsHistory 
   CONSTRAINT     {   ALTER TABLE ONLY public."__EFMigrationsHistory"
    ADD CONSTRAINT "PK___EFMigrationsHistory" PRIMARY KEY ("MigrationId");
 \   ALTER TABLE ONLY public."__EFMigrationsHistory" DROP CONSTRAINT "PK___EFMigrationsHistory";
       public            postgres    false    215                        2606    16578    Movies PK_id 
   CONSTRAINT     P   ALTER TABLE ONLY public."Movies"
    ADD CONSTRAINT "PK_id" PRIMARY KEY ("Id");
 :   ALTER TABLE ONLY public."Movies" DROP CONSTRAINT "PK_id";
       public            postgres    false    216            �   �   x�}��N�0���)�C�$mH���@BB:FWɵVK"��<=9����᷿��b/>�88���0��g
;8\p����-�0�<�_	a�)��5|b�њ���s��V����)����c�Y���RV]����µ�`V�JY])U�T�ӫ;љ�F�"�w_2���t%�J�R�K�7R4���.Q��x͎�C@��3%�p�~�i@�Y+�c�n��)"j縋�����kH      �   =   x�320264401�4210�O.JM,IMI
H/.��4�3�34�2��161�@UcS���� +�     