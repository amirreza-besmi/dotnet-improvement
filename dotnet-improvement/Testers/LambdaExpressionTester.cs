using dotnet_improvement.Core.Domain.Entities;
using System.Collections.Generic;

namespace dotnet_improvement.Presentation.Testers
{
    public static class LambdaExpressionTester
    {
        // Added from C# verion 9
        public static void TestStaticLambdaExpression()
        {
            List<Product> products = new List<Product>()
            {
                 new Product { Id = 1, Name = "Camera" },
                 new Product { Id = 2, Name = "Laptop" }
            };

            const int id = 2;
            var firstProduct = products.Find(static x => x.Id == id);
        }
    }
}
