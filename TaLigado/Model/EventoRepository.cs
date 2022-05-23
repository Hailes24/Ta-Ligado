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
        Conexao Conexao = new Conexao();
        public string titulo { get ; set ; }
        public string frequencia { get ; set ; }
        public bool repetir { get ; set ; }
        public string pessoas_envolvidas { get ; set ; }
        public string localizacao { get ; set ; }
        public string descricao { get ; set ; }
        public string imagem { get ; set ; }
        public DateTime data { get ; set ; }
        public int horas { get ; set ; }

        public void Delecte(byte id)
        {
            //TODO
        }

        public DataTable GetTableEvento()
        {
            //TODO
            return new DataTable();
        }

        public void Insert(IEvento objecto)
        {
            //TODO
        }

        public void UpDate(IEvento objecto)
        {
            //TODO
        }
    }
}
