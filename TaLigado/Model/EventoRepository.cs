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

        public void Delecte(int id)
        {
            conexao = new Conexao();
            var query = $"DELETE eventos WHERE ID = {id}";
            conexao.Delecte(query);
        }

        public DataTable GetTableEvento(bool way, int id)
        {
            DataTable dados;
            conexao = new Conexao();
            if (way)
            {
                var query = $"SELECT * FROM eventos";
                dados = conexao.SelectAll(query);
            }
            else
            {
                var query = $"SELECT * FROM eventos WHERE ID = {id}";
                dados = conexao.SelectWhere(query);
            }
            return dados;
        }

        public void Insert(IEvento objecto)
        {
            conexao = new Conexao();
            var query = $"INSERT INTO eventos (titulo, frequencia, repetir, pessoas_envolvidas, localizacao, descricao, imagem, data, horas) " +
                                    $"VALUES ('{objecto.titulo}', '{objecto.frequencia}', {objecto.repetir}, '{objecto.pessoas_envolvidas}, '{objecto.localizacao}, " +
                                    $"'{objecto.descricao}', '{objecto.imagem}', {objecto.data}, {objecto.horas})'";
            conexao.Insert(query);
        }

        public void UpDate(IEvento objecto, int id)
        {
            conexao = new Conexao();
            var strSQL = $"UPDATE eventos " +
                        $"SET titulo, =         {objecto.titulo}," +
                        $"frequencia, =         {objecto.frequencia}," +
                        $"repetir, =            {objecto.repetir}," +
                        $"pessoas_envolvidas =  {objecto.pessoas_envolvidas}," +
                        $"localizacao, =        {objecto.localizacao}," +
                        $"descricao, =          {objecto.descricao}," +
                        $"imagem, =             {objecto.imagem}," +
                        $"data, =               {objecto.data}," +
                        $"horas =               {objecto.horas} " +
                        $"WHERE ID = {id}";
            conexao.Update(strSQL);
        }
    }
}
