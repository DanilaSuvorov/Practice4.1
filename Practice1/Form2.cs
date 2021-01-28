using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice1
{
    public partial class Form2 : Form
    {
        public static int tb;
        public Form2()
        {
            InitializeComponent();

            trackBar1.Scroll += trackBar1_Scroll;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            tb = trackBar1.Value;
        }
    }
}
