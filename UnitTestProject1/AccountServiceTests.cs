using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web;
using EbaySdkLib;
using EbaySdkLib.Models;
using EbaySdkLib.Messages;
using EbaySdkLib.Enums;
using EbaySdkLib.Services;

namespace UnitTestProject1
    {
    [TestClass]
    public class AccountServiceTests
        {
        #region FulffillmentPolicy
        [TestMethod]
        public void DeleteFulfillmentPolicyTest()
            {
            AccountService accountService = new AccountService();
            EbaySdkLib.Messages.DeleteFulfillmentPolicyRequest deleteFulfillmentPolicyRequest = new EbaySdkLib.Messages.DeleteFulfillmentPolicyRequest();
            deleteFulfillmentPolicyRequest.fulfillmentPolicyId = "5446309000";
            string fulfillmentPolicyId = deleteFulfillmentPolicyRequest.fulfillmentPolicyId;
            var response = accountService.FulfilmentPolicyService.DeleteFulfillmentPolicy(fulfillmentPolicyId).Result;               if(response.Item2.ToString()=="OK"){ Assert.IsNotNull(response.Item1);}else{Assert.Fail(response.Item2.ToString());}
             if(response.Item2.ToString()=="OK")
                 { Assert.IsNotNull(response.Item1);}
             else{Assert.Fail(response.Item2.ToString());
                 }
            }

        [TestMethod]
        public void CreateFulfillmentPolicyTest()
            {
            AccountService accountService = new AccountService();

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

            var response = accountService.FulfilmentPolicyService.CreateFulfillmentPolicy(createFulfillmentRequest).Result;       
             if(response.Item2.ToString()=="OK"){ Assert.IsNotNull(response.Item1);}
             else{Assert.Fail(response.Item2.ToString());}

            Assert.IsNotNull(response);
            // Assert.AreEqual(response.marketplaceId);
            }


        [TestMethod]
        public void GetFulfilmentPolicies()
            {
            AccountService accountService = new AccountService();
            EbaySdkLib.Messages.GetFulfilmentPoliciesRequest createFulfillmentRequest = new EbaySdkLib.Messages.GetFulfilmentPoliciesRequest();
            createFulfillmentRequest.marketplaceId = EbaySdkLib.Models.MarketplaceIdEnum.EBAY_US;
            string Id = createFulfillmentRequest.marketplaceId.ToString();
            var response = accountService.FulfilmentPolicyService.GetFulfilmentPolicies(Id).Result; 
             if(response.Item2.ToString()=="OK"){ Assert.IsNotNull(response.Item1);}else{Assert.Fail(response.Item2.ToString());}
            
            }


        [TestMethod]
        public void GetfulfillmentPolicyByNameTest()
            {
            AccountService accountService = new AccountService();
            EbaySdkLib.Messages.GetFulfillmentPolicyByNameRequest getFulfillmentPolicyByNameRequest = new EbaySdkLib.Messages.GetFulfillmentPolicyByNameRequest();
            getFulfillmentPolicyByNameRequest.marketplaceId = EbaySdkLib.Models.MarketplaceIdEnum.EBAY_US;
            string Id = getFulfillmentPolicyByNameRequest.marketplaceId.ToString();

            string Name = getFulfillmentPolicyByNameRequest.name = "Domestic free shipping";
            var response = accountService.FulfilmentPolicyService.GetFulfillmentPolicyByName(Name, Id).Result;      
            if(response.Item2.ToString()=="OK"){ Assert.IsNotNull(response.Item1);}else{Assert.Fail(response.Item2.ToString());}
        
            }



        [TestMethod]
        public void UpdateFulfillmentPolicyTest()
            {
            AccountService accountService = new AccountService();

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

            var response = accountService.FulfilmentPolicyService.UpdateFulfillmentPolicy(fulfillmentpolicyid).Result; 
            if(response.Item2.ToString()=="OK"){ Assert.IsNotNull(response.Item1);}else{Assert.Fail(response.Item2.ToString());}
          
            //  Assert.AreEqual(response.,);
            }
        [TestMethod]
        public void GetFulfillmentPolicyTest()
            {
            AccountService accountService = new AccountService();

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

            var response = accountService.FulfilmentPolicyService.GetFulfillmentPolicy(fulfillmentpolicyid).Result;               if(response.Item2.ToString()=="OK"){ Assert.IsNotNull(response.Item1);}else{Assert.Fail(response.Item2.ToString());}
     
           
            }


        #endregion

        #region Program
        [TestMethod]
        public void GetOptedInProgramsTest()
            {
            AccountService accountService = new AccountService();
            //GetOptedInProgramsRequest getOptedInProgramsRequest = new GetOptedInProgramsRequest();
            EbaySdkLib.Messages.GetOptedInProgramsRequest getOptedInProgramsRequest = new EbaySdkLib.Messages.GetOptedInProgramsRequest();
            getOptedInProgramsRequest.programs = new EbaySdkLib.Models.Program[] { new EbaySdkLib.Models.Program() { programType = ProgramTypeEnum.SELLING_POLICY_MANAGEMENT } };
            var response = accountService.ProgramService.GetOptedprogram(getOptedInProgramsRequest).Result;           
            if(response.Item2.ToString()=="OK"){ Assert.IsNotNull(response.Item1);}else{Assert.Fail(response.Item2.ToString());}
            
            }


        [TestMethod]
        public void OpInToProgramsTest()
            {
            AccountService accountService = new AccountService();

            //EbaySdkLib.Messages. getOptedInProgramsRequest = new EbaySdkLib.Messages.GetOptedInProgramsRequest();
            EbaySdkLib.Messages.OptInToProgramRequest opInProgramsRequest = new EbaySdkLib.Messages.OptInToProgramRequest();
            opInProgramsRequest.programs = new EbaySdkLib.Models.Program[] { new EbaySdkLib.Models.Program() { programType = ProgramTypeEnum.OUT_OF_STOCK_CONTROL } };
            var response = accountService.ProgramService.OplnToprogram(opInProgramsRequest).Result;     
            if(response.Item2.ToString()=="OK"){ Assert.IsNotNull(response.Item1);}else{Assert.Fail(response.Item2.ToString());}
            
            }

        [TestMethod]
        public void OutPutOfProgramsTest()
            {
            AccountService accountService = new AccountService();

            //EbaySdkLib.Messages. getOptedInProgramsRequest = new EbaySdkLib.Messages.GetOptedInProgramsRequest();
            EbaySdkLib.Messages.OptOutOfProgramRequest optOutOfProgramRequest = new EbaySdkLib.Messages.OptOutOfProgramRequest();
            optOutOfProgramRequest.programs = new EbaySdkLib.Models.Program[] { new EbaySdkLib.Models.Program() { programType = ProgramTypeEnum.SELLING_POLICY_MANAGEMENT } };

            var response = accountService.ProgramService.OutPutOfProgram(optOutOfProgramRequest).Result; 
            if(response.Item2.ToString()=="OK"){ Assert.IsNotNull(response.Item1);}else{Assert.Fail(response.Item2.ToString());}
          
            }

        #endregion

        #region Privilage
        [TestMethod]
        public void GetPrivilageTest()
            {
            AccountService accountService = new AccountService();

            //EbaySdkLib.Messages. getOptedInProgramsRequest = new EbaySdkLib.Messages.GetOptedInProgramsRequest();
            EbaySdkLib.Messages.GetPrivilegesRequest getPrivilegesRequest = new EbaySdkLib.Messages.GetPrivilegesRequest();


            var response = accountService.PrivilegeService.GetPrivilage(getPrivilegesRequest).Result;  
            if(response.Item2.ToString()=="OK"){ Assert.IsNotNull(response.Item1);}else{Assert.Fail(response.Item2.ToString());}

          
            }
        #endregion

        #region SalesTax
        [TestMethod]
        public void CreateOrReplaceSalesTexTest()
            {
            AccountService accountService = new AccountService();
            EbaySdkLib.Messages.CreateOrReplaceSalesTaxRequest createOrReplaceSalesTaxRequest = new EbaySdkLib.Messages.CreateOrReplaceSalesTaxRequest();
            createOrReplaceSalesTaxRequest.salesTaxPercentage = "4.0";
            createOrReplaceSalesTaxRequest.shippingAndHandlingTaxed = true;
            string countyCode = CountryCodeEnum.US.ToString();
            string jurisdictionId = "NY";
            var response = accountService.SalesTaxService.CreateorReplaceSalesTax(createOrReplaceSalesTaxRequest, countyCode, jurisdictionId).Result;     
            if(response.Item2.ToString()=="OK"){ Assert.IsNotNull(response.Item1);}else{Assert.Fail(response.Item2.ToString());}
            

            }
        [TestMethod]
        public void DeleteSalesTaxTest()
            {
            AccountService accountService = new AccountService();
            EbaySdkLib.Messages.DeleteSalesTaxRequest deleteSalesTaxRequest = new EbaySdkLib.Messages.DeleteSalesTaxRequest();
            string countyCode = CountryCodeEnum.US.ToString();
            string jurisdictionId = "IL";
            var response = accountService.SalesTaxService.DeleteSalesTax(countyCode, jurisdictionId).Result;
            if(response.Item2.ToString()=="OK"){ Assert.IsNotNull(response.Item1);}else{Assert.Fail(response.Item2.ToString());}
            
            }
        [TestMethod]
        public void GetSalesTaxTest()
            {
            AccountService accountService = new AccountService();
            EbaySdkLib.Messages.GetSalesTaxRequest getSalesTaxRequest = new EbaySdkLib.Messages.GetSalesTaxRequest();
            string countyCode = CountryCodeEnum.US.ToString();
            string jurisdictionId = "NY";
            var response = accountService.SalesTaxService.GetSalesTax(countyCode, jurisdictionId).Result;  
            if(response.Item2.ToString()=="OK"){ Assert.IsNotNull(response.Item1);}else{Assert.Fail(response.Item2.ToString());}
           

            }
        [TestMethod]
        public void GetSalesTaxesTest()
            {
            AccountService accountService = new AccountService();
            EbaySdkLib.Messages.GetSalesTaxesRequest getSalesTaxesRequest = new EbaySdkLib.Messages.GetSalesTaxesRequest();
            string countryCode = CountryCodeEnum.US.ToString();

            var response = accountService.SalesTaxService.GetSalesTaxes(countryCode).Result;  
            if(response.Item2.ToString()=="OK"){ Assert.IsNotNull(response.Item1);}else{Assert.Fail(response.Item2.ToString());}
           

            }
        #endregion

        #region FulFillmentapi order
        [TestMethod]
        public void GetOrderTest()
            {
            FulFillmentApiService fulfillmentApiService = new FulFillmentApiService();
            EbaySdkLib.Messages.GetOrderRequest getOrderRequest = new EbaySdkLib.Messages.GetOrderRequest();
            string orderId = "6498414015!260000000562911";
            var response = fulfillmentApiService.OrderService.GetOrder(orderId).Result; 
            if(response.Item2.ToString()=="OK"){ Assert.IsNotNull(response.Item1);}else{Assert.Fail(response.Item2.ToString());}
            
            }
        [TestMethod]
        public void GetOrdersTest()
            {
            FulFillmentApiService fulfillmentApiService = new FulFillmentApiService();
            EbaySdkLib.Messages.GetOrdersRequest getOrdersRequest = new EbaySdkLib.Messages.GetOrdersRequest();
            string filter = "%5B2016-09-29T15:05:43.026Z..%5D";
            string limit = "50";
            string offset = "0";
            string orderIds = "6498414015!260000000562911";
            var response = fulfillmentApiService.OrderService.GetOrders(filter, limit, offset, orderIds).Result;    
            if(response.Item2.ToString()=="OK"){ Assert.IsNotNull(response.Item1);}else{Assert.Fail(response.Item2.ToString());}
           

            }







        #endregion

        #region PaymentPolicies
        [TestMethod]
        public void getPaymentPolicy()
            {
            AccountService accountService = new AccountService();
            EbaySdkLib.Messages.GetPaymentpolicyRequest getPaymentpolicy = new EbaySdkLib.Messages.GetPaymentpolicyRequest();
            getPaymentpolicy.payment_policy_id = "5486492000";
            string Id = getPaymentpolicy.payment_policy_id.ToString();
            var response = accountService.PaymentpolicyService.getPaymentpolicyService(Id).Result;    
            if(response.Item2.ToString()=="OK"){ Assert.IsNotNull(response.Item1);}else{Assert.Fail(response.Item2.ToString());}
            
            }

        [TestMethod]
        public void getPaymentPolicies()
            {
            AccountService accountService = new AccountService();
            EbaySdkLib.Messages.GetpaymentpoliciesRequest getpaymentpoliciesRequest = new EbaySdkLib.Messages.GetpaymentpoliciesRequest();
            getpaymentpoliciesRequest.marketplaceId = EbaySdkLib.Models.MarketplaceIdEnum.EBAY_US;
            string Id = getpaymentpoliciesRequest.marketplaceId.ToString();
            var response = accountService.PaymentpolicyService.getPaymentpoliciesService(Id).Result;   
            if(response.Item2.ToString()=="OK"){ Assert.IsNotNull(response.Item1);}else{Assert.Fail(response.Item2.ToString());}
           
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
            var response = accountService.PaymentpolicyService.getPaymentPolicyByNameService(name, marketplaceId).Result;  
            if(response.Item2.ToString()=="OK"){ Assert.IsNotNull(response.Item1);}else{Assert.Fail(response.Item2.ToString());}
            
            }

        [TestMethod]
        public void createPaymentPolicy()
            {
            AccountService accountService = new AccountService();
            EbaySdkLib.Messages.CreatePaymerntPolicyRequest createPaymerntPolicyRequest = new EbaySdkLib.Messages.CreatePaymerntPolicyRequest();
            createPaymerntPolicyRequest.categoryTypes = new EbaySdkLib.Models.CategoryType[] { new EbaySdkLib.Models.CategoryType() { name = CategoryTypeEnum.ALL_EXCLUDING_MOTORS_VEHICLES } };
            createPaymerntPolicyRequest.name = "minimal Payment Policy";
            createPaymerntPolicyRequest.paymentMethods = new EbaySdkLib.Models.PaymentMethod[] { new EbaySdkLib.Models.PaymentMethod() { paymentMethodType = PaymentMethodTypeEnum.PERSONAL_CHECK } };


            var response = accountService.PaymentpolicyService.createPaymentPolicyService(createPaymerntPolicyRequest).Result;           
            if(response.Item2.ToString()=="OK"){ Assert.IsNotNull(response.Item1);}else{Assert.Fail(response.Item2.ToString());}
            
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
            var response = accountService.PaymentpolicyService.updatePaymentPolicyService(updatePaymentPolicyrequest, policyId).Result;      
            if(response.Item2.ToString()=="OK"){ Assert.IsNotNull(response.Item1);}else{Assert.Fail(response.Item2.ToString());}
           
            }


        [TestMethod]
        public void deletePaymentpolicy()
            {
            AccountService accountService = new AccountService();
            string payment_policy_id = "5446270000";
            var response = accountService.ReturnPolicyService.deleteReturnPolicyService(payment_policy_id).Result;             
            if(response.Item2.ToString()=="OK"){ Assert.IsNotNull(response.Item1);}else{Assert.Fail(response.Item2.ToString());}

            }

        #endregion
        #region RateTable
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
            var response = accountService.PaymentpolicyService.getratePolicyService(ratetables).Result;  
            if(response.Item2.ToString()=="OK"){ Assert.IsNotNull(response.Item1);}else{Assert.Fail(response.Item2.ToString());}

            }
        #endregion
        #region Return Policy
        /// <summary>
        ///  Return policy starts
        /// </summary>
        [TestMethod]
        public void getReturnPolicy()
            {
            AccountService accountService = new AccountService();
            string return_policy_id = "5458323000";
            var response = accountService.ReturnPolicyService.getReturnPolicy(return_policy_id).Result;      
            if(response.Item2.ToString()=="OK"){ Assert.IsNotNull(response.Item1);}else{Assert.Fail(response.Item2.ToString());}
            
            }

        [TestMethod]
        public void getReturnPolicies()
            {
            AccountService accountService = new AccountService();
            GetReturnPoliciesRequest getReturnPoliciesRequest = new GetReturnPoliciesRequest();
            getReturnPoliciesRequest.marketplaceId = EbaySdkLib.Models.MarketplaceIdEnum.EBAY_US;
            string marketplaceId = getReturnPoliciesRequest.marketplaceId.ToString();
            var response = accountService.ReturnPolicyService.getReturnPolicies(marketplaceId).Result;         
            if(response.Item2.ToString()=="OK"){ Assert.IsNotNull(response.Item1);}else{Assert.Fail(response.Item2.ToString());}
            
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
            var response = accountService.ReturnPolicyService.getReturnPoliciesByName(marketplaceId, name).Result;  
            if(response.Item2.ToString()=="OK"){ Assert.IsNotNull(response.Item1);}else{Assert.Fail(response.Item2.ToString());}
            
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
            var response = accountService.ReturnPolicyService.createReturnPolicyService(createReturnPolicyrequest).Result;      
            if(response.Item2.ToString()=="OK"){ Assert.IsNotNull(response.Item1);}else{Assert.Fail(response.Item2.ToString());}
           
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
            var response = accountService.ReturnPolicyService.updateReturnPolicyService(updateReturnPolicyRequest, Id).Result;        
            if(response.Item2.ToString()=="OK"){ Assert.IsNotNull(response.Item1);}else{Assert.Fail(response.Item2.ToString());}
            
            }
        [TestMethod]
        public void deleteReturnPolicy()
            {
            AccountService accountService = new AccountService();
            string return_policy_id = "5456159000";
            var response = accountService.ReturnPolicyService.deleteReturnPolicyService(return_policy_id).Result;             
            if(response.Item2.ToString()=="OK"){ Assert.IsNotNull(response.Item1);}else{Assert.Fail(response.Item2.ToString());}
           
            }
        #endregion
        
        #region Offers
        /// <summary>
        /// header issue
        /// </summary>
        [TestMethod]
        public void createOffers()
            {
            InventoryApiService inventoryApiService = new InventoryApiService();
            EbaySdkLib.Messages.CreateOffersRequest createOffersRequest = new EbaySdkLib.Messages.CreateOffersRequest();
            createOffersRequest.marketplaceId=EbaySdkLib.Models.MarketplaceIdEnum.EBAY_US;
            createOffersRequest.format=EbaySdkLib.Enums.FormatTypeEnum.FIXED_PRICE;
            createOffersRequest.sku = "ddtest1";
            createOffersRequest.availableQuantity=75;
            createOffersRequest.listingPolicies=new ListingPolicies(){
                paymentPolicyId = "37967344010",
                returnPolicyId = "61019560011"
            };
            createOffersRequest.pricingSummary = new PricingSummary()
           {
             price = new Amount()
               {
                   currency = EbaySdkLib.Models.CurrencyCodeEnum.USD,
                   value = "260.00"

               }
           };
            var response = inventoryApiService.createOffersService(createOffersRequest).Result;           
            if(response.Item2.ToString()=="OK"){ Assert.IsNotNull(response.Item1);}else{Assert.Fail(response.Item2.ToString());}
            

            
            }
        [TestMethod]
        public void UpdateOffers()
            {
            InventoryApiService inventoryApiService = new InventoryApiService();
            string OfferId = "36445435465";
            EbaySdkLib.Messages.UpdateInventoryOfferRequest updateInventoryOfferRequest = new EbaySdkLib.Messages.UpdateInventoryOfferRequest();
            updateInventoryOfferRequest.categoryId = "30120";
            updateInventoryOfferRequest.availableQuantity = 75;
            updateInventoryOfferRequest.listingPolicies = new ListingPolicies()
            {
                paymentPolicyId="37967344010",
                returnPolicyId = "37967343010"
            };
            updateInventoryOfferRequest.pricingSummary = new PricingSummary()
            {
                price = new Amount()
                {
                    currency=EbaySdkLib.Models.CurrencyCodeEnum.USD,
                    value = "260.00"

                }
                
            };

            var response = inventoryApiService.updateOffersService(updateInventoryOfferRequest, OfferId).Result;          
            if(response.Item2.ToString()=="OK"){ Assert.IsNotNull(response.Item1);}else{Assert.Fail(response.Item2.ToString());}
            
           
            }

        [TestMethod]
        public void getOffers()
            {
            InventoryApiService inventoryApiService = new InventoryApiService();
            string sku = "3455632452345";
            var response = inventoryApiService.getOffersService(sku).Result;           
            if(response.Item2.ToString()=="OK"){ Assert.IsNotNull(response.Item1);}else{Assert.Fail(response.Item2.ToString());}
            
            }

        [TestMethod]
        public void getOffer()
            {
            InventoryApiService inventoryApiService = new InventoryApiService();
            string offerId = "36445435465";
            var response = inventoryApiService.getOfferService(offerId).Result;            
            if(response.Item2.ToString()=="OK"){ Assert.IsNotNull(response.Item1);}else{Assert.Fail(response.Item2.ToString());}
           
            
            }
        [TestMethod]
        public void deleteOffer()
            {
            InventoryApiService inventoryApiService = new InventoryApiService();
            string offerId = "3455632452345";
            var response = inventoryApiService.deleteOffersService(offerId).Result;         
            if(response.Item2.ToString()=="OK"){ Assert.IsNotNull(response.Item1);}else{Assert.Fail(response.Item2.ToString());}
         
            }
        [TestMethod]
        public void publishOffer()
            {
            InventoryApiService inventoryApiService = new InventoryApiService();
            string offerId = "36445435465";
            var response = inventoryApiService.publishOfferService(offerId).Result;        
            if(response.Item2.ToString()=="OK"){ Assert.IsNotNull(response.Item1);}else{Assert.Fail(response.Item2.ToString());}
           
            
            }
        [TestMethod]
        public void getListingFees()
            {
            InventoryApiService inventoryApiService = new InventoryApiService();
            string get_listing_fees = "get_listing_fees";
            var response = inventoryApiService.getListingFeesService(get_listing_fees).Result;          
            if(response.Item2.ToString()=="OK"){ Assert.IsNotNull(response.Item1);}else{Assert.Fail(response.Item2.ToString());}
           
            
            }
        [TestMethod]
        public void publishOfferByInventoryItemGroup()
            {
            InventoryApiService inventoryApiService = new InventoryApiService();
            string get_listing_fees = "get_listing_fees";
            var response = inventoryApiService.publishOfferByInventoryItemGroupService(get_listing_fees).Result;        
            if(response.Item2.ToString()=="OK"){ Assert.IsNotNull(response.Item1);}else{Assert.Fail(response.Item2.ToString());}
           
           
            }

            
        [TestMethod]
        public void WithdrawOrder()
            {
            InventoryApiService inventoryApiService = new InventoryApiService();
            string Listing_Id = "3455632452346";
            var response = inventoryApiService.WithdrawOfferService(Listing_Id).Result;         
            if(response.Item2.ToString()=="OK"){ Assert.IsNotNull(response.Item1);}else{Assert.Fail(response.Item2.ToString());}
           
           
            }
       
        #endregion
        

        
        


        }
    }
