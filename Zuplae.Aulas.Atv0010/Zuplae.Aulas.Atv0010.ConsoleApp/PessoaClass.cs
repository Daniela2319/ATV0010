using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zuplae.Aulas.Atv0010.ConsoleApp
{
    internal class PessoaClass
    {// Atributos
        private string Nome { get; set; }
        private string Telefone { get; set; }
        private string Email { get; set; }
        private string Endereco { get; set; }


        public PessoaClass(string nome, string telefone, string email, string endereco)
        { // Construtor
            this.Nome = nome;
            this.Telefone = telefone;
            this.Email = email;
            this.Endereco = endereco;
        }

        public void MostrarDados()
        {
            Console.WriteLine($"Nome: {this.Nome}");
            Console.WriteLine($"Telefone: {this.Telefone}");
            Console.WriteLine($"Email: {this.Email}");
            Console.WriteLine($"Endereco: {this.Endereco}");
        }
    }
}
