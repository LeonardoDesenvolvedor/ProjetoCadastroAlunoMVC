using CadastroAluno.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CadastroAluno.Controllers
{
    public class CadastroController : Controller
    {

        private static IList<Cadastro> Cadastros = new List<Cadastro>()
        {
            new Cadastro()
            {
                CadastroId = 1,
                Nome = "Leonardo"
            },

            new Cadastro()
            {
                CadastroId = 2,
                Nome = "Paula"
            }


        };



        // GET: Cadastro
        public ActionResult Index()
        {
            return View(Cadastros);
        }
    }
}