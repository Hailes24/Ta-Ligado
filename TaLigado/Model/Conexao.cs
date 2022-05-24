using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaLigado.Model
{
    public class Conexao
    {
        SqlConnection conexao;
        SqlCommand comando;
        SqlDataAdapter da;
        SqlDataReader dr;
        string strSQL;

        public Conexao()
        {
            var str = @"Server=DESKTOP-HAILES\MSSQLSERVERNWA ;Database=TALIGADO ;Initial Catalog=MRADMIN;Integrated Security=True; ";
            conexao = new SqlConnection(str);
        }
        private void Insert(IEvento evento)
        {
            try
            {
                strSQL = $"INSERT INTO eventos (titulo, frequencia, repetir, pessoas_envolvidas, localizacao, descricao, imagem, data, horas) " +
                                    $"VALUES ('{evento.titulo}', '{evento.frequencia}', {evento.repetir}, '{evento.pessoas_envolvidas}, '{evento.localizacao}, " +
                                    $"'{evento.descricao}', '{evento.imagem}', {evento.data}, {evento.horas})'";

                comando = new SqlCommand(strSQL, conexao);

                //comando.Parameters.AddWithValue("@NOME", txtNome.Text);
                //comando.Parameters.AddWithValue("@NUMERO", txtNumero.Text);

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
                conexao = null;
                comando = null;
            }
        }
    }
}
