using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using N2B1_CadCurriculos.Models;
using System.Diagnostics;

namespace N2B1_CadCurriculos.Controllers
{
    public class CurriculoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Sobre()
        {
            return View();
        }

        public IActionResult Cadastro()
        {
            return View();
        }
    }
}
