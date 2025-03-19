using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroCliente
{
    internal class Cliente
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string DataNascimento { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string NomeSocial { get; set; }
        public bool Estrangeiro { get; set; }
        public Genero Genero { get; set; }
        public Etnia Etnia {  get; set; }
        public Tipo Tipo { get; set; }
        public Endereco Endereco { get; set; }
    }
            
}
