using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using Vidlly.Models;

namespace Vidlly.Controllers
{
    public class CustomerController : Controller
    {
        private ApplicationDbContext _context;

        public CustomerController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Customer
        public ActionResult Index()
        {
            //return View();

            var customers = _context.Customers.Include(a => a.MembershipType).ToList();
            //var customer = new List<Customer>()
            //{
            //    new Customer { Name = "Rawan" },
            //    new Customer {Name = "Ram" }
            //};
            return View(customers);
        }


    }
}