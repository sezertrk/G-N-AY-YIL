using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GÜN_AY_YIL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int gun = int.Parse(textBox1.Text);
            int ay = int.Parse(textBox2.Text);
            int yil1 = int.Parse(textBox3.Text)/1000;
            int yil2 = (int.Parse(textBox3.Text) - (yil1 * 1000)) / 100;
            int yil3 = (int.Parse(textBox3.Text) - (yil1 * 1000) + (yil2 * 100)) / 10;
            int yil4 = (int.Parse(textBox3.Text) - (yil1 * 1000) + (yil2 * 100) + (yil3 * 10));
            int olyil = 0;
            olyil = (ay + gun);

          
        }
    }
}
