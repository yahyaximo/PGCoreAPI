-- Table: public.Movies

-- DROP TABLE IF EXISTS public."Movies";

CREATE TABLE IF NOT EXISTS public."Movies"
(
    "Id" integer NOT NULL,
    "Title" text COLLATE pg_catalog."default" NOT NULL,
    "Description" text COLLATE pg_catalog."default",
    "Rating" numeric NOT NULL,
    "Image" text COLLATE pg_catalog."default",
    "Create_at" timestamp with time zone NOT NULL,
    "Update_at" timestamp with time zone NOT NULL,
    CONSTRAINT "PK_id" PRIMARY KEY ("Id")
)

TABLESPACE pg_default;

ALTER TABLE IF EXISTS public."Movies"
    OWNER to postgres;