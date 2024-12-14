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
    public partial class Sticker : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private DateTime timeOfNotification;
        private TimeSpan ts;
        private String name;
        private String text;
        private int notifyAhead;
        private DateTime dateTime;


        public Sticker(String name, String text, Color color, DateTime dateTime, int notifyAhead)
        {
            InitializeComponent();
            setName(name);
            setText(text);
            setDateTime(dateTime);
            setNotifyAhead(notifyAhead);
            updateNotificationTime();
            
            this.textBox1.BackColor = color;
            this.button1.BackColor = color;
            this.button2.BackColor = color;
            this.BackColor = color;

            this.timer1.Start();

        }

        private void Sticker_Load(object sender, EventArgs e)
        {

        }

        private void Sticker_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void Sticker_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void Sticker_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeOfNotification < DateTime.Now)
            {
                this.timer1.Stop();
                this.Activate();
                MessageBox.Show("Your note " + '"' + this.name + '"' + " will be less then in " + this.notifyAhead + " minutes");

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Change c = new Change(this);
            c.ShowDialog();
        }

        public String getName()
        {
            return this.name;
        }
        public void setName(String name)
        {
            this.name = name;
            this.label1.Text = name;
        }
        public String getText()
        {
            return this.text;
        }
        public void setText(String text)
        {
            this.text = text;
            this.textBox1.Text = text;
        }
        public int getNotifyAhead() 
        {
            return this.notifyAhead;
        }
        public void setNotifyAhead(int notifyAhead) 
        {
            this.notifyAhead = notifyAhead;
        }

        public DateTime getDateTime() 
        {
            return this.dateTime;
        }
        public void setDateTime(DateTime dateTime) 
        {
            this.dateTime = dateTime;
            this.label3.Text = dateTime.ToString();
        }
        public void updateNotificationTime() 
        {
            this.ts = new TimeSpan(0, notifyAhead, 0);
            this.timeOfNotification = this.dateTime - this.ts;
        }
    }
}
