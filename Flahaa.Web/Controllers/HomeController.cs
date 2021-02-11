using FlaHa.Domain;
using FlaHa.Repository.Interfaces;
using Flahaa.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Flahaa.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUnitOfWork<Customer> unitOfWork;
        public HomeController(IUnitOfWork<Customer> unitOfWork)
        {
            this.unitOfWork = unitOfWork;  
        }

        public async Task<IActionResult> Index()
        {
            var list = await unitOfWork.repo.GetAll();
            return View(list);
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
