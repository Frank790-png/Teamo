using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quieressermiminita
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label2.Parent = pictureBox2;
            panel3.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void MoverBoton()
        {
            Random r = new Random();
            int x = r.Next(0, this.Width - button2.Width);
            int y = r.Next(0, this.Height - button2.Height);
            button2.Location = new Point(x, y);
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            MoverBoton();
            if(button2.Location == button1.Location || button2.Location == label1.Location)
            {
                MoverBoton();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel3.Show();
        }
    }
}
