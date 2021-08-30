create database sospet;

use sospet;

create table tb_usuario (
	id_usuario INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
	primeiro_nome VARCHAR(255),
    segundo_nome VARCHAR(255),
    senha VARCHAR(255),
    telefone VARCHAR(255),
    data_nascimento date,
    email VARCHAR(255),
    cpf VARCHAR(255)
);

CREATE Table tb_endereco (
    id_endereco INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
    cep VARCHAR(255),
    estado VARCHAR(255),
    cidade VARCHAR(255),
    bairro VARCHAR(255),
    rua VARCHAR(255),
    numero VARCHAR(255),
    id_usuario INT,
    CONSTRAINT fk_usuario FOREIGN KEY (id_usuario) REFERENCES tb_usuario (id_usuario)
);

ALTER TABLE tb_endereco MODIFY numero INT;
