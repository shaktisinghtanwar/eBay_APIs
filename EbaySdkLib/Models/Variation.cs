namespace EbaySdkLib.Messages
{
    public class Variation
    {
        public string sku { get; set; }
        public VariationAspect[] variationAspects { get; set; }
    }
}