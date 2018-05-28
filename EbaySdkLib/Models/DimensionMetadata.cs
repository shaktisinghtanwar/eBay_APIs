using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EbaySdkLib.Models
{
    public class DimensionMetadata
    {
        public MetadataHeader metadataHeader { get; set; }
        public MetadataRecord[] metadataRecords { get; set; }
    }
}
