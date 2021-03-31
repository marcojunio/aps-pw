using Buffet.Models.Buffet.Cliente;
using Buffet.Models.Buffet.Tipos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Buffet.Models.Buffet.EventoLocal
{
    public class Evento
    {
        public TipoEvento Tipo{ get; set; }

        public string Descricao { get; set; }
        public DateTime DtEHoraInicioEvento { get; set; }
        public DateTime DtEHoraFinalEvento { get; set; }
        public ClienteEntity Cliente { get; set; }
        public StatusEvento Situacao { get; set; }

        public Local Local { get; set; }
        public string Observacao { get; set; }
        public DateTime DtDeRegistro { get; set; }
        public DateTime DtUltimaModificaoDoRegistro { get; set; }
    }
}
