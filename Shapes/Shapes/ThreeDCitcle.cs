﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class ThreeDCitcle : Circle
    {
        protected new String shapeName;
        public new void Draw()
        {
            Console.WriteLine("Drawing a 3D Circle");
        }
    }
}
