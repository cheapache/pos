using POS.Core.Domain.Orders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;
using System.Text;

namespace POS.Core.Domain.Products
{
    public partial class Product : BaseEntity
    {
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal ProductPrice { get; set; }
        public decimal ProductDiscount { get; set; }
        public int Status { get; set; }
        public int CategoryId { get; set; }
        public DateTime? CreatedOnUtc { get; set; }
        public DateTime? UpdatedOnUtc { get; set; }
        public virtual ICollection<ProductImage> ProductImages { get; set; }
        public ProductStatus ProductStatus
        {
            get => (ProductStatus)Status;
            set => Status = (int)value;
        }

    }
}
