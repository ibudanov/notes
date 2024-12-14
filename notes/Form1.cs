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
        public Form1()
        {
            DateTime current = DateTime.Now;
            InitializeComponent(current);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            DateTime dateTime = dateTimePicker1.Value;
            TimeSpan ts = new TimeSpan(int.Parse(textBox3.Text), int.Parse(textBox4.Text), 0);
            dateTime = dateTime.Date + ts;
            Sticker s = new Sticker(textBox1.Text,textBox2.Text, Color.Yellow, dateTime,(int)comboBox1.SelectedItem);
            s.Visible = true;
        }
    }
}
