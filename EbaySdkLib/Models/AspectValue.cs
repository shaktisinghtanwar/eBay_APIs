using System.Collections.Generic;

namespace EbaySdkLib.Models
{
    public class AspectValue
    {
        public string localizedValue { get; set; }
        public List<ValueConstraint> valueConstraints { get; set; }
    }
}
