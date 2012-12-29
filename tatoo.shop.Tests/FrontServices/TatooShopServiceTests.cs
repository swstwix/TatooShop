using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using tatoo.shop.FrontServices;
using tatoo.shop.FrontServices.Concret;

namespace tatoo.shop.Tests.FrontServices
{
    [TestClass]
    public class TatooShopServiceTests
    {
        private ITatooShopFrontService service;

        [TestInitialize]
        public void Init()
        {
            service = new TatooShopFrontService();
        }
    }
}
