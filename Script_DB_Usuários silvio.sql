Create database db_usuarios;
use db_usuarios;

create table tb_usuarios (
    id INT auto_increment primary key,
    nome VARCHAR(45),
    email VARCHAR(45)
);


insert into tb_usuarios (nome, email) values ('Fernando Vieira', 'fernando@gmail.com','Brasil','13981223344');
insert into tb_usuarios (nome, email) values ('Fernanda Vieira', 'fernanda@gmail.com','Brasil','13981223344');

insert into tb_usuarios (nome, email) values ('Fernanda Juqueira', 'fernandaj@gmail.com');


alter table tb_usuarios
add nm_nacionalidade varchar(45);

alter table tb_usuarios
add nr_telefone char(11);