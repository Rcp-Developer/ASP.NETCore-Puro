using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace meu_aula1.DAL
{
    public class UsuarioDAL
    {
        MySQLPersistence banco = new MySQLPersistence();

        public void gravar(Models.Usuario usuario)
        {
            string sql = @"insert into usuario values(default, @usu_nome, @usu_senha, @usu_email)";

            Dictionary<string, object> parametros = new Dictionary<string, object>();

            parametros.Add("@usu_nome", usuario.Nome);
            parametros.Add("@usu_senha", usuario.Senha);
            parametros.Add("@usu_email", usuario.Email);

            banco.execNonQuery(sql, parametros);
        }

    }
}
