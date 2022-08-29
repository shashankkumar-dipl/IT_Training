using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    public struct StructRectangle
    {
        public int height, width;

        public StructRectangle(int h, int w)
        {
            height = h;
            width = w;
        }

        public void areaOfReactangle()
        {
            int area = height * width;
            Console.WriteLine("\nArea = " + area);
        }
    }


}
