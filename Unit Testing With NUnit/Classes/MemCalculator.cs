using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_Testing_With_NUnit.Classes
{
    public class MemCalculator
    {
        private int sum = 0;

        public void Add(int number)
        {
            sum += number;
        }

        public int Sum()
        {
            int temp = sum;
            sum = 0;
            return temp;
        }
    }
}
