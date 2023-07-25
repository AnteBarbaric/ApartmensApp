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
    public partial class Unos_admina : Form
    {
        public Unos_admina()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "ante" || textBox2.Text != "hajduksplit")
            {
                MessageBox.Show("Vase korisnicko ime ili sifra su pogresni. Molimo vas pokusajte ponovo!");
                textBox1.Clear();
                textBox2.Clear();
            }

            if (textBox1.Text == "ante" && textBox2.Text == "hajduksplit")
            {
                Pregled_gostiju pregled = new Pregled_gostiju();
                pregled.Show();
                this.Close();
            }
            
        }

        

        

        

        
    }
}
