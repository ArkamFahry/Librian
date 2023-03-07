create database trackx;
-- type file_types

create table file_types
(
    id         varchar(255) default newid(),
    extension  varchar(255) not null,
    mime_type  varchar(max) not null,
    created_at datetime2       not null default getdate(),
    updated_at datetime2,
    unique (extension),
    primary key (id)
);
go;

create trigger file_types_updated_at on file_types
    for update
as
    update ft set updated_at = getdate()
              from file_types as ft join inserted as i on ft.id = i.id;
go;

insert into file_types (extension, mime_type)
values ('.docx', 'application/vnd.openxmlformats-officedocument.wordprocessingml.document'),
       ('.doc', 'application/msword'),
       ('.csv', 'text/csv'),
       ('.epub', 'application/epub+zip'),
       ('.gz', 'application/gzip'),
       ('.htm,.html', 'text/html'),
       ('.ics', 'text/calendar'),
       ('.jpeg,.jpg', 'image/jpeg'),
       ('.js', 'text/javascript'),
       ('.json', 'application/json'),
       ('.mp3', 'audio/mpeg'),
       ('.mp4', 'video/mp4'),
       ('.png', 'image/png'),
       ('.pdf', 'application/pdf'),
       ('.ppt', 'application/vnd.ms-powerpoint'),
       ('.pptx', 'application/vnd.openxmlformats-officedocument.presentationml.presentation'),
       ('.rar', 'application/vnd.rar'),
       ('.svg', 'image/svg+xml'),
       ('.xml', 'application/xml'),
       ('.zip', 'application/zip'),
       ('.7z', 'application/x-7z-compressed'),
       ('folder', 'application/folder');
go;

-- user entities

create table users
(
    id                       varchar(255),
    email                    varchar(255) not null,
    email_verified_at        datetime2,
    phone_number             varchar(255),
    phone_number_verified_at datetime2,
    signup_methods           varchar(max) not null,
    nickname                 varchar(max),
    given_name               varchar(max),
    middle_name              varchar(max),
    family_name              varchar(max),
    birth_date               varchar(max),
    gender                   varchar(max),
    picture                  varchar(max),
    revoked_timeStamp        datetime2,
    created_at               datetime2       not null default getdate(),
    updated_at               datetime2,
    unique (email),
    primary key (id)
);
go;

create unique nonclustered index users_phone_number_unique
on users(phone_number)
where phone_number is not null;
go;

create trigger users_updated_at on users
    for update
as
    update u set updated_at = getdate()
              from users as u join inserted as i on u.id = i.id;
go;

create table user_roles
(
    id         varchar(255) default newid(),
    user_id    varchar(255),
    role       varchar,
    created_at datetime2 not null default getdate(),
    updated_at datetime2,
    unique (user_id, Role),
    foreign key (user_id) references users (id) on delete cascade,
    primary key (id)
);
go;

create trigger user_roles_updated_at on user_roles
    for update
as
    update ur set updated_at = getdate()
              from user_roles as ur join inserted as i on ur.id = i.id;
go;


-- project entities

create table projects
(
    id           varchar(255) default newid(),
    creator_id   varchar(255) not null,
    name         varchar(255) not null,
    description  varchar(max),
    active       binary    not null,
    dead_line    datetime2,
    completed    binary    not null,
    completed_at datetime2,
    created_at   datetime2  not null default getdate(),
    updated_at   datetime2,
    unique (name),
    foreign key (creator_id) references users (id) on delete no action,
    primary key (id)
);
go;

create trigger projects_updated_at on projects
    for update
as
    update p set updated_at = getdate()
              from projects as p join inserted as i on p.id = i.id;
go;


create table project_attachments
(
    id         varchar(255) default newid(),
    project_id varchar(255)      not null,
    extension  varchar(255)     not null,
    name       varchar(max) not null,
    reference  varchar(max) not null,
    created_at datetime2       not null default getdate(),
    updated_at datetime2,
    foreign key (project_id) references projects (id) on delete cascade,
    foreign key (extension) references file_types (extension),
    primary key (id)
);
go;

create trigger project_attachments_updated_at on project_attachments
    for update
as
    update pa set updated_at = getdate()
              from project_attachments as pa join inserted as i on pa.id = i.id;
go;

create table project_tags
(
    id          varchar(255) default newid(),
    project_id  varchar(255) not null,
    name        varchar(255) not null,
    description varchar(max),
    created_at  datetime2  not null default getdate(),
    updated_at  datetime2,
    unique (project_id, name),
    primary key (id)
);
go;

create trigger project_tags_updated_at on project_tags
    for update
as
    update pg set updated_at = getdate()
              from project_tags as pg join inserted as i on pg.id = i.id;
go;

create table project_users
(
    id         varchar(255) default newid(),
    project_id varchar(255) not null,
    user_id    varchar(255) not null,
    reader     binary    not null,
    writer     binary    not null,
    controller binary    not null,
    created_at datetime2  not null default getdate(),
    updated_at datetime2,
    unique (project_id, user_id),
    foreign key (project_id) references projects (id) on delete cascade,
    foreign key (user_id) references users (id) on delete cascade,
    primary key (id)
);
go;

create trigger project_users_updated_at on project_users
    for update
as
    update pu set updated_at = getdate()
              from project_users as pu join inserted as i on pu.id = i.id;
go;

create table project_issue_tags
(
    id          varchar(255) default newid(),
    project_id  varchar(255) not null,
    name        varchar(255) not null,
    description varchar(max),
    created_at  datetime2  not null default getdate(),
    updated_at  datetime2,
    unique (project_id, name),
    foreign key (project_id) references projects (id) on delete cascade,
    primary key (id)
);
go;

create trigger project_issue_tags_updated_at on project_issue_tags
    for update
as
    update pit set updated_at = getdate()
              from project_issue_tags as pit join inserted as i on pit.id = i.id;
go;

-- issue entities

create table issues
(
    id          varchar(255) default newid(),
    project_id  varchar(255) not null,
    creator_id  varchar(255) not null,
    name        varchar(255) not null,
    description varchar(max),
    [public]      binary    not null,
    fixed       binary    not null,
    fixed_at    datetime2,
    created_at  datetime2  not null default getdate(),
    updated_at  datetime2,
    unique (project_id, name),
    foreign key (project_id) references projects (id) on delete cascade,
    foreign key (creator_id) references users (id) on delete no action,
    primary key (id)
);
go;

create trigger issues_updated_at on issues
    for update
as
    update s set updated_at = getdate()
              from issues as s join inserted as i on s.id = i.id;
go;


create table issue_attachments
(
    id         varchar(255) default newid(),
    issue_id   varchar(255)      not null,
    type       varchar(255)     not null,
    name       varchar(max) not null,
    reference  varchar(max) not null,
    created_at datetime2       not null default getdate(),
    updated_at datetime2,
    foreign key (issue_id) references issues (id) on delete cascade,
    foreign key (type) references file_types (extension),
    primary key (id)
);
go;

create trigger issue_attachment_updated_at on issue_attachments
    for update
as
    update sa set updated_at = getdate()
              from issue_attachments as sa join inserted as i on sa.id = i.id;
go;


create table issue_tags
(
    id          varchar(255) default newid(),
    issue_id    varchar(255) not null,
    name        varchar(255) not null,
    description varchar(max),
    created_at  datetime2  not null default getdate(),
    updated_at  datetime2,
    unique (issue_id, name),
    foreign key (issue_id) references issues (id) on delete cascade,
    primary key (id)
);
go;

create trigger issue_tags_updated_at on issue_tags
    for update
as
    update st set updated_at = getdate()
              from issue_tags as st join inserted as i on st.id = i.id;
go;

create table issue_users
(
    id         varchar(255) default newid(),
    issue_id   varchar(255) not null,
    user_id    varchar(255) not null,
    reader     binary    not null,
    writer     binary    not null,
    controller binary    not null,
    created_at datetime2  not null default getdate(),
    updated_at datetime2,
    unique (issue_id, user_id),
    foreign key (issue_id) references issues (id) on delete cascade,
    foreign key (user_id) references users (id) on delete cascade,
    primary key (id)
);
go;

create trigger issue_users_updated_at on issue_users
    for update
as
    update su set updated_at = getdate()
              from issue_users as su join inserted as i on su.id = i.id;
go;

create table issue_fixes
(
    id          varchar(255) default newid(),
    issue_id    varchar(255) not null,
    user_id     varchar(255) not null,
    name        varchar(255) not null,
    description varchar(max),
    accepted    binary    not null,
    accepted_at datetime2,
    created_at  datetime2  not null default getdate(),
    updated_at  datetime2,
    foreign key (issue_id) references issues (id) on delete cascade,
    foreign key (user_id) references users (id) on delete no action,
    primary key (id)
);
go;

create trigger issue_fixes_updated_at on issue_fixes
    for update
as
    update sf set updated_at = getdate()
              from issue_fixes as sf join inserted as i on sf.id = i.id;
go;

create table issue_fix_attachments
(
    id           varchar(255) default newid(),
    issue_fix_id varchar(255)      not null,
    type         varchar(255)      not null,
    name         varchar(max) not null,
    reference    varchar(max) not null,
    created_at   datetime2       not null default getdate(),
    updated_at   datetime2,
    foreign key (issue_fix_id) references issue_fixes (id) on delete cascade,
    foreign key (type) references file_types (extension),
    primary key (id)
);
go;

create trigger issue_fix_attachments_updated_at on issue_fix_attachments
    for update
as
    update sfa set updated_at = getdate()
              from issue_fix_attachments as sfa join inserted as i on sfa.id = i.id;
go;
