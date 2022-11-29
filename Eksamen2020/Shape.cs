using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ia2112_sp_v2020
{
    abstract class Shape 
    {
        public Shape()
        {
            X = 0;
            Y = 0;
            Side = 130;
        }

        public Shape(int side) 
        {
            X = 0;
            Y = 0;
            Side = side;
        }

        public int X { get; set; }
        public int Y { get; set; }

        private int side; 

        public int Side 
        {
            get { return side; }
            set
            {
                if (value > 130) //Prøves verdien satt til over 130, settes den til 130.
                {
                    side = 130;
                }
                else
                {
                    side = value;
                }
            }
        }

        public abstract int CalcArea();

        public virtual string GetShapeType()
        {
            string text;
            text = "ukjent";
            return text; 
        }

    }
}
