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
    class MarketingServiceTest
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
        }
    }
