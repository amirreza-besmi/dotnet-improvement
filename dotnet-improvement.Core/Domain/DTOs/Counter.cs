using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet_improvement.Core.Domain.DTOs
{
    public class Counter
    {
        private Counter() { }

        public static int currentCount;

        public static int IncrementCount()
        {
            return ++currentCount;
        }
    }
}
