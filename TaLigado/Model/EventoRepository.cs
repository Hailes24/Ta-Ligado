using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaLigado.Model
{
    public class EventoRepository : IEvento, IGatewayEvento<IEvento>
    {
        private Conexao conexao;
        public string titulo { get ; set ; }
        public string frequencia { get ; set ; }
        public bool repetir { get ; set ; }
        public string pessoas_envolvidas { get ; set ; }
        public string localizacao { get ; set ; }
        public string descricao { get ; set ; }
        public string imagem { get ; set ; }
        public DateTime data { get ; set ; }
        public int horas { get ; set ; }
        public string periodo { get ; set ; }
        public string estado { get ; set ; }
        public int Id { get ; set; }

        public EventoRepository()
        {
            conexao = new Conexao();
        }

        public void Delecte(byte id)
        {
            conexao = new Conexao();
            var query = $"DELETE eventos WHERE ID = {id}";
            conexao.Delecte(query);
        }

        public DataTable GetTableEvento(bool way, int id = 1)
        {
            DataTable dados;
            conexao = new Conexao();
            if (way)
            {
                var query = $"SELECT * FROM eventos ORDER BY Id DESC";
                dados = conexao.SelectAll(query);
                var lastCol = dados.Columns.Count - 1;
                foreach (DataColumn col in dados.Columns)
                    col.Caption = col.ColumnName.Replace("_", " ").ToUpper();
                foreach (DataRow lin in dados.Rows)
                {
                    var valor = Convert.ToDateTime((string)lin[8]).CompareTo(Convert.ToDateTime(DateTime.Now.ToShortTimeString()));
                    if (valor < 0 && (((string)lin[lastCol]).Trim().Equals("Pendente")))
                    {
                        lin[lastCol] = "Não Feito";
                    }
                }
            }
            else
            {
                var query = $"SELECT * FROM eventos WHERE Id = {id}";
                dados = conexao.SelectWhere(query);
            }
            return dados;
        }
        public int GetTableEventoByEstado(string estado)
        {
            DataTable dados;
            var query = $"SELECT estado FROM eventos WHERE estado = '{estado}'";
            dados = (new Conexao()).SelectAll(query);
            return dados.Rows.Count;
        }

        public void Insert(IEvento objecto)
        {
            conexao = new Conexao();
            var query = $"INSERT INTO eventos (titulo, frequencia, repetir, pessoas_envolvidas, localizacao, descricao, imagem, data, horas, periodo, estado) " +
                                    $"VALUES ('{objecto.titulo}', '{objecto.frequencia}', '{objecto.repetir.ToString()}', '{objecto.pessoas_envolvidas}', '{objecto.localizacao}', " +
                                    $"'{objecto.descricao}', '{objecto.imagem}', '{objecto.data.ToString().Remove(10)}', {objecto.horas}, '{objecto.periodo}', '{objecto.estado}')";
            conexao.Insert(query);
        }

        public void UpDate(IEvento objecto, int id)
        {
            conexao = new Conexao();
            var strSQL = $"UPDATE eventos " +
                        $"SET titulo =         {objecto.titulo}," +
                        $"frequencia =         {objecto.frequencia}," +
                        $"repetir =            {objecto.repetir}," +
                        $"pessoas_envolvidas =  {objecto.pessoas_envolvidas}," +
                        $"localizacao =        {objecto.localizacao}," +
                        $"descricao =          {objecto.descricao}," +
                        $"imagem =             {objecto.imagem}," +
                        $"data =               {objecto.data}," +
                        $"horas =               {objecto.horas} " +
                        $"WHERE ID = {id}";
            conexao.Update(strSQL);
        }

        public List<DataRow> GetTableEventoLIst(string data)
        {
            var query = $"SELECT * FROM eventos WHERE data = '{data}' AND estado = 'Pendente'";
            var dados = (new Conexao()).SelectAll(query);
            return dados.AsEnumerable().ToList();
        }

        public List<DataRow> GetTableEventoLIst(DateTime dateTime)
        {
            string query = $"SELECT * FROM eventos WHERE estado = 'Pendente'";
            DataTable dadosFiltraodos = new DataTable();
            var dados = (new Conexao()).SelectAll(query);
            dadosFiltraodos = (from aux in dados.AsEnumerable()
                               where Convert.ToDateTime((string)aux["data"]) > dateTime
                               select aux).CopyToDataTable();
            return dadosFiltraodos.AsEnumerable().ToList();
        }
    }
}
