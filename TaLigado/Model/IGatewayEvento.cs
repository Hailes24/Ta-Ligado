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
        DataTable GetTableEvento(int id, bool way);
    }
}
