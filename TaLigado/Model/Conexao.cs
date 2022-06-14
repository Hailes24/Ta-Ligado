using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaLigado.Model
{
    public class Conexao
    {
        private SqlConnection conexao;
        private SqlCommand comando;
        private SqlDataAdapter dataAdapter;
        private SqlDataReader dataReader;
        private string strConexao;

        public Conexao()
        {
            strConexao = @"Server=DESKTOP-HAILES\MSSQLSERVERNWA ;Database=TALIGADO ;Integrated Security=True;";
            conexao = new SqlConnection(strConexao);
        }
        public void Insert(string query)
        {
            try
            {
                comando = new SqlCommand(query, conexao);
                conexao.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao.Dispose();
                comando.Dispose();
            }
        }
        public DataTable SelectAll(string query)
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (var command = new SqlCommand(query, conexao))
                {
                    conexao.Open();
                    dataAdapter = new SqlDataAdapter(command);
                    dataAdapter.Fill(dataTable);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao.Dispose();
            }
            return dataTable;
        }
        public DataTable SelectWhere(string query)
        {
            try
            {
                comando = new SqlCommand(query, conexao);
                conexao.Open();
                dataReader = comando.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao.Dispose();
                comando.Dispose();
            }
            return dataReader.GetSchemaTable();
        }
        public void Update(string consulta)
        {
            try
            {
                comando = new SqlCommand(consulta, conexao);
                conexao.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao.Dispose();
                comando.Dispose();
            }
        }
        public void Delecte(string query)
        {
            try
            {
                comando = new SqlCommand(query, conexao);
                conexao.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao.Dispose();
                comando.Dispose();
            }
        }
    }
}
