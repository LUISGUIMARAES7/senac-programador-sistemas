using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produto.dominio
{
    internal class Estoque
    {
        public int Id { get; set; }
        public int Quantidade { get; set; }
        public int IdProduto { get; set; }
        public DateTime Data {  get; set; } 
    }
}
