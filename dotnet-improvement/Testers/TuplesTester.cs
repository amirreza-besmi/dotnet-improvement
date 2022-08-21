using dotnet_improvement.Core.Domain.Entities;
using System;

namespace dotnet_improvement.Presentation.Testers
{
    public static class TuplesTester
    {
        public static void TestTuples()
        {
            CompareTuples();
        }

        private static void TestSimpleTuples()
        {
            var user1 = (1000, "Ali", "Tehran");
            Console.WriteLine($"{user1.Item1}, {user1.Item2}, {user1.Item3}");
        }

        private static void TestTuplesWithNames()
        {
            string lastName = "Bagheri";
            var user1 = (Id: 1000, Name: "Ali", lastName, City: "Tehran");
            Console.WriteLine($"{user1.Item1}, {user1.Item2}, {user1.Item3}");
            Console.WriteLine($"{user1.Id}, {user1.Name}, {lastName}, {user1.City}");

            DateTime date = DateTime.Now;
            var dateTuples = (year: date.Year, date.Month, date.Day);
            Console.WriteLine($"{dateTuples.year}, {dateTuples.Month}, {dateTuples.Day}");

            var user2 = GetUser();
            Console.WriteLine(user2.Name);

            ValueTuple<int, string> user3 = ValueTuple.Create(1000, "Ali");
            (int, string) user4 = ValueTuple.Create(1000, "Ali");
            (int Id, string Name) user5 = ValueTuple.Create(1000, "Ali");

            // Deconstructing Tuples (filling it's values into local variables)
            (int userId, string userName) = user5;
            Console.WriteLine(userId);

            var product = new Product(100, "LG Mobile");
            Console.WriteLine(product.Name);
        }

        private static void CompareTuples()
        {
            // Value Type
            var user1 = (Id: 1000, Name: "Ali");
            var user2 = (Id: 1000, Name: "Ali");
            
            // Reference Type
            Tuple<int, string> user3 = Tuple.Create(1000, "Ahmad");
            Tuple<int, string> user4 = Tuple.Create(1000, "Ahmad");

            Console.WriteLine(user1 == user2);
            Console.WriteLine(user1.Equals(user2));

            // Mutable
            user1.Name = "Reza";
            Console.WriteLine(user1.Name);

            // Immutable
            // user3.Item2 = "Reza";

            Console.WriteLine(user3 == user4); // False because check references for comparing
            Console.WriteLine(user3.Equals(user4)); // True because check values for comparing
        }

        private static (int Id, string Name, string LastName, string Address) GetUser()
        {
            return (1000, "Ali", "Bagheri", "Tehran");
        }
    }
}
