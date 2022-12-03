using JJBA_SITE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JJBA_SITE.Controllers 
{ 
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Usuario()
        {
            var usuario = new Usuario();       // criando objeto para classe
            return View(usuario);              // retorna para view os dados da classe
        }

        [HttpPost]
        public ActionResult Usuario(Usuario usuario)
        {
            if (ModelState.IsValid)                            // validando o estado, ou seja, verificando a requisição
            {
                return View("Resultado", usuario);             // retorna para a view resultado
            }
            return View(usuario);
        }

        public ActionResult Resultado(Usuario usuario)          //criando a ação para a view usuário
        {
            return View(usuario);
        }


    }
}