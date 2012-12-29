using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using tatoo.shop.Models;

namespace tatoo.shop.FrontServices
{
    public interface ITatooShopFrontService
    {
        IndexPageModel LoadIndexPageModel();
    }
}