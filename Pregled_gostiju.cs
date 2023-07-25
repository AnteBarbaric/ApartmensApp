using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INF
{
    public partial class Pregled_gostiju : Form
    {
        public Pregled_gostiju()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = Admin.pregled_gostiju("APP1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = Admin.pregled_gostiju("APP2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = Admin.pregled_gostiju("APP3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = Admin.pregled_gostiju("APP4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = Admin.pregled_gostiju("APP5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = Admin.pregled_gostiju("APP6");
        }

        

        

        

        
    }
}
