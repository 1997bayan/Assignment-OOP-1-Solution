using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_opp_1
{
    internal struct Point
    {
        public int x, y;
        public Point(int _x, int _y) {

           x= _x;
            y= _y;
        
        }

        public double Sub()
        {
            return (x - y);
        }
    }

}

   
