using Buffet.Models.Buffet.Tipos;
using System;
using System.ComponentModel.DataAnnotations;

namespace Buffet.Models.Buffet.Cliente
{
    public class ClienteEntity
    {
        [Key] public int Id { get; set; }
        [Required] public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Email { get; set; }
        public string Observacoes { get; set; }
        public DateTime DtDeRegistro { get; set; }
        public DateTime DtUltimaModificacao { get; set; }
        public TipoCliente Tipo { get; set; }
    }
}