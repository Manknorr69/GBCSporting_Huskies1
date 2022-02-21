using GBCSporting_Huskies1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GBCSporting_Huskies1.Controllers
{
    public class CustomerController : Controller
    {
        private CustomerContext context { get; set; }

        public CustomerController(CustomerContext ctx)
        {
            context = ctx;
        }
       [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            ViewBag.Categories = context.Category.OrderBy(c => c.Name).ToList();
            return View("Edit", new Customer());
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var customer = context.Customer.Include(c=>c.Catergory).FirstOrDefault(c=>c.CategoryId == id);
            return View(customer);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            ViewBag.Categories = context.Category.OrderBy(c => c.Name).ToList();
            

            var cusomer = context.Customer.Include(c => c.Catergory).FirstOrDefault(c=> c.CategoryId == id);
            return View("Edit", new Customer());

        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var customer = context.Customer.Include(c => c.Catergory).FirstOrDefault(c => c.CategoryId == id);
            return View(customer);
        }


    }
}
