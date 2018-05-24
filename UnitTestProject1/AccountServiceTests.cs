using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web;
using EbaySdkLib;
using EbaySdkLib.Models;
using EbaySdkLib.Messages;

namespace UnitTestProject1
{
    [TestClass]
    public class AccountServiceTests
    {
        [TestMethod]
        [Priority(1)]
        public void DeleteFulfillmentPolicyTest()
        {
            AccountService accountService = new AccountService();

           CreateFulfillmentRequest createFulfillmentRequest = new CreateFulfillmentRequest();
            createFulfillmentRequest.categoryTypes = new EbaySdkLib.Models.CategoryType[] {new EbaySdkLib.Models.CategoryType(){name = CategoryTypeEnum.ALL_EXCLUDING_MOTORS_VEHICLES }};
            createFulfillmentRequest.marketplaceId = EbaySdkLib.Models.MarketplaceIdEnum.EBAY_US;
            createFulfillmentRequest.name = "Domestic free shipping";
            createFulfillmentRequest.handlingTime = new EbaySdkLib.Models.TimeDuration() {
                value = "1",
                unit = EbaySdkLib.Models.TimeDurationUnitEnum.DAY
            };
            createFulfillmentRequest.shippingOptions = new EbaySdkLib.Models.ShippingOption[]{
                new EbaySdkLib.Models.ShippingOption()
                {
                    costType= EbaySdkLib.Models.ShippingCostTypeEnum.FLAT_RATE,
            optionType=EbaySdkLib.Models.ShippingOptionTypeEnum.DOMESTIC,
            shippingServices = new EbaySdkLib.Models.ShippingService[]{ new EbaySdkLib.Models.ShippingService()
                {
                    buyerResponsibleForShipping= "false",
                    freeShipping= "true",
                    shippingCarrierCode="USPS",
                    shippingServiceCode="USPSPriorityFlatRateBox"
                } }
                }
            };
            
            var response = accountService.FulfilmentPolicyService.CreateFulfillmentPolicy(createFulfillmentRequest).Result;

            Assert.IsNotNull(response);
          //  Assert.AreEqual(response.,);
        }

     
        [TestMethod]
        public void GetFulfilmentPolicies()
        {
            AccountService accountService = new AccountService();
            EbaySdkLib.Messages.GetFulfilmentPoliciesRequest createFulfillmentRequest = new EbaySdkLib.Messages.GetFulfilmentPoliciesRequest();
            createFulfillmentRequest.marketplaceId = EbaySdkLib.Models.MarketplaceIdEnum.EBAY_US;
            string Id = createFulfillmentRequest.marketplaceId.ToString();
            GetFulfilmentPoliciesResponse response = accountService.FulfilmentPolicyService.GetFulfilmentPolicies(Id).Result;
            Assert.IsNotNull(response);
        }

        [TestMethod]
        public void getPaymentPolicy()
            {
            AccountService accountService = new AccountService();
            EbaySdkLib.Messages.GetPaymentpolicyRequest getPaymentpolicy = new EbaySdkLib.Messages.GetPaymentpolicyRequest();
            getPaymentpolicy.payment_policy_id = "5486492000";
            string Id = getPaymentpolicy.payment_policy_id.ToString();
            GetPaymentpolicyresponse response = accountService.PaymentpolicyService.getPaymentpolicyService(Id).Result;
            Assert.IsNotNull(response);
            }

        [TestMethod]
        public void getPaymentPolicies()
            {
            AccountService accountService = new AccountService();
            EbaySdkLib.Messages.GetpaymentpoliciesRequest getpaymentpoliciesRequest = new EbaySdkLib.Messages.GetpaymentpoliciesRequest();
            getpaymentpoliciesRequest.marketplaceId = EbaySdkLib.Models.MarketplaceIdEnum.EBAY_US;
            string Id = getpaymentpoliciesRequest.marketplaceId.ToString();
            GetPaymentpoliciesResponse response = accountService.PaymentpolicyService.getPaymentpoliciesService(Id).Result;
            Assert.IsNotNull(response);
            }


        [TestMethod]
        public void getPaymentPolicyByName()
            {
            AccountService accountService = new AccountService();
            EbaySdkLib.Messages.GetPaymentPolicyByNameRequest getPaymentPolicyByNameRequest = new EbaySdkLib.Messages.GetPaymentPolicyByNameRequest();
            getPaymentPolicyByNameRequest.name = "default payment policy";
            getPaymentPolicyByNameRequest.marketplaceId = EbaySdkLib.Models.MarketplaceIdEnum.EBAY_US;
            string marketplaceId = getPaymentPolicyByNameRequest.marketplaceId.ToString();
            string name = getPaymentPolicyByNameRequest.name;
            GetPaymentpolicyByNameresponse response = accountService.PaymentpolicyService.getPaymentPolicyByNameService(name, marketplaceId).Result;
            Assert.IsNotNull(response);
            }
    }
}
