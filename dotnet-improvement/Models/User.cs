using System.ComponentModel.DataAnnotations;

namespace dotnet_improvement.Models
{
    public class User
    {
        public int Id { get; set; }
        
        [MaxLength(200)]
        public string Name { get; set; }

        public decimal CreditAmount { get; set; }
    }
}
