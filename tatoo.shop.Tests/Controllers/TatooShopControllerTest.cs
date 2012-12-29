using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Routing;
using Moq;
using NUnit.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using tatoo.shop.Controllers;
using tatoo.shop.FrontServices;
using tatoo.shop.Models;
using Assert = NUnit.Framework.Assert;

namespace tatoo.shop.Tests.Controllers
{
    [TestClass]
    public class TatooShopControllerTest
    {
        private TatooShopController controller;
        private Mock<ITatooShopFrontService> tatooShopFrontService;
        private MockRepository mockRepository;

        [TestInitialize]
        public void Init()
        {
            mockRepository = new MockRepository(MockBehavior.Default);
            tatooShopFrontService = mockRepository.Create<ITatooShopFrontService>();
            controller = new TatooShopController(tatooShopFrontService.Object);
        }

        [TestCleanup]
        public void End()
        {
            mockRepository.VerifyAll();
        }

        [TestMethod]
        public void IndexPageExists()
        {
            var viewResult = controller.Index();
            Assert.That(viewResult, Is.Not.Null);
        }

        [TestMethod]
        public void IndexPageIsModelView()
        {
            var viewResult = controller.Index() as ViewResult;
            Assert.That(viewResult, Is.Not.Null);
        }

        [TestMethod]
        public void IndexPageIsIndexPageViewModel()
        {
            var viewResult = controller.Index() as ViewResult;
            Assert.That(viewResult.Model.GetType(), Is.EqualTo(typeof(IndexPageModel)));
        }

        [TestMethod]
        public void IndexPageIsLoadModelFromTatooShopFrontService()
        {
            tatooShopFrontService
                .Setup(x => x.LoadIndexPageModel())
                .Returns(new IndexPageModel())
                .Verifiable();

            controller.Index();
        }
    }
}
