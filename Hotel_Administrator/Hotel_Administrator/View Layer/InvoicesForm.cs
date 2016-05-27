using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Hotel_Administrator
{
    // Форма отображения квитанций.
    public partial class InvoicesForm : Form
    {
        public InvoicesForm()
        {
            InitializeComponent();
            var invoices = Directory.GetFiles("..\\..\\Invoices").OrderByDescending(inv => Directory.GetCreationTime(inv));
            
            foreach(string inv in invoices)
            {
                Button b = new Button();
                invoicesTable.Rows.Add(inv.Substring(15), b);
            }
        }

        private void openInvoice(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0) return;
            string path = "..\\..\\Invoices\\" + invoicesTable.Rows[e.RowIndex].Cells[0].Value;
            Process.Start(path);
        }
    }
}
