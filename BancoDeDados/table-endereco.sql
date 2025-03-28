CREATE TABLE if not exists endereco (
	id int primary key auto_increment,
    logradouro varchar(30) not null,
    numero int(4) not null unique,
    bairro varchar(30) not null,
    cidade varchar(30) not null,
    estado varchar(2) not null,
    país  varchar(30) not null
);

SELECT 
    *
FROM
    endereco;
    
INSERT INTO endereco (Logradouro, numero, bairro, cidade, estado, país) VALUES
('Rua São Marcos', '195', 'Gaivotas', 'São Paulo', 'SP', 'Brasil');


SELECT 
    logradouro
FROM
    endereco;

SELECT 
    logradouro
FROM
    endereco
WHERE
	logradouro like '%Rua%' ;


drop table livro;
