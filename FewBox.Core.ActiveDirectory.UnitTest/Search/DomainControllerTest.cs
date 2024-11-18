using FewBox.Core.ActiveDirectory.Object;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FewBox.Core.ActiveDirectory.TestSuite.Search
{
    [TestClass]
    public class DomainControllerTest : BaseTest
    {
        [TestMethod]
        public void TestFindCurrentDomainController()
        {
            using (DomainController domainController = DomainController.GetCurrent())
            {
                Assert.IsNotNull(domainController);
            }
        }

        [TestMethod]
        public void TestFindOneDomainController()
        {
            using (DomainController domainController = DomainController.FindOne())
            {
                Assert.IsNotNull(domainController);
                Assert.AreEqual(this.Configuration["DomainControllerName"], domainController.Name);
            }
        }

        [TestMethod]
        public void TestFindOneUser()
        {
            using (User user = User.FindOneByCN(this.Configuration["UserName"]))
            {
                Assert.IsNotNull(user);
            }
        }
    }
}
