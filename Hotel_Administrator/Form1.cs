using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Administrator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            DateTime dt = DateTime.Now;
            Text += dt.ToShortDateString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }

   
}
