create table if not exists empregado (
	id int auto_increment,
    nome varchar(60) not null,
    idade smallint not null,
    departamento varchar(30) not null,
    salario int not null,
    primary key (id)
);

insert into empregado (nome, idade, departamento, salario) 
values 
('joão',30,'RH','50000'),
('Sarah',28,'TI', '60000'),
('Miguel',35,'Vendas', '55000'),
('Ana',27,'TI', '62000');


/*Exercício 1*/
/*1*/
select nome, departamento
from empregado 
where departamento = 'TI';

/*2*/
select nome, salario 
from empregado 
where salario > 55000;

/*3*/
select nome, idade
from empregado
order by idade desc;

/*Exercício 2*/
/*1*/
select nome, idade
from empregado
where idade between '28' and '35';

/*2*/
select nome
from empregado
where nome like 'M%';

/*3*/
select nome, departamento
from empregado
where departamento not like 'RH';

/*Exercício 3*/
/*1*/
select departamento, count(departamento)
from empregado
group by departamento;

/*2*/
select avg(salario) as media_salarial_TI 
from empregado
where departamento = 'TI';

/*3*/
select sum(salario) as salario_dep_vendas 
from empregado 
where departamento = 'vendas';

/*Exercício 4*/

drop table empregado;

create table if not exists departamento (
	id int auto_increment,
    nome varchar(30) not null,
    primary key (id)
);

insert into departamento (nome)
values 
('RH'),
('TI'),
('VENDAS');

CREATE TABLE IF NOT EXISTS empregado (
	id int auto_increment,
    nome varchar(60) not null,
    salario int not null,
    id_departamento int not null,
    primary key (id),
    foreign key (id_departamento)
		references departamento (id)
);
        
insert into empregado (nome, id_departamento,salario)
values 
	('João', 1, 50000),
	('Sarah', 2, 60000),
	('Miguel', 3, 55000),
	('Ana', 2, 62000);

/*1*/

select 
	empregado.id,
	empregado.nome as empregados,
	departamento.nome as departamentos
from 
	empregado
JOIN
	departamento on empregado.id_departamento = departamento.id;


/*2*/

insert into departamento (nome)
values ('ASSISTENCIA_TECNICA');

SELECT 
	departamento.id,
    departamento.nome as departamentos,
    empregado.nome as empregados
FROM 
	departamento
LEFT JOIN 
	empregado ON departamento.id = empregado.id_departamento;

    
/*Exercício 5*/

/*1*/

select nome, salario
from empregado
where salario > (select avg(salario) from empregado );

/*2*/

	


	

        
        