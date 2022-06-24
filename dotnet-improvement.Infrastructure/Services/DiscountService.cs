using dotnet_improvement.Core.Interfaces;
using System;

namespace dotnet_improvement.Infrastructure.Services
{
    public class DiscountService : IDiscountService
    {
        public void SetDiscountCode(string email, string discountCode)
        {
            Console.WriteLine($"Discount code [{discountCode}] has been set for [{email}]...");
        }
    }
}
