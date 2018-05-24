using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EbaySdkLib.Models
{
    public class PaymentMethod
        {
        public List<string> brands { get; set; }
        public string paymentMethodType { get; set; }
        public RecipientAccountReference recipientAccountReference { get; set; }
        }
}
