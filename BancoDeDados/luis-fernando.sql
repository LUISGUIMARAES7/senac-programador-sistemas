
CREATE TABLE IF NOT EXISTS produto (
    id INT AUTO_INCREMENT,
    nome VARCHAR(30) NOT NULL,
    categoria VARCHAR(30) NOT NULL,
    preco DECIMAL(6 , 2 ) NOT NULL,
    estoque INT NOT NULL,
    fornecedor_id INT NOT NULL,
    PRIMARY KEY (id),
    FOREIGN KEY (fornecedor_id)
        REFERENCES fornecedor (id)
);

CREATE TABLE IF NOT EXISTS fornecedor (
    id INT AUTO_INCREMENT,
    nome VARCHAR(30) NOT NULL,
    cidade VARCHAR(30) NOT NULL,
    PRIMARY KEY (id)
);

CREATE TABLE IF NOT EXISTS pedido (
    id INT AUTO_INCREMENT,
    produto_id INT NOT NULL,
    quantidade INT NOT NULL,
    data_pedido DATE NOT NULL,
    cliente_id INT NULL,
    PRIMARY KEY (id),
    FOREIGN KEY (produto_id)
        REFERENCES produto (id),
    FOREIGN KEY (cliente_id)
        REFERENCES cliente (id)
);

CREATE TABLE IF NOT EXISTS cliente (
    id INT AUTO_INCREMENT,
    nome VARCHAR(60) NOT NULL,
    cidade VARCHAR(30) NOT NULL,
    idade SMALLINT NOT NULL,
    PRIMARY KEY (id)
);


insert into produto (nome, categoria,preco,estoque,fornecedor_id)
values 
	('Celular X', 'Eletrônicos', 2500, 30,1),
	('Notebook Y', 'Eletrônicos', 4800, 15,2),
	('Mesa de Madeira', 'Móveis', 750, 10,3),
	('Cadeira Z', 'Móveis', 300, 25,3),
	('TV 50"', 'Eletrônicos', 3500, 8,1);

insert into fornecedor (nome,cidade)    
values
	('TechBrasil','São Paulo'),
	('Computech','Rio de Janeiro'),
	('Moveis&Co','Curitiba'),
	('NewTech','São Paulo');
    
insert into pedido (produto_id,quantidade, data_pedido, cliente_id)
values
	(1,2,'2024-03-10',1),
	(3,1,'2024-03-11',2),
	(2,1,'2024-03-15',3),
	(5,3,'2024-03-18',1),
	(4,4,'2024-03-20',4);

insert into cliente (nome,cidade,idade)
values 
	('João Silva','São Paulo', 35),
	('Maria Santos','Belo Horizonte', 28),
	('Carlos Lima','Rio de Janeiro', 42),
	('Fernando Rocha','Curitiba', 30),
	('Luis Fernando','São Paulo', 28);
    
-- 1.1
SELECT 
    *
FROM
    produto
WHERE
    categoria = 'Eletrônicos'
        AND preco > 3000
ORDER BY preco DESC;

-- 1.2

SELECT 
    *
FROM
    cliente
WHERE
    cidade <> 'São Paulo' AND idade > 30;

-- 1.3

SELECT 
    *
FROM
    pedido
WHERE
    data_pedido BETWEEN '2024-03-10' AND '2024-03-15'
ORDER BY data_pedido;

-- 1.4

SELECT 
    *
FROM
    produto
WHERE
    estoque < 10
ORDER BY estoque;

-- 1.5

SELECT 
    *
FROM
    fornecedor
WHERE
    cidade != 'Rio de Janeiro'
        AND nome LIKE 'T%';
        
        
/*2.1*/

SELECT 
    categoria, ROUND(AVG(preco), 2) AS preço_médio
FROM
    produto
GROUP BY categoria;

-- 2.2
 
 SELECT 
    cliente.nome, cliente_id, COUNT(cliente_id) AS total_pedidos
FROM
    pedido
        JOIN
    cliente ON pedido.cliente_id = cliente.id
GROUP BY cliente_id;

-- 2.3

select categoria, sum(estoque) as total_produtos
from produto
group by categoria;

-- 2.4

SELECT 
    id, produto_id, quantidade
FROM
    pedido
where quantidade = (select max(quantidade) from pedido);

-- 2.5

SELECT 
    COUNT(id) AS qtd_cliente, cidade
FROM
    cliente
GROUP BY cidade
ORDER BY qtd_cliente DESC;

-- 3.1

SELECT 
    p.id,
    p.nome AS 'produto',
    p.categoria,
    p.preco,
    p.estoque,
    f.nome AS 'fornecedor'
FROM
    produto p
        JOIN
    fornecedor f ON p.fornecedor_id = f.id
ORDER BY f.nome asc;
    
-- 3.2

SELECT
	p.id,
	p.data_pedido,
    c.nome AS cliente, 
    prod.nome AS produto
FROM
    pedido p
        JOIN
    cliente c ON p.cliente_id = c.id
        JOIN
    produto prod ON p.produto_id = prod.id
ORDER BY p.data_pedido;

-- 3.3

SELECT 
    p.id AS pedido_id,
    c.nome AS cliente,
    prod.nome AS produto,
    f.nome AS fornecedor
FROM
    pedido p
        JOIN
    cliente c ON p.cliente_id = c.id
        JOIN
    produto prod ON p.produto_id = prod.id
        JOIN
    fornecedor f ON prod.fornecedor_id = f.id;

-- 3.4

SELECT 
	c.nome as cliente, sum(quantidade) as comprados
FROM
    pedido p
        JOIN
    cliente c ON p.cliente_id = c.id
 group by c.nome;

-- 4.1

SELECT 
    nome, categoria, preco
FROM
    produto p
WHERE
    preco > (SELECT 
            AVG(preco)
        FROM
            produto pr
        WHERE
            p.categoria = pr.categoria)
order by p.categoria;
            
            
-- 4.2

UPDATE produto 
SET 
    preco = preco * 1.10
WHERE
    categoria = 'Eletrônicos';
    
-- 4.3

DELETE FROM pedido 
WHERE
    cliente_id in (select id from cliente where cidade = 'curitiba');
    
-- 4.4

insert into cliente (nome, cidade, idade)
values 	
	('Ricardo Lopes', 'Porto Alegre', 38);

-- 4.5

insert into pedido (produto_id,quantidade, data_pedido, cliente_id)
values(
    (select id from produto where nome = 'Notebook Y'),
    2,
    '2024-03-25',
    (select id from cliente where nome = 'João Silva' and cidade = 'São Paulo')
    );

-- 4.6

SELECT DISTINCT
    c.nome AS cliente, prod.categoria
FROM
    pedido p
        JOIN
    cliente c ON p.cliente_id = c.id
        JOIN
    produto prod ON p.produto_id = prod.id
WHERE
    categoria = 'Móveis';
