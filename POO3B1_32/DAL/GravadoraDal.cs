using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace POO3B1_32.DAL
{
    public class GravadoraDal
    {
       const string stringConexao = "Persist Security info = false; server=localhost; database=bd_Gravadora ;user=root ;pwd=";
        MySqlConnection conexao;
        
       public void conectar()
        {
            try
            {
                conexao = new MySqlConnection(stringConexao);
                conexao.Open();
            }
            catch(MySqlException e)
            {
                throw new Exception(e.Message);
            }
        }
        public DataTable pegardados(string pesquisa)
        {
            try
            {
                conectar();
                MySqlDataAdapter recuperadados = new MySqlDataAdapter(pesquisa , conexao);
                DataTable retornodados = new DataTable();
                recuperadados.Fill(retornodados);
                return retornodados;
            }
            catch(MySqlException e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
        public void executarcomando(string consulta)
        {
            try
            {
                conectar();
                MySqlCommand comando = new MySqlCommand(consulta , conexao);
                comando.ExecuteNonQuery();
            }
            catch(MySqlException e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
