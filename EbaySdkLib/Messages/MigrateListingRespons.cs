﻿using EbaySdkLib.Models;

namespace EbaySdkLib.Messages
{
    public class MigrateListingRespons
    {
        public int statusCode { get; set; }
        public string listingId { get; set; }
        public string inventoryItemGroupKey { get; set; }
        public MarketplaceIdEnum marketplaceId { get; set; }
        public InventoryItem[] inventoryItems { get; set; }
        public Warning[] errors { get; set; }
        public Warning[] warnings { get; set; }

    }
}