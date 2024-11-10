using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Models
{
   public class Cidade:Padrao
    {

        public virtual Estado Estado { get; private set; }

        private Cidade() { }
    }
}
