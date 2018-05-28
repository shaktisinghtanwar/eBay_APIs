using EbaySdkLib.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EbaySdkLib.Models
{
    public class Metric
    {
        public StandardsLevelEnum level { get; set; }
        public string lookbackEndDate { get; set; }
        public string lookbackStartDate { get; set; }
        public string metricKey { get; set; }
        public string name { get; set; }
        public string thresholdLowerBound { get; set; }
        public string thresholdMetaData { get; set; }
        public string thresholdUpperBound { get; set; }
        public DataTypeEnum type { get; set; }
        public string value { get; set; }
    }
}
