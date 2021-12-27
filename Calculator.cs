using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes_in_Csharp
{
    public class Calculator
    {
        [ObsoleteAttribute ("Use The Add List Method that takes many integers")] //Attribute 
        public static int Add(int FirNumber , int SecNumber)
        {
            return FirNumber + SecNumber;
        }

        // In this case we can't create a many functions with many Parameters that takes a lot of time .

        public static int Add(List<int> Numbers) // Add a List of infinite Numbers inside Function Add();
        {
            int Sum = 0;

            foreach (int number in Numbers)
                Sum += number;

            return Sum;
        }
    }
}
