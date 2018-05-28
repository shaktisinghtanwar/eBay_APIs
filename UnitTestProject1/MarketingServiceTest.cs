using EbaySdkLib.Messages;
using EbaySdkLib.Models;
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
    class marketingAPIService 
        {
        #region marketingApi/compaign
        [TestMethod]
        public void CloneMarketingTest()
            {
            MarketingAPIService marketingAPIService = new MarketingAPIService();
            EbaySdkLib.Messages.CloneCampaignRequest cloneCampaignRequest = new EbaySdkLib.Messages.CloneCampaignRequest();
            string campaign_id = "10001741014";
            cloneCampaignRequest.campaignName = "Fall Sale";
            string campaignName = cloneCampaignRequest.campaignName.ToString();
            cloneCampaignRequest.endDate = "2016-10-25T20:57:00.000Z";
            cloneCampaignRequest.fundingStrategy = new EbaySdkLib.Models.FundingStrategy()
            {
                bidPercentage = "15.0",
                fundingModel = EbaySdkLib.Enums.FundingModelEnum.COST_PER_SALE

            };
            cloneCampaignRequest.startDate = "2016-09-24T20:57:00.000Z";
            var response = marketingAPIService.CloneMarketing(cloneCampaignRequest, campaign_id).Result;
            Assert.IsNotNull(response);
            }

        [TestMethod]
        public void CreatemarketingTest()
            {
            MarketingAPIService marketingAPIService = new MarketingAPIService();
            EbaySdkLib.Messages.CreateCampaignRequest createCampaignRequest = new EbaySdkLib.Messages.CreateCampaignRequest();
            createCampaignRequest.campaignName = "Fall Sale";
            createCampaignRequest.fundingStrategy = new EbaySdkLib.Models.FundingStrategy()
            {
                bidPercentage = "10.0",
                fundingModel = EbaySdkLib.Enums.FundingModelEnum.COST_PER_SALE

            };
            createCampaignRequest.marketplaceId = EbaySdkLib.Models.MarketplaceIdEnum.EBAY_US;
            createCampaignRequest.startDate = "2016-09-24T20:57:00.000Z";
            var response = marketingAPIService.CreateMarketing(createCampaignRequest).Result;
            Assert.IsNotNull(response);
            }
        [TestMethod]
        public void DeleteMarketingTest()
            {
            MarketingAPIService marketingAPIService = new MarketingAPIService();
            string campaign_id = "10001741014";
            var response = marketingAPIService.DeleteMarketing(campaign_id).Result;
            Assert.IsNotNull(response);

            }
        [TestMethod]
        public void EndCampaignTest()
            {
            MarketingAPIService marketingAPIService = new MarketingAPIService();
            string campaign_id = "10001741014";
            var response = marketingAPIService.EndCampaign(campaign_id).Result;
            Assert.IsNotNull(response);

            }
        [TestMethod]
        public void GetCampaignTest()
            {
            MarketingAPIService marketingAPIService = new MarketingAPIService();
            string campaign_id = "10000176012";
            var response = marketingAPIService.GetCampaign(campaign_id).Result;
            Assert.IsNotNull(response);

            }
        [TestMethod]
        public void GetCampaignByNameTest()
            {
            MarketingAPIService marketingAPIService = new MarketingAPIService();
            string campaignName = "Summer Sale";
            var response = marketingAPIService.GetCampaignByNameRequest(campaignName).Result;
            Assert.IsNotNull(response);

            }
        [TestMethod]
        public void GetCampaignsTest()
            {
            MarketingAPIService marketingAPIService = new MarketingAPIService();
            string campaignName = "Fall Sale";
            string campaignStatus = "SCHEDULED";
            string startDate = "2016-09-25T02:20:00.000Z";
            string endDate = "2016-09-26T19:57:00.000Z";
            string limit = "10";
            string offset = "0";

            var response = marketingAPIService.GetCampaigns(campaignName, campaignStatus, startDate, endDate, limit, offset).Result;
            Assert.IsNotNull(response);

            }
        [TestMethod]
        public void PauseCampaignTest()
            {
            MarketingAPIService marketingAPIService = new MarketingAPIService();
            string campaign_id = "10005213014";
            var response = marketingAPIService.PauseCampaign(campaign_id).Result;
            Assert.IsNotNull(response);

            }
        [TestMethod]
        public void ResumeCampaignTest()
            {
            MarketingAPIService marketingAPIService = new MarketingAPIService();
            string campaign_id = "10005213014";
            var response = marketingAPIService.ResumeCampaign(campaign_id).Result;
            Assert.IsNotNull(response);

            }
        [TestMethod]
        public void UpdateCampaignIdentificationTest()
            {
            MarketingAPIService marketingAPIService = new MarketingAPIService();
            EbaySdkLib.Messages.UpdateCampaignIdentificationRequest updateCampaignIdentificationRequest = new EbaySdkLib.Messages.UpdateCampaignIdentificationRequest();
            string campaign_id = "10005213014";
            updateCampaignIdentificationRequest.campaignName = "Fall Sale II";
            updateCampaignIdentificationRequest.endDate = "2016-09-07T21:43:00.000Z";
            updateCampaignIdentificationRequest.startDate = null;
            var response = marketingAPIService.UpdateCampaignIdentification(updateCampaignIdentificationRequest, campaign_id).Result;
            Assert.IsNotNull(response);

            }


        #endregion
        #region marketingApi/Item_Promotion
        [TestMethod]
        public void CreateItemPromotionTest()
            {
            MarketingAPIService marketingAPIService = new MarketingAPIService();
            EbaySdkLib.Messages.CreateItemPromotionRequest createItemPromotionRequest = new EbaySdkLib.Messages.CreateItemPromotionRequest();
            createItemPromotionRequest.description = "Buy 1 and get 2nd one 25% off -part 6";
            createItemPromotionRequest.discountRules = new EbaySdkLib.Models.DiscountRule[]{
                new EbaySdkLib.Models.DiscountRule()
                    {
                   
                discountSpecification = new EbaySdkLib.Models.DiscountSpecification()
                        {
       
                         numberOfDiscountedItems =1,
                         forEachQuantity=1
                                         
                          },
                          ruleOrder=0,

                    discountBenefit=new EbaySdkLib.Models.DiscountBenefit()
                    {
                        percentageOffItem="25",

                    },
                  }
                
                };
            createItemPromotionRequest.name = "Buy 1 and get 2nd one 25% off -part 6";
            createItemPromotionRequest.startDate = "2017-03-11T19:58:18.918Z";
            createItemPromotionRequest.endDate = "2027-03-01T20:00:00.000Z";
            createItemPromotionRequest.marketplaceId = "EBAY-US";

            var response = marketingAPIService.CreateItemPromotion(createItemPromotionRequest).Result;
            Assert.IsNotNull(response);

            }
        [TestMethod]
        public void DeleteItemPromotionTest()
            {
            MarketingAPIService marketingAPIService = new MarketingAPIService();
            string promotion_id = "115001954505@EBAY-US";
            var response = marketingAPIService.DeleteItemPromotion(promotion_id).Result;
            Assert.IsNotNull(response);
            }







        #endregion

        #region Lodhiwork
        [TestMethod]
        public void bulkCreateAdsByInventory()
            {
            MarketingAPIService marketingAPIService = new MarketingAPIService();
            bulkCreateAdsByInventoryReferenceRequest bulkCreateAds = new bulkCreateAdsByInventoryReferenceRequest();
            bulkCreateAds.inventoryReferenceId = "66352443";
            bulkCreateAds.inventoryReferenceType = "INVENTORY_ITEM";
            string campaign_id = "10001741014";
            string bulk_create_ads = "bulk_create_ads_by_inventory_reference";
            bulkCreateAdsByInventoryReferenceRequest response = marketingAPIService .bulkCreateAdsByInventory(bulkCreateAds, campaign_id, bulk_create_ads).Result;

            Assert.IsNotNull(response.statusCode);
            }
        [TestMethod]
        public void bulkCreateAdsByListingId()
            {
            MarketingAPIService marketingAPIService = new MarketingAPIService();
            bulkCreateAdsByInventoryReferenceRequest bulkCreateAds = new bulkCreateAdsByInventoryReferenceRequest();
            bulkCreateAds.inventoryReferenceId = "66352443";
            bulkCreateAds.inventoryReferenceType = "INVENTORY_ITEM";
            string campaign_id = "10001741014";
            string bulk_create_ads_by_listing = "bulk_create_ads_by_listing_id";
            bulkCreateAdsByInventoryReferenceRequest response = marketingAPIService .bulkCreateAdsByListingId(bulkCreateAds, campaign_id, bulk_create_ads_by_listing).Result;
            Assert.IsNotNull(response);
            }
        [TestMethod]
        public void bulkDeleteAdsByInventoryReference()
            {
            MarketingAPIService marketingAPIService = new MarketingAPIService();
            bulkCreateAdsByInventoryReferenceRequest bulkCreateAds = new bulkCreateAdsByInventoryReferenceRequest();
            bulkCreateAds.inventoryReferenceId = "66352443";
            bulkCreateAds.inventoryReferenceType = "INVENTORY_ITEM";
            string campaign_id = "10001741014";
            string bulk_delete_ads_by_inventory = "bulk_delete_ads_by_inventory_reference";
            bulkCreateAdsByInventoryReferenceRequest response = marketingAPIService .bulkDeleteAdsByInventoryReference(bulkCreateAds, campaign_id, bulk_delete_ads_by_inventory).Result;
            Assert.IsNotNull(response);
            }
        [TestMethod]
        public void bulkDeleteAdsByListingId()
            {
            MarketingAPIService marketingAPIService = new MarketingAPIService();
            bulkCreateAdsByInventoryReferenceRequest bulkDeleteAd = new bulkCreateAdsByInventoryReferenceRequest();
            bulkDeleteAd.inventoryReferenceId = "66352443";
            bulkDeleteAd.inventoryReferenceType = "INVENTORY_ITEM";
            string campaign_id = "10001741014";
            string bulkDeleteAdsByListingId = "bulk_delete_ads_by_listing_id";
            bulkCreateAdsByInventoryReferenceRequest response = marketingAPIService .bulkDeleteAdsByListingId(bulkDeleteAd, campaign_id, bulkDeleteAdsByListingId).Result;
            Assert.IsNotNull(response);
            }
        [TestMethod]
        public void bulkUpdateAdsBidByInventoryReference()
            {
            MarketingAPIService marketingAPIService = new MarketingAPIService();
            bulkCreateAdsByInventoryReferenceRequest bulkUpdateAds = new bulkCreateAdsByInventoryReferenceRequest();
            bulkUpdateAds.inventoryReferenceId = "2343212";
            bulkUpdateAds.inventoryReferenceType = "INVENTORY_ITEM";
            string campaign_id = "10001741014";
            string bulk_update_ads = "bulk_update_ads_bid_by_inventory_reference";
            bulkCreateAdsByInventoryReferenceRequest response = marketingAPIService .bulkUpdateAdsBidByInventoryReference(bulkUpdateAds, campaign_id, bulk_update_ads).Result;
            Assert.IsNotNull(response);
            }
        [TestMethod]
        public void bulkUpdateAdsBidByListingId()
            {
            MarketingAPIService marketingAPIService = new MarketingAPIService();
            bulkCreateAdsByInventoryReferenceRequest bulkUpdateAds = new bulkCreateAdsByInventoryReferenceRequest();
            bulkUpdateAds.listingId = "190007022519";
            string campaign_id = "10001741014";
            string bulk_update_ads_by_listing = "bulk_update_ads_bid_by_listing_id";
            bulkCreateAdsByInventoryReferenceRequest response = marketingAPIService .bulkUpdateAdsBidByListingId(bulkUpdateAds, campaign_id, bulk_update_ads_by_listing).Result;
            Assert.IsNotNull(response);
            }
        [TestMethod]
        public void createAdByListingId()
            {
            MarketingAPIService marketingAPIService = new MarketingAPIService();
            bulkCreateAdsByInventoryReferenceRequest createAdByListing = new bulkCreateAdsByInventoryReferenceRequest();
            createAdByListing.listingId = "190007022519";
            createAdByListing.bidPercentage = "10";
            string campaign_id = "10001741014";
            string createAd = "ad";
            var response = marketingAPIService .createAdByListingId(createAdByListing, campaign_id, createAd).Result;
            Assert.IsNotNull(response);
            }
        [TestMethod]
        public void createAdsByInventoryReference()
            {
            MarketingAPIService marketingAPIService = new MarketingAPIService();
            bulkCreateAdsByInventoryReferenceRequest createAdsByInventoryReference = new bulkCreateAdsByInventoryReferenceRequest();
            createAdsByInventoryReference.bidPercentage = "10";
            createAdsByInventoryReference.inventoryReferenceId = "87536492";
            createAdsByInventoryReference.inventoryReferenceType = "INVENTORY_ITEM";
            string campaign_id = "10001741014";
            string create_ads_by_inventory = "create_ads_by_inventory_reference";
            bulkCreateAdsByInventoryReferenceRequest response = marketingAPIService .createAdsByInventoryReference(createAdsByInventoryReference, campaign_id, create_ads_by_inventory).Result;
            Assert.IsNotNull(response);
            }
        [TestMethod]
        public void deleteAd()
            {
            MarketingAPIService marketingAPIService = new MarketingAPIService();
            bulkCreateAdsByInventoryReferenceRequest deleteAd = new bulkCreateAdsByInventoryReferenceRequest();
            //deleteAd.bidPercentage = "10";
            //deleteAd.inventoryReferenceId = "87536492";
            //deleteAd.inventoryReferenceType = "INVENTORY_ITEM";
            string campaign_id = "10001741014";
            string deletead = "ad";
            string addid = "12428546014";
            bulkCreateAdsByInventoryReferenceRequest response = marketingAPIService .deleteAd(deleteAd, campaign_id, deletead, addid).Result;
            Assert.IsNotNull(response);
            }
        [TestMethod]
        public void deleteAdsByInventoryReference()
            {
            MarketingAPIService marketingAPIService = new MarketingAPIService();
            bulkCreateAdsByInventoryReferenceRequest deleteAdsByInventoryReference = new bulkCreateAdsByInventoryReferenceRequest();
            deleteAdsByInventoryReference.inventoryReferenceId = "133232";
            deleteAdsByInventoryReference.inventoryReferenceType = "INVENTORY_ITEM";
            string campaign_id = "10001741014";
            string delete_ads = "delete_ads_by_inventory_reference";
            bulkCreateAdsByInventoryReferenceRequest response = marketingAPIService .deleteAdsByInventoryReference(deleteAdsByInventoryReference, campaign_id, delete_ads).Result;
            Assert.IsNotNull(response);
            }
        [TestMethod]
        public void getAd()
            {

            MarketingAPIService marketingAPIService = new MarketingAPIService();
            bulkCreateAdsByInventoryReferenceRequest getAd = new bulkCreateAdsByInventoryReferenceRequest();
            string campaign_id = "10001741014";
            string ad = "ad";
            string adId = "12427947014";
            bulkCreateAdsByInventoryReferenceRequest response = marketingAPIService .getAd(getAd, campaign_id, ad, adId).Result;
            Assert.IsNotNull(response);
            }
        [TestMethod]
        public void getAds()
            {
            MarketingAPIService marketingAPIService = new MarketingAPIService();
            //GetAdsResponse getAds = new GetAdsResponse();
            //getAds.ads = new EbaySdkLib.Models.Ad[] { new EbaySdkLib.Models.Ad() {listingId= "190007022518" } };
            //getAds.limit = "10";
            //getAds.offset = "0";
            string campaign_id = "10001741014";
            string ad = "ad";
            GetAdsResponse response = marketingAPIService .getAds(campaign_id, ad).Result;
            Assert.IsNotNull(response);
            }
        [TestMethod]
        public void getAdsByInventoryReference()
            {
            MarketingAPIService marketingAPIService = new MarketingAPIService();
            bulkCreateAdsByInventoryReferenceRequest getAdsByInventoryReference = new bulkCreateAdsByInventoryReferenceRequest();
            getAdsByInventoryReference.inventoryReferenceType = "INVENTORY_ITEM";
            getAdsByInventoryReference.inventoryReferenceId = "133232";
            string campaign_id = "10001741014";
            string getads = "get_ads_by_inventory_reference?";
            bulkCreateAdsByInventoryReferenceRequest response = marketingAPIService .getAdsByInventoryReference(getAdsByInventoryReference, campaign_id, getads).Result;
            Assert.IsNotNull(response);
            }
        [TestMethod]
        public void updateBid()
            {
            MarketingAPIService marketingAPIService = new MarketingAPIService();
            bulkCreateAdsByInventoryReferenceRequest updateBid = new bulkCreateAdsByInventoryReferenceRequest();
            updateBid.bidPercentage = "11";
            string campaign_id = "10001741014";
            string updatead = "ad";
            string adId = "12427947014";
            string update_bid = "update_bid";
            bulkCreateAdsByInventoryReferenceRequest response = marketingAPIService .updateBid(updateBid, campaign_id, updatead, adId, update_bid).Result;
            Assert.IsNotNull(response);
            }
        [TestMethod]
        public void getReport()
            {
            MarketingAPIService marketingAPIService = new MarketingAPIService();
            string reportiId = "10000049014";
            var response = marketingAPIService .getReport(reportiId).Result;
            Assert.IsNotNull(response);
            }
        [TestMethod]
        public void getReportMetadata()
            {
            MarketingAPIService marketingAPIService = new MarketingAPIService();
            GetReportMetadataResponse response = marketingAPIService .getReportMetadata().Result;
            Assert.IsNotNull(response);
            }
        [TestMethod]
        public void getReportMetadataForReportType()
            {
            MarketingAPIService marketingAPIService = new MarketingAPIService();
            GetReportMetadataResponse GetReportMetadata = new GetReportMetadataResponse();
            GetReportMetadata.reportType = "ACCOUNT_PERFORMANCE_REPORT";
            GetReportMetadataResponse response = marketingAPIService .getReportMetadataForReportType(GetReportMetadata).Result;
            Assert.IsNotNull(response);
            }
        [TestMethod]
        public void createReportTask()
            {
            MarketingAPIService marketingAPIService = new MarketingAPIService();
            CreateReportTaskRequest createReportTask = new CreateReportTaskRequest();
            string[] metricKeys = new string[] { "CLICKS" };
            string[] annotationKeys = new string[] { "campaign_name", "campaign_start_date", "campaign_end_date" };

            createReportTask.reportType = EbaySdkLib.Enums.ReportTypeEnum.CAMPAIGN_PERFORMANCE_REPORT;
            createReportTask.dateTo = "yyyy-MM-ddThh:mm.ss.sssZ";
            //createReportTask.metricKeys = metricKeys;
            //createReportTask.dimensions = new Dimension(new string[]{ "Darth", "Vader" }).dimensionKey("Luke"); 
            CreateReportTaskRequest response = marketingAPIService .createReportTask(createReportTask).Result;
            Assert.IsNotNull(response);
            }
        [TestMethod]
        public void deleteReportTask()
            {
            MarketingAPIService marketingAPIService = new MarketingAPIService();
            string reportTaskId = "10000056014";
            CreateReportTaskRequest response = marketingAPIService .deleteReportTask(reportTaskId).Result;
            Assert.IsNotNull(response);
            }
        [TestMethod]
        public void getReportTask()
            {
            MarketingAPIService marketingAPIService = new MarketingAPIService();
            string reportTaskId = "10000049014";
            CreateReportTaskRequest response = marketingAPIService .getReportTask(reportTaskId).Result;
            Assert.IsNotNull(response);
            }
        [TestMethod]
        public void getReportTasks()
            {
            MarketingAPIService marketingAPIService = new MarketingAPIService();
            CreateReportTaskRequest reporttask = new CreateReportTaskRequest();

            string reportTaskstatus = "PENDING,SUCCESS";
            string limit = "10";
            CreateReportTaskRequest response = marketingAPIService .getReportTasks(reportTaskstatus, limit).Result;
            Assert.IsNotNull(response);
            }
        #endregion
        }
    }
