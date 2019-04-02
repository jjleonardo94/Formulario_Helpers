using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Form.Models;
using Microsoft.AspNetCore.Mvc;


namespace Form.Controllers
{
    public class FormularioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
		[HttpGet]
			public IActionResult FormularioForm()
		{
			return View();
		}
		[HttpPost]
		public IActionResult FormularioForm(Empleado emp)
		{
			if (ModelState.IsValid)
			{
				return View("Gracias", emp);
			}
			else
			{
				return View("FormularioForm");	
			}
			
		}
	}
}