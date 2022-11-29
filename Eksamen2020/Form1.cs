using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Formler for beregning av areal i de tre klassene Square, Circle og Triangle:

//Square-area: area = Side* Side;
//Circle-area: area= (int) (Math.PI* Math.Pow(Side / 2.0,2));
//Triangle-area: area = (int) ((((Math.Sqrt(3.0)) / 4.0) * Side * Side));

namespace ia2112_sp_v2020
{
    public partial class Form1 : Form
    {
        Graphics paper;
        Circle circle;
        Square rectangle;
        Triangle triangle;
        Random random;
        Stack<Shape> shapes;
        public Form1()
        {
            InitializeComponent();
            paper = picShape.CreateGraphics();
            shapes = new Stack<Shape>();
            random = new Random();

            myEvent += new EventHandler(MyeventHandler);


        }

        private void btnShowRandomShape_Click(object sender, EventArgs e)
        {
            int side, shape = 0, areal = 0;
            shape = random.Next(1, 4); // vil stoppe på 3
            side = random.Next(10, 200);
            txtSide.Text = side.ToString();


            if (shape == 1)
            {
                circle = new Circle(side);
                circle.DrawShape(paper);
                areal = circle.CalcArea();
                shapes.Push(circle);


            }
            else if (shape == 2)
            {
                triangle = new Triangle(side);
                triangle.DrawShape(paper);
                areal = triangle.CalcArea();
                shapes.Push(triangle);
            }
            else
            {
                rectangle = new Square(side);
                rectangle.DrawShape(paper);
                areal = rectangle.CalcArea();
                shapes.Push(rectangle);
            }
            ShowAllShapes();
            txtNumber.Text = shapes.Count.ToString();
            CheckNumber();

        }

        void ShowAllShapes()
        {
            {
                int areal;
                int Shapes = shapes.Count;
                txtShow.Clear(); // gjør så ikke alle verdier blir lagt til fler ganger i vindu.
                foreach (Shape shape in shapes)
                {

                    areal = shape.CalcArea();
                    txtShow.AppendText(shape.GetShapeType() + "\t" + shape.Side + "\t" + areal + "\r\n");

                }
            }
        }

        private void btnDeleteAllShapes_Click(object sender, EventArgs e)
        {


            shapes.Clear();
            txtSide.Clear();
            txtShow.Clear();
            txtNumber.Text = 0.ToString();
            picShape.Image = null;


        }

        private void btnRemoveFromStack_Click(object sender, EventArgs e)
        {
            shapes.Pop(); // fjerner øverste elementet 
            ShowAllShapes(); // viser alle formene på nytt uten det siste elementet 
            txtNumber.Text = shapes.Count.ToString(); // oppdaterer antallet i stack.
            CheckNumber();
            // hvordan får vise verdier til det nye elementet på toppen ? 
        }


        // event 
        public event EventHandler myEvent;

        public void CheckNumber()
        {
            if (Convert.ToInt32(txtNumber.Text) % 5 == 0)
            {
                myEvent(this, new EventArgs());
            }

        }
        private void MyeventHandler(Object source, EventArgs argument)
        {
            MessageBox.Show("Totalt antall objekter er deleilig med 5");

        }



    }
}
