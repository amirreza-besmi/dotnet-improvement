using System;
using System.Collections.Generic;

#nullable disable

namespace dotnet_improvement.Infrastructure.Entities
{
    public partial class ProductFile
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int FileId { get; set; }
        public DateTime GenerationDateTime { get; set; }

        public virtual File File { get; set; }
        public virtual Product Product { get; set; }
    }
}
