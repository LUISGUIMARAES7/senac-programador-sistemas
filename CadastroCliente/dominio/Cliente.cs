
using CadastroDeClientes.repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroCliente.dominio
{
    internal class Cliente
    {

        private readonly ClienteRepositorio clienteRepositorio = new();

        public int Id { get; internal set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string NomeSocial { get; set; }
        public bool Estrangeiro { get; set; }
        public Genero Genero { get; set; }
        public Etnia Etnia { get; set; }
        public Tipo Tipo { get; set; }
        public Endereco Endereco { get; set; }

        public List<Cliente> ListarClientes()
        {
            return clienteRepositorio.ListarClientes();
        }

        public void InserirCliente(Cliente novoCliente)
        {
            ClienteRepositorio.InserirCliente(novoCliente);
        }
    }

}
