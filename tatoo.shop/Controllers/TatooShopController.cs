using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using tatoo.shop.Models;
using tatoo.shop.Models.TatooShop;

namespace tatoo.shop.Controllers
{
    public class TatooShopController : Controller
    {
        public ActionResult Index()
        {
            return View(new IndexPageModel());
        }


        public object Portfolio()
        {
            return View(new PortfolioModel());
        }

        public ViewResult About()
        {
            return View(new AboutModel());
        }

        public ViewResult Rates()
        {
            return View(new RatesModel());
        }
    }
}
