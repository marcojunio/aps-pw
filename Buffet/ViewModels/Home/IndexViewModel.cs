using System.Collections;
using System.Collections.Generic;

namespace Buffet.ViewModels.Home
{
    public class IndexViewModel
    {
        public string InformacaoQualquer { get; set; }
        public string Titulo { get; set; }

        public Usuario UsuarioLogado { get; set; }

        public ICollection<Cliente> Clientes { get; set; }

        public IndexViewModel()
        {
            Clientes = new List<Cliente>();
        }
    }

    public class Usuario
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
    }

    public class Cliente
    {
        public string Id { get; set; }
        public string Nome { get; set; }
    }
}