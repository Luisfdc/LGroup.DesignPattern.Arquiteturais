using LGroup.Arquiteturais.App.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LGroup.Arquiteturais.UI.MVC.Controllers
{
    public class MatriculaController : Controller
    {
        private IMatriculaApplicationService _matriculaApplicationService;
        public MatriculaController(IMatriculaApplicationService matriculaApplicationService)
        {
            _matriculaApplicationService = matriculaApplicationService;
        }
        // GET: Matricula
        public ActionResult Index()
        {
            _matriculaApplicationService.Add(null);
            return View();
        }
    }
}