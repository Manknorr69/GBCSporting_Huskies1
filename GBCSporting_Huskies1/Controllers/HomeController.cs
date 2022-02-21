using GBCSporting_Huskies1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;


namespace GBCSporting_Huskies1.Controllers
{
    public class HomeController : Controller
    {
        private CustomerContext context { get; set; }

        public HomeController(CustomerContext ctx)
        {
            context = ctx; 
        }

        public IActionResult Index()
        {
            var customer = context.Customer
            .Include(c => c.Catergory)
            .OrderBy(context => context.Firstname).ToList();
            return View(customer);

        }

      
    }
}