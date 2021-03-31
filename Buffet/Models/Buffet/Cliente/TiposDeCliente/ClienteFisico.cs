using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Buffet.Models.Buffet.Cliente
{
    public class ClienteFisico : ClienteEntity
    {
        public string Cpf { get; set; }
        public DateTime DtNascimento { get; set; }
    }
}
