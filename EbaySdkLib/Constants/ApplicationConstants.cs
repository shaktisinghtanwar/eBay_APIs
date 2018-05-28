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
        public const string BASE_URL = "https://api.sandbox.ebay.com";
        public const string CONTENT_LANGUAGE = "en-US";
        public const string TOKEN = "v^1.1#i^1#f^0#I^3#r^0#p^3#t^H4sIAAAAAAAAAOVXW2wUVRju9gYVWzVBbkJcRiRKnd0zM7uzu0N3ddtCWYW2dJcGKJecmTnTDp2dWeacpd2QSGmxkduD0WAaiOmDgIaHJkZtwPCCAYwPKpqaEGJjvCRESEQxoAajZ3d72dYAvRDTxH3ZPef81+///n/PAR3FJSu613TfLnXMyu/tAB35Dgc3B5QUF5WXFeQvKsoDOQKO3o5lHYWdBVcrMIwbCakB4YRlYuRsjxsmljKbQSZpm5IFsY4lE8YRlogiRcPr1kq8C0gJ2yKWYhmMM1IdZDQgChongoAXcoIfKHTXHLYZs4JMACga5KDqUb2C6PGL9BzjJIqYmECTBBkecH4WeFlejHG8xAckzufifPxmxtmIbKxbJhVxASaUCVfK6No5sd47VIgxsgk1woQi4dXRunCkelVtrMKdYys0hEOUQJLEY1dVloqcjdBIonu7wRlpKZpUFIQx4w5lPYw1KoWHg5lC+BmoOVEQvX6eV9UAx2kAPRAoV1t2HJJ7x5He0VVWy4hKyCQ6Sd0PUYqGvAMpZGhVS01Eqp3pr/VJaOiajuwgs6oyvGlDdFUD44zW19vWLl1FaiZTwcN5eT8nMCGCMIUQ2dtNvQXaeisc8pU1OIT0OGdVlqnqadyws9YilYgGjsbDw+XAQ4XqzDo7rJF0ULlynmEYRSrnHi5kkrSY6dKiOMXCmVnevwjDrBjlwYPiBS96ednHQcD5oE8TwVhepHt9atwIpcsTrq93p2NBMkyxcWi3IpIwoIJYhcKbjCNbVyXBq/GCX0OsKgY01hPQNFb2qiLLaQgBhGRZCfj/ZxQhxNblJEEjNBl/kMkzyEQVK4HqLUNXUsx4kczkGSJFOw4yLYQkJLe7ra3N1Sa4LLvZzQPAuTeuWxtVWlAcMiOy+v2FWT1DD4VOESovkVSCRtNO2Uedm81MSLDVemiTVGUyRddRZBj0a5jBYyIMjd+9S6o4nerMSjKtj6kBmNBdaYK7FCvutiBt6PTW9kzEzokIueVkivpXke2yEVQt00hNXK85SQmc1Z6YEqbVcGV7kaaR4zHd65M3MAmnurmLctmyU5NMc6zyJHSgolhJk0zF3ZDqJDS0pKHphpFu16k4zFGfTJgmNFJEV/BUXOYMZAov1ptbyGTt0D06xam+Agk0rFE6TavZw4lERJ1ZzY5bYCu9uUBWob/sBFbZaOVGVhRFvxeo9C8LqX7gQ5pnWnlXo13/Ud6FnfkvTzh30RPwBQRVY71eGbEeD0SsrPI8S3vEI6saJyuaMK28qwyd0j6WmmkTfo2FCVKnlxq9a82spLK8zdLWqwmIFaCHZz2iorCy6POwASEw4Wq673pf+ddt1T32xRjKy3y4TsdZ0Ok4TR+dwAdYrhw8W1ywobDgYQbrBLkwNFXZanfpUHPR+WTSB5GNXK0olYC6nV/saHrip+fv5LxVe7eCBSOv1ZICbk7O0xUsHj0p4h6ZX8r5gZcXOZ4PcL7N4KnR00JuXuHcnvlPf1Fa5W/tubH5h4HF+4/02WUvgNIRIYejKK+w05F38pnj7tm/XX/Nc7mmv/TcG0d7r11Y3l8jX/nZv+n8+7Prvi5Y+EvTwYozO4u+mbvh7Du/rjlwfqD8xLmub8sbagKH+7Ztvbj60JnQYHeff33Zm4d3FGFyoevxR/vn8ttOMXmvvsd9sLLp4IrHru3Z+9Fn83q232ruOtXwd+yrOxVLUO/AnpWXrp96u+9q+cdx2N3+Y+ranzfrdP++0n24v2xpY8mTCxf0fBJfuvWyUfXc9dpXbg8Orlsm76659frem8qWpjns0dYVHy6JLXqr80rqu9NNAzcqdqvLj/2+sfuY9tfJAxe3fFl6vBi/+7mrO7Lz+7C++6X6E5eCXbftkrazf7w4C8eqj+wfbPxUfyhbxn8AIe9jMkUQAAA=";
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

        public const string ANALYTICS_URL = "sell/analytics/v1/traffic_report/?filter=";

        public const string COMPLIANCE_URL = "sell/compliance/v1/listing_violation_summary";
        public const string SELLER_STANDARDS_URL = "sell/analytics/v1/seller_standards_profile";
        public const string LISTINGVIOLATION_URL = "sell/compliance/v1/listing_violation";
        public const string CATALOG_URL = "commerce/catalog/v1_beta/product";
        public const string PRODUCTMETADATA_URL = "commerce/catalog/v1_beta/get_product_metadata";
        public const string PRODUCTMETADATAFORCATEGORIES_URL = "commerce/catalog/v1_beta/product";
        public const string GETCHANGEREQUEST_URL = "commerce/catalog/v1_beta/change_request";

        }
    }
