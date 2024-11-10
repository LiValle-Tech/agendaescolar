using Agenda.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Models
{
    public class Contato:Padrao
    {
        public int Id { get; set; }                       /
        public TipoContato Tipo { get; set; }            
        public bool Principal { get; set; }               
        public string Descricao { get; set; }             
        public int IdPessoa { get; set; }                 

        // Construtor opcional para inicializar os dados
        public Contato(TipoContato tipo, bool principal, string descricao, int idPessoa)
        {
            Tipo = tipo;
            Principal = principal;
            Descricao = descricao;
            IdPessoa = idPessoa;
        }
    }
}
