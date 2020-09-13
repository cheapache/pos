using POS.Core.Domain.Categories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace POS.Core.Domain.Products
{
    public partial class Category : BaseEntity
    {
        public string CategoryName { get; set; }
        public int Status { get; set; }
        public DateTime? CreatedOnUtc { get; set; }
        public DateTime? UpdatedOnUtc { get; set; }

        [NotMapped]
        public CategoryStatus CategoryStatus
        {
            get => (CategoryStatus)Status;
            set => Status = (int)value;
        }

    }
}
