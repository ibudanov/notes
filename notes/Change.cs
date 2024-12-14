using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace notes
{
    public partial class Change : Form
    {
        private Point pos;
        private Sticker sticker;
        int h;
        int m;

        public Change(Sticker s)
        {
            
            InitializeComponent();

            pos = s.Location;
            h = s.getDateTime().Hour;
            m = s.getDateTime().Minute;
            this.nameTextBox.Text = s.getName();
            this.textTextBox.Text = s.getText();
            this.hourTextBox.Text = h.ToString();
            this.minuetsTextBox.Text = m.ToString();
            this.dateTimePicker.Text = s.getDateTime().Date.ToString();
            
            this.notifyAheadComboBox.SelectedItem = s.getNotifyAhead();
            sticker = s;

        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Change_Load(object sender, EventArgs e)
        {
            pos.Offset(sticker.changerLocation);
            this.Location = pos;
        }

        private void save_Click(object sender, EventArgs e)
        {
            try 
            {
                int hours = int.Parse(hourTextBox.Text);
                int minutes = int.Parse(minuetsTextBox.Text);
                if (hours > 23 || hours < 0)
                {
                    MessageBox.Show("Hours must be between 0 and 23");
                    hourTextBox.Text = h.ToString();
                }
                else if (minutes > 59 || minutes < 0)
                {
                    MessageBox.Show("Minutes must be between 0 and 59");
                    minuetsTextBox.Text = m.ToString();
                }
                else
                {
                    TimeSpan ts = new TimeSpan(int.Parse(hourTextBox.Text), int.Parse(minuetsTextBox.Text), 0);
                    sticker.setName(this.nameTextBox.Text);
                    sticker.setText(this.textTextBox.Text);
                    sticker.setDateTime(dateTimePicker.Value + ts);
                    sticker.setNotifyAhead((int)notifyAheadComboBox.SelectedItem);
                    sticker.updateNotificationTime();
                    this.Close();
                }
            }
            catch 
            {
                MessageBox.Show("invalid time");
            }
            
            
        }
    }
}
