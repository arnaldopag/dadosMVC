using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using atividade_ii.Models;

namespace atividade_ii.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Cadastro(ItemPedido novoItem)
        {
            Dados.PedidoAtual.AddItemPedido(novoItem);
            return View();
        }
        public IActionResult Cadastro()
        {
            return View();
        }

        public IActionResult PedidoAtual()
        {
            return View();
        }
    }
}
