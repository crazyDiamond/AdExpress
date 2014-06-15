using System.Web.Mvc;
using System.Data.Entity;
using AdExpress.Controllers;
using AdExpress.Models;
using AdExpressService;
using Moq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdExpress.Tests.Controllers
{
    [TestClass]
    public class AdControllerTest
    {
        [TestMethod]
        public void TestAddindAnAdd()
        {
            var mockSet = new Mock<DbSet<Ad>>();
            var mockContext = new Mock<AdDBContext>();
            mockContext.Setup(m => m.Ads).Returns(mockSet.Object);
            
            var service = new AdExpressDataService(mockContext.Object);
            service.AddAd("Testing Adding An Ad", "1.0");

            mockSet.Verify(m => m.Add(It.IsAny<Ad>()), Times.Once());
            mockContext.Verify(m => m.SaveChanges(), Times.Once()); 
           
        }
    }
}
