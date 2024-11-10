using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Models
{
    public abstract class Padrao
    {
        public int id { get; set; }
        public DateTime CriadoEm { get; set; } = DateTime.Now;
        public DateTime AlteradoEm { get; set; }
        public string Nome { get; set; }
    }
    
}
