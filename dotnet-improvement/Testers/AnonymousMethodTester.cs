using dotnet_improvement.Core.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace dotnet_improvement.Presentation.Testers
{
    public static class AnonymousMethodTester
    {
        // Added from C# verion 2
        public static void TestAnonymousMethod()
        {
            List<Product> products = new List<Product>()
            {
                 new Product { Id = 1, Name = "Camera" },
                 new Product { Id = 2, Name = "Laptop" }
            };

            var firstProduct = products.Find(
                delegate (Product product)
                {
                    return product.Id == 1;
                });
            var firstProduct_with_lamdaExpression = products.Find(x => x.Id == 1);
        }

        // Used in C# lower than verion 2
        public static void TestNamedMethod()
        {
            List<Product> products = new List<Product>()
            {
                 new Product { Id = 1, Name = "Camera" },
                 new Product { Id = 2, Name = "Laptop" }
            };

            var laptops = products.Where(IsLaptop);
            var cameras = products.Where(IsCamera);
            var firstProduct = products.Find(IsFirstId);
        }


        #region == Private Methods ==

        // Sample named method
        private static bool IsLaptop(Product product)
        {
            return product.Name == "Laptop";
        }

        // Sample named method
        private static bool IsCamera(Product product)
        {
            return product.Name == "Camera";
        }

        // Sample named method
        private static bool IsFirstId(Product product)
        {
            return product.Id == 1;
        }

        #endregion

    }
}
