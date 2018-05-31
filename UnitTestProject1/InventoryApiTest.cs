using EbaySdkLib.Messages;
using EbaySdkLib.Models;
using EbaySdkLib.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
    {
    [TestClass]
    public class InventoryApiTest
        {
        InventoryApiService _inventoryApiService;
        public string Token { get; set; }
        [TestInitialize]
        public void Setup()
            {
        Token = ConfigurationManager.AppSettings["token"];
        _inventoryApiService = new InventoryApiService(Token);

            }

        #region InventoryLocation


        [TestMethod]
        public void CreateInventoryLocation()
            {
          
            string merchantLocationKey = "Warehouse-1";
            CreateInventoryLocationRequest createInventoryLocationRequest = new CreateInventoryLocationRequest();
            createInventoryLocationRequest.location = new Location()
            {
                address = new Address()
                {
                    addressLine1 = "2055 Hamilton Ave",
                    addressLine2 = "Building 3",
                    city = "San Jose",
                    stateOrProvince = "CA",
                    postalCode = "95125",
                    countryCode = EbaySdkLib.Enums.CountryCodeEnum.US

                }

            };
            var response = _inventoryApiService.CreateInventoryLocationService(createInventoryLocationRequest, merchantLocationKey).Result;
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
        public void UpdateInventoryLocation()
            {
          
            string merchantLocationKey = "Warehouse-1";
            UpdateInventoryLocationRequest updateInventoryLocationRequest = new UpdateInventoryLocationRequest();
            updateInventoryLocationRequest.locationAdditionalInformation = "Available for drop-off on Mondays only.";
            updateInventoryLocationRequest.locationInstructions = "Entrance is on the backside of the building.";
            updateInventoryLocationRequest.locationWebUrl = "http://www.example.com/warehouse-1";
            updateInventoryLocationRequest.name = "Warehouse-South";
            updateInventoryLocationRequest.phone = "888-730-0000";
            updateInventoryLocationRequest.operatingHours = new OperatingHour[]
           {
               new OperatingHour()
               {
               dayOfWeekEnum=EbaySdkLib.Enums.DayOfWeekEnum.MONDAY
               }
           };

            var response = _inventoryApiService.UpdateInventoryLocationService(updateInventoryLocationRequest, merchantLocationKey).Result;
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
        public void getInventoryLocation()
            {
          
            string merchantLocationKey = "Warehouse-1";
            var response = _inventoryApiService.getInventoryLocationService(merchantLocationKey).Result;
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
        public void getInventoryLocations()
            {
          
            int limit = 2; int offset = 2;
            //GetInventoryLocationsResponce response = inventoryApiService.getInventoryLocationsService(limit, offset).Result;
            var response = _inventoryApiService.getInventoryLocationsService(limit, offset).Result;
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
        public void enableInventoryLocation()
            {
          
            string merchantLocationKey = "warehouse-1";
            var response = _inventoryApiService.enableInventoryLocationService(merchantLocationKey).Result;
            Assert.IsNotNull(response);
            }
        [TestMethod]
        public void disableInventoryLocation()
            {
          
            string merchantLocationKey = "warehouse-1";
            var response = _inventoryApiService.disableInventoryLocationService(merchantLocationKey).Result;
            if (response.Item2.ToString() == "OK")
                {
                Assert.IsNotNull(response.Item1);
                }
            else
                {
                Assert.Fail(response.Item2.ToString());
                }
            }


        //[TestMethod]
        //public void createInventoryLocations()
        //    {
        //  
        //    EbaySdkLib.Messages.CreateInventoryLocationRequest createInventoryLocationRequest = new EbaySdkLib.Messages.CreateInventoryLocationRequest();
        //    createInventoryLocationRequest.location = new EbaySdkLib.Models.Location()
        //    {
        //        address = new Address()
        //        {
        //            addressLine1 = "2055 Hamilton Ave",
        //            addressLine2 = "Building 3",
        //            city = "San Jose",
        //            country = CountryCodeEnum.US,
        //            postalCode = "12",
        //            stateOrProvince = "12"
        //        },
        //        geoCoordinates = new GeoCoordinates()
        //        {
        //            latitude = "12",
        //            longitude = "a34c"
        //        },
        //        locationId = "abc"
        //    };
        //    createInventoryLocationRequest.merchantLocationStatus = EbaySdkLib.Enums.StatusEnum.ENABLED;
        //    createInventoryLocationRequest.operatingHours = new EbaySdkLib.Models.OperatingHour[] { new EbaySdkLib.Models.OperatingHour()
        //    { 
        //        DayOfWeekEnum=DayOfWeekEnum.MONDAY,

        //    };
        //    //var response = _inventoryApiService.createInventoryLocationsService().Result;
        //   // Assert.IsNotNull(response);
        //    }

        [TestMethod]
        public void deleteInventoryLocation()
            {
          
            string merchantLocationKey = "warehouse-1";
            var response = _inventoryApiService.deleteInventoryLocationService(merchantLocationKey).Result;
            if (response.Item2.ToString() == "OK")
                {
                Assert.IsNotNull(response.Item1);
                }
            else
                {
                Assert.Fail(response.Item2.ToString());
                }
            }
        #endregion
        #region Offers
        /// <summary>
        /// header issue
        /// </summary>
        [TestMethod]
        public void createOffers()
            {
          
            EbaySdkLib.Messages.CreateOffersRequest createOffersRequest = new EbaySdkLib.Messages.CreateOffersRequest();
            createOffersRequest.marketplaceId = EbaySdkLib.Models.MarketplaceIdEnum.EBAY_US;
            createOffersRequest.format = EbaySdkLib.Enums.FormatTypeEnum.FIXED_PRICE;
            createOffersRequest.sku = "ddtest1";
            createOffersRequest.availableQuantity = 75;
            createOffersRequest.listingPolicies = new ListingPolicies()
            {
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
            var response = _inventoryApiService.createOffersService(createOffersRequest).Result;
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
        public void UpdateOffers()
            {
          
            string OfferId = "36445435465";
            EbaySdkLib.Messages.UpdateInventoryOfferRequest updateInventoryOfferRequest = new EbaySdkLib.Messages.UpdateInventoryOfferRequest();
            updateInventoryOfferRequest.categoryId = "30120";
            updateInventoryOfferRequest.availableQuantity = 75;
            updateInventoryOfferRequest.listingPolicies = new ListingPolicies()
            {
                paymentPolicyId = "37967344010",
                returnPolicyId = "37967343010"
            };
            updateInventoryOfferRequest.pricingSummary = new PricingSummary()
            {
                price = new Amount()
                {
                    currency = EbaySdkLib.Models.CurrencyCodeEnum.USD,
                    value = "260.00"

                }

            };

            var response = _inventoryApiService.updateOffersService(updateInventoryOfferRequest, OfferId).Result;
            if (response.Item2.ToString() == "OK")
                {
                Assert.IsNotNull(response.Item1);
                }
            else
                {
                Assert.Fail(response.Item2.ToString());
                };
            }

        [TestMethod]
        public void getOffers()
            {
          
            string sku = "3455632452345";
            var response = _inventoryApiService.getOffersService(sku).Result;
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
        public void getOffer()
            {
          
            string offerId = "36445435465";
            var response = _inventoryApiService.getOfferService(offerId).Result;
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
        public void deleteOffer()
            {
          
            string offerId = "3455632452345";
            var response = _inventoryApiService.deleteOffersService(offerId).Result;
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
        public void publishOffer()
            {
          
            string offerId = "36445435465";
            var response = _inventoryApiService.publishOfferService(offerId).Result;
            Assert.IsNotNull(response);
            Assert.Fail();
            }
        [TestMethod]
        public void getListingFees()
            {
          
            string get_listing_fees = "get_listing_fees";
            var response = _inventoryApiService.getListingFeesService(get_listing_fees).Result;
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
        public void publishOfferByInventoryItemGroup()
            {
          
            string get_listing_fees = "get_listing_fees";
            var response = _inventoryApiService.publishOfferByInventoryItemGroupService(get_listing_fees).Result;
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
        public void WithdrawOrder()
            {
          
            string Listing_Id = "3455632452346";
            var response = _inventoryApiService.WithdrawOfferService(Listing_Id).Result;
            if (response.Item2.ToString() == "OK")
                {
                Assert.IsNotNull(response.Item1);
                }
            else
                {
                Assert.Fail(response.Item2.ToString());
                }
            }

        #endregion
        #region InventoryItems
        [TestMethod]
        public void getInventoryItem()
            {
          
            string sku = "GP-Cam-01";
            var response = _inventoryApiService.getInventoryItemService(sku).Result;
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
        public void getInventoryItems()
            {
          

            var response = _inventoryApiService.getInventoryItemsService().Result;
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
        public void deleteInventoryItem()
            {
          
            string sku = "GP-Cam-01";
            var response = _inventoryApiService.deleteInventoryItemService(sku).Result;
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
        public void bulkUpdatePriceQuality()
            {
          
            EbaySdkLib.Messages.BulkUpdatePriceQualityRequest bulkUpdatePriceQualityRequest = new EbaySdkLib.Messages.BulkUpdatePriceQualityRequest();
            bulkUpdatePriceQualityRequest.requests = new PriceQuality[]{
                          new PriceQuality ()
                          {
                          sku="GP-Cam-01",
                          shipToLocationAvailability=new ShipToLocationAvailability (){ quantity= "25"},
                         offers=new Offer[]{new Offer(){availableQuantity= 10,offerId= "3455632452395", pricingSummary=new PricingSummary { price=new Amount(){currency=EbaySdkLib.Models.CurrencyCodeEnum.GBP,value="182.0"} }
                           }
                             }
                          }
                        };

            var response = _inventoryApiService.bulkUpdatePriceQualityService(bulkUpdatePriceQualityRequest).Result;
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
        public void CreateorReplaceItem()
            {
          
            CreateorReplaceInventoryItemrequest createorReplaceInventoryItemrequest = new CreateorReplaceInventoryItemrequest();
            string sku = "GP-Cam-01";
            createorReplaceInventoryItemrequest.availability = new Availability
            {
                shipToLocationAvailability = new ShipToLocationAvailability()
                {
                    quantity = "50"
                }

            };
            createorReplaceInventoryItemrequest.condition = EbaySdkLib.Enums.ConditionEnum.NEW;
            createorReplaceInventoryItemrequest.product = new Product()
            {
                title = "GoPro Hero4 Helmet Cam",
                description = "New GoPro Hero4 Helmet Cam. Unopened box."
            };

            var response = _inventoryApiService.CreateorReplaceItemService(createorReplaceInventoryItemrequest, sku).Result;
            if (response.Item2.ToString() == "OK")
                {
                Assert.IsNotNull(response.Item1);
                }
            else
                {
                Assert.Fail(response.Item2.ToString());
                }
            }
        #endregion
        #region InventoryItemGrp

        [TestMethod]
        public void createorReplceItemGroup()
            {
          
            CreateOrReplaceinventoryItemGrpRequest createorReplaceInventoryItemrequest = new CreateOrReplaceinventoryItemGrpRequest();
            string inventoryItemGroupKey = "Mens_Solid_Polo_Shirts";
            createorReplaceInventoryItemrequest.variantSKUs = new string[]
            {
                "MSPS-GrS",
        "MSPS-GrM",
        "MSPS-GrL",
        "MSPS-GrXL",
        "MSPS-BlS",
        "MSPS-BlM",
        "MSPS-BlL",
        "MSPS-BlXL",
        "MSPS-RdS",
        "MSPS-RdM",
        "MSPS-RdL",
        "MSPS-RdXL",
        "MSPS-BkS",
        "MSPS-BkM",
        "MSPS-BkL"
            };
            var response = _inventoryApiService.CreateorReplaceItemgrpProdService(createorReplaceInventoryItemrequest, inventoryItemGroupKey).Result;
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
        public void getInventoryItemGroup()
            {
          
            string inventoryItemGroupKey = "Mens_Solid_Polo_Shirts";
            var response = _inventoryApiService.getInventoryItemGroupService(inventoryItemGroupKey).Result;
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
        public void deleteInventoryItemGroup()
            {
          
            string inventoryItemGroupKey = "Mens_Solid_Polo_Shirts";
            var response = _inventoryApiService.deleteInventoryItemgrpService(inventoryItemGroupKey).Result;
            if (response.Item2.ToString() == "OK")
                {
                Assert.IsNotNull(response.Item1);
                }
            else
                {
                Assert.Fail(response.Item2.ToString());
                }
            }
        #endregion
        #region Listing

        [TestMethod]
        public void bulkMigrateListing()
            {

          
            BulkMigrateListingRequest bulkMigrateListingRequest = new BulkMigrateListingRequest();
            bulkMigrateListingRequest.requests = new MigrateListRequest[]
            {
                new MigrateListRequest()
                {
                    listingId="160009220563"
                },
                new MigrateListRequest()
                {
                    listingId="160009220564"
                },
                new MigrateListRequest()
                {
                    listingId="160009220565"
                }

            };
            var response = _inventoryApiService.bulkMigrateListingService(bulkMigrateListingRequest).Result;
            if (response.Item2.ToString() == "OK")
                {
                Assert.IsNotNull(response.Item1);
                }
            else
                {
                Assert.Fail(response.Item2.ToString());
                }
            }



        #endregion

        #region ProdCompatibility
        [TestMethod]
        public void CreateOrReplaceProductCompatibilityService()
            {
          
            CreateOrReplaceProductCompatibilityRequest createOrReplaceProductCompatibilityRequest = new CreateOrReplaceProductCompatibilityRequest();
            string sku = "Al-8730";
            createOrReplaceProductCompatibilityRequest.compatibleProducts = new CompatibleProduct[]{
                new CompatibleProduct(){
                productFamilyProperties=new ProductFamilyProperties()
                {
                make="Subaru",
                model ="DL",
                year="1982",
                trim="Base Wagon 4-Door",
                engine= "1.8L 1781CC H4 GAS SOHC Naturally Aspirated"
                },
                notes="Equivalent to AC Delco Alternator"
                }

            };
            var response = _inventoryApiService.CreateOrReplaceProductCompatibilityService(createOrReplaceProductCompatibilityRequest, sku).Result;
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
        public void getProdCompatibility()
            {
          
            string sku = "Al-8730";
            var response = _inventoryApiService.getProductCompatibilityService(sku).Result;
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
        public void deleteProdCompatibility()
            {
          
            string sku = "Al-8730";
            var response = _inventoryApiService.deleteProductCompatibilityService(sku).Result;
            if (response.Item2.ToString() == "OK")
                {
                Assert.IsNotNull(response.Item1);
                }
            else
                {
                Assert.Fail(response.Item2.ToString());
                }
            }

        #endregion
        }
    }
