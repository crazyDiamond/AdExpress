using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using AdExpress.AdExpressWcfService;
using AdExpressServices;
using AdExpressServices.DataContext;
using Moq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ad = AdExpressServices.Models.Ad;
using Newspaper = AdExpressServices.Models.Newspaper;

namespace AdExpress.Tests.Services
{
    [TestClass]
    public class AdExpressServiceTest
    {
        private IAdExpressWcfService facilityRepository;
       
        [TestMethod]
        public void TestAddingAnAd()
        {
            var mockSet = new Mock<DbSet<Ad>>();
            var mockContext = new Mock<AdExpressDBContext>();
            mockContext.Setup(m => m.Ads).Returns(mockSet.Object);
            
            var service = new AddExpressWcfService(mockContext.Object);
            service.AddAd("Testing Adding An Ad", "1.0");

           mockSet.Verify(m => m.Add(It.IsAny<Ad>()), Times.Once());
           mockContext.Verify(m => m.SaveChanges(), Times.Once()); 
           
        }
        [TestMethod]
        public void TestAddingANewspaper()
        {
            var mockSet = new Mock<DbSet<Newspaper>>();
            var mockContext = new Mock<AdExpressDBContext>();
            mockContext.Setup(m => m.Newspapers).Returns(mockSet.Object);

            var service = new AddExpressWcfService(mockContext.Object);
            service.AddNewspaper("Testing Adding a newspaper", "1.0");

            mockSet.Verify(m => m.Add(It.IsAny<Newspaper>()), Times.Once());
            mockContext.Verify(m => m.SaveChanges(), Times.Once());

        }

        [TestMethod]
        public void TestGettingAllAds()
        {
            var mockSet = new Mock<DbSet<Newspaper>>();
            var mockContext = new Mock<AdExpressDBContext>();
            mockContext.Setup(m => m.Newspapers).Returns(mockSet.Object);

            var service = new AddExpressWcfService(mockContext.Object);
            mockSet.Setup(x => x.Add(It.IsAny<Newspaper>()));
            service.GetAllNewspapers();


        }
        [TestMethod]
        public void GetAllAds_OrderByName()
        {
            var data = new List<Ad> 
            { 
                new Ad { Title = "Ad1", Version = "1"}, 
                new Ad { Title = "Ad2", Version = "1"}, 
                new Ad { Title = "Ad3", Version = "1" }, 
            }.AsQueryable();

            var mockSet = new Mock<DbSet<Ad>>();
            mockSet.As<IQueryable<Ad>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Ad>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Ad>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Ad>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<AdExpressDBContext>();
            mockContext.Setup(c => c.Ads).Returns(mockSet.Object);

            var service = new AddExpressWcfService(mockContext.Object);
            var ads = service.GetAllAdsList();

            Assert.AreEqual(3, ads.Count());
            Assert.AreEqual("Ad1", ads[0].Title);
            Assert.AreEqual("Ad2", ads[1].Title);
            Assert.AreEqual("Ad3", ads[2].Title);
        } 
   
    }
}
