using EbaySdkLib.Messages;
using EbaySdkLib.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
    {
    [TestClass]
    class CpmplianceAPIServiceTest
        {

        [TestMethod]
        public void getListingViolationsSummary()
            {
            ComplianceService complainceservice = new ComplianceService();

            string compliance_type = "PRODUCT_ADOPTION";
            // GetListingViolationsSummaryResponse response = complainceservice.getListingViolationsSummary(compliance_type).Result;
            var response = complainceservice.getListingViolationsSummary(compliance_type).Result;
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
            ComplianceService complainceservice = new ComplianceService();

            string compliance_type = EbaySdkLib.Enums.ComplianceTypeEnum.PRODUCT_ADOPTION.ToString();

            int offset = 0;
            string listing_id = "200008552419";
            int limit = 100;
            //GetListingViolationsResponse response = complainceservice.getListingViolations(compliance_type, offset, listing_id, limit).Result;
            var response = complainceservice.getListingViolations(compliance_type, offset, listing_id, limit).Result;
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
