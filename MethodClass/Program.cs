using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClass
{
    class Program
    {
        static void Main(string[] args)
        {
            MathDisplay mathDisplay = new MathDisplay();

            mathDisplay.MathDis(5, 7);

            Console.ReadLine();
        }
    }
}
