using Microsoft.AspNetCore.Mvc;
using WebApplication7.Models;

namespace WebApplication7.Controllers
{
    public class PessoaController : Controller
    {
        public IActionResult Index()
        {
            var pessoa = new Pessoa();
            return View();
        }
        [HttpPost]
        public IActionResult Index(Pessoa pessoa)
        {
            //validacao ao chamar a pagina
           /* if (string.IsNullOrEmpty(pessoa.Nome))
            {
                ModelState.AddModelError("Nome", "O campo nome deve ser preenchido");
            }*/


            if (ModelState.IsValid)
            {
                return View("Resultado", pessoa);
            }
            return View(pessoa);
        }
        public IActionResult Resultado(Pessoa pessoa)
        {
            if (ModelState.IsValid)
            {
                return View("Resultado", pessoa);
            }
            return View(pessoa);
        }


    }
}
