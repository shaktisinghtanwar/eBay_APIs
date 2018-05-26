using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web;
using EbaySdkLib;
using EbaySdkLib.Models;
using EbaySdkLib.Messages;
using EbaySdkLib.Enums;

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
            createFulfillmentRequest.categoryTypes = new CategoryType[] {new CategoryType(){name = CategoryTypeEnum.ALL_EXCLUDING_MOTORS_VEHICLES }};
            createFulfillmentRequest.marketplaceId = MarketplaceIdEnum.EBAY_US;
            createFulfillmentRequest.name = "Domestic free shipping";
            createFulfillmentRequest.handlingTime = new TimeDuration() {
                value = "1",
                unit = TimeDurationUnitEnum.DAY
            };
            createFulfillmentRequest.shippingOptions = new ShippingOption[]{
                new ShippingOption()
                {
                    costType= ShippingCostTypeEnum.FLAT_RATE,
            optionType=ShippingOptionTypeEnum.DOMESTIC,
            shippingServices = new ShippingService[]{ new ShippingService()
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
            createFulfillmentRequest.marketplaceId = MarketplaceIdEnum.EBAY_US;
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
            getpaymentpoliciesRequest.marketplaceId = MarketplaceIdEnum.EBAY_US;
            string Id = getpaymentpoliciesRequest.marketplaceId.ToString();
            GetPaymentpoliciesResponse response = accountService.PaymentpolicyService.getPaymentpoliciesService(Id).Result;
            Assert.IsNotNull(response);
            }


        [TestMethod]
        public void getPaymentPolicyByName()
            {
            AccountService accountService = new AccountService();
            GetPaymentPolicyByNameRequest getPaymentPolicyByNameRequest = new GetPaymentPolicyByNameRequest();
            getPaymentPolicyByNameRequest.name = "default payment policy";
            getPaymentPolicyByNameRequest.marketplaceId = MarketplaceIdEnum.EBAY_US;
            string marketplaceId = getPaymentPolicyByNameRequest.marketplaceId.ToString();
            string name = getPaymentPolicyByNameRequest.name;
            GetPaymentpolicyByNameresponse response = accountService.PaymentpolicyService.getPaymentPolicyByNameService(name, marketplaceId).Result;
            Assert.IsNotNull(response);
            }
    }
}
