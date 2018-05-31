using EbaySdkLib.Messages;
using EbaySdkLib.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
    {

    [TestClass]
    class CpmplianceAPIServiceTest
        {
        ComplianceService _complianceService;
        public string Token { get; set; }
        [TestInitialize]
        public void Setup()
            {
        Token = ConfigurationManager.AppSettings["token"];
        _complianceService = new ComplianceService(Token);

            }

        [TestMethod]
        public void getListingViolationsSummary()
            {
            string compliance_type = "PRODUCT_ADOPTION";
            // GetListingViolationsSummaryResponse response = complainceservice.getListingViolationsSummary(compliance_type).Result;
            var response = _complianceService.getListingViolationsSummary(compliance_type).Result;
            if (response.Item2.ToString() == "OK")
                {
                Assert.IsNotNull(response.Item1);
                }
            else
                {
                Assert.Fail(response.Item2.ToString());
                }
            }

        [TestMethod]
        public void getListingViolations()
            {
            

            string compliance_type = EbaySdkLib.Enums.ComplianceTypeEnum.PRODUCT_ADOPTION.ToString();

            int offset = 0;
            string listing_id = "200008552419";
            int limit = 100;
            //GetListingViolationsResponse response = complainceservice.getListingViolations(compliance_type, offset, listing_id, limit).Result;
            var response = _complianceService.getListingViolations(compliance_type, offset, listing_id, limit).Result;
            if (response.Item2.ToString() == "OK")
                {
                Assert.IsNotNull(response.Item1);
                }
            else
                {
                Assert.Fail(response.Item2.ToString());
                }
            }

        }
    }
