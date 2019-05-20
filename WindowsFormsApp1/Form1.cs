using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int x;
        
        public Form1()
        {
            InitializeComponent();
            Draw_1();
            Draw_2();
            Draw_3();
            Draw_4();
            Draw_5();
            Draw_6();
            Draw_7();
            Draw_8();
            Draw_9();
            Draw_10();
        }
        void Draw_1()
        {
            SolidBrush brush = new SolidBrush(Color.Blue);
            brush.Color = Color.Red;
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics graph = Graphics.FromImage(bmp);
            Pen pen = new Pen(Color.Black);
            graph.FillEllipse(brush, 00, 350, 100, 100);//Мячик
            graph.DrawEllipse(pen, 00, 350, 100, 100);//Мячик
            pictureBox1.Image = bmp;
            timer1.Start();
            x = 1;
        }
        void Draw_2()
        {
            SolidBrush brush = new SolidBrush(Color.Blue);
            brush.Color = Color.Red;
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics graph = Graphics.FromImage(bmp);
            Pen pen = new Pen(Color.Black);
            graph.DrawEllipse(pen, 100, 350, 100, 100);//Мячик
            graph.FillEllipse(brush, 100, 350, 100, 100);//Мячик
            pictureBox1.Image = bmp;
            timer2.Start();
            x = 2;
        }
        void Draw_3()
        {
            SolidBrush brush = new SolidBrush(Color.Blue);
            brush.Color = Color.Red;
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics graph = Graphics.FromImage(bmp);
            Pen pen = new Pen(Color.Black);
            graph.DrawEllipse(pen, 200, 350, 100, 100);//Мячик
            graph.FillEllipse(brush, 200, 350, 100, 100);//Мячик
            pictureBox1.Image = bmp;
            timer3.Start();
            x = 3;
        }
        void Draw_4()
        {
            SolidBrush brush = new SolidBrush(Color.Blue);
            brush.Color = Color.Red;
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics graph = Graphics.FromImage(bmp);
            Pen pen = new Pen(Color.Black);
            graph.DrawEllipse(pen, 300, 350, 100, 100);//Мячик
            graph.FillEllipse(brush, 300, 350, 100, 100);//Мячик
            pictureBox1.Image = bmp;
            timer4.Start();
            x = 4;
        }
        void Draw_5()
        {
            SolidBrush brush = new SolidBrush(Color.Blue);
            brush.Color = Color.Red;
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics graph = Graphics.FromImage(bmp);
            Pen pen = new Pen(Color.Black);
            graph.DrawEllipse(pen, 400, 350, 100, 100);//Мячик
            graph.FillEllipse(brush, 400, 350, 100, 100);//Мячик
            pictureBox1.Image = bmp;
            timer5.Start();
            x = 5;
        }
        void Draw_6()
        {
            SolidBrush brush = new SolidBrush(Color.Blue);
            brush.Color = Color.Red;
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics graph = Graphics.FromImage(bmp);
            Pen pen = new Pen(Color.Black);
            graph.DrawEllipse(pen, 500, 350, 100, 100);//Мячик
            graph.FillEllipse(brush, 500, 350, 100, 100);//Мячик
            pictureBox1.Image = bmp;
            timer6.Start();
            x = 6;
        }
        void Draw_7()
        {
            SolidBrush brush = new SolidBrush(Color.Blue);
            brush.Color = Color.Red;
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics graph = Graphics.FromImage(bmp);
            Pen pen = new Pen(Color.Black);
            graph.DrawEllipse(pen, 600, 350, 100, 100);//Мячик
            graph.FillEllipse(brush, 600, 350, 100, 100);//Мячик
            pictureBox1.Image = bmp;
            timer7.Start();
        }
        void Draw_8()
        {
            SolidBrush brush = new SolidBrush(Color.Blue);
            brush.Color = Color.Red;
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics graph = Graphics.FromImage(bmp);
            Pen pen = new Pen(Color.Black);
            graph.DrawEllipse(pen, 500, 350, 100, 100);//Мячик
            graph.FillEllipse(brush, 500, 350, 100, 100);//Мячик
            pictureBox1.Image = bmp;
            timer8.Start();
        }
        void Draw_9()
        {
            SolidBrush brush = new SolidBrush(Color.Blue);
            brush.Color = Color.Red;
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics graph = Graphics.FromImage(bmp);
            Pen pen = new Pen(Color.Black);
            graph.DrawEllipse(pen, 400, 350, 100, 100);//Мячик
            graph.FillEllipse(brush, 400, 350, 100, 100);//Мячик
            pictureBox1.Image = bmp;
            timer9.Start();
        }
        void Draw_10()
        {
            SolidBrush brush = new SolidBrush(Color.Blue);
            brush.Color = Color.Red;
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics graph = Graphics.FromImage(bmp);
            Pen pen = new Pen(Color.Black); 
            graph.DrawEllipse(pen, 300, 350, 100, 100);//Мячик
            graph.FillEllipse(brush, 300, 350, 100, 100);//Мячик
            pictureBox1.Image = bmp;
            timer10.Start();
        }
        void Draw_11()
        {
            SolidBrush brush = new SolidBrush(Color.Blue);
            brush.Color = Color.Red;
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics graph = Graphics.FromImage(bmp);
            Pen pen = new Pen(Color.Black);
            graph.DrawEllipse(pen, 200, 350, 100, 100);//Мячик
            graph.FillEllipse(brush, 200, 350, 100, 100);//Мячик
            pictureBox1.Image = bmp;
            timer11.Start();
        }
        void Draw_12()
        {
            SolidBrush brush = new SolidBrush(Color.Blue);
            brush.Color = Color.Red;
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics graph = Graphics.FromImage(bmp);
            Pen pen = new Pen(Color.Black);
            graph.DrawEllipse(pen, 100, 350, 100, 100);//Мячик
            graph.FillEllipse(brush, 100, 350, 100, 100);//Мячик
            pictureBox1.Image = bmp;
            timer12.Start();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            Draw_2();
            timer1.Stop();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Draw_3();
            timer2.Stop();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            Draw_4();
            timer3.Stop();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            Draw_5();
            timer4.Stop();
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            Draw_6();
            timer5.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
            timer4.Stop();
            timer5.Stop();
            timer6.Stop();
            timer7.Stop();
            timer8.Stop();
            timer9.Stop();
            timer10.Stop();
            timer11.Stop();
            timer12.Stop();
            Draw_1();
            
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            Draw_7();
            timer6.Stop();
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            Draw_8();
            timer7.Stop();
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            Draw_9();
            timer8.Stop();
        }

        private void timer9_Tick(object sender, EventArgs e)
        {
            Draw_10();
            timer9.Stop();
        }

        private void timer10_Tick(object sender, EventArgs e)
        {
            Draw_11();
            timer10.Stop();
        }

       

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
            timer4.Stop();
            timer5.Stop();
            timer6.Stop();
            timer7.Stop();
            timer8.Stop();
            timer9.Stop();
            timer10.Stop();
            timer11.Stop();
            timer12.Stop();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void timer11_Tick(object sender, EventArgs e)
        {
            Draw_12();
            timer11.Stop();
        }

        private void timer12_Tick(object sender, EventArgs e)
        {
            Draw_1();
            timer12.Stop();
        }

        
    }
}
