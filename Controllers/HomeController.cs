using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Teste_FitCard.Models;
using Teste_FitCard.Services;

namespace Teste_FitCard.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private EstabelecimentoService estabelecimentoService;
        private CategoriaService categoriaService;
        private List<Categoria> categorias;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            estabelecimentoService = new EstabelecimentoService();
            categoriaService = new CategoriaService();
            categorias = categoriaService.Get();
        }

        public IActionResult Index()
        {      
            return View(estabelecimentoService.Get());
        }
        public IActionResult Criar()
        {
            ViewBag.Categorias = categorias;
            return View();
        }
        [HttpPost]
        public IActionResult Criar(Estabelecimento estabelecimento)
        {
            try
            {
                estabelecimentoService.Post(estabelecimento);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("erro", ex.Message);
                ViewBag.Categorias = categorias;
                return View();
            }
        }
        public IActionResult Deletar(int id)
        {
            ViewBag.Categorias = categorias;
            return View(estabelecimentoService.Get(id));
        }
        [HttpPost, ActionName("Deletar")]
        public IActionResult DeletarEstabelecimento(int id)
        {
            estabelecimentoService.Delete(id);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Detalhes(int id)
        {
            ViewBag.Categorias = categorias;
            return View(estabelecimentoService.Get(id));
        }
        public IActionResult Editar(int id)
        {
            ViewBag.Categorias = categorias;
            return View(estabelecimentoService.Get(id));
        }
        [HttpPost]
        public IActionResult Editar(Estabelecimento estabelecimento)
        {
            try
            {
                estabelecimentoService.Update(estabelecimento);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("erro", ex.Message);
                ViewBag.Categorias = categorias;
                return View(estabelecimentoService.Get(estabelecimento.id));
            }
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
