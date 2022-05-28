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
        private string strSQL, strConexao;

        public Conexao()
        {
            strConexao = @"Server=DESKTOP-HAILES\MSSQLSERVERNWA ;Database=TALIGADO ;Integrated Security=True;";
            conexao = new SqlConnection(strConexao);
        }
        private void Insert(IEvento evento)
        {
            try
            {
                strSQL = $"INSERT INTO eventos (titulo, frequencia, repetir, pessoas_envolvidas, localizacao, descricao, imagem, data, horas) " +
                                    $"VALUES ('{evento.titulo}', '{evento.frequencia}', {evento.repetir}, '{evento.pessoas_envolvidas}, '{evento.localizacao}, " +
                                    $"'{evento.descricao}', '{evento.imagem}', {evento.data}, {evento.horas})'";

                comando = new SqlCommand(strSQL, conexao);
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
        private DataTable SelectAll(string tableName)
        {
            DataTable dataTable = new DataTable();
            try
            {
                conexao = new SqlConnection(@"Server=DESKTOP-HAILES\MSSQLSERVERNWA ;Database=TALIGADO ;Integrated Security=True;");
                strSQL = $"SELECT * FROM {tableName}";
                using (var command = new SqlCommand(strSQL, conexao))
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
        private DataTable SelectWhere(short id, string tableName)
        {
            try
            {
                conexao = new SqlConnection(@"Server=DESKTOP-HAILES\MSSQLSERVERNWA ;Database=TALIGADO ;Integrated Security=True;");
                strSQL = $"SELECT * FROM {tableName} WHERE ID = {id}";
                comando = new SqlCommand(strSQL, conexao);
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
        private void Update(short id, string tableName, IEvento evento)
        {
            try
            {
                conexao = new SqlConnection(@"Server=DESKTOP-HAILES\MSSQLSERVERNWA ;Database=TALIGADO ;Integrated Security=True;");
                strSQL = $"UPDATE {tableName} " +
                                    $"SET titulo, =         {evento.titulo}," +
                                    $"frequencia, =         {evento.frequencia}," +
                                    $"repetir, =            {evento.repetir}," +
                                    $"pessoas_envolvidas =  {evento.pessoas_envolvidas}," +
                                    $"localizacao, =        {evento.localizacao}," +
                                    $"descricao, =          {evento.descricao}," +
                                    $"imagem, =             {evento.imagem}," +
                                    $"data, =               {evento.data}," +
                                    $"horas =               {evento.horas} " +
                                    $"WHERE ID = {id}";
                comando = new SqlCommand(strSQL, conexao);
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
        private void Delecte(short id, string tableName)
        {
            try
            {
                conexao = new SqlConnection(@"Server=DESKTOP-HAILES\MSSQLSERVERNWA ;Database=TALIGADO ;Integrated Security=True;");
                strSQL = $"DELETE {tableName} WHERE ID = {id}";
                comando = new SqlCommand(strSQL, conexao);
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
