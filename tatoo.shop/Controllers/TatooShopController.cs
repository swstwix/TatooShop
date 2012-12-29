using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using tatoo.shop.FrontServices;
using tatoo.shop.Models;

namespace tatoo.shop.Controllers
{
    public class TatooShopController : Controller
    {
        private ITatooShopFrontService tatooShopFrontService;

        public TatooShopController(ITatooShopFrontService tatooShopFrontService)
        {
            this.tatooShopFrontService = tatooShopFrontService;
        }

        public ActionResult Index()
        {
            var model = tatooShopFrontService.LoadIndexPageModel();

            return View(new IndexPageModel());
        }

    }
}
