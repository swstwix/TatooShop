using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ninject.Modules;
using tatoo.shop.FrontServices;
using tatoo.shop.FrontServices.Concret;

namespace tatoo.shop.DependencyInjection.Modules
{
    public class FrontServiceModule : NinjectModule 
    {
        public override void Load()
        {
            Bind<ITatooShopFrontService>().To<TatooShopFrontService>();
        }
    }
}