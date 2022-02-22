using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace meu_aula1.Models
{
    public class Usuario
    {
        private int _id;
        private string _nome;
        private string _email;
        private string _senha;

        public Usuario() { }

        public int Id { get => _id; set => _id = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public string Email { get => _email; set => _email = value; }
        public string Senha { get => _senha; set => _senha = value; }

        public bool validarLogin()
        {
            return Email == "rodrigo-q2@hotmail.com" && Senha == "123456";
        }

        public bool gravar()
        {
            //regras de negócio
            return true;
        }
    }
}
