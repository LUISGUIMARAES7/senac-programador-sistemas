/*Exercicio 1*/

CREATE TABLE IF NOT EXISTS cliente (
    id INT AUTO_INCREMENT,
    nome VARCHAR(60) NOT NULL,
    idade SMALLINT NOT NULL,
    cidade VARCHAR(30),
    saldo DECIMAL(6 , 2 ),
    PRIMARY KEY (id)
);

INSERT INTO cliente 
	(nome,idade,cidade,saldo) 
values 	
	('Carlos', 45,'São Paulo', 2500.00),
	('Mariana', 32,'Rio de Janeiro', 3200.50),
    ('Pedro', 27,'Belo Horizonte', 1500.75),
    ('Fernanda', 38,'Curitiba', 4200.00);

/*1.1*/

SELECT 
    nome
FROM
    cliente
WHERE
    cidade = 'Rio de Janeiro';

/*1.2*/

SELECT 
    saldo, nome
FROM
    cliente
WHERE
    saldo > 2000
ORDER BY saldo DESC;

/*1.3*/

SELECT 
    nome, idade
FROM
    cliente
WHERE
    idade > 30;

/*Exercicio 2*/
/*2.1*/

SELECT 
    nome, idade
FROM
    cliente
WHERE
    idade BETWEEN 25 AND 40;

/*2.2*/

SELECT 
    nome
FROM
    cliente
WHERE
    nome LIKE 'F%';

/*2.3*/

SELECT 
    cidade, nome
FROM
    cliente
WHERE
    cidade NOT IN ('São Paulo' , 'Curitiba');

/*Exercicio 3*/

CREATE TABLE IF NOT EXISTS pedido (
    id INT AUTO_INCREMENT,
    cliente_id INT NOT NULL,
    valor DECIMAL(6 , 2 ) NOT NULL,
    data_pedido DATE NOT NULL,
    PRIMARY KEY (id),
    FOREIGN KEY (cliente_id)
        REFERENCES cliente (id)
);

insert into pedido (cliente_id, valor,data_pedido)
values 
	(1,500.00,'2024-03-10'),
    (2,1200.00,'2024-03-12'),
    (3,300.50,'2024-03-15'),
    (1,800.00,'2024-03-18');
    

/*3.1*/

SELECT 
    COUNT(data_pedido) AS compras
FROM
    pedido;

/*3.2*/

SELECT 
    ROUND(AVG(valor), 2) AS media_valores
FROM
    pedido
WHERE
    valor;

/*3.3*/

SELECT 
    cliente_id, SUM(valor)
FROM
    pedido
WHERE
    valor
GROUP BY cliente_id;

SELECT 
    p.cliente_id, SUM(p.valor), c.nome
FROM
    pedido p
        JOIN
    cliente c ON p.cliente_id = c.id
GROUP BY p.cliente_id;

/*Exercicio 4*/

/*4.1*/

SELECT 
    p.id, p.valor, c.nome
FROM
    pedido p
        JOIN
    cliente c ON p.cliente_id = c.id
GROUP BY id;

/*4.2*/
    
SELECT 
    c.nome, p.id AS pedido_id
FROM
    cliente c
        LEFT JOIN
    pedido p ON c.id = p.cliente_id;

/*Exercicio 5*/

/*5.1*/

SELECT 
    c.nome, p.valor, ROUND(AVG(p.valor), 2) AS media_pedidos
FROM
    cliente c
        JOIN
    pedido p ON c.id = p.cliente_id
WHERE
    valor > (SELECT 
            AVG(valor)
        FROM
            pedido);

/*5.2*/

SELECT 
    c.nome, p.valor
FROM
    cliente c
        JOIN
    pedido p ON c.id = p.cliente_id
WHERE
    valor > 1000;

/*Exercicio 6*/

/*6.1*/

INSERT INTO cliente 
	(nome,idade,cidade,saldo) 
values 	
	('Rafael', 33,'Porto Alegre', 4000.00);
    
/*6.2*/

UPDATE cliente 
SET 
    saldo = saldo * 1.10;

/*6.3*/

DELETE FROM pedido 
WHERE
    valor < 500; 