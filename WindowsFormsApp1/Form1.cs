using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics graph = Graphics.FromImage(bmp);
            Pen pen = new Pen(Color.Black);
            graph.DrawLine(pen, 120, 0, 120, 460);//Стенки
            graph.DrawLine(pen, 720, 0, 720, 460);
            graph.DrawEllipse(pen, 120, 350, 100, 100);//Мячик
            pictureBox1.Image = bmp;
            timer1.Start();
            x = 1;
        }
        void Draw_2()
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics graph = Graphics.FromImage(bmp);
            Pen pen = new Pen(Color.Black);
            graph.DrawLine(pen, 120, 0, 120, 460);//Стенки
            graph.DrawLine(pen, 720, 0, 720, 460);
            graph.DrawEllipse(pen, 220, 350, 100, 100);//Мячик
            pictureBox1.Image = bmp;
            timer2.Start();
            x = 2;
        }
        void Draw_3()
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics graph = Graphics.FromImage(bmp);
            Pen pen = new Pen(Color.Black);
            graph.DrawLine(pen, 120, 0, 120, 460);//Стенки
            graph.DrawLine(pen, 720, 0, 720, 460);
            graph.DrawEllipse(pen, 320, 350, 100, 100);//Мячик
            pictureBox1.Image = bmp;
            timer3.Start();
            x = 3;
        }
        void Draw_4()
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics graph = Graphics.FromImage(bmp);
            Pen pen = new Pen(Color.Black);
            graph.DrawLine(pen, 120, 0, 120, 460);//Стенки
            graph.DrawLine(pen, 720, 0, 720, 460);
            graph.DrawEllipse(pen, 420, 350, 100, 100);//Мячик
            pictureBox1.Image = bmp;
            timer4.Start();
            x = 4;
        }
        void Draw_5()
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics graph = Graphics.FromImage(bmp);
            Pen pen = new Pen(Color.Black);
            graph.DrawLine(pen, 120, 0, 120, 460);//Стенки
            graph.DrawLine(pen, 720, 0, 720, 460);
            graph.DrawEllipse(pen, 520, 350, 100, 100);//Мячик
            pictureBox1.Image = bmp;
            timer5.Start();
            x = 5;
        }
        void Draw_6()
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics graph = Graphics.FromImage(bmp);
            Pen pen = new Pen(Color.Black);
            graph.DrawLine(pen, 120, 0, 120, 460);//Стенки
            graph.DrawLine(pen, 720, 0, 720, 460);
            graph.DrawEllipse(pen, 620, 350, 100, 100);//Мячик
            pictureBox1.Image = bmp;
            timer6.Start();
            x = 6;
        }
        void Draw_10()
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics graph = Graphics.FromImage(bmp);
            Pen pen = new Pen(Color.Black);
            graph.DrawLine(pen, 120, 0, 120, 460);//Стенки
            graph.DrawLine(pen, 720, 0, 720, 460);
            graph.DrawEllipse(pen, 220, 350, 100, 100);//Мячик
            pictureBox1.Image = bmp;
            timer10.Start();
            x = 10;
        }
        void Draw_9()
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics graph = Graphics.FromImage(bmp);
            Pen pen = new Pen(Color.Black);
            graph.DrawLine(pen, 120, 0, 120, 460);//Стенки
            graph.DrawLine(pen, 720, 0, 720, 460);
            graph.DrawEllipse(pen, 320, 350, 100, 100);//Мячик
            pictureBox1.Image = bmp;
            timer9.Start();
            x = 9;
        }
        void Draw_8()
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics graph = Graphics.FromImage(bmp);
            Pen pen = new Pen(Color.Black);
            graph.DrawLine(pen, 120, 0, 120, 460);//Стенки
            graph.DrawLine(pen, 720, 0, 720, 460);
            graph.DrawEllipse(pen, 420, 350, 100, 100);//Мячик
            pictureBox1.Image = bmp;
            timer8.Start();
            x = 8;
        }
        void Draw_7()
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics graph = Graphics.FromImage(bmp);
            Pen pen = new Pen(Color.Black);
            graph.DrawLine(pen, 120, 0, 120, 460);//Стенки
            graph.DrawLine(pen, 720, 0, 720, 460);
            graph.DrawEllipse(pen, 520, 350, 100, 100);//Мячик
            pictureBox1.Image = bmp;
            timer7.Start();
            x = 7;
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
            Draw_1();
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
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (x)
            {
                case 1: timer1.Start(); break;
                case 2: timer2.Start(); break;
                case 3: timer3.Start(); break;
                case 4: timer4.Start(); break;
                case 5: timer5.Start(); break;
                case 6: timer6.Start(); break;
                case 7: timer7.Start(); break;
                case 8: timer8.Start(); break;
                case 9: timer9.Start(); break;
                case 10: timer10.Start(); break;
            }  
        }
    }
}
