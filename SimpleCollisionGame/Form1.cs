using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCollisionGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!checkIntract(label1, label2)&& !checkIntract(label1, label3))
            {
                Point newPoint = new Point(label1.Location.X, label1.Location.Y - 15);
                label1.Location = newPoint;

            }
            else
            {
                label4.Text = "Game Over";
            }
            if (checkIntract(label1, label5))
            {
                label4.Text = "You Won";
                disableButton();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!checkIntract(label1, label2) && !checkIntract(label1, label3))
            {
                Point newPoint = new Point(label1.Location.X+15, label1.Location.Y );
                label1.Location = newPoint;

            }
            else
            {
                label4.Text = "Game Over";
            }
            if (checkIntract(label1, label5))
            {
                label4.Text = "You Won";
                disableButton();
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!checkIntract(label1, label2) && !checkIntract(label1, label3))
            {
                Point newPoint = new Point(label1.Location.X, label1.Location.Y + 15);
                label1.Location = newPoint;

            }
            else
            {
                label4.Text = "Game Over";
            }
            if (checkIntract(label1, label5))
            {
                label4.Text = "You Won";
                disableButton();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!checkIntract(label1, label2) && !checkIntract(label1, label3))
            {
                Point newPoint = new Point(label1.Location.X -15, label1.Location.Y);
                label1.Location = newPoint;

            }
            else
            {
                label4.Text = "Game Over";
            }
            if (checkIntract(label1, label5))
            {
                label4.Text = "You Won";
                disableButton();
            }
            
        }

        public bool checkIntract(Label label1, Label label2)
        {
            var rect1 = new System.Drawing.Rectangle(label1.Location.X, label1.Location.Y, label1.Width, label1.Height);
            var rect2 = new System.Drawing.Rectangle(label2.Location.X, label2.Location.Y, label2.Width, label2.Height);
            return rect1.IntersectsWith(rect2);
          
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        public void disableButton()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }
    }
}
