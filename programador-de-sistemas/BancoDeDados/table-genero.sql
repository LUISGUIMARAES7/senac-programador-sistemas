CREATE TABLE IF NOT EXISTS genero (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100)
);

SELECT 
    *
FROM
    genero;

INSERT INTO genero (nome) 
VALUES 
('tecnologia'),
('documentário cinematográfico'),
('terror'),
('drama'),
('entrevista'),
('aventura'),
('fantasia'),
('ação'),
('ficção científica'),
('romance distópico');

    
 
    
drop table genero;