/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2016                    */
/* Created on:     01/05/2017 10:49:38 AM                       */
/*==============================================================*/


if exists (select 1
            from  sysobjects
           where  id = object_id('ACTOR')
            and   type = 'U')
   drop table ACTOR
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ACTS')
            and   type = 'U')
   drop table ACTS
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ADMIN')
            and   type = 'U')
   drop table ADMIN
go

if exists (select 1
            from  sysobjects
           where  id = object_id('DIRECTOR')
            and   type = 'U')
   drop table DIRECTOR
go

if exists (select 1
            from  sysobjects
           where  id = object_id('MOVIE')
            and   type = 'U')
   drop table MOVIE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('RENT')
            and   type = 'U')
   drop table RENT
go

if exists (select 1
            from  sysobjects
           where  id = object_id('"USER"')
            and   type = 'U')
   drop table "USER"
go

/*==============================================================*/
/* Table: ACTOR                                                 */
/*==============================================================*/
create table ACTOR (
   ACTOR_ID             int                  not null,
   ACTOR_NAME           varchar(30)          null,
   constraint PK_ACTOR primary key (ACTOR_ID)
)
go

/*==============================================================*/
/* Table: ACTS                                                  */
/*==============================================================*/
create table ACTS (
   MOVIE_ID             int                  not null,
   ACTOR_ID             int                  not null,
   constraint PK_ACTS primary key (MOVIE_ID, ACTOR_ID)
)
go

/*==============================================================*/
/* Table: ADMIN                                                 */
/*==============================================================*/
create table ADMIN (
   ADMIN_ID             int                  not null,
   ADMIN_USERNAME       varchar(20)          not null,
   ADMIN_PASSWORD       varchar(20)          not null,
   ADMIN_FIRSTNAME      varchar(30)          not null,
   ADMIN_LASTNAME       varchar(30)          not null,
   ADMIN_REGDATE        datetime             not null,
   constraint PK_ADMIN primary key (ADMIN_ID)
)
go

/*==============================================================*/
/* Table: DIRECTOR                                              */
/*==============================================================*/
create table DIRECTOR (
   DIRECTOR_ID          int                  not null,
   DIRECTOR_NAME        varchar(30)          null,
   constraint PK_DIRECTOR primary key (DIRECTOR_ID)
)
go

/*==============================================================*/
/* Table: MOVIE                                                 */
/*==============================================================*/
create table MOVIE (
   MOVIE_ID             int                  not null,
   DIRECTOR_ID          int                  not null,
   ADMIN_ID             int                  not null,
   MOVIE_NAME           varchar(30)          null,
   MOVIE_YEAR           int                  not null,
   MOVIE_CATEGORY       varchar(20)          null,
   constraint PK_MOVIE primary key (MOVIE_ID)
)
go

/*==============================================================*/
/* Table: RENT                                                  */
/*==============================================================*/
create table RENT (
   USER_ID              int                  not null,
   MOVIE_ID             int                  not null,
   START_DATE           datetime             not null,
   END_DATE             datetime             not null,
   constraint PK_RENT primary key (USER_ID, MOVIE_ID)
)
go

/*==============================================================*/
/* Table: "USER"                                                */
/*==============================================================*/
create table "USER" (
   USER_ID              int                  not null,
   USER_USERNAME        varchar(20)          not null,
   USER_PASSWORD        varchar(20)          not null,
   USER_FIRSTNAME       varchar(30)          not null,
   USER_LASTNAME        varchar(30)          not null,
   USER_REGDATE         datetime             not null,
   constraint PK_USER primary key (USER_ID)
)
go

