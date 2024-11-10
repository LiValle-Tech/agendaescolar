using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Agenda.Models
{
    public class Estado:Padrao
    {
    
        public string Sigla { get; private set; }    
       
        public virtual IReadOnlyCollection<Cidade> Cidades { get; private set; }

        private Estado() { } 
    }
}
