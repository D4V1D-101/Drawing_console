using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp48
{
    class Circle
    {
        private double radius;

        //----------------------------

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public Circle()
        {
            this.radius = 8;
        }

        public double Radius
        {


            get
            {
                Console.WriteLine("itt adtam értéket.");
                return radius;

            }
            set
            {
                radius = value;
            }

        }
        //----------------------------


        public void SetRad(double ossz)
        {
            radius = ossz;
        }

        public double Getarea()
        {
            return radius;
        }
        public double ker()
        {
            return 2 * radius * Math.PI;
        }
        public double ter()
        {
            return Math.Sqrt(radius) * Math.PI;
        }

    }
  
   
}
