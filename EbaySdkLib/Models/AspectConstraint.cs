using EbaySdkLib.Enums;

namespace EbaySdkLib.Models
{
    public class AspectConstraint
    {
        public AspectDataTypeEnum aspectDataType { get; set; }
        public bool aspectEnabledForVariations { get; set; }
        public string aspectFormat { get; set; }
        public AspectModeEnum aspectMode { get; set; }
        public bool aspectRequired { get; set; }
        public ItemToAspectCardinalityEnum itemToAspectCardinality { get; set; }
    }
}
