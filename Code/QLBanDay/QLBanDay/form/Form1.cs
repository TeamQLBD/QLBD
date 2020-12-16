using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanDay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chart1.Series["dashboard"].Points.AddXY("A", "12");
            chart1.Series["dashboard"].Points.AddXY("B", "2");
            chart1.Series["dashboard"].Points.AddXY("C", "20");

            chart1.Series["Series2"].Points.AddXY("A", "30");
            chart1.Series["Series2"].Points.AddXY("B", "15");
            chart1.Series["Series2"].Points.AddXY("C", "3");
        }
    }
}
