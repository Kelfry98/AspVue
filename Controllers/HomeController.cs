using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Crud.Models;
using Crud.PersisteceData;
using Crud.Services.IterfaceServices;

namespace Crud.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPersonService _personService;
        public HomeController(IPersonService personService)
        {
            _personService = personService;
        }

        [HttpGet]
        public ActionResult GetAll()
        {
            return Ok(_personService.GetAll());
        }
        [HttpGet]
        public ActionResult Get(int id)
        {
            return Ok(_personService.GetById(id));
        }
        [HttpPost]
        public ActionResult Add([FromBody] Person model)
        {
            return Ok(
                _personService.Add(model));
        }
        [HttpPut]
        public ActionResult Update([FromBody] Person model)
        {
            return Ok(
                _personService.Update(model));
        }
        [HttpDelete]
        public ActionResult Remove(int id)
        {
            return Ok(
               _personService.Delete(id));
        }
        




        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
