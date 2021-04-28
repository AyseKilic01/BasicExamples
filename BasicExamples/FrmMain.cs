using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicExamples
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnFib_Click(object sender, EventArgs e)
        {
            Forms.Fibonacci frm = new Forms.Fibonacci();
            frm.Show();

        }

        private void btnIslem_Click(object sender, EventArgs e)
        {
            Forms.HesapMakine frm = new Forms.HesapMakine();
            frm.Show();
        }
    }
}
