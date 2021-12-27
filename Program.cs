using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Attributes_in_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var Result = Calculator.Add(12, 45); // Correcte but Not useful for Calculate sum of Many numbers just tow .

            var Result2 = Calculator.Add(new List<int>() { 2, 45, 16, 35 });

            Console.WriteLine(Result + "\n"+ Result2);
        }
    }
}
