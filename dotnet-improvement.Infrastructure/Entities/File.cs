using System;
using System.Collections.Generic;

#nullable disable

namespace dotnet_improvement.Infrastructure.Entities
{
    public partial class File
    {
        public File()
        {
            ProductFiles = new HashSet<ProductFile>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string ContentType { get; set; }
        public DateTime GenerationDateTime { get; set; }

        public virtual ICollection<ProductFile> ProductFiles { get; set; }
    }
}
