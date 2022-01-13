using System.Web.Mvc;
using WebApplication2.Entity;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            string str = "One";
            int i = 0;
            Invoice inv = new Invoice();
           

                //string a = t.dipak(1);
                //string b = t.dipak("d");
                //Invoice Fn = new FinalInvoice();
                //double FnlAmount = Fn.GetInvoiceDiscount(1000);
                //Invoice Nml = new Invoice();
                //double NmlAmount = Nml.GetInvoiceDiscount(1000);

                Fruit f = new apple();
            Fruit ff = new Orange();
            
            // ViewBag.Message ="Final :" +  FnlAmount.ToString() + " Nml:" + NmlAmount.ToString();
            ViewBag.Message = f.Getcolor() + " " + ff.Getcolor();

            return View();
        }

        protected override void OnException(ExceptionContext filterContext)
        {
            base.OnException(filterContext);
        }

    }
}