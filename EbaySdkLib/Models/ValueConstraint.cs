using System.Collections.Generic;

namespace EbaySdkLib.Models
{
    public class ValueConstraint
    {
        public string applicableForLocalizedAspectName { get; set; }
        public List<string> applicableForLocalizedAspectValues { get; set; }
    }
}
