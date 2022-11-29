using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ia2112_sp_v2020
{
    internal class Square: Shape , IDisplayable
    {
        public Square() : base() 
        {
        }
        public Square(int Side) : base(Side) 
        {
        }

        public override string GetShapeType()
        {
            string text;
            text = "Firkant";
            return text;
        }
        public void DrawShape(Graphics drawArea)
        {
            Bitmap pic = new Bitmap("Square.png"); //Legg inn aktuell bildefil
            drawArea.Clear(Color.White); //Sletter forrige figur ved å skrive over med hvitt
            drawArea.DrawImage(pic, X, Y, Side, Side);
        }

        public override int CalcArea()
        {
            int area;
            area = Side * Side;
            return area;
        }
    }
}
