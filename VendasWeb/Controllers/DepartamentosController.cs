using Microsoft.AspNetCore.Mvc;
using VendasWeb.Models;

namespace VendasWeb.Controllers
{
    public class DepartamentosController : Controller
    {
        public IActionResult Index()
        {

            List<Departamento> departamentos = new List<Departamento>();
            departamentos.Add(new Departamento { Id = 1, Nome = "Vendas" });
            departamentos.Add(new Departamento { Id = 2, Nome = "Marketing" });
            departamentos.Add(new Departamento { Id = 3, Nome = "TI" });

            return View(departamentos);
        }
    }
}
