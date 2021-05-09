using BasicExamples.ReflectionC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicExamples.Funcs
{
    public partial class MathOperand : Form
    {
        public MathOperand()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int sayi1 = new Random().Next(100);
            int sayi2 = new Random().Next(100);
            DortIslem oper = new DortIslem();
            Func<int, int, int> value = oper.RandomX;
            textBox1.Text = value(sayi1,sayi2).ToString();
        }
    }
}
