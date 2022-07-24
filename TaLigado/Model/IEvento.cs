using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaLigado.Model
{
    public interface IEvento
    {
        int Id { get; set; }
        string titulo { get; set; }
        string frequencia { get; set; }
        bool repetir { get; set; }
        string pessoas_envolvidas { get; set; }
        string localizacao { get; set; }
        string descricao { get; set; }
        string imagem { get; set; }
        DateTime data { get; set; }
        int horas { get; set; }
        string periodo { get; set; }
        string estado { get; set; }
    }
}
