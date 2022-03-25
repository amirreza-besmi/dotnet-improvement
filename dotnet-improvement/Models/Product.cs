
using System.ComponentModel.DataAnnotations;

namespace dotnet_improvement.Models
{
    public class Product
    {
        public int Id { get; set; }
        
        [MaxLength(200)]
        public string Name { get; set; }

        public decimal Price { get; set; }


        #region == Methods ==

        public static bool Compare(Product product1, Product product2)
        {
            return product1.Price > product2.Price;
        }

        #endregion
    }
}
