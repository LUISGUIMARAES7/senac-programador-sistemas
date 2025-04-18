using MySql.Data.MySqlClient;
using Produto.banco_de_dados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Produto.dominio;
using Mysqlx.Crud;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;
using Google.Protobuf.WellKnownTypes;

namespace Produto.repositorio
{
    internal class ProdutoRepositorio
    {
        private readonly Estoque estoque = new();

        public void CriarProduto(string nome, int quantidade)
        {
            
            using (var con = Database.GetConnection())
            {
                con.Open();
                string query = "INSERT INTO produto (nome) VALUES (@nome);";


                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.ExecuteNonQuery();
                }
            }

            int Id = 0;

            using (var con = Database.GetConnection())
            {
                con.Open();
                string query = "SELECT id FROM produto WHERE nome = @nome;";

                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@nome", nome);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Id = reader.GetInt32("id");
                        }
                    }
                }
            }

            using (var conn = Database.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO estoque (quantidade, id_produto) VALUES (@quantidade, @id);";


                using (var cmd = new MySqlCommand(query, conn))
                {

                    cmd.Parameters.AddWithValue("@id", Id);
                    cmd.Parameters.AddWithValue("@quantidade", quantidade);
                    cmd.ExecuteNonQuery();
                }
            }

        }

        //Remover produto
        public void RemoverProduto(int id)
        {
            using (var con = Database.GetConnection())
            {
                con.Open();
                string query = "DELETE FROM produto WHERE id = @id;";

                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        //Listar todos produtos
        public Produto_ ListarProdutos()
        {
            List<Produto_> produtos = [];

            using (var conn = Database.GetConnection())
            {
                conn.Open();
                string query = $"SELECT * FROM produto";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            produtos.Add(new Produto_()
                            {
                                Id = reader.GetInt32("id"),
                                Nome = reader.GetString("nome"),
                                Data = reader.GetDateTime("data_")
                            });
                        }
                    }
                }
            }

            return new Produto_();
        }
    }
}
