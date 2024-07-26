using InvoiceApplication.Models;
using Microsoft.AspNetCore.Mvc;
//using InvoiceApplication.Report;

namespace InvoiceApplication.Controllers
{
    public class pdfGenerator : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //public ActionResult pdfGenerate(AddDetails AddDetails) 
        //{
        //    PdfData pdf = new PdfData();
        //    byte[] value = pdf.PrepareReports(GetDetails());
        //    return File(value,"application/pdf");
        //}

        //public List<AddDetails> GetDetails() 
        //{
        //    List<AddDetails> AddData = new List<AddDetails>();
        //    AddDetails AddDetail=new AddDetails();
        //    for (int i=1;i<=6;i++)
        //    {
        //        AddDetail = new AddDetails();
        //        AddDetail.Id = i;
        //        AddDetail.ItemName = i.ToString();
        //        AddDetail.Price = i;
        //        AddDetail.Gst = i;

        //    }
        //    return AddData;
        //}
    }
}
