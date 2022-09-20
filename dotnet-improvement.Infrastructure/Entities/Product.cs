using System;
using System.Collections.Generic;

#nullable disable

namespace dotnet_improvement.Infrastructure.Entities
{
    public partial class Product
    {
        public Product()
        {
            ProductFiles = new HashSet<ProductFile>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public DateTime GenerationDateTime { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<ProductFile> ProductFiles { get; set; }
    }
}
