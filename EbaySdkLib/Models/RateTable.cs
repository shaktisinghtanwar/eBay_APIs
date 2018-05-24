using EbaySdkLib.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EbaySdkLib.Models
    {
    public class RateTable
        {
        [JsonConverter(typeof(StringEnumConverter))]
        public CountryCodeEnum countryCode { get; set; }
        public string locality { get; set; }
        public string name { get; set; }
        public string rateTableId { get; set; }
        }
    }
