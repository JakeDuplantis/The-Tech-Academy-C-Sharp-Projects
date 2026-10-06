using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Methods_App
{
    public class mathMethod
    {
        public void mathStuff(int numX) 
        {     
            int divNumX = numX / 2;
            Console.WriteLine(numX + " divided by 2 equals " + divNumX);
        }

        //method with output parameters
        public void mathStuff2(int NumX, int NumY, out int result)
        {
            result = NumX + NumY;
            Console.WriteLine(NumX + " plus " + NumY + " equals " + result);
            
        }

        //named like previous to overload
        public void mathStuff2(double NumX, double NumY, out double result) 
        {
            result = NumX + NumY;
            Console.WriteLine(NumX + " plus " + NumY + " equals " + result);
        }

    }
}
