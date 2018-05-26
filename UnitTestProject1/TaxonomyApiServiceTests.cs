using EbaySdkLib;
using EbaySdkLib.Enums;
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
    public class TaxonomyApiServiceTests
    {
        [TestMethod]
        public void GetDefaultCategoryTreeIdTest()
        {
            TaxonomyApiService taxonomyApiService = new TaxonomyApiService();
            var request = new GetDefaultCategoryTreeIdRequest();
            request.marketplace_id = MarketplaceIdEnum.EBAY_US;
            string Id = request.marketplace_id.ToString();
            GetDefaultCategoryTreeIdResponse response = taxonomyApiService.GetDefaultCategoryTreeId(request).Result;
            Assert.IsNotNull(response);
        }

        [TestMethod]
        public void GetItemAspectsForCategoryTest()
        {
            TaxonomyApiService taxonomyApiService = new TaxonomyApiService();
            var request = new GetItemAspectsForCategoryRequest();
            request.category_id = "";
            request.category_tree_id = "";
            var response = taxonomyApiService.GetItemAspectsForCategory(request).Result;
            Assert.IsNotNull(response);
        }
    }
}
