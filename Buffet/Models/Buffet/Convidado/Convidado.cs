using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Buffet.Models.Buffet.EventoLocal;

namespace Buffet.Models.Buffet.Convidado
{
    public class Convidado
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime DtNascimento { get; set; }
        public StatusConvidado Situacao { get; set; }
        public string Observacao { get; set; }
        public DateTime DtDeRegistro { get; set; }
        public DateTime DtUltimaModificao { get; set; }
        public Evento Evento{ get; set; }
    }
}
