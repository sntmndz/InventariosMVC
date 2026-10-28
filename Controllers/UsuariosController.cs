using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using InventariosMVC.Models;

namespace InventariosMVC.Controllers;

public class UsuariosController : Controller
{
    public IActionResult ListarUsuarios()
    {
        return View();
    }



    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
