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

namespace BasicExamples.Forms
{
    public partial class HesapMakine : Form
    {
        int sayi1 = 0;
        int sayi2 = 0;
        double sonuc = 0;
        List<int> vs = new List<int>();
        
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

            var type = typeof(DortIslem);
            //calisma aninda aktif instance uretmek icin
            DortIslem cs = (DortIslem)Activator.CreateInstance(type, sayi1, sayi2);
            sonuc = cs.Bolme();
            txtSonuc.Text = "";
            txtSonuc.Text = sonuc.ToString();

        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            var type = typeof(DortIslem);
            //calisma aninda aktif instance uretmek icin
            DortIslem cs = (DortIslem)Activator.CreateInstance(type, sayi1, sayi2);
            sonuc = cs.Carp();
            txtSonuc.Text = "";
            txtSonuc.Text = sonuc.ToString();
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            var type = typeof(DortIslem);
            //calisma aninda aktif instance uretmek icin
            DortIslem cs = (DortIslem)Activator.CreateInstance(type, sayi1, sayi2);
            sonuc = cs.Topla();
            txtSonuc.Text = "";
            txtSonuc.Text = sonuc.ToString();
        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            var type = typeof(DortIslem);
            //calisma aninda aktif instance uretmek icin
            DortIslem cs = (DortIslem)Activator.CreateInstance(type, vs[0], vs[1]);
            sonuc = cs.Cikarma();
            txtSonuc.Text = "";
            txtSonuc.Text = sonuc.ToString();
        }

        private void simpleButton17_Click(object sender, EventArgs e)
        {

        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            vs.Add(int.Parse(btnOne.Text));
         
        }
    }
}
