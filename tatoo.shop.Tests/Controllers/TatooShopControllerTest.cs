using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Routing;
using Moq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using tatoo.shop.Controllers;
using tatoo.shop.Models;
using tatoo.shop.Models.TatooShop;

namespace tatoo.shop.Tests.Controllers
{
    [TestClass]
    public class TatooShopControllerTest
    {
        private TatooShopController controller;
        private MockRepository mockRepository;

        [TestInitialize]
        public void Init()
        {
            mockRepository = new MockRepository(MockBehavior.Default);
            controller = new TatooShopController();
        }

        [TestCleanup]
        public void End()
        {
            mockRepository.VerifyAll();
        }

        [TestMethod]
        public void IndexPageIsModelView()
        {
            var viewResult = controller.Index() as ViewResult;
            Assert.IsNotNull(viewResult);
        }

        [TestMethod]
        public void IndexPageIsIndexPageViewModel()
        {
            var viewResult = controller.Index() as ViewResult;
            Assert.IsInstanceOfType(viewResult.Model, typeof(IndexPageModel));
        }

        [TestMethod]
        public void PorfolioPageExists()
        {
            var viewResult = controller.Portfolio();
            Assert.IsNotNull(viewResult);
        }

        [TestMethod]
        public void PortfolioViewModelIsPortfolioModel() 
        {
            var viewResult = controller.Portfolio() as ViewResult;
            var model = viewResult.Model;
            Assert.IsInstanceOfType(model, typeof(PortfolioModel));
        }

        [TestMethod]
        public void AboutPageExists()
        {
            var viewResult = controller.About() as ViewResult;
            Assert.IsNotNull(viewResult);
        }

        [TestMethod]
        public void AboutPageViewModelIsAboutModel()
        {
            var viewResult = controller.About() as ViewResult;
            Assert.IsInstanceOfType(viewResult.Model, typeof(AboutModel));
        }
    }
}
