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
            string filter = "marketplace_ids:%7BEBAY_US%7D,date_range:%5B20161007..20161009%5D";
            string dimension = "LISTING";
            string metric = "LISTING_IMPRESSION_SEARCH_RESULTS_PAGE,LISTING_IMPRESSION_STORE,SALES_CONVERSION_RATE";
            string sort = "LISTING_IMPRESSION_STORE";
            GetTrafficReportResponse response = analyticsService.getAnalyticsService(filter, dimension, metric, sort).Result;
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

        [TestMethod]
        public void getSellerAnalytics()
            {
            AnalyticsService analyticsService = new AnalyticsService();
            getSellerStandardsProfileResponse getSellerStandards = new getSellerStandardsProfileResponse();
            getSellerStandards.program = EbaySdkLib.Enums.ProgramEnum.PROGRAM_DE;
            string cycle = "CURRENT";
            getSellerStandardsProfileResponse response = analyticsService.getSellerStandards(getSellerStandards, cycle).Result;
            Assert.IsNotNull(response);
            }

        }
    }
