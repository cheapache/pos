using POS.Core.Domain.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace POS.Core.Domain.Orders
{
    public partial class Order : BaseEntity
    {
        public string OrderCode { get; set; }
        public int Status { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public DateTime? CreatedOnUtc { get; set; }

        public OrderStatus OrderStatus {
            get => (OrderStatus)Status;
            set => Status = (int)value;
        }

    }
}
