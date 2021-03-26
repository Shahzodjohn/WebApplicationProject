using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationProject.Models;
using WebApplicationProject.Repositories;

namespace WebApplicationProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(new PersonRepository().Select());
        }
        
    }
}
