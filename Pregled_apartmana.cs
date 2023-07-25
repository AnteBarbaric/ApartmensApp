using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace INF
{
    public partial class Pregled_apartmana : Form
    {
        public Pregled_apartmana()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Odabir_app odabir = new Odabir_app("APP1");
            odabir.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Odabir_app odabir = new Odabir_app("APP2");
            odabir.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Odabir_app odabir =new  Odabir_app("APP3");
            odabir.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Odabir_app odabir = new Odabir_app("APP4");
            odabir.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Odabir_app odabir = new Odabir_app("APP5");
            odabir.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Odabir_app odabir = new Odabir_app("APP6");
            odabir.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
        }


        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Size size = new Size(600, 350);
            pictureBox1.Size = size;
        }

        private void pictureBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            pictureBox1.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation="d.jpg";
            pictureBox1.Visible = true;
        }


        private void button12_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "a.jpg";
            pictureBox1.Visible = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "b.jpg";
            pictureBox1.Visible = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "c.jpg";
            pictureBox1.Visible = true;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "e.jpg";
            pictureBox1.Visible = true;
        }

        
    }
}
