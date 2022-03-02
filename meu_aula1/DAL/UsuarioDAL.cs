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

        public bool buscar(int id, Models.Usuario usua)
        {
            string sql = $@"select * from usuario 
                            where usu_id = {id}";
            try
            {
                System.Data.Common.DbDataReader dr = banco.execSelect(sql);
                usua = map(dr).First();
                banco.fecharConexao();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public List<Models.Usuario> pesquisar(string nome)
        {
            string sql = $@"select * from usuario 
                            where usu_nome like @usu_nome";
            
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("@usu_nome", "%" + nome + "%");
            List<Models.Usuario> usuarios = new List<Models.Usuario>();

            try
            {
                System.Data.Common.DbDataReader dr = banco.execSelect(sql, parametros);
                usuarios = map(dr);
                return usuarios;
            }
            finally
            {
                banco.fecharConexao();
            }
        }

        private List<Models.Usuario> map(System.Data.Common.DbDataReader dr)
        {
            List<Models.Usuario> usuarios = new List<Models.Usuario>();
            while (dr.Read())
            {
                Models.Usuario usua = new Models.Usuario();

                usua.Id = Convert.ToInt32(dr["usu_id"]);
                usua.Nome = dr["usu_nome"].ToString();
                usua.Senha = dr["usu_senha"].ToString();
                usua.Email = dr["usu_email"].ToString();

                usuarios.Add(usua);
            }
            return usuarios;
        }
    }
}
