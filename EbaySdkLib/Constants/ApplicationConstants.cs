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
        public const string TOKEN = "v^1.1#i^1#r^0#f^0#I^3#p^3#t^H4sIAAAAAAAAAOVXa2wURRzvXR9YSyE0hIeUeFmBCGT3Znfv9nY33MG15XEIbeEKAobAPmbbtXu7l9052jVRmyqYCJqixA+CsdWY+EWIaWIgAioCJiQGMSCIRD8gQQ1EQQ2kPmevr2sJ9EVME+/LZmb+r99vfv+5GdBSVLxgx4odt0p9E/ztLaDF7/PRJaC4qHDhpHz/Q4V5IMfA194yp6WgNf+HRY6UMtLiWuikLdOBgeaUYTpidjJKZGxTtCRHd0RTSkFHRIqYjK9eJTIUENO2hSzFMohAoipKyIyqyhEZKDIrCKEIwLNmb8w6K0qosqpyPM9FZIbjNaDhdcfJwITpIMlEUYIBNE+CMMkIdUAQw2GRZSiWDm0iAuuh7eiWiU0oQMSy5YpZXzun1nuXKjkOtBEOQsQS8WXJmniiaml13aJgTqxYDw9JJKGMM3BUaakwsF4yMvDeaZystZjMKAp0HCIY684wMKgY7y1mFOVnqQ7TmsKGWFbgJU7DvN4XKpdZdkpC967Dm9FVUsuaitBEOnKHYhSzIT8JFdQzqsYhElUB77MmIxm6pkM7SiytiG9cl1y6lggka2tta5uuQtVDSrMhmguFIwIRQ9DBFEJ7i6k3SHZPou5oPTQPylRpmarukeYEqi1UAXHVcDA3oRxusFGNWWPHNeRVlGNH070cAm6Tt6ndu5hBDaa3rzCFiQhkh0PvQK8k+kVwv0QhA0ZiaVplFEYJ0Txzhyi8Xh+FMGLe3sRra4NeLVCWXDIl2Y0QpQ1JgaSC6c2koK2rIhvWGJbXIKlygkaGBE0j5bDKkbQGIYBQlhWB/z/pAyFblzMI9mlk8EIWZJRIKlYa1lqGrrjEYJPsmdOjiGYnSjQglBaDwaamJqqJpSy7PsgAQAc3rF6VVBpgSiL6bPWhjUk9qw0FYi9HF5GbxtU0Y+nh5GY9EWNttVaykVuRcfE4CQ0Df3rlO6DC2ODZu0B1PKjjC6Tn7+AAUlqnPHVTipUKWhLuZm9qS7biwHCMgnLGxflVaFM2lFTLNNzh+9VnsHq7vYfn5ODdoLobEcO4I6PX6yMJMIKkurkNa9my3RHCHOg8Ah9JUayMiUaTrsd1BB5axtB0w/DadTQJc9xHUqYpGS7SFWc0KXNOY0yvo9c3oJHGwXP4CMf+ioQkw+qX05iaPZ5OJ9Tx1ezZvwa9USIdyVRlq5lMVmwgBU6WVQ5mz3KN5xmJHhPsKrjtv4Vd0OpvGho6LwBZ1oQwCWiOI0NQ4UmeE0Ikq4AwAxVapSNwTLgrDR2rvs4dbwf8CstBUB0bNHzPGl+gPN32yjai0QLJgjBNhjiVIXmGi5BAhspwIQfvel2546YaHPhUjOVlf3Sr7who9R3Cr00QASS9EMwvyl9XkD+RcHQEqZ5eo3RJo/DxZOKXkA2pRuimJd32F/memPXT4j9zHqntm8GMvmdqcT5dkvNmBeX9K4X05OmlNI/lKwAhHGaZTeCR/tUCelrB1G+vHg3/svP4wa4pNZtrTjcXfXmxoROU9hn5fIV5Ba2+vI3vfnjp4e1tH7x2/cjJGzWtHcXF12e+6D++82DyBLm242KJUjJvdvVznyQ2vHei9PWP4OVrV47NXRKMpN3GF84yE2NX2p79u2LX/JdWPU6dn/M8uW/3nnn+hZ1vTOjcX166d0V77PfvouWPde3Su8hXzh2uXFdW45+xp/yz6Q/U11mLPj01of6vawW1K8/V3Z625xv36L6b3MmV68+fWa4o4fPb0amrNzq2XHhbdDsfXDDr8q1nDm0tL5sLv6fa5iZ/vr378Kvmma2xeY8u2Xrg/ZabXz91qWTNzbKvZjeWbbx9bPfxj6umpaoWnz5QNLWr5dd/Ju3ftfetN0+Wme+0/dbxxecNl1+eOWXyhR8TZ/94unsb/wUDYybXPhAAAA==";
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
