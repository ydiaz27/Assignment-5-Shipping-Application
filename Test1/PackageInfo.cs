using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingApp
{
    public class PackageInfo
    {
        public string trackingNumber { get; set; }
        public string recipientName { get; set; }
        public string streetAddress { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string postalCode { get; set; }
        public string emailAddress { get; set; }
        public string phoneNumber { get; set; }
        public string dateShipped { get; set; }
        public string dateDelivered { get; set; }
        public string packageWeight { get; set; }
        public string carrier { get; set; }
        public string deliveryMode { get; set; }
        public string isFragile { get; set; }
    }
}
