using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ia2112_sp_v2020
{
    internal class Triangle: Shape , IDisplayable
    {
        public Triangle() : base()
        {
        }
        public Triangle(int side) : base(side)
        {
        }
        public override string GetShapeType()
        {
            string text;
            text = "Trekant";
            return text;
        }
        public void DrawShape(Graphics drawArea)
        {
            Bitmap pic = new Bitmap("Triangle.png"); //Legg inn aktuell bildefil
            drawArea.Clear(Color.White); //Sletter forrige figur ved å skrive over med hvitt
            drawArea.DrawImage(pic, X, Y ,Side, Side);
        }

        public override int CalcArea()
        {
            int area;
            area = (int)((((Math.Sqrt(3.0)) / 4.0) * Side * Side));
            return area;
        }

    }
}
