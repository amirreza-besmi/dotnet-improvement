using dotnet_improvement.Core.Services;
using System;

namespace dotnet_improvement.Presentation.Testers
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
