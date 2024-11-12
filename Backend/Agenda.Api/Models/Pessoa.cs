using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Models
{
    public class Pessoa: Padrao
    {
        public  long Documento { get; set; }
        public string Endereco { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        
        public string Bairro { get; set; }
        public long Cep { get; set; }
        public int TipoPessoaId { get; set; }
        public int Cidadeid { get; set; }
        public virtual ICollection<Contato> Contatos { get; set; }
     
    }
}
