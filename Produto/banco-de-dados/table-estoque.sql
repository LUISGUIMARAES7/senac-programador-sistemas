create table estoque (
	id int primary key not null,
    quantidade int not null,
    data_ datetime not null,
    id_produto int not null,
		foreign key (id_produto) references produto (id)
);