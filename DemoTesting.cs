using HybridFramework.ComonUtilities;
using HybridFramework.Reusable_Functions.D365FO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HybridFramework.TestSuites
{
    [TestClass]
    public class DemoTesting :TestBase
    {       
        FO_ARPages arpage = new FO_ARPages();
        DemoPage demo = new DemoPage();
        FO_Reusable fO_Reusable = new FO_Reusable();

        [ClassInitialize]

        // login 
        public static void LoginFO(TestContext testContext)
        {
            FO_LoginPage.loginFO(FO_URL,FO_Username,FO_Password);
        }

        [TestMethod]
        public void CreateSalesOrder()
        {
            // Navigate to Sales Order 
            arpage.NavigateToAllSalesOrderPage();
            // Create SO 
            demo.SalesOrderCreation(fO_Reusable);
            // confirm SO 
           string salesValue =  arpage.ConfirmingSO(fO_Reusable);

        }
    }
}
