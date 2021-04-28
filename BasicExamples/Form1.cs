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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int Fibonacci(int n)
        {
            int n1 = 0;
            int n2 = 1;
            int sum = 0;

            for (int i = 2; i <= n; i++)
            {
                sum = n1 + n2;
                n1 = n2;
                n2 = sum;
                lstFib.Items.Add(sum.ToString());
            }
            return n == 0 ? n1 : n2;
        }
        int IntegerDivide(int dividend, int divisor)
        {    //eger 0 ile bölme girisiminde bulunursa debug dan uyarı dönecek
            Debug.Assert(divisor != 0, $"nameof(divisor) is 0 and will cause an exception.");

            return dividend / divisor;
        }

        private void btnFib_Click(object sender, EventArgs e)
        {
          int result =  Fibonacci(5);
            MessageBox.Show(result.ToString());
            IntegerDivide(6, 0);
        }
    }
}
