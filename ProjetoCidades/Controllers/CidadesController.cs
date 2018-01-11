using Microsoft.AspNetCore.Mvc;
using ProjetoCidades.Models;
using ProjetoCidades.Repositorio;

namespace ProjetoCidades.Controllers {
    public class CidadesController : Controller {
        Cidade cidade = new Cidade ();
        CidadeRep objCidadeRep = new CidadeRep ();
        public IActionResult Index () {
            var lista = objCidadeRep.Listar ();
            return View (lista);
        }
        public IActionResult CidadesEstados () {
            var lista = cidade.ListarCidades ();
            return View (lista);
        }
        public IActionResult TodosOsDados () {
            var lista = cidade.ListarCidades ();
            return View (lista);
        }
        public IActionResult Cadastrar () {
            return View ();
        }
    }
}