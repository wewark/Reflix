/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2016                    */
/* Created on:     05/05/2017 8:19:17 PM                        */
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
           where  id = object_id('USERS')
            and   type = 'U')
   drop table USERS
go

/*==============================================================*/
/* Table: ACTOR                                                 */
/*==============================================================*/
create table ACTOR (
   actor_id             int                  identity,
   actor_name           varchar(30)          null,
   constraint PK_ACTOR primary key (actor_id)
)
go

/*==============================================================*/
/* Table: ACTS                                                  */
/*==============================================================*/
create table ACTS (
   movie_id             int                  not null,
   actor_id             int                  not null,
   constraint PK_ACTS primary key (movie_id, actor_id)
)
go

/*==============================================================*/
/* Table: ADMIN                                                 */
/*==============================================================*/
create table ADMIN (
   admin_id             int                  identity,
   admin_username       varchar(20)          not null,
   admin_password       varchar(20)          not null,
   admin_firstname      varchar(30)          not null,
   admin_lastname       varchar(30)          null,
   admin_email          varchar(50)          not null,
   admin_regdate        datetime             not null,
   constraint PK_ADMIN primary key (admin_id)
)
go

/*==============================================================*/
/* Table: DIRECTOR                                              */
/*==============================================================*/
create table DIRECTOR (
   director_id          int                  identity,
   director_name        varchar(30)          null,
   constraint PK_DIRECTOR primary key (director_id)
)
go

/*==============================================================*/
/* Table: MOVIE                                                 */
/*==============================================================*/
create table MOVIE (
   movie_id             int                  identity,
   director_id          int                  not null,
   admin_id             int                  not null,
   movie_name           varchar(30)          not null,
   movie_year           int                  null,
   movie_category       varchar(20)          null,
   movie_pricepermonth  float                not null,
   constraint PK_MOVIE primary key (movie_id)
)
go

/*==============================================================*/
/* Table: RENT                                                  */
/*==============================================================*/
create table RENT (
   user_id              int                  not null,
   movie_id             int                  not null,
   constraint PK_RENT primary key (user_id, movie_id)
)
go

/*==============================================================*/
/* Table: USERS                                                 */
/*==============================================================*/
create table USERS (
   user_id              int                  identity,
   user_username        varchar(20)          not null,
   user_password        varchar(20)          not null,
   user_firstname       varchar(30)          not null,
   user_lastname        varchar(30)          null,
   user_email           varchar(50)          not null,
   user_creditcard      varchar(16)          null,
   user_regdate         datetime             not null,
   constraint PK_USERS primary key (user_id)
)
go

