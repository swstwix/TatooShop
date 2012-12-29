using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using tatoo.shop.Models;

namespace tatoo.shop.FrontServices.Concret
{
    public class TatooShopFrontService : ITatooShopFrontService
    {
        public IndexPageModel LoadIndexPageModel()
        {
            return new IndexPageModel();
        }
    }
}