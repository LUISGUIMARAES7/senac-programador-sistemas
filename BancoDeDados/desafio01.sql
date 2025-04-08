-- 1
SELECT 
    categorias.nome AS categoria,
    COUNT(emprestimos.id_emprestimo) AS qtd_total
FROM
    emprestimos_livros
        JOIN
    emprestimos ON emprestimos_livros.id_emprestimo = emprestimos.id_emprestimo
        JOIN
    livros ON emprestimos_livros.id_livro = livros.id_livro
        JOIN
    livros_categorias ON livros.id_livro = livros_categorias.id_livro
        JOIN
    categorias ON livros_categorias.id_categoria = categorias.id_categoria
GROUP BY categoria
ORDER BY emprestimos.id_emprestimo;

-- 2

SELECT 
    autores.nome AS autor,
    COUNT(avaliacoes.id_avaliacao) AS avaliação
FROM
    avaliacoes
        JOIN
    clientes ON avaliacoes.id_cliente = clientes.id_cliente
        JOIN
    livros ON avaliacoes.id_livro = livros.id_livro
        JOIN
    autores ON livros.id_autor = autores.id_autor
GROUP BY autores.nome
ORDER BY avaliacoes.id_avaliacao
LIMIT 3;
    
-- 3
    
SELECT 
    clientes.nome,
    CASE
        WHEN paga = TRUE THEN multas.valor
    END AS multa_paga
FROM
    multas
        JOIN
    emprestimos ON multas.id_emprestimo = emprestimos.id_emprestimo
        JOIN
    clientes ON emprestimos.id_cliente = clientes.id_cliente
WHERE
    paga = TRUE
ORDER BY multas.valor DESC;
	
-- 4


