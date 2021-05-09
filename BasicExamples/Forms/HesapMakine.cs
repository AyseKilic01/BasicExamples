using BasicExamples.DelegateS;
using BasicExamples.ReflectionC;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicExamples.Forms
{
    public partial class HesapMakine : Form
    {
        int sayi1 = 0;
        int sayi2 = 0;
        double sonuc = 0;
        List<int> vs = new List<int>();
        public delegate int math_Op(int number1, int number2);

        public HesapMakine()
        {
            InitializeComponent();
        }
        void Bul()
        {
            DortIslem dortIslem = new DortIslem(int.Parse(btnSix.Text), int.Parse(btnThree.Text));
        }
        
        private void btnDivide_Click(object sender, EventArgs e)
        {
            //delegate used
            FourOperations operations = new FourOperations();
            math_Op op = operations.Divide;
            sonuc = op(vs[0], vs[1]);
            txtSonuc.Text = "";
            txtSonuc.Text = sonuc.ToString();

        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            FourOperations operations = new FourOperations();
            math_Op op = operations.Multiplication;
            sonuc = op(vs[0], vs[1]);
            txtSonuc.Text = "";
            txtSonuc.Text = sonuc.ToString();
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            FourOperations operations = new FourOperations();
            math_Op op = operations.Sum;
            sonuc = op(vs[0], vs[1]);
            txtSonuc.Text = "";
            txtSonuc.Text = sonuc.ToString();
        }

        private void btnExtraction_Click(object sender, EventArgs e)
        {
            FourOperations operations = new FourOperations();
            math_Op op = operations.Extraction;
            sonuc = op(vs[0], vs[1]);
            txtSonuc.Text = "";
            txtSonuc.Text = sonuc.ToString();
        }

        private void simpleButton17_Click(object sender, EventArgs e)
        {

        }
        void click(SimpleButton button)
        {
            vs.Add(int.Parse(button.Text));
            foreach(var i in vs)
            {
                txtSonuc.Text = i.ToString();
            }
        }
        private void btnOne_Click(object sender, EventArgs e)
        {
            click(btnOne);
        }
        private void btnTwo_Click(object sender, EventArgs e)
        {
            click(btnTwo);
        }
        private void btnThree_Click(object sender, EventArgs e)
        {
            click(btnThree);
        }
        private void btnFour_Click(object sender, EventArgs e)
        {
            click(btnFour);
        }
        private void btnFive_Click(object sender, EventArgs e)
        {
            click(btnFive);
        }
        private void btnSix_Click(object sender, EventArgs e)
        {
            click(btnSix);
        }
        private void btnSeven_Click(object sender, EventArgs e)
        {
            click(btnSeven);
        }
        private void btnEight_Click(object sender, EventArgs e)
        {
            click(btnEight);
        }
        private void btnNine_Click(object sender, EventArgs e)
        {
            click(btnNine);
        }
    }
}
