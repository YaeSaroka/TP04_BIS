using Microsoft.AspNetCore.Mvc;

namespace TP4_BIS.Controllers;

public class HomeController : Controller
{
    public IActionResult Index(List<Pais> ListaPaises)
    {
        ViewBag.ListaPaises = Info.ListarPaises();
        return View();
    }
    public IActionResult DetallePais(string pais)
    {
        Pais pais_ = Info.DetallePais(pais);
        ViewBag.Pais= pais_;
        return View();
    }
}
