
SELECT 
    categorias.nome AS categoria
FROM
    emprestimos_livros
        JOIN
    emprestimos ON emprestimos_livros.id_emprestimo = emprestimos.id_emprestimo
		join
	livros on emprestimos_livros.id_livro = livros.id_livro
		join
	livros_categorias on livros.id_livro = livros_categorias.id_livro
		join 
	categorias on livros_categorias.id_categoria = categorias.id_categoria
    group by categoria
;
    