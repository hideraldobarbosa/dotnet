using DevIO.UI.AppModelo.Data;
using DevIO.UI.Site.Servicos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevIO.UI.AppModelo.Controllers
{
    public class HomeController : Controller 
    {
        public OperacaoService OperacaoService { get; }
        public OperacaoService OperacaoService2 { get; }

        // injeção de dependencia usual

        //private readonly IPedidoRepository _pedidoRepostitory;
        //public HomeController(IPedidoRepository pedidoRepository)
        //{
        //    _pedidoRepostitory = pedidoRepository;
        //}

        public HomeController(OperacaoService operacaoService, OperacaoService operacaoService2)
        {
            OperacaoService = operacaoService;
            OperacaoService2 = operacaoService2;
        }

        public string Index()
        {
            return "Primeira Instância: " + Environment.NewLine +
                OperacaoService.Transient.OperacaoId + Environment.NewLine +
                OperacaoService.Scoped.OperacaoId + Environment.NewLine +
                OperacaoService.Singleton.OperacaoId + Environment.NewLine +
                OperacaoService.SingletonInstance.OperacaoId + Environment.NewLine +
               
                Environment.NewLine +
                Environment.NewLine +

                 "Segunda Instância: " + Environment.NewLine +
                OperacaoService2.Transient.OperacaoId + Environment.NewLine +
                OperacaoService2.Scoped.OperacaoId + Environment.NewLine +
                OperacaoService2.Singleton.OperacaoId + Environment.NewLine +
                OperacaoService2.SingletonInstance.OperacaoId;
        }

        /*
        public IActionResult Index([FromServices] IPedidoRepository _pedidoRepository) // forma de injeção de dependencia não indicado
        {
            var pedido = _pedidoRepository.ObterPedido();
                
            return View();

        }
        */
    }
}
