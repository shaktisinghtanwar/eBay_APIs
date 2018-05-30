using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EbaySdkLib.Constants
    {
    static class ApplicationConstants
        {
        public const string CONTENT_TYPE = "application/json";
        public const string BASE_URL = "https://api.sandbox.ebay.com/";
        public const string CONTENT_LANGUAGE = "en-US";
        public const string TOKEN = "v^1.1#i^1#f^0#r^0#p^3#I^3#t^H4sIAAAAAAAAAOVXe2wURRi/6wt5FNFAMULkWJRYcO9mbx93t7aHV1rCGSiVaxFLkM7tzrZr93aPndm2FxJTakQTQ4ImGkJiqDyCRIPwB6ImBAOBBFGJCWowETQoaGPEIIZgRJ296+NaAvRBTBPvj9udme/1+77fNzsDOksmLti0dNO1Uu+Egu5O0Fng9XKTwcSS4oVTCwseLPaAPAFvd+fDnUVdhT9VYJgy0vJKhNOWiZGvI2WYWM5OVjKObcoWxDqWTZhCWCaKnIgtXyYH/UBO2xaxFMtgfPHqSgbyqsgLIKxw9F8UAZ01+2zWW5WMhEJADIV5VVIgpyUjdB1jB8VNTKBJKpkg4MIsEFke1IOIzEdkQH2IXCPjW4VsrFsmFfEDJpoNV87q2nmx3j5UiDGyCTXCROOxJYkVsXh1TW19RSDPVrQ3DwkCiYMHjxZbKvKtgoaDbu8GZ6XlhKMoCGMmEM15GGxUjvUFM4rws6nmJImXEOA1VYAhDQTvSiqXWHYKktvH4c7oKqtlRWVkEp1k7pRRmo3kc0ghvaNaaiJe7XMfTznQ0DUd2ZVMTVXsmYZEzUrGl6irs602XUVqFikvcJIghiJMlCBMU4jsdabeAu1eRzlrvWke4mmxZaq6mzTsq7VIFaJRo6G5CeblhgqtMFfYMY24EeXJcVxfDgW+0S1qrooOaTHduqIUTYQvO7xzBfooMUCCu0UKgZe4cEQJhbSwCGAI3UQKt9dHQYyoW5tYXV3AjQUlYYZNQbsVkbQBFcQqNL1OCtm6KvOiFuTDGmJVKaKxQkTT2KSoSiynIQQQSiaVSPj/xA9CbD3pENTPkaELWZCVTEKx0qjOMnQlwwwVye45vYzowJVMCyFpORBob2/3t/N+y24OBAHgAquXL0soLSgFmX5Z/c7CrJ7lhkKpQuVlkknTaDoo9ahzs5mJ8rZaB22SqXIydJxAhkEfffQdFGF06OwtoGIX6vgC6epjagCmdb/Lbr9ipQIWpN3sTq3LRuwbjlAg6WSofxXZfhtB1TKNzPD1mh3K3pz28JQwrYY/14gUxk0e3V4fiYERONXNNsply86MEOZg5RHoQEWxHJOMxl2v6gg0NMfQdMNw23U0DvPURxKmCY0M0RU8Gpd5uzFNL9abW8hI7dA5uoVTfQUSaFgDdBpTs8fS6bg6vpodt8BWemaBrELf7DRW2UTValaSJPrJVOn3CqlhEEKaMCbc1ajtP8Vd1FXQMQzskhAJRXhVY0UxiVhBgIhNqsEgS3tESKoal1Q0fky4Fxs6pX19Zrzt8EstTJA6Nmj0oDW+QOV4m6OtqPGI5aEQZAVJUdikFBLYCB8ZdjUDtzyv3HRUDQy+K0Y92R/X5T0Murwf0usmCAGWWwjKSwobigqnMFgnyI+hqSatDr8ONT/dn0x6FbKRvxVl0lC3C0q8a2b1LPor75bavRY80H9PnVjITc67tILZAyvF3L0zS7kwEHkAKF4QbATzBlaLuLKi6X9uLvcue7Xk77f3PHv29bKehjPifftAab+Q11vsKeryetZiVlnfPundQxvv2VbYVLrTI7ZEmrqv9rS+9MnTk6zf6g4uadv5j7Tx959vbFu14/SLFfyTF/d/MON89QYLTrvwJZr+TsPBy2c9sxthw/YX9u/fVTTzsfU1e6dvNU4//0XqvSmndmw/37r1MHu6M37lzUcXzqmo+TbtO7WrOH5MQaT+/RllL1+5dOK7UOe13Q8xr5xbx2ybP5W/+MsCciwT+6Oi3M/Wyluvz928xeY/P35mw7nL19a+5QDf1T1vrCku2xv+pmnOieOH4dHvmzzKoh553vUjvx5Fcz+7VPvxhK9u7N7QOuu1qZ92TPtxZfjrPRcOCUfks5pyoOLxk/seKf/oZHP3/ScO7Hvih/m5Mv4LvLaRCT8QAAA=";
        public const string PaymentPolicy_Url = "sell/account/v1/payment_policy/";
        public const string RATETABLE_URL = "sell/account/v1/rate_table/?country_code=";
        public const string INVENTORY_URL = "sell/inventory/v1/";
        public const string RETURNPOLICY_URL = "sell/account/v1/return_policy/";
        public const string INVENTORYLOCATION_URL = "sell/inventory/v1/location/";
        public const string INVENTORYOFFER_URL = "sell/inventory/v1/offer/";
        public const string JURISDICTION_URL = "sell/metadata/v1/country/";
        public const string MARKETPLACE_URL = "sell/metadata/v1/marketplace/";
        public const string ACCEPT_ENCODING = "application/gzip";
        public const string INVENTRYITEMGROUP_URL = "sell/inventory/v1/inventory_item_group/";
        public const string _URLCOMPAIGN = "sell/marketing/v1/ad_campaign/";
        public const string _URLPROMOTION = "sell/marketing/v1/item_promotion";
        public const string PRODCOMPATIBILITY_URL = "sell/inventory/v1/inventory_item/";

        public const string ANALYTICS_URL = "sell/analytics/v1/traffic_report/";

        public const string COMPLIANCE_URL = "sell/compliance/v1/listing_violation_summary";
        public const string SELLER_STANDARDS_URL = "sell/analytics/v1/seller_standards_profile";
        public const string LISTINGVIOLATION_URL = "sell/compliance/v1/listing_violation";
        public const string CATALOG_URL = "commerce/catalog/v1_beta/product";
        public const string PRODUCTMETADATA_URL = "commerce/catalog/v1_beta/get_product_metadata";
        public const string PRODUCTMETADATAFORCATEGORIES_URL = "commerce/catalog/v1_beta/product";
        public const string GETCHANGEREQUEST_URL = "commerce/catalog/v1_beta/change_request";
        public const string SELLER_ANALYTICS_URL = "sell/analytics/v1/seller_standards_profile";

        public const string BULKCREATEADSBYINVENTORY_URL = "sell/marketing/v1/ad_campaign/";
        public const string GETREPORT_URL = "sell/marketing/v1/ad_report/";
        public const string GETREPORTMETADATA_URL = "sell/marketing/v1/ad_report_metadata/";


        public const string ADDREPORTTASK_URL = "sell/marketing/v1/ad_report_task";

        public const string PROMOTIONLIST_URL = "sell/marketing/v1/promotion";
        public const string ITEMPRICE_URL = "sell/marketing/v1/item_price_markdown";
        public const string PROMOTIONREPORT_URL = "sell/marketing/v1/promotion_report";
        public const string PROMOTIONSUMMARYREP_URL = "sell/marketing/v1/promotion_summary_report";
        public const string ORDER_URL = "sell/fulfillment/v1/order/";
        public const string ORDERS_URL = "sell/fulfillment/v1/order/";
        public const string PROGRAM_URL  = "sell/account/v1/program";
        public const string FULFILMENT_URL = "sell/account/v1/fulfillment_policy";
        public const string PRIVILAGE_URL = "sell/account/v1/privilege";
        public const string SALESTAX_URL = "sell/account/v1/sales_tax/";
        }
    }
