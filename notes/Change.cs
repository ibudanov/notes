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
    public partial class Change : Form
    {
        private Point pos;
        public Change(Sticker s)
        {
            
            InitializeComponent();
            pos = s.Location;
            
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Change_Load(object sender, EventArgs e)
        {
            this.Location = pos;
        }
    }
}
