using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Buffet.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Buffet.Models;
using Buffet.Models.Buffet;
using Buffet.Models.Buffet.Cliente;
using Buffet.ViewModels.Home;
using Buffet.ViewModels.Shared;

namespace Buffet.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ClienteService _clienteService;

        public HomeController(
            ILogger<HomeController> logger,
            ClienteService clienteService
        ){
            _logger = logger;
            _clienteService = clienteService;
        }

        public IActionResult Index()
        {      
            // 1º Forma de enviar dados para a view
            ViewBag.InformacaoQualquer = "Informação Qualquer";
            
            // 2º Forma de enviar dados para a view
            ViewData["informacao"] = "Outra informação";
            
            // 3º Forma de enviar dados para a view
            var viewmodel = new IndexViewModel();
            viewmodel.InformacaoQualquer = "Informação pela View Model";
            viewmodel.Titulo = "Título qualquer";
            viewmodel.UsuarioLogado = new Usuario()
            {
                Nome = "Leonardo",
                Idade = 34
            };
            
            
            // Trazer lista de clientes do banco de dados
            var clientesDoBanco = _clienteService.ObterClientes();
            foreach (var clienteEntity in clientesDoBanco) {
                viewmodel.Clientes.Add(new Cliente()
                {
                    Id = clienteEntity.Id.ToString(),
                    Nome = clienteEntity.Nome
                });
            }

            return View(viewmodel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult StatusEvento()
        {
            // Acessando um service para obter a lista de
            // Status dos Eventos
            var listaStatusEventos = new List<StatusEvento>();
            listaStatusEventos.Add(new StatusEvento()
            {
                Id = 1,
                Descricao = "Reservado"
            });
            listaStatusEventos.Add(new StatusEvento()
            {
                Id = 2,
                Descricao = "Confirmado"
            });
            listaStatusEventos.Add(new StatusEvento()
            {
                Id = 3,
                Descricao = "Realizado"
            });
            
            // Crio a view model
            var viewmodel = new StatusEventoViewModel();
            
            // Alimento a view model com os dados dos status
            foreach (StatusEvento statusEvento in listaStatusEventos) {
                viewmodel.ListaDeStatus.Add(new Status()
                {
                    Id = statusEvento.Id,
                    Descricao = statusEvento.Descricao,
                });
            }
            
            return View(viewmodel);
        }
        
        public IActionResult StatusConvidado()
        {
            // Acessando um service para obter a lista de
            // Status dos Convidados
            var listaStatusConvidado = new List<StatusConvidado>();
            listaStatusConvidado.Add(new StatusConvidado()
            {
                Id = 1,
                Descricao = "A Confirmar"
            });
            listaStatusConvidado.Add(new StatusConvidado()
            {
                Id = 2,
                Descricao = "Confirmado"
            });
       
            // Crio a view model
            var viewmodel = new StatusConvidadoViewModel();
            
            // Alimento a view model com os dados dos status
            foreach (StatusConvidado statusConvidado in listaStatusConvidado) {
                viewmodel.ListaDeStatus.Add(new Status()
                {
                    Id = statusConvidado.Id,
                    Descricao = statusConvidado.Descricao,
                });
            }
            
            return View(viewmodel);
        }
        
        
        
        
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}