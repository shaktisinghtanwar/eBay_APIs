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
    class CommerceCatalogApiTest
        {
        [TestMethod]
        public void getProductResponseTest()
            {
            CatalogService catalogceservice = new CatalogService();

            string epid = "232669172";
            var response = catalogceservice.getProductResponse(epid).Result;
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
        public void productSummarySearchResponse()
            {
            CatalogService catalogceservice = new CatalogService();

            string q = "232669172";
            //GetProductResponse response = catalogceservice.productSummarySearchResponse(q).Result;
            var response = catalogceservice.productSummarySearchResponse(q).Result;
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
        public void getProductMetadataResponse()
            {
            CatalogService catalogceservice = new CatalogService();

            string epid = "242755377";
            var response = catalogceservice.productSummarySearchResponse(epid).Result;
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
        public void getProductMetadataForCategoriesResponse()
            {
            CatalogService catalogceservice = new CatalogService();

            string primary_category_id = "500";
            var response = catalogceservice.getProductMetadataForCategoriesResponse(primary_category_id).Result;
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
        public void getChangeRequestResponse()
            {
            CatalogService catalogceservice = new CatalogService();

            string change_request_id = "5ac3cf22ca4c591b0c324749";
            var response = catalogceservice.getChangeRequestResponse(change_request_id).Result;
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
        public void getChangeRequestsResponse()
            {
            CatalogService catalogceservice = new CatalogService();

            var response = catalogceservice.getChangeRequestsResponse().Result;
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
        public void createChangeRequestsResponse()
            {
            CatalogService catalogceservice = new CatalogService();
            CreateChangeRequest changerequest = new CreateChangeRequest();
            changerequest.changeRequestType = EbaySdkLib.Enums.ChangeRequestTypeEnum.PRODUCT_UPDATE;
            changerequest.suggestedProduct = new SuggestedProduct()
            {
                primaryCategoryId = "9355"
            };
            var response = catalogceservice.createChangeRequestService(changerequest).Result;
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
