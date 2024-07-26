using InvoiceApplication.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InvoiceApplication.Controllers
{
    public class InvoiceFormController : Controller
    {
        private readonly InvoiceApplicationContext _context;

        public InvoiceFormController(InvoiceApplicationContext context)
        {
            _context = context;
        }
        //public IActionResult Index()
        //{
        //    var data =  _context.AddDetails.ToListAsync();
        //      Console.WriteLine(data);
        //    //Console.WriteLine(_context.AddDetails);
        //    return View();
        //}

    }
}
