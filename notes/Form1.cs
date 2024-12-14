using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notes
{
    public partial class Form1 : Form
    {
        private int hours;
        private int minutes;
        public Form1()
        {
            DateTime current = DateTime.Now;
            InitializeComponent();
            this.textBox3.Text = current.Hour.ToString();
            this.textBox4.Text = current.Minute.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try 
            {
                hours = int.Parse(textBox3.Text);
                minutes = int.Parse(textBox4.Text);
                if (hours > 23 || hours < 0)
                {
                    MessageBox.Show("Hours must be between 0 and 23");
                    textBox3.Text = DateTime.Now.Hour.ToString();
                }
                else if (minutes > 59 || minutes < 0)
                {
                    MessageBox.Show("Minutes must be between 0 and 59");
                    textBox4.Text = DateTime.Now.Minute.ToString();
                }
                else
                {
                    DateTime dateTime = dateTimePicker1.Value;
                    TimeSpan ts = new TimeSpan(hours, minutes, 0);
                    dateTime = dateTime.Date + ts;
                    Sticker s = new Sticker(textBox1.Text, textBox2.Text, Color.Yellow, dateTime, (int)comboBox1.SelectedItem);
                    s.Visible = true;
                    clear();
                }
            }
            catch 
            {
                MessageBox.Show("invalid time");
            }
            
            

        }
        private void clear() 
        {
            this.textBox1.Text = string.Empty;
            this.textBox2.Text = string.Empty;
            this.textBox3.Text = DateTime.Now.Hour.ToString();
            this.textBox4.Text= DateTime.Now.Minute.ToString();
            this.dateTimePicker1.Value = DateTime.Now.Date;
            this.comboBox1.SelectedIndex = 0;
        }
    }
}
