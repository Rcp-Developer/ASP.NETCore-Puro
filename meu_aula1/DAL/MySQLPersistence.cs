using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace meu_aula1.DAL
{
    public class MySQLPersistence
    {
        public MySqlConnection _con { get; set; }
        
        public MySqlCommand _cmd { get; set; }
        
        public int _ultimo_id { get; set; }

        public MySQLPersistence()
        {
            _con = new MySqlConnection("Server=192.168.0.197;Database=exemplo;Uid=rodrigo;Pwd=Aeiou@123");
            _cmd = _con.CreateCommand();
        }

        public void abrirConexao()
        {
            if (_con.State != System.Data.ConnectionState.Open)
            {
                _con.Open();
            }
        }

        public void fecharConexao()
        {
            _con.Close();
        }

        /// <summary>
        /// Executa comandos não consulta
        /// </summary>
        /// <param name="sql">Comando SQL</param>
        /// <param name="parametros">Filtros do SQL</param>
        /// <returns>Retorna quantidade de linhas afetadas</returns>
        public int execNonQuery(string sql, Dictionary<string, object> parametros = null)
        {
            try
            {
                abrirConexao();
                _cmd.CommandText = sql;
                if (parametros != null)
                {
                    foreach (var param in parametros)
                    {
                        _cmd.Parameters.AddWithValue(param.Key, param.Value);
                    }
                }
                int qtde_linhas_afetadas = _cmd.ExecuteNonQuery();
                _ultimo_id = (int)_cmd.LastInsertedId;

                return qtde_linhas_afetadas;
            }
            finally
            {
                fecharConexao();
            }
        }

        /// <summary>
        /// Executa comandos sql que retornam somente uma linha e uma coluna ex: Count(), Max().
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="parametros">Filtros do SQL</param>
        /// <returns>Retorna tipo objeto para ser generico a quem chama o método</returns>
        public object execQueryScalar(string sql, Dictionary<string, object> parametros = null) {

            try
            {
                abrirConexao();
                _cmd.CommandText = sql;
                if (parametros != null)
                {
                    foreach (var param in parametros)
                    {
                        _cmd.Parameters.AddWithValue(param.Key, param.Value);
                    }
                }

                return _cmd.ExecuteScalar();
            }
            finally
            {
                fecharConexao();
            }
        }

        public System.Data.Common.DbDataReader execSelect(string sql, Dictionary<string, object> parametros = null)
        {
            abrirConexao();
            _cmd.CommandText = sql;
            if (parametros != null)
            {
                foreach (var param in parametros)
                {
                    _cmd.Parameters.AddWithValue(param.Key, param.Value);
                }
            }
            MySqlDataReader reader = _cmd.ExecuteReader();
            return reader;
        }
    }
}
