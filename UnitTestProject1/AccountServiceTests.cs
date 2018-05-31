using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web;
using EbaySdkLib;
using EbaySdkLib.Models;
using EbaySdkLib.Messages;
using EbaySdkLib.Enums;
using EbaySdkLib.Services;
using System.Configuration;

namespace UnitTestProject1
    {
    [TestClass]
    public class _accountServiceTests
        {
        AccountService _accountService;
        public string Token { get; set; }
        [TestInitialize]
        public void Setup()
            {
            Token = ConfigurationManager.AppSettings["token"];
            _accountService = new AccountService(Token);

            }
        #region FulffillmentPolicy
        [TestMethod]
        public void DeleteFulfillmentPolicyTest()
            {
            EbaySdkLib.Messages.DeleteFulfillmentPolicyRequest deleteFulfillmentPolicyRequest = new EbaySdkLib.Messages.DeleteFulfillmentPolicyRequest();
            deleteFulfillmentPolicyRequest.fulfillmentPolicyId = "5446309000";
            string fulfillmentPolicyId = deleteFulfillmentPolicyRequest.fulfillmentPolicyId;
            var response = _accountService.FulfilmentPolicyService.DeleteFulfillmentPolicy(fulfillmentPolicyId).Result; if (response.Item2.ToString() == "OK") { Assert.IsNotNull(response.Item1); } else { Assert.Fail(response.Item2.ToString()); }
            if (response.Item2.ToString() == "OK")
            { Assert.IsNotNull(response.Item1); }
            else
                {
                Assert.Fail(response.Item2.ToString());
                }
            }

        [TestMethod]
        public void CreateFulfillmentPolicyTest()
            {

            //CreateFulfillmentRequest createFulfillmentRequest = new CreateFulfillmentRequest();
            EbaySdkLib.Messages.CreateFulfillmentRequest createFulfillmentRequest = new EbaySdkLib.Messages.CreateFulfillmentRequest();
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

            var response = _accountService.FulfilmentPolicyService.CreateFulfillmentPolicy(createFulfillmentRequest).Result;
            if (response.Item2.ToString() == "OK") { Assert.IsNotNull(response.Item1); }
            else { Assert.Fail(response.Item2.ToString()); }

            Assert.IsNotNull(response);
            // Assert.AreEqual(response.marketplaceId);
            }


        [TestMethod]
        public void GetFulfilmentPolicies()
            {
            EbaySdkLib.Messages.GetFulfilmentPoliciesRequest createFulfillmentRequest = new EbaySdkLib.Messages.GetFulfilmentPoliciesRequest();
            createFulfillmentRequest.marketplaceId = EbaySdkLib.Models.MarketplaceIdEnum.EBAY_US;
            string Id = createFulfillmentRequest.marketplaceId.ToString();
            var response = _accountService.FulfilmentPolicyService.GetFulfilmentPolicies(Id).Result;
            if (response.Item2.ToString() == "OK") { Assert.IsNotNull(response.Item1); } else { Assert.Fail(response.Item2.ToString()); }

            }


        [TestMethod]
        public void GetfulfillmentPolicyByNameTest()
            {
            EbaySdkLib.Messages.GetFulfillmentPolicyByNameRequest getFulfillmentPolicyByNameRequest = new EbaySdkLib.Messages.GetFulfillmentPolicyByNameRequest();
            getFulfillmentPolicyByNameRequest.marketplaceId = EbaySdkLib.Models.MarketplaceIdEnum.EBAY_US;
            string Id = getFulfillmentPolicyByNameRequest.marketplaceId.ToString();

            string Name = getFulfillmentPolicyByNameRequest.name = "Domestic free shipping";
            var response = _accountService.FulfilmentPolicyService.GetFulfillmentPolicyByName(Name, Id).Result;
            if (response.Item2.ToString() == "OK") { Assert.IsNotNull(response.Item1); } else { Assert.Fail(response.Item2.ToString()); }

            }



        [TestMethod]
        public void UpdateFulfillmentPolicyTest()
            {
            EbaySdkLib.Messages.UpdateFulfillmentPolicyRequest updateFulfillmentPolicyRequest = new EbaySdkLib.Messages.UpdateFulfillmentPolicyRequest();
            string fulfillmentpolicyid = "5733606000";
            updateFulfillmentPolicyRequest.categoryTypes = new EbaySdkLib.Models.CategoryType[] { new EbaySdkLib.Models.CategoryType() { name = CategoryTypeEnum.ALL_EXCLUDING_MOTORS_VEHICLES } };
            updateFulfillmentPolicyRequest.marketplaceId = EbaySdkLib.Models.MarketplaceIdEnum.EBAY_US;
            updateFulfillmentPolicyRequest.name = "Domestic free shipping";
            updateFulfillmentPolicyRequest.handlingTime = new EbaySdkLib.Models.TimeDuration()
            {
                value = "1",
                unit = EbaySdkLib.Models.TimeDurationUnitEnum.DAY
            };
            updateFulfillmentPolicyRequest.shippingOptions = new EbaySdkLib.Models.ShippingOption[]{
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

            var response = _accountService.FulfilmentPolicyService.UpdateFulfillmentPolicy(fulfillmentpolicyid).Result;
            if (response.Item2.ToString() == "OK") { Assert.IsNotNull(response.Item1); } else { Assert.Fail(response.Item2.ToString()); }

            //  Assert.AreEqual(response.,);
            }
        [TestMethod]
        public void GetFulfillmentPolicyTest()
            {
            //GetFulfillmentPolicyRequest getFulfillmentPolicyRequest = new GetFulfillmentPolicyRequest();
            EbaySdkLib.Messages.GetFulfillmentPolicyRequest getFulfillmentPolicyRequest = new EbaySdkLib.Messages.GetFulfillmentPolicyRequest();
            string fulfillmentpolicyid = "5733606000";
            getFulfillmentPolicyRequest.categoryTypes = new EbaySdkLib.Models.CategoryType[] { new EbaySdkLib.Models.CategoryType() { name = CategoryTypeEnum.ALL_EXCLUDING_MOTORS_VEHICLES } };
            getFulfillmentPolicyRequest.marketplaceId = EbaySdkLib.Models.MarketplaceIdEnum.EBAY_US;
            getFulfillmentPolicyRequest.name = "Domestic free shipping";
            getFulfillmentPolicyRequest.handlingTime = new EbaySdkLib.Models.TimeDuration()
            {
                value = "1",
                unit = EbaySdkLib.Models.TimeDurationUnitEnum.DAY
            };
            getFulfillmentPolicyRequest.shippingOptions = new EbaySdkLib.Models.ShippingOption[]{
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
                } 
            }
                }
            };

            var response = _accountService.FulfilmentPolicyService.GetFulfillmentPolicy(fulfillmentpolicyid).Result; if (response.Item2.ToString() == "OK") { Assert.IsNotNull(response.Item1); } else { Assert.Fail(response.Item2.ToString()); }


            }


        #endregion

        #region Program
        [TestMethod]
        public void GetOptedInProgramsTest()
            {
            
            //GetOptedInProgramsRequest getOptedInProgramsRequest = new GetOptedInProgramsRequest();
            EbaySdkLib.Messages.GetOptedInProgramsRequest getOptedInProgramsRequest = new EbaySdkLib.Messages.GetOptedInProgramsRequest();
            getOptedInProgramsRequest.programs = new EbaySdkLib.Models.Program[] { new EbaySdkLib.Models.Program() { programType = ProgramTypeEnum.SELLING_POLICY_MANAGEMENT } };
            var response = _accountService.ProgramService.GetOptedprogram(getOptedInProgramsRequest).Result;
            if (response.Item2.ToString() == "OK") { Assert.IsNotNull(response.Item1); } else { Assert.Fail(response.Item2.ToString()); }

            }


        [TestMethod]
        public void OpInToProgramsTest()
            {
            

            //EbaySdkLib.Messages. getOptedInProgramsRequest = new EbaySdkLib.Messages.GetOptedInProgramsRequest();
            EbaySdkLib.Messages.OptInToProgramRequest opInProgramsRequest = new EbaySdkLib.Messages.OptInToProgramRequest();
            opInProgramsRequest.programs = new EbaySdkLib.Models.Program[] { new EbaySdkLib.Models.Program() { programType = ProgramTypeEnum.OUT_OF_STOCK_CONTROL } };
            var response = _accountService.ProgramService.OplnToprogram(opInProgramsRequest).Result;
            if (response.Item2.ToString() == "OK") { Assert.IsNotNull(response.Item1); } else { Assert.Fail(response.Item2.ToString()); }

            }

        [TestMethod]
        public void OutPutOfProgramsTest()
            {
            

            //EbaySdkLib.Messages. getOptedInProgramsRequest = new EbaySdkLib.Messages.GetOptedInProgramsRequest();
            EbaySdkLib.Messages.OptOutOfProgramRequest optOutOfProgramRequest = new EbaySdkLib.Messages.OptOutOfProgramRequest();
            optOutOfProgramRequest.programs = new EbaySdkLib.Models.Program[] { new EbaySdkLib.Models.Program() { programType = ProgramTypeEnum.SELLING_POLICY_MANAGEMENT } };

            var response = _accountService.ProgramService.OutPutOfProgram(optOutOfProgramRequest).Result;
            if (response.Item2.ToString() == "OK") { Assert.IsNotNull(response.Item1); } else { Assert.Fail(response.Item2.ToString()); }

            }

        #endregion

        #region Privilage
        [TestMethod]
        public void GetPrivilageTest()
            {

            var response = _accountService.PrivilegeService.GetPrivilage().Result;
            if (response.Item2.ToString() == "OK") { Assert.IsNotNull(response.Item1); } else { Assert.Fail(response.Item2.ToString()); }


            }
        #endregion

        #region SalesTax
        [TestMethod]
        public void CreateOrReplaceSalesTexTest()
            {
            
            EbaySdkLib.Messages.CreateOrReplaceSalesTaxRequest createOrReplaceSalesTaxRequest = new EbaySdkLib.Messages.CreateOrReplaceSalesTaxRequest();
            createOrReplaceSalesTaxRequest.salesTaxPercentage = "4.0";
            createOrReplaceSalesTaxRequest.shippingAndHandlingTaxed = true;
            string countyCode = CountryCodeEnum.US.ToString();
            string jurisdictionId = "NY";
            var response = _accountService.SalesTaxService.CreateorReplaceSalesTax(createOrReplaceSalesTaxRequest, countyCode, jurisdictionId).Result;
            if (response.Item2.ToString() == "OK") { Assert.IsNotNull(response.Item1); } else { Assert.Fail(response.Item2.ToString()); }


            }
        [TestMethod]
        public void DeleteSalesTaxTest()
            {
            
            EbaySdkLib.Messages.DeleteSalesTaxRequest deleteSalesTaxRequest = new EbaySdkLib.Messages.DeleteSalesTaxRequest();
            string countyCode = CountryCodeEnum.US.ToString();
            string jurisdictionId = "IL";
            var response = _accountService.SalesTaxService.DeleteSalesTax(countyCode, jurisdictionId).Result;
            if (response.Item2.ToString() == "OK") { Assert.IsNotNull(response.Item1); } else { Assert.Fail(response.Item2.ToString()); }

            }
        [TestMethod]
        public void GetSalesTaxTest()
            {
            
            EbaySdkLib.Messages.GetSalesTaxRequest getSalesTaxRequest = new EbaySdkLib.Messages.GetSalesTaxRequest();
            string countyCode = CountryCodeEnum.US.ToString();
            string jurisdictionId = "NY";
            var response = _accountService.SalesTaxService.GetSalesTax(countyCode, jurisdictionId).Result;
            if (response.Item2.ToString() == "OK") { Assert.IsNotNull(response.Item1); } else { Assert.Fail(response.Item2.ToString()); }


            }
        [TestMethod]
        public void GetSalesTaxesTest()
            {
            
            EbaySdkLib.Messages.GetSalesTaxesRequest getSalesTaxesRequest = new EbaySdkLib.Messages.GetSalesTaxesRequest();
            string countryCode = CountryCodeEnum.US.ToString();

            var response = _accountService.SalesTaxService.GetSalesTaxes(countryCode).Result;
            if (response.Item2.ToString() == "OK") { Assert.IsNotNull(response.Item1); } else { Assert.Fail(response.Item2.ToString()); }


            }
        #endregion

        

        #region PaymentPolicies
        [TestMethod]
        public void getPaymentPolicy()
            {
            
            EbaySdkLib.Messages.GetPaymentpolicyRequest getPaymentpolicy = new EbaySdkLib.Messages.GetPaymentpolicyRequest();
            getPaymentpolicy.payment_policy_id = "5486492000";
            string Id = getPaymentpolicy.payment_policy_id.ToString();
            var response = _accountService.PaymentpolicyService.getPaymentpolicyService(Id).Result;
            if (response.Item2.ToString() == "OK") { Assert.IsNotNull(response.Item1); } else { Assert.Fail(response.Item2.ToString()); }

            }

        [TestMethod]
        public void getPaymentPolicies()
            {
            
            EbaySdkLib.Messages.GetpaymentpoliciesRequest getpaymentpoliciesRequest = new EbaySdkLib.Messages.GetpaymentpoliciesRequest();
            getpaymentpoliciesRequest.marketplaceId = EbaySdkLib.Models.MarketplaceIdEnum.EBAY_US;
            string Id = getpaymentpoliciesRequest.marketplaceId.ToString();
            var response = _accountService.PaymentpolicyService.getPaymentpoliciesService(Id).Result;
            if (response.Item2.ToString() == "OK") { Assert.IsNotNull(response.Item1); } else { Assert.Fail(response.Item2.ToString()); }

            }


        [TestMethod]
        public void getPaymentPolicyByName()
            {
            
            EbaySdkLib.Messages.GetPaymentPolicyByNameRequest getPaymentPolicyByNameRequest = new EbaySdkLib.Messages.GetPaymentPolicyByNameRequest();
            getPaymentPolicyByNameRequest.name = "default payment policy";
            getPaymentPolicyByNameRequest.marketplaceId = EbaySdkLib.Models.MarketplaceIdEnum.EBAY_US;
            string marketplaceId = getPaymentPolicyByNameRequest.marketplaceId.ToString();
            string name = getPaymentPolicyByNameRequest.name;
            var response = _accountService.PaymentpolicyService.getPaymentPolicyByNameService(name, marketplaceId).Result;
            if (response.Item2.ToString() == "OK") { Assert.IsNotNull(response.Item1); } else { Assert.Fail(response.Item2.ToString()); }

            }

        [TestMethod]
        public void createPaymentPolicy()
            {
            
            EbaySdkLib.Messages.CreatePaymerntPolicyRequest createPaymerntPolicyRequest = new EbaySdkLib.Messages.CreatePaymerntPolicyRequest();
            createPaymerntPolicyRequest.categoryTypes = new EbaySdkLib.Models.CategoryType[] { new EbaySdkLib.Models.CategoryType() { name = CategoryTypeEnum.ALL_EXCLUDING_MOTORS_VEHICLES } };
            createPaymerntPolicyRequest.name = "minimal Payment Policy";
            createPaymerntPolicyRequest.paymentMethods = new EbaySdkLib.Models.PaymentMethod[] { new EbaySdkLib.Models.PaymentMethod() { paymentMethodType = PaymentMethodTypeEnum.PERSONAL_CHECK } };


            var response = _accountService.PaymentpolicyService.createPaymentPolicyService(createPaymerntPolicyRequest).Result;
            if (response.Item2.ToString() == "OK") { Assert.IsNotNull(response.Item1); } else { Assert.Fail(response.Item2.ToString()); }

            }

        [TestMethod]
        public void updatepaymentPolicy()
            {
            
            EbaySdkLib.Messages.updatePaymentPolicyRequest updatePaymentPolicyrequest = new EbaySdkLib.Messages.updatePaymentPolicyRequest();
            updatePaymentPolicyrequest.categoryTypes = new EbaySdkLib.Models.CategoryType[] { new EbaySdkLib.Models.CategoryType() { name = CategoryTypeEnum.ALL_EXCLUDING_MOTORS_VEHICLES } };
            updatePaymentPolicyrequest.description = "Standard payment policy, PP & CC payments";
            updatePaymentPolicyrequest.name = "default payment policy";
            updatePaymentPolicyrequest.paymentMethods = new EbaySdkLib.Models.PaymentMethod[] { new EbaySdkLib.Models.PaymentMethod() { paymentMethodType = PaymentMethodTypeEnum.PERSONAL_CHECK } };
            string policyId = "5458323000";
            var response = _accountService.PaymentpolicyService.updatePaymentPolicyService(updatePaymentPolicyrequest, policyId).Result;
            if (response.Item2.ToString() == "OK") { Assert.IsNotNull(response.Item1); } else { Assert.Fail(response.Item2.ToString()); }

            }


        [TestMethod]
        public void deletePaymentpolicy()
            {
            
            string payment_policy_id = "5446270000";
            var response = _accountService.ReturnPolicyService.deleteReturnPolicyService(payment_policy_id).Result;
            if (response.Item2.ToString() == "OK") { Assert.IsNotNull(response.Item1); } else { Assert.Fail(response.Item2.ToString()); }

            }

        #endregion
        #region RateTable
        /// Rate-tables
        ///Response is null but status code=200.
        [TestMethod]
        public void getrateTables()
            {
            
            //EbaySdkLib.Messages.GetRateTablesRequest geteRatetable = new EbaySdkLib.Messages.GetRateTablesRequest();
            var ratetables = new EbaySdkLib.Models.RateTable()
            {
                countryCode = EbaySdkLib.Enums.CountryCodeEnum.US
            };
            var response = _accountService.PaymentpolicyService.getratePolicyService(ratetables).Result;
            if (response.Item2.ToString() == "OK") { Assert.IsNotNull(response.Item1); } else { Assert.Fail(response.Item2.ToString()); }

            }
        #endregion
        #region Return Policy
        /// <summary>
        ///  Return policy starts
        /// </summary>
        [TestMethod]
        public void getReturnPolicy()
            {
            
            string return_policy_id = "5458323000";
            var response = _accountService.ReturnPolicyService.getReturnPolicy(return_policy_id).Result;
            if (response.Item2.ToString() == "OK") { Assert.IsNotNull(response.Item1); } else { Assert.Fail(response.Item2.ToString()); }

            }

        [TestMethod]
        public void getReturnPolicies()
            {
            
            GetReturnPoliciesRequest getReturnPoliciesRequest = new GetReturnPoliciesRequest();
            getReturnPoliciesRequest.marketplaceId = EbaySdkLib.Models.MarketplaceIdEnum.EBAY_US;
            string marketplaceId = getReturnPoliciesRequest.marketplaceId.ToString();
            var response = _accountService.ReturnPolicyService.getReturnPolicies(marketplaceId).Result;
            if (response.Item2.ToString() == "OK") { Assert.IsNotNull(response.Item1); } else { Assert.Fail(response.Item2.ToString()); }

            }

        [TestMethod]
        public void getReturnPoliciesByName()
            {
            
            GetReturnPolicyByNameRequest getReturnPolicyByNameRequest = new GetReturnPolicyByNameRequest();
            getReturnPolicyByNameRequest.marketplaceId = EbaySdkLib.Models.MarketplaceIdEnum.EBAY_US;
            getReturnPolicyByNameRequest.name = "minimal return policy, US marketplace";
            string marketplaceId = getReturnPolicyByNameRequest.marketplaceId.ToString();
            string name = getReturnPolicyByNameRequest.name.ToString();
            var response = _accountService.ReturnPolicyService.getReturnPoliciesByName(marketplaceId, name).Result;
            if (response.Item2.ToString() == "OK") { Assert.IsNotNull(response.Item1); } else { Assert.Fail(response.Item2.ToString()); }

            }
        /// <summary>
        /// Invalid return error
        /// </summary>
        [TestMethod]
        public void createReturnPolicy()
            {
            
            CreateReturnPolicyrequest createReturnPolicyrequest = new CreateReturnPolicyrequest();
            createReturnPolicyrequest.categoryTypes = new EbaySdkLib.Models.CategoryType[] { new EbaySdkLib.Models.CategoryType() { name = CategoryTypeEnum.ALL_EXCLUDING_MOTORS_VEHICLES } };
            createReturnPolicyrequest.marketplaceId = EbaySdkLib.Models.MarketplaceIdEnum.EBAY_US;
            createReturnPolicyrequest.name = "minimal return policy, US marketplace";
            var response = _accountService.ReturnPolicyService.createReturnPolicyService(createReturnPolicyrequest).Result;
            if (response.Item2.ToString() == "OK") { Assert.IsNotNull(response.Item1); } else { Assert.Fail(response.Item2.ToString()); }

            }
        [TestMethod]
        public void UpdateReturnPolicy()
            {
            
            UpdateReturnPolicyRequest updateReturnPolicyRequest = new UpdateReturnPolicyRequest();
            updateReturnPolicyRequest.categoryTypes = new EbaySdkLib.Models.CategoryType[] { new EbaySdkLib.Models.CategoryType() { name = CategoryTypeEnum.ALL_EXCLUDING_MOTORS_VEHICLES } };
            updateReturnPolicyRequest.marketplaceId = EbaySdkLib.Models.MarketplaceIdEnum.EBAY_US;
            updateReturnPolicyRequest.returnsAccepted = false;
            updateReturnPolicyRequest.name = "minimal return policy, US marketplace";
            string Id = "5487698000";
            var response = _accountService.ReturnPolicyService.updateReturnPolicyService(updateReturnPolicyRequest, Id).Result;
            if (response.Item2.ToString() == "OK") { Assert.IsNotNull(response.Item1); } else { Assert.Fail(response.Item2.ToString()); }

            }
        [TestMethod]
        public void deleteReturnPolicy()
            {
            
            string return_policy_id = "5456159000";
            var response = _accountService.ReturnPolicyService.deleteReturnPolicyService(return_policy_id).Result;
            if (response.Item2.ToString() == "OK") { Assert.IsNotNull(response.Item1); } else { Assert.Fail(response.Item2.ToString()); }

            }
        #endregion

       



        }
    }
