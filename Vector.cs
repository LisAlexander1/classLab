using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classLab
{
    internal class Vector
    {
        private double x1, y1, x2, y2;

        public double X1 { get => x1; set => x1 = value; }
        public double Y1 { get => y1; set => y1 = value; }
        public double X2 { get => x2; set => x2 = value; }
        public double Y2 { get => y2; set => y2 = value; }

        public Vector()
        {
            this.x1 = 0;
            this.y1 = 0;
            this.x2 = 5;
            this.y2 = 5;
        }
        public Vector(double x2, double y2)
        {
            this.x1 = 0;
            this.y1 = 0;
            this.x2 = x2;
            this.y2 = y2;
        }
        public Vector(double x1, double y1, double x2, double y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }

        public double[] GetDoubleLength()
        {

            return new double[] { x1, y1, 2 * x2 - x1, 2 * y2 - y1 };
        }

        public double GetAreaRightTriangle()
        {
            
            return 0.5 * (x2-x1)* (y2 - y1);
        }
        public double[] GetCoords()
        {
           return new double[] { x1, y1, x2, y2 };
        }
    }
}
