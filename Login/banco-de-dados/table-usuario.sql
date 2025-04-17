CREATE TABLE IF NOT EXISTS usuario (
    id INT AUTO_INCREMENT,
    email VARCHAR(50) NOT NULL UNIQUE,
    senha VARCHAR(20) NOT NULL,
    primary key (id)
);

insert into usuario (email, senha) values 
	('ney@email.com','Bruna123@'),
    ('cr7@email.com','Receba123@'),
    ('rony@email.com','Rustico123@');
    
    
select *
from usuario;
