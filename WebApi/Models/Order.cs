using System;
using System.Collections.Generic;

#nullable disable

namespace WebApi.Models
{
    public partial class Order
    {
        public int OrderId { get; set; }
        public string OrderedItem { get; set; }
        public DateTime? OrderedDate { get; set; }
        public int? OrderQuantity { get; set; }
        public int CustId { get; set; }

        public virtual Customer Cust { get; set; }
    }
}
