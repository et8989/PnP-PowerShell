using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Management.Automation.Runspaces;

namespace PnP.PowerShell.Tests.InformationManagement
{
    [TestClass]
    public class GetLabelTests
    {
        #region Test Setup/CleanUp
        [ClassInitialize]
        public static void Initialize(TestContext testContext)
        {
            // This runs on class level once before all tests run
            //using (var ctx = TestCommon.CreateClientContext())
            //{
            //}
        }

        [ClassCleanup]
        public static void Cleanup(TestContext testContext)
        {
            // This runs on class level once
            //using (var ctx = TestCommon.CreateClientContext())
            //{
            //}
        }

        [TestInitialize]
        public void Initialize()
        {
            using (var scope = new PSTestScope())
            {
                // Example
                // scope.ExecuteCommand("cmdlet", new CommandParameter("param1", prop));
            }
        }

        [TestCleanup]
        public void Cleanup()
        {
            using (var scope = new PSTestScope())
            {
                try
                {
                    // Do Test Setup - Note, this runs PER test
                }
                catch (Exception)
                {
                    // Describe Exception
                }
            }
        }
        #endregion

        #region Scaffolded Cmdlet Tests
        //TODO: This is a scaffold of the cmdlet - complete the unit test
        //[TestMethod]
        public void GetPnPLabelTest()
        {
            using (var scope = new PSTestScope(true))
            {
                // Complete writing cmd parameters

				// This is a mandatory parameter
				// From Cmdlet Help: The ID or Url of the list
				var list = "";
				// From Cmdlet Help: If provided, the results will be returned as values instead of in written text and will include more detailed information
				var valuesOnly = "";

                var results = scope.ExecuteCommand("Get-PnPLabel",
					new CommandParameter("List", list),
					new CommandParameter("ValuesOnly", valuesOnly));
                
                Assert.IsNotNull(results);
            }
        }
        #endregion
    }
}
            