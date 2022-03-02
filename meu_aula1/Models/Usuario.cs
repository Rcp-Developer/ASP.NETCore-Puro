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
            return Email != null && Email == "rodrigo-q2@hotmail.com"
                && Senha != null && Senha == "123456";
        }

        public bool gravar()
        {
            DAL.UsuarioDAL dal = new DAL.UsuarioDAL();
            dal.gravar(this);

            return true;
        }

        public bool buscar(int id)
        {
            DAL.UsuarioDAL dal = new DAL.UsuarioDAL();
            return dal.buscar(id, this);
        }

        public List<Usuario> pesquisar(string nome)
        {
            DAL.UsuarioDAL dal = new DAL.UsuarioDAL();
            return dal.pesquisar(nome);
        }
    }
}
