using System;
using System.Drawing;
using System.Windows.Forms;
using MyExtensions;

namespace ColorPicker
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnColorOpen_Click(object sender, EventArgs e)
        {
            cd.ShowDialog();
            Color c = cd.Color;
            lblColorCode.BackColor = c;
            txtHTMLCode.Text = c.ToHTMLColor();
            txtRGBCode.Text = c.R.ToString() + "," + c.G.ToString() + "," + c.B.ToString();

        }

        
    }
}
