-- Create database

create database Librian;
go;

-- Use database

use Librian;
go;

-- Role entities

create table Roles
(
    Id        varchar(255),
    CreatedAt datetime2 not null default getdate(),
    UpdatedAt datetime2,
    primary key (Id)
);
go;

insert into Roles(Id)
values ('user'),
       ('admin');
go;

-- User entities

create table Users
(
    Id              varchar(255)                                default newId(),
    Email           varchar(255) not null,
    PasswordHash    varchar(255) not null,
    Name            varchar(255) not null,
    Picture         varchar(max),
    Role            varchar(255) not null references Roles (Id) default 'user',
    AccessRevoked   binary,
    AccessRevokedAt datetime2,
    CreatedAt       datetime2    not null                       default getdate(),
    UpdatedAt       datetime2,
    unique (Email),
    primary key (Id)
);
go;

-- Book entities

create table Books
(
    Id            varchar(255)          default newId(),
    Name          varchar(max) not null,
    Description   varchar(max),
    PublishedDate datetime2,
    Picture       varchar(max),
    Reference     varchar(max),
    CreatedAt     datetime2    not null default getdate(),
    UpdatedAt     datetime2,
    primary key (Id)
);
go;

-- Category entities

create table Categories
(
    Id        varchar(255)       default newId(),
    Name      varchar(255),
    CreatedAt datetime2 not null default getdate(),
    UpdatedAt datetime2,
    unique (Name),
    primary key (Id)
);
go;

-- Book category entities

create table BookCategories
(
    Id         varchar(255)          default newId(),
    BookId     varchar(255) not null references Books (Id),
    CategoryId varchar(255) not null references Categories (Id),
    CreatedAt  datetime2    not null default getdate(),
    UpdatedAt  datetime2,
    unique (BookId, CategoryId),
    primary key (Id)
);
go;

-- Author entities

create table Authors
(
    Id          varchar(255)          default newId(),
    Name        varchar(max) not null,
    Description varchar(max),
    CreatedAt   datetime2    not null default getdate(),
    UpdatedAt   datetime2,
    primary key (Id)
);
go;

-- Book Author entities

create table BookAuthors
(
    Id        varchar(255)          default newId(),
    BookId    varchar(255) not null references Books (Id),
    AuthorId  varchar(255) not null references Authors (Id),
    CreatedAt datetime2    not null default getdate(),
    UpdatedAt datetime2,
    unique (BookId, AuthorId),
    primary key (Id)
);
go;

-- Book Borrower entities

create table BookBorrowers
(
    Id         varchar(255)          default newId(),
    UserId     varchar(255) not null references Users (Id),
    BookId     varchar(255) not null references Books (Id),
    DueDate    datetime2    not null,
    ReturnedAt datetime2,
    CreatedAt  datetime2    not null default getdate(),
    UpdatedAt  datetime2,
    primary key (Id)
);
go;