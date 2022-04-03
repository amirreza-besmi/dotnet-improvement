using dotnet_improvement.Core.Domain.Entities;
using dotnet_improvement.Utility.Helpers;
using System;
using System.Collections.Generic;

namespace dotnet_improvement.Presentation.Testers
{
    public static class SortTester
    {
        public static void StartBubbleSortGenericProcess()
        {
            #region == Users ==

            List<User> users = new List<User>();
            users.Add(new User { Id = 1, Name = "Ehsan", CreditAmount = 10000 });
            users.Add(new User { Id = 2, Name = "Rashid", CreditAmount = 70000 });
            users.Add(new User { Id = 3, Name = "Zaynab", CreditAmount = 43000 });
            users.Add(new User { Id = 4, Name = "Saeed", CreditAmount = 8900 });
            users.Add(new User { Id = 5, Name = "Sadegh", CreditAmount = 50 });

            users.BubbleSort(User.Compare);

            foreach (var item in users)
            {
                Console.WriteLine($"Name: {item.Name}, Credit: {item.CreditAmount}");
            }

            #endregion

            #region == Products ==

            List<Product> products = new List<Product>()
            {
                 new Product { Price = 50000 },
                 new Product { Price = 178000 },
                 new Product { Price = 150 },
                 new Product { Price = 2500 },
            };

            products.BubbleSort(Product.Compare);

            foreach (var item in products)
            {
                Console.WriteLine($"Price : {item.Price}");
            }

            #endregion
        }

        public static void StartBubbleSortProcess()
        {
            int[] array = { 8, 6, 4, 2, 9, 3, 1, 5, 7 };
            array.BubbleSort();
            var sortedArray = array;
        }
    }
}
