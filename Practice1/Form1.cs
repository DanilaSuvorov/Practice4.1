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
    public partial class Form1 : Form
    {
        public Color col = new Color();
        public static int R;
        public Form1()
        {
            InitializeComponent();
            col = Color.Red;
            R = 100;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush brush = new SolidBrush(col);
            e.Graphics.FillEllipse(brush, 100, 100, R + Form2.tb * 5, R + Form2.tb * 5);
        }

        private void изменитьЦветToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
            this.Invalidate();
        }

        private void изменитьЦветToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog1 = new ColorDialog();
            colorDialog1.ShowDialog();
            col = colorDialog1.Color;
            this.Invalidate();
        }
    }
}
