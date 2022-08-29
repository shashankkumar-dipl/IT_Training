using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    internal class Shape
    {
        public int length { get; set; }
        public int width { get; set; }
        public int radius { get; set; }


        public Shape()
        {
            //GIVE DEFAULT VALUES
            this.length = 1;
            this.width = 1;
            this.radius = 1;
        }

        public double getCircleArea()
        {
            return this.radius * this.radius * 2.13;
        }
        public double getCircleArea(int radius)
        {
            return radius * radius * 2.13;
        }

        public double getRectangleArea()
        {
            return this.length * this.width;
        }

        public double getRectangleArea(int length, int width)
        {
            return length * width;
        }
    }
}
