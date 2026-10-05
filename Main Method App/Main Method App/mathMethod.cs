using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method_App
{
    public class mathMethod
    {
        public int mathStuff(int X)
        {
            return X + 5;
        }

        public decimal mathStuff(decimal X)
        {
           
            return  X / 2;
        }

        public string mathStuff(string X) 
        {
            //convert to int for math operation then convert back to string
            int numX = Convert.ToInt32(X);
            int numY = numX * 3; 
            string numZ = Convert.ToString(numY);
            return numZ;
           
        }

    }
}
