CREATE TABLE IF NOT EXISTS empregado (
    id INT AUTO_INCREMENT,
    nome VARCHAR(60) NOT NULL,
    idade SMALLINT NOT NULL,
    departamento VARCHAR(30) NOT NULL,
    salario INT NOT NULL,
    PRIMARY KEY (id)
);

insert into empregado (nome, idade, departamento, salario) 
values 
('joão',30,'RH','50000'),
('Sarah',28,'TI', '60000'),
('Miguel',35,'Vendas', '55000'),
('Ana',27,'TI', '62000');


/*Exercício 1*/
/*1.1*/
SELECT 
    nome, departamento
FROM
    empregado
WHERE
    departamento = 'TI';

/*1.2*/
SELECT 
    nome, salario
FROM
    empregado
WHERE
    salario > 55000;

/*1.3*/
SELECT 
    *
FROM
    empregado
ORDER BY idade DESC;

/*Exercício 2*/

/*2.1*/
SELECT 
    nome, idade
FROM
    empregado
WHERE
    idade BETWEEN 28 AND 35;

/*2.2*/
SELECT 
    nome
FROM
    empregado
WHERE
    nome LIKE 'M%';

/*2.3*/
SELECT 
    *
FROM
    empregado
WHERE
    departamento NOT LIKE 'RH';

/*Exercício 3*/
/*3.1*/

SELECT 
    departamento, COUNT(id)
FROM
    empregado
GROUP BY departamento;

/*3.2*/

SELECT 
    AVG(salario) AS media_salarial_TI
FROM
    empregado
WHERE
    departamento = 'TI';

/*3.3*/

SELECT 
    SUM(salario) AS salario_dep_vendas
FROM
    empregado
WHERE
    departamento = 'vendas';

/*Exercício 4*/

drop table empregado;

CREATE TABLE IF NOT EXISTS departamento (
    id INT AUTO_INCREMENT,
    nome VARCHAR(30) NOT NULL,
    PRIMARY KEY (id)
);

insert into departamento (nome)
values 
('RH'),('TI'),('VENDAS');

CREATE TABLE IF NOT EXISTS empregado (
	id int auto_increment,
    nome varchar(60) not null,
    idade smallint not null,
    salario int not null,
    id_departamento int not null,
    primary key (id),
    foreign key (id_departamento)
		references departamento (id)
);
        
insert into empregado (nome,idade, id_departamento,salario)
values 
	('João',30, 1, 50000),
	('Sarah',28, 2, 60000),
	('Miguel',35, 3, 55000),
	('Ana',27, 2, 62000),
    ('Luis',28, 3, 70000),
    ('Marcos',40,2,55000);

/*4.1*/

SELECT 
    e.nome AS Empregado, d.nome AS Departamento
FROM
    empregado e
        INNER JOIN
    departamento d ON e.id_departamento = d.id;

/*4.2*/

insert into departamento (nome)
values ('ASSISTENCIA_TECNICA');

SELECT 
    departamento.nome AS departamentos,
    empregado.nome AS empregados
FROM
    departamento
        LEFT JOIN
    empregado ON departamento.id = empregado.id_departamento;

    
/*Exercício 5*/

/*5.1*/

SELECT 
    *
FROM
    empregado
WHERE
    salario > (SELECT 
            AVG(salario)
        FROM
            empregado);

/*5.2*/

SELECT 
     e.nome as Empregado,
     d.nome as Departamento
FROM
    empregado e
		inner join
	departamento d on e.id_departamento = d.id
WHERE
    id_departamento = (SELECT 
            e.id_departamento
        FROM
            empregado e
        WHERE
            nome = 'Sarah');

/*Exercício 6*/

/*6.1*/
	
insert into empregado (nome,idade, id_departamento,salario)
values ('Tomás',39,3,58000);

SELECT 
    d.nome, count(e.id) as total
FROM
    empregado e
        JOIN
    departamento d ON e.id_departamento = d.id
GROUP BY id_departamento;

/*6.2*/

UPDATE empregado 
SET 
    salario = salario * 1.05
WHERE
    id_departamento = 2;

/*6.3*/ 

DELETE FROM empregado 
WHERE
    idade > 40;

        
