using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Dynamic;
using System.Text;

namespace POS.Core.Domain.Products
{
    public partial class ProductImage : BaseEntity
    {

        public int ProductId { get; set; }
        public string ImageName { get; set; }
        public string ImagePath { get; set; }
        public int Status { get; set; }
        public DateTime? CreatedOnUtc { get; set; }
        public DateTime? UpdatedOnUtc { get; set; }

        [NotMapped]
        public ProductStatus ProductStatus
        {
            get => (ProductStatus)Status;
            set => Status = (int)value;
        }
    }
}
