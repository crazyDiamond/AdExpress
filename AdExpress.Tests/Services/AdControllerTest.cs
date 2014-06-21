using System.Data.Entity;
using AdExpressServices;
using AdExpressServices.DataContext;
using AdExpressServices.Models;
using Moq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdExpress.Tests.Services
{
    [TestClass]
    public class AdControllerTest
    {
        [TestMethod]
        public void TestAddingAnAd()
        {
            var mockSet = new Mock<DbSet<Ad>>();
            var mockContext = new Mock<AdExpressDBContext>();
            mockContext.Setup(m => m.Ads).Returns(mockSet.Object);
            
            var service = new AddExpressWcfService();
            service.AddAd("Testing adding an ad", "1.0");

            mockSet.Verify(m => m(It.IsAny<Ad>()), Times.Once());
            mockContext.Verify(m => m.SaveChanges(), Times.Once()); 
           
        }
    }
}
