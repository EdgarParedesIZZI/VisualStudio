using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace appWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World!!");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Me agregaron 2 version!!");
        }
    }
}
