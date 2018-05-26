using System.Collections.Generic;

namespace EbaySdkLib.Models
{
    public class Aspect
    {
        public AspectConstraint aspectConstraint { get; set; }
        public List<AspectValue> aspectValues { get; set; }
        public string localizedAspectName { get; set; }
    }
}
