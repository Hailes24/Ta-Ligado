using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaLigado.Model
{
    public interface IGatewayEvento <C> where C : class
    {
        void Insert(C objecto);
        void UpDate(C objecto, int id);
        void Delecte(byte id);
        DataTable GetTableEvento(bool way, int id = 1);
        List<DataRow> GetTableEventoLIst(string data);
        List<DataRow> GetTableEventoLIst(DateTime dateTime);
        List<DataRow> GetTableEventoByDate(string data);
    }
}
