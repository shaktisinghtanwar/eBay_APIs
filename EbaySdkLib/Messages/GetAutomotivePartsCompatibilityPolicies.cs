﻿using EbaySdkLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EbaySdkLib.Messages
    {
 public   class GetAutomotivePartsCompatibilityPolicies
        {
        public AutomotivePartsCompatibilityPolicy[] automotivePartsCompatibilityPolicies { get; set; }
        public Warning[] warnings { get; set; }
        }
    }
