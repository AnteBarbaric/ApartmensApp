using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Configuration;
using System.Drawing.Design;
using System.Drawing.Text;
using System.Drawing.Imaging;

namespace INF
{
    public partial class Odabir_app : Form
    {
        double cijena = 0.0;
        static string apartman = "";
        public Odabir_app(string app)
        {
            InitializeComponent();

            cijena = 50;

            apartman = app;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(dobar_unos()==false)
            {
                return;
            }

            string path = Application.StartupPath;
            string filePath = path + @"\podaci.txt";
            
            string text = apartman + "|" + textBox2.Text + "|"+ textBox3.Text + "|" + monthCalendar1.SelectionRange.Start.Date.ToString("dd.MM.yyyy") + "|"+
              monthCalendar2.SelectionRange.Start.Date.ToString("dd.MM.yyyy")+"|"+textBox1.Text+"|"+numericUpDown1.Value;

            using (StreamWriter sw = File.AppendText(filePath)) 
        {
            sw.WriteLine(text);
            sw.Close();
        }

            MessageBox.Show("Spremljeno!");

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            numericUpDown1.Value = 0;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                double rezultat = (cijena + 10) * Admin.raspon_dana(monthCalendar1.SelectionRange.Start.Date, monthCalendar2.SelectionRange.Start.Date);
                textBox1.Text = rezultat + "€";
            }
            else
            {
                double rezultat = cijena * Admin.raspon_dana(monthCalendar1.SelectionRange.Start.Date,monthCalendar2.SelectionRange.Start.Date);
                textBox1.Text = rezultat + "€";
            }
        }

        public bool dobar_unos()
        {
            bool val = true;
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Izracunajte cijenu!");
                val = false;
            }
            if (String.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Upisite ime!");
                val = false;
            }
            if (String.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Upisite prezime!");
                val = false;
            }
            if (numericUpDown1.Value<=0)
            {
                MessageBox.Show("Unesite broj gostiju!");
                val = false;
            }
            if (radioButton1.Checked==false&&radioButton2.Checked==false)
            {
                MessageBox.Show("Odaberite WI-FI!");
                val = false;
            }

            DateTime startDate = monthCalendar1.SelectionRange.Start.Date;
            DateTime endDate = monthCalendar2.SelectionRange.Start.Date;
            Admin.slobodan_app(startDate, endDate, apartman);
            if (Admin.slobodan_app(startDate, endDate, apartman) == true)
            {
                MessageBox.Show("Datumi koji ste odabrali su vec zauzeti. Molimo vas pokusajte s novim!!");
                val = false;
            }

            return val;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = null;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = null;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBox1.Text = null;
        }

        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBox1.Text = null;
        }

       
             
        }
        
      
    }
    
        




