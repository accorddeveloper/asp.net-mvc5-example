using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        public ViewResult Index()
        {
            var customers = new List<Customer>
            {
                new Customer { Id = 1, Name = "John Hancock" },
                new Customer { Id = 2, Name = "Mary Williams" }
            };

            var viewModel = new CustomersViewModel
            {
                Customers = customers
            };
            return View(viewModel);
        }

        [Route("Customers/Details/{id}")]
        public ActionResult Details(int id)
        {
            var customers = new List<Customer>
            {
                new Customer { Id = 1, Name = "John Hancock" },
                new Customer { Id = 2, Name = "Mary Williams" }
            };

            foreach (var customer in customers)
            {
                if (customer.Id == id)
                {
                    return View(customer);
                }
            }
            return new HttpNotFoundResult();
        }
    }
}