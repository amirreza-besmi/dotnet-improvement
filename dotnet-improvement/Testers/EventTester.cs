using dotnet_improvement.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_improvement.Testers
{
    public static class EventTester
    {
        public static void TestAddProductEvent()
        {
            ProductService productService = new ProductService(); // for test
            // productService.AddProductEvent += AddProductHandler;
            productService.Add("Book");
        }


        #region == Private Methods ==

        private static void AddProductHandler()
        {
            Console.WriteLine("Add Product Handled!");
        }

        #endregion

    }
}
