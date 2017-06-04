using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using Vidlly.Models;
using Vidlly.ViewModels;

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

        public ActionResult New()
        {
            var membershipTypes = _context.MembershipTypes.ToList();
            var viewModel = new NewCustomerViewModel
            {
                MembershipTypes = membershipTypes
            };

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Save(NewCustomerViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View("New", viewModel);
            }

            if (viewModel.Customer.Id == 0)
            {
                _context.Customers.Add(viewModel.Customer);
            }
            else
            {
                var customerInDbContext = _context.Customers.Single(c => c.Id == viewModel.Customer.Id);

                //TryUpdateModel()
                customerInDbContext.Name = viewModel.Customer.Name;
                customerInDbContext.Birthday = viewModel.Customer.Birthday;
                customerInDbContext.MembershipTypeId = viewModel.Customer.MembershipTypeId;
                customerInDbContext.IsSubscribedToNewsletter = viewModel.Customer.IsSubscribedToNewsletter;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Customer");
        }

        public ActionResult Edit(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            if (customer == null)
            {
                return HttpNotFound();
            }

            var viewModel = new NewCustomerViewModel
            {
                Customer = customer,
                MembershipTypes = _context.MembershipTypes.ToList()
            };
            return View("New", viewModel);
        }

        public ActionResult Details(int id)
        {
            var customer = _context.Customers.Include(a => a.MembershipType).SingleOrDefault(a => a.Id == id);
            return View(customer);
        }


    }
}