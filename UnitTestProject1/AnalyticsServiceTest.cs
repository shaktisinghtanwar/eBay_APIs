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
    class AnalyticsServiceTest
        {
        [TestMethod]
        public void getTrafficreport()
            {
            AnalyticsService analyticsService = new AnalyticsService();
            string marketPlaceId = EbaySdkLib.Models.MarketplaceIdEnum.EBAY_US.ToString();
            string metric = "LISTING_IMPRESSION_SEARCH_RESULTS_PAGE,LISTING_IMPRESSION_STORE,SALES_CONVERSION_RATE";
            GetTrafficReportResponse response = analyticsService.getAnalyticsService(marketPlaceId, metric).Result;
            Assert.IsNotNull(response);
            }

        [TestMethod]
        public void findSellerStandardsProfile()
            {
            AnalyticsService analyticsService = new AnalyticsService();
            //Return status is 200, but there is issue in response
            FindSellerStandardsProfilesResponse response = analyticsService.findSellerStandardsProfilesResponseAnalyticsService().Result;
            Assert.IsNotNull(response);
            }

        }
    }
