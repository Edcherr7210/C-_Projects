namespace SP2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Width = 900;
            this.Height = 700;
            bm = new Bitmap(this.Width, this.Height);
            g = Graphics.FromImage(bm);
            g.Clear(System.Drawing.Color.White);
            Pic.Image = bm;
        }

        Graphics g;
        Bitmap bm;
        bool paint = false;
        Point pX, pY;
        Pen myPen = new Pen(System.Drawing.Color.Black, 3);
        Pen erase = new Pen(System.Drawing.Color.White, 7);
        int index;
        int x, y, sX, sY, cX, cY;
        


        private void Line_Click(object sender, EventArgs e)
        {
            index = 1;
        }

        private void Pic_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            pY = e.Location;

            cX = e.X;
            cY = e.Y;
        }

        private void Pic_MouseMove(object sender, MouseEventArgs e)
        {

            if (paint)
            {
                if (index == 1)
                {
                    pX = e.Location;
                    g.DrawLine(myPen, pX, pY);
                    pY = pX;
                }

                else if (index == 2)
                {
                    pX = e.Location;
                    g.DrawLine(erase, pX, pY);
                    pY = pX;
                }
            }
            Pic.Invalidate();  

            x = e.X;
            y = e.Y;
        }

        private void Pic_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;

            sX = x - cX;
            sY = y - cY;

            if (index == 3)
            {
                g.DrawEllipse(myPen, cX, cY, sX, sY);
            }
            if (index == 4)
            {
                g.DrawRectangle(myPen, cX, cY, sX, sY);
            }
            Pic.Invalidate();
        }

        private void rubber_Click(object sender, EventArgs e)
        {
            index = 2;
        }

        private void Circle_Click(object sender, EventArgs e)
        {
            index = 3;
        }

        private void Square_Click(object sender, EventArgs e)
        {
            index = 4;
        }

        private void colorBox_TextChanged(object sender, EventArgs e)
        {
            if (colorBox.Text == "Green" || colorBox.Text == "green")
            {
                myPen = new Pen(Color.Green);
            }
            else if (colorBox.Text == "Red" || colorBox.Text == "red")
            {
                myPen = new Pen(Color.Red);
            }
            else if (colorBox.Text == "Yellow" || colorBox.Text == "yellow")
            {
                myPen = new Pen(Color.Yellow);
            }
            else if (colorBox.Text == "Blue" || colorBox.Text == "blue")
            {
                myPen = new Pen(Color.Blue);
            }
            else if (colorBox.Text == null)
            {
                myPen = new Pen(Color.Black);
            }
            else if (colorBox.Text == "Purple" || colorBox.Text == "purple")
            {
                myPen = new Pen(Color.Purple);
            }
        }

        private void LineSize_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(LineSize.Text, out int size) && size > 0)
            {
                myPen.Dispose();
                myPen = new Pen(Color.Black, size);
            }
            else if (string.IsNullOrWhiteSpace(LineSize.Text))
            {
                myPen.Dispose();
                myPen = new Pen(Color.Black, 2);
            }
        }
    }
}
