
using System.ComponentModel.DataAnnotations;

namespace dotnet_improvement.Models
{
    public class Product
    {
        public int Id { get; set; }
        [MaxLength(200)]
        public string Name { get; set; }
    }
}
