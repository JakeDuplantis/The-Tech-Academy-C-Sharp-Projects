using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Parameters_App
{
    public class Employee<T>
    {
        //List Things with generic data type matching class generic type
        public List<T> Things {  get; set; }
    }
}
