using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optional_Method_Parameter_App
{
    public class mathIntegers
    {
        //second int parameter set an initial value 
        public int mathStuff(int x, int y = 0)
        {
            return x + y;
        }
    }
}
