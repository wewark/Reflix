/*==============================================================*/
/* DBMS name:      MySQL 5.0                                    */
/* Created on:     05/05/2017 8:32:18 PM                        */
/*==============================================================*/


drop table if exists ACTOR;

drop table if exists ACTS;

drop table if exists ADMIN;

drop table if exists DIRECTOR;

drop table if exists MOVIE;

drop table if exists RENT;

drop table if exists USERS;

/*==============================================================*/
/* Table: ACTOR                                                 */
/*==============================================================*/
create table ACTOR
(
   actor_id             int not null auto_increment,
   actor_name           varchar(30),
   primary key (actor_id)
);

/*==============================================================*/
/* Table: ACTS                                                  */
/*==============================================================*/
create table ACTS
(
   movie_id             int not null,
   actor_id             int not null,
   primary key (movie_id, actor_id)
);

/*==============================================================*/
/* Table: ADMIN                                                 */
/*==============================================================*/
create table ADMIN
(
   admin_id             int not null auto_increment,
   admin_username       varchar(20) not null,
   admin_password       varchar(20) not null,
   admin_firstname      varchar(30) not null,
   admin_lastname       varchar(30),
   admin_email          varchar(50) not null,
   admin_regdate        datetime not null,
   primary key (admin_id)
);

/*==============================================================*/
/* Table: DIRECTOR                                              */
/*==============================================================*/
create table DIRECTOR
(
   director_id          int not null auto_increment,
   director_name        varchar(30),
   primary key (director_id)
);

/*==============================================================*/
/* Table: MOVIE                                                 */
/*==============================================================*/
create table MOVIE
(
   movie_id             int not null auto_increment,
   director_id          int not null,
   admin_id             int not null,
   movie_name           varchar(30) not null,
   movie_year           int,
   movie_category       varchar(20),
   movie_pricepermonth  float not null,
   primary key (movie_id)
);

/*==============================================================*/
/* Table: RENT                                                  */
/*==============================================================*/
create table RENT
(
   user_id              int not null,
   movie_id             int not null,
   primary key (user_id, movie_id)
);

/*==============================================================*/
/* Table: USERS                                                 */
/*==============================================================*/
create table USERS
(
   user_id              int not null auto_increment,
   user_username        varchar(20) not null,
   user_password        varchar(20) not null,
   user_firstname       varchar(30) not null,
   user_lastname        varchar(30),
   user_email           varchar(50) not null,
   user_creditcard      varchar(16),
   user_regdate         datetime not null,
   primary key (user_id)
);

alter table ACTS add constraint FK_ACTORS foreign key (actor_id)
      references ACTOR (actor_id) on delete restrict on update restrict;

alter table ACTS add constraint FK_ACTS_IN foreign key (movie_id)
      references MOVIE (movie_id) on delete restrict on update restrict;

alter table MOVIE add constraint FK_ADD foreign key (admin_id)
      references ADMIN (admin_id) on delete restrict on update restrict;

alter table MOVIE add constraint FK_DIRECT foreign key (director_id)
      references DIRECTOR (director_id) on delete restrict on update restrict;

alter table RENT add constraint FK_RENTED foreign key (user_id)
      references USERS (user_id) on delete restrict on update restrict;

alter table RENT add constraint FK_RENTS foreign key (movie_id)
      references MOVIE (movie_id) on delete restrict on update restrict;

