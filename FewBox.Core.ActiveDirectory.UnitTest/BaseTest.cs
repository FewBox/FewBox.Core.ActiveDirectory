using System.IO;
using FewBox.Core.ActiveDirectory.Authentication;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FewBox.Core.ActiveDirectory.TestSuite
{
    public abstract class BaseTest
    {
        protected IConfiguration Configuration;
        [TestInitialize]
        public void SetUp()
        {
            this.Configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false)
            .Build();
            ClientContext.Init(this.Configuration["LdapPath"], this.Configuration["Username"], this.Configuration["Password"]);
        }
    }
}
