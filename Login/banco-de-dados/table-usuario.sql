CREATE TABLE IF NOT EXISTS usuario (
    id INT AUTO_INCREMENT,
    email VARCHAR(50) NOT NULL UNIQUE,
    senha VARCHAR(20) NOT NULL,
    primary key (id)
);

insert into usuario (email, senha) values 
	('neymar@email.com','Ney123@'),
    ('rony@email.com','Rustico123@'),
    ('cr7@email.com','Siii123@');
    
select *
from usuario
where email = 'neymar@email.com';