using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisionProblem
{
    public class LineComparision
    {
        public int x1 = 30, x2 = 63, y1 = 36, y2 = 70;

        public double length;
        public int l1, l2;

        public void checkLength()
        {
            length = Math.Sqrt((Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)));
            Console.WriteLine("The length Is -> "+length);
        }
        public void checkEquality()
        {
            l1 = x2 - x1;
            l2 = y2 - y1;
            if (l1.Equals(l2))
            {
                Console.WriteLine("*** The given two straight lines are Identical ***");
            }
            else
            {
                Console.WriteLine("*** The given two straight lines are not Identical ***");
            }          
        }
    }
}
