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
            createFulfillmentRequest.categoryTypes = new EbaySdkLib.Models.CategoryType[] { new EbaySdkLib.Models.CategoryType() { name = CategoryTypeEnum.ALL_EXCLUDING_MOTORS_VEHICLES } };
            createFulfillmentRequest.marketplaceId = EbaySdkLib.Models.MarketplaceIdEnum.EBAY_US;
            createFulfillmentRequest.name = "Domestic free shipping";
            createFulfillmentRequest.handlingTime = new EbaySdkLib.Models.TimeDuration()
            {
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

        [TestMethod]
        public void createPaymentPolicy()
            {
            AccountService accountService = new AccountService();
            EbaySdkLib.Messages.CreatePaymerntPolicyRequest createPaymerntPolicyRequest = new EbaySdkLib.Messages.CreatePaymerntPolicyRequest();
            createPaymerntPolicyRequest.categoryTypes = new EbaySdkLib.Models.CategoryType[] { new EbaySdkLib.Models.CategoryType() { name = CategoryTypeEnum.ALL_EXCLUDING_MOTORS_VEHICLES } };
            createPaymerntPolicyRequest.name = "minimal Payment Policy";
            createPaymerntPolicyRequest.paymentMethods = new EbaySdkLib.Models.PaymentMethod[] { new EbaySdkLib.Models.PaymentMethod() { paymentMethodType = PaymentMethodTypeEnum.PERSONAL_CHECK } };


            Createpaymentpolicyresponse response = accountService.PaymentpolicyService.createPaymentPolicyService(createPaymerntPolicyRequest).Result;
            Assert.IsNotNull(response);
            }

        [TestMethod]
        public void updatepaymentPolicy()
            {
            AccountService accountService = new AccountService();
            EbaySdkLib.Messages.updatePaymentPolicyRequest updatePaymentPolicyrequest = new EbaySdkLib.Messages.updatePaymentPolicyRequest();
            updatePaymentPolicyrequest.categoryTypes = new EbaySdkLib.Models.CategoryType[] { new EbaySdkLib.Models.CategoryType() { name = CategoryTypeEnum.ALL_EXCLUDING_MOTORS_VEHICLES } };
            updatePaymentPolicyrequest.description = "Standard payment policy, PP & CC payments";
            updatePaymentPolicyrequest.name = "default payment policy";
            updatePaymentPolicyrequest.paymentMethods = new EbaySdkLib.Models.PaymentMethod[] { new EbaySdkLib.Models.PaymentMethod() { paymentMethodType = PaymentMethodTypeEnum.PERSONAL_CHECK } };
            string policyId = "5458323000";
            updatePaymentPolicyResponse response = accountService.PaymentpolicyService.updatePaymentPolicyService(updatePaymentPolicyrequest, policyId).Result;
            Assert.IsNotNull(response);
            }


        [TestMethod]
        public void deletePaymentpolicy()
            {
            AccountService accountService = new AccountService();
            string payment_policy_id = "5446270000";
            var response = accountService.PaymentpolicyService.deleteReturnPolicyService(payment_policy_id).Result;

            }

        /// Rate-tables
        ///Response is null but status code=200.
        [TestMethod]
        public void getrateTables()
            {
            AccountService accountService = new AccountService();
            //EbaySdkLib.Messages.GetRateTablesRequest geteRatetable = new EbaySdkLib.Messages.GetRateTablesRequest();
            var ratetables = new EbaySdkLib.Models.RateTable()
            {
                countryCode = EbaySdkLib.Enums.CountryCodeEnum.US
            };
            GetRateTablesResponse response = accountService.PaymentpolicyService.getratePolicyService(ratetables).Result;

            }
        /// <summary>
        ///  Return policy starts
        /// </summary>
        [TestMethod]
        public void getReturnPolicy()
            {
            AccountService accountService = new AccountService();
            string return_policy_id = "5458323000";
            GetReturnPolicyResponse response = accountService.ReturnPolicyService.getReturnPolicy(return_policy_id).Result;
            Assert.IsNotNull(response);
            }

        [TestMethod]
        public void getReturnPolicies()
            {
            AccountService accountService = new AccountService();
            GetReturnPoliciesRequest getReturnPoliciesRequest = new GetReturnPoliciesRequest();
            getReturnPoliciesRequest.marketplaceId = EbaySdkLib.Models.MarketplaceIdEnum.EBAY_US;
            string marketplaceId = getReturnPoliciesRequest.marketplaceId.ToString();
            GetReturnPoliciesResponse response = accountService.ReturnPolicyService.getReturnPolicies(marketplaceId).Result;
            Assert.IsNotNull(response);
            }

        [TestMethod]
        public void getReturnPoliciesByName()
            {
            AccountService accountService = new AccountService();
            GetReturnPolicyByNameRequest getReturnPolicyByNameRequest = new GetReturnPolicyByNameRequest();
            getReturnPolicyByNameRequest.marketplaceId = EbaySdkLib.Models.MarketplaceIdEnum.EBAY_US;
            getReturnPolicyByNameRequest.name = "minimal return policy, US marketplace";
            string marketplaceId = getReturnPolicyByNameRequest.marketplaceId.ToString();
            string name = getReturnPolicyByNameRequest.name.ToString();
            GetReturnPolicyByNameResponse response = accountService.ReturnPolicyService.getReturnPoliciesByName(marketplaceId, name).Result;
            Assert.IsNotNull(response);
            }
        /// <summary>
        /// Invalid return error
        /// </summary>
        [TestMethod]
        public void createReturnPolicy()
            {
            AccountService accountService = new AccountService();
            CreateReturnPolicyrequest createReturnPolicyrequest = new CreateReturnPolicyrequest();
            createReturnPolicyrequest.categoryTypes = new EbaySdkLib.Models.CategoryType[] { new EbaySdkLib.Models.CategoryType() { name = CategoryTypeEnum.ALL_EXCLUDING_MOTORS_VEHICLES } };
            createReturnPolicyrequest.marketplaceId = EbaySdkLib.Models.MarketplaceIdEnum.EBAY_US;
            createReturnPolicyrequest.name = "minimal return policy, US marketplace";
            CreateReturnPolicyResponse response = accountService.ReturnPolicyService.createReturnPolicyService(createReturnPolicyrequest).Result;
            Assert.IsNotNull(response);
            }
        [TestMethod]
        public void UpdateReturnPolicy()
            {
            AccountService accountService = new AccountService();
            UpdateReturnPolicyRequest updateReturnPolicyRequest = new UpdateReturnPolicyRequest();
            updateReturnPolicyRequest.categoryTypes = new EbaySdkLib.Models.CategoryType[] { new EbaySdkLib.Models.CategoryType() { name = CategoryTypeEnum.ALL_EXCLUDING_MOTORS_VEHICLES } };
            updateReturnPolicyRequest.marketplaceId = EbaySdkLib.Models.MarketplaceIdEnum.EBAY_US;
            updateReturnPolicyRequest.returnsAccepted = false;
            updateReturnPolicyRequest.name = "minimal return policy, US marketplace";
            string Id = "5487698000";
            UpdatereturnPolicyresponse response = accountService.ReturnPolicyService.updateReturnPolicyService(updateReturnPolicyRequest, Id).Result;
            Assert.IsNotNull(response);
            }
        [TestMethod]
        public void deleteReturnPolicy()
            {
            AccountService accountService = new AccountService();
            string return_policy_id = "5456159000";
            var response = accountService.ReturnPolicyService.deleteReturnPolicyService(return_policy_id).Result;
            Assert.IsNotNull(response);
            }
        }
    }
