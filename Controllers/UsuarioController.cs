using Microsoft.AspNetCore.Mvc;
using sistemacontatos.Models;
using sistemacontatos.Repositorio;
using System;
using System.Collections.Generic;

namespace sistemacontatos.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
