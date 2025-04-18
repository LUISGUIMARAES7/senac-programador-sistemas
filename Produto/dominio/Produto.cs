using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Produto.repositorio;

namespace Produto.dominio
{
    internal class Produto_
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime Data { get; set; }

        private readonly ProdutoRepositorio repositorio = new();

        public bool CriarProduto(int quantidade)
        {
            if (!ValidarProduto())
            {
                return false;
            }

            repositorio.CriarProduto(this.Nome, quantidade);
            return true;
        }

        public bool Deletar()
        {
            if (!ValidarId())
            {
                return false;
            }

            repositorio.RemoverProduto(Id);
            return true;
        }

        public Produto_ ListarProdutos()
        {
            return repositorio.ListarProdutos();
        }

        private bool ValidarId()
        {
            return Id > 0;
        }

        private bool ValidarProduto()
        {
            return !string.IsNullOrEmpty(Nome);
        }
    }
}
