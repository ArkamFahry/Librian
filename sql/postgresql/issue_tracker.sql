create extension if not exists "uuid-ossp";

-- created_at function
create or replace function created_at() returns timestamp
    language plpgsql
as
$$
declare
    _new timestamp;
begin
    _new = now();
    return _new;
end;
$$;


-- updated_at function
create or replace function updated_at() returns trigger
    language plpgsql
as
$$
declare
    _new record;
begin
    _new := new;
    _new.updated_at = now();

    return _new;

end ;
$$;

-- type entities

create table file_types
(
    id         varchar default uuid_generate_v4(),
    extension       text   not null,
    mime_type       text not null,
    created_at timestamp not null default created_at(),
    updated_at timestamp,
    unique (extension),
    primary key (id)
);

create trigger file_update_at
    before update
    on file_types
    for each row
execute procedure updated_at();

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

-- user entities

create table users
(
    id                       varchar,
    email                    text   not null,
    email_verified_at        timestamp,
    phone_number             text,
    phone_number_verified_at timestamp,
    signup_methods           text   not null,
    nickname                 text,
    given_name               text,
    middle_name              text,
    family_name              text,
    birth_date               text,
    gender                   text,
    picture                  text,
    revoked_timeStamp        timestamp,
    created_at               timestamp not null default created_at(),
    updated_at               timestamp,
    unique (email),
    unique (phone_number),
    primary key (id)
);

create trigger users_update_at
    before update
    on users
    for each row
execute procedure updated_at();

create table user_roles
(
    id         varchar default uuid_generate_v4(),
    user_id    varchar,
    role       varchar,
    created_at timestamp not null default created_at(),
    updated_at timestamp,
    unique (user_id, Role),
    foreign key (user_id) references users (id) on delete cascade,
    primary key (id)
);

create trigger user_roles_update_at
    before update
    on user_roles
    for each row
execute procedure updated_at();

-- project entities

create table projects
(
    id           varchar default uuid_generate_v4(),
    creator_id   varchar not null,
    name         varchar not null,
    description  text,
    active       bool    not null default true,
    dead_line    timestamp,
    completed    bool    not null default false,
    completed_at timestamp,
    created_at   timestamp  not null default created_at(),
    updated_at   timestamp,
    unique (name),
    foreign key (creator_id) references users (id) on delete no action,
    primary key (id)
);

create trigger projects_update_at
    before update
    on projects
    for each row
execute procedure updated_at();

create table project_attachments
(
    id           varchar default uuid_generate_v4(),
    project_id varchar not null,
    extension         varchar not null,
    name         text not null,
    reference    text not null,
    created_at   timestamp  not null default created_at(),
    updated_at   timestamp,
    foreign key (project_id) references projects (id) on delete cascade,
    foreign key (extension) references file_types (extension),
    primary key (id)
);

create trigger project_attachment_update_at
    before update
    on project_attachments
    for each row
execute procedure updated_at();

create table project_tags
(
    id          varchar default uuid_generate_v4(),
    project_id  varchar not null,
    name        varchar not null,
    description text,
    created_at  timestamp  not null default created_at(),
    updated_at  timestamp,
    unique (project_id, name),
    primary key (id)
);

create trigger project_tags_update_at
    before update
    on project_tags
    for each row
execute procedure updated_at();

create table project_users
(
    id         varchar default uuid_generate_v4(),
    project_id varchar not null,
    user_id    varchar not null,
    reader     bool    not null default false,
    writer     bool    not null default false,
    controller bool    not null default false,
    created_at timestamp  not null default created_at(),
    updated_at timestamp,
    unique (project_id, user_id),
    foreign key (project_id) references projects (id) on delete cascade,
    foreign key (user_id) references users (id) on delete cascade,
    primary key (id)
);

create trigger project_users_update_at
    before update
    on project_users
    for each row
execute procedure updated_at();

create table project_issue_tags
(
    id          varchar default uuid_generate_v4(),
    project_id  varchar not null,
    name        varchar not null,
    description text,
    created_at  timestamp  not null default created_at(),
    updated_at  timestamp,
    unique (project_id, name),
    foreign key (project_id) references projects (id) on delete cascade,
    primary key (id)
);

create trigger project_issue_tags_update_at
    before update
    on project_issue_tags
    for each row
execute procedure updated_at();

-- issue entities

create table issues
(
    id          varchar default uuid_generate_v4(),
    project_id  varchar not null,
    creator_id  varchar not null,
    name        varchar not null,
    description text,
    public      bool    not null default true,
    fixed       bool    not null default false,
    fixed_at    timestamp,
    created_at  timestamp  not null default created_at(),
    updated_at  timestamp,
    unique (project_id, name),
    foreign key (project_id) references projects (id) on delete cascade,
    foreign key (creator_id) references users (id) on delete no action,
    primary key (id)
);

create trigger issues_update_at
    before update
    on issues
    for each row
execute procedure updated_at();

create table issue_attachments
(
    id           varchar default uuid_generate_v4(),
    issue_id varchar not null,
    type         varchar not null,
    name         text not null,
    reference    text not null,
    created_at   timestamp  not null default created_at(),
    updated_at   timestamp,
    foreign key (issue_id) references issues (id) on delete cascade,
    foreign key (type) references file_types (extension),
    primary key (id)
);

create trigger issue_attachment_update_at
    before update
    on issue_attachments
    for each row
execute procedure updated_at();

create table issue_tags
(
    id          varchar default uuid_generate_v4(),
    issue_id    varchar not null,
    name        varchar not null,
    description text,
    created_at  timestamp  not null default created_at(),
    updated_at  timestamp,
    unique (issue_id, name),
    foreign key (issue_id) references issues (id) on delete cascade,
    primary key (id)
);

create trigger issue_tags_update_at
    before update
    on issue_tags
    for each row
execute procedure updated_at();

create table issue_users
(
    id         varchar default uuid_generate_v4(),
    issue_id   varchar not null,
    user_id    varchar not null,
    reader     bool    not null default false,
    writer     bool    not null default false,
    controller bool    not null default false,
    created_at timestamp  not null default created_at(),
    updated_at timestamp,
    unique (issue_id, user_id),
    foreign key (issue_id) references issues (id) on delete cascade,
    foreign key (user_id) references users (id) on delete cascade,
    primary key (id)
);

create trigger issue_users_update_at
    before update
    on issue_users
    for each row
execute procedure updated_at();

create table issue_fixes
(
    id          varchar default uuid_generate_v4(),
    issue_id    varchar not null,
    user_id     varchar not null,
    name        varchar not null,
    description text,
    accepted    bool    not null default false,
    accepted_at timestamp,
    created_at  timestamp  not null default created_at(),
    updated_at  timestamp,
    foreign key (issue_id) references issues (id) on delete cascade,
    foreign key (user_id) references users (id) on delete no action,
    primary key (id)
);

create trigger issue_fixes_update_at
    before update
    on issue_fixes
    for each row
execute procedure updated_at();

create table issue_fix_attachments
(
    id           varchar default uuid_generate_v4(),
    issue_fix_id varchar not null,
    type         varchar not null,
    name         text not null,
    reference    text not null,
    created_at   timestamp  not null default created_at(),
    updated_at   timestamp,
    foreign key (issue_fix_id) references issue_fixes (id) on delete cascade,
    foreign key (type) references file_types (extension),
    primary key (id)
);

create trigger issue_fix_attachment_update_at
    before update
    on issue_fix_attachments
    for each row
execute procedure updated_at();