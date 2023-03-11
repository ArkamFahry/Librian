-- user entities

create table users
(
    id                varchar(255)            default newid(),
    email             varchar(255)   not null,
    password_hash          varbinary(255) not null,
    user_name         varchar(255)   not null,
    picture           varchar(max),
    access_revoked    binary,
    access_revoked_at datetime2,
    created_at        datetime2      not null default getdate(),
    updated_at        datetime2,
    unique (email),
    unique (user_name),
    primary key (id)
);
go;
create trigger users_updated_at
    on users
    for update
    as
    update u
    set updated_at = getdate()
    from users as u
             join inserted as i on u.id = i.id;
go;

-- role entities

create table roles
(
    id         varchar(255) default newid(),
    created_at datetime2 not null default getdate(),
    updated_at datetime2,
    primary key (id)
);
go;
create trigger roles_updated_at
    on roles
    for update
    as
    update r
    set updated_at = getdate()
    from roles as r
             join inserted as i on r.id = i.id;
go;
insert into roles(id)
values ('user'),
       ('admin');
go;

-- user role entities
create table user_roles
(
    id         varchar(255)          default newid(),
    user_id    varchar(255) not null references users (id),
    role_id    varchar(255) not null references roles (id),
    created_at datetime2    not null default getdate(),
    updated_at datetime2,
);
go;
create trigger user_roles_updated_at
    on user_roles
    for update
    as
    update ur
    set updated_at = getdate()
    from user_roles as ur
             join inserted as i on ur.id = i.id;
go;

-- book entities

create table books
(
    id             varchar(255)          default newid(),
    name           varchar(max) not null,
    description    varchar(max),
    published_date datetime2,
    picture        varchar(max),
    reference      varchar(max),
    created_at     datetime2    not null default getdate(),
    updated_at     datetime2,
    primary key (id)
);
go;
create trigger books_updated_at
    on books
    for update
    as
    update b
    set updated_at = getdate()
    from books as b
             join inserted as i on b.id = i.id;
go;

-- category entities

create table categories
(
    id         varchar(255)       default newid(),
    name       varchar(max),
    created_at datetime2 not null default getdate(),
    updated_at datetime2,
    primary key (id)
);
go;
create trigger categories_updated_at
    on categories
    for update
    as
    update c
    set updated_at = getdate()
    from categories as c
             join inserted as i on c.id = i.id;
go;

-- book category entities

create table book_categories
(
    id          varchar(255)          default newid(),
    book_id     varchar(255) not null references books (id),
    category_id varchar(255) not null references categories (id),
    created_at  datetime2    not null default getdate(),
    updated_at  datetime2,
    unique (book_id, category_id),
    primary key (id)
);
go;
create trigger book_categories_updated_at
    on book_categories
    for update
    as
    update bc
    set updated_at = getdate()
    from book_categories as bc
             join inserted as i on bc.id = i.id;
go;

-- author entities

create table authors
(
    id          varchar(255)          default newid(),
    name        varchar(max) not null,
    description varchar(max),
    created_at  datetime2    not null default getdate(),
    updated_at  datetime2,
    primary key (id)
);
go;
create trigger authors_updated_at
    on authors
    for update
    as
    update a
    set updated_at = getdate()
    from authors as a
             join inserted as i on a.id = i.id;
go;

-- book author entities

create table book_authors
(
    id         varchar(255)          default newid(),
    book_id    varchar(255) not null references books (id),
    author_id  varchar(255) not null references authors (id),
    created_at datetime2    not null default getdate(),
    updated_at datetime2,
    unique (book_id, author_id),
    primary key (id)
);
go;
create trigger book_authors_updated_at
    on book_authors
    for update
    as
    update ba
    set updated_at = getdate()
    from book_authors as ba
             join inserted as i on ba.id = i.id;
go;

-- book borrower entities

create table book_borrowers
(
    id          varchar(255)          default newid(),
    user_id     varchar(255) not null references users (id),
    book_id     varchar(255) not null references users (id),
    due_date    datetime2    not null,
    returned_at datetime2,
    created_at  datetime2    not null default getdate(),
    updated_at  datetime2,
    primary key (id)
);
go;
create trigger book_borrowers_updated_at
    on book_borrowers
    for update
    as
    update bb
    set updated_at = getdate()
    from book_borrowers as bb
             join inserted as i on bb.id = i.id;
go;