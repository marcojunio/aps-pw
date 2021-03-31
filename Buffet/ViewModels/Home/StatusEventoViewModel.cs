using System.Collections.Generic;
using Buffet.ViewModels.Shared;

namespace Buffet.ViewModels.Home
{
    public class StatusEventoViewModel
    {
        public List<Status> ListaDeStatus { get; set; }

        public StatusEventoViewModel()
        {
            ListaDeStatus = new List<Status>();
        }
    }
}