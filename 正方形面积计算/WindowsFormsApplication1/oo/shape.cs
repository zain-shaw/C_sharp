using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.oo
{
    class shape
    {
        public string name { get; set; }
        public string whoami()
        {
            return name;
        }
    }
    class square:shape
    {
        public double width;
        public double getarea ()
        {
            return width * width;
        }
    }
}
