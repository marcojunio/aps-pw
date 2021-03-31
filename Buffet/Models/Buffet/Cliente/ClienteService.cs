using System;
using System.Collections.Generic;
using System.Linq;
using Buffet.Data;

namespace Buffet.Models.Buffet.Cliente
{
    public class ClienteService
    {
        private readonly DatabaseContext _databaseContext;

        public ClienteService(
            DatabaseContext databaseContext
        ){
            _databaseContext = databaseContext;
        }

        public List<ClienteEntity> ObterClientes()
        {
            return _databaseContext.Clientes.ToList();
        }
    }
}