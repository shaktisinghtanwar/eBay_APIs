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
    class MetadataSericeTest
        {
        #region MetadataApi
        [TestMethod]
        public void getSalesTaxJurisdictions()
            {
            MetadataAPIService metadataAPIService = new MetadataAPIService();
            string countrycode = EbaySdkLib.Enums.CountryCodeEnum.CA.ToString();
            var response = metadataAPIService.getSalesTaxJurisdictionsService(countrycode).Result;
            Assert.IsNotNull(response);
            Assert.Fail();
            }
        [TestMethod]
        public void getAutomotivePartsCompatibilityPolicies()
            {
            MetadataAPIService metadataAPIService = new MetadataAPIService();
            string marketPlaceId = EbaySdkLib.Models.MarketplaceIdEnum.EBAY_MOTORS_US.ToString();

            string filter = System.Net.WebUtility.UrlEncode("80740|33548");
            var response = metadataAPIService.getAutomotivePartsCompatibilityService(marketPlaceId, filter).Result;
            Assert.IsNotNull(response);
            Assert.Fail();
            }
        [TestMethod]
        public void getItemConditionPolicies()
            {
            MetadataAPIService metadataAPIService = new MetadataAPIService();
            string marketPlaceId = EbaySdkLib.Models.MarketplaceIdEnum.EBAY_US.ToString();

            string filter = System.Net.WebUtility.UrlEncode("80740|33548");
            var response = metadataAPIService.getItemConditionPoliciesService(marketPlaceId, filter).Result;
            Assert.IsNotNull(response);
            Assert.Fail();
            }

        [TestMethod]
        public void GetListingStructurePolicies()
            {
            MetadataAPIService metadataAPIService = new MetadataAPIService();
            string marketPlaceId = EbaySdkLib.Models.MarketplaceIdEnum.EBAY_US.ToString();

            string filter = System.Net.WebUtility.UrlEncode("75592|90638");
            var response = metadataAPIService.GetListingStructurePoliciesService(marketPlaceId, filter).Result;
            Assert.IsNotNull(response);
            Assert.Fail();
            }
        [TestMethod]
        public void getNegotiatedPricePolicies()
            {
            MetadataAPIService metadataAPIService = new MetadataAPIService();
            string marketPlaceId = EbaySdkLib.Models.MarketplaceIdEnum.EBAY_US.ToString();

            string filter = System.Net.WebUtility.UrlEncode("75592|90638");
            var response = metadataAPIService.getNegotiatedPricePoliciesService(marketPlaceId, filter).Result;
            Assert.IsNotNull(response);
            Assert.Fail();
            }
        [TestMethod]
        public void getProductAdoptionPolicies()
            {
            MetadataAPIService metadataAPIService = new MetadataAPIService();
            string marketPlaceId = EbaySdkLib.Models.MarketplaceIdEnum.EBAY_US.ToString();

            string filter = System.Net.WebUtility.UrlEncode("75592|90638");
            var response = metadataAPIService.getProductAdoptionPoliciesService(marketPlaceId, filter).Result;
            Assert.IsNotNull(response);
            Assert.Fail();
            }
        [TestMethod]
        public void getReurnPoliciesMetadata()
            {
            MetadataAPIService metadataAPIService = new MetadataAPIService();
            string marketPlaceId = EbaySdkLib.Models.MarketplaceIdEnum.EBAY_US.ToString();

            string filter = System.Net.WebUtility.UrlEncode("80740|33548");
            var response = metadataAPIService.metadataGetreturnPolicyService(marketPlaceId, filter).Result;
            Assert.IsNotNull(response);
            Assert.Fail();
            }

        #endregion
        }
    }
