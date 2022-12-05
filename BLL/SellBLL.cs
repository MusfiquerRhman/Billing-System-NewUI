using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billing_System.BLL
{
    class SellBLL
    {
        public string ProductID { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public int Discount { get; set; }
        public double GrandTotal { get; set; }
        public string PhoneNo { get; set; }
    }
}
