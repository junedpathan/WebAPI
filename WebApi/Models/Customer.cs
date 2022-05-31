using System;
using System.Collections.Generic;

#nullable disable

namespace WebApi.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Order>();
        }

        public int CustId { get; set; }
        public string CustName { get; set; }
        public string CustEmail { get; set; }
        public string CustAdd { get; set; }
        public string CustCity { get; set; }
        public string CustState { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
