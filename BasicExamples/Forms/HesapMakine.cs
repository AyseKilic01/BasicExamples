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
            //DortIslem cs = (DortIslem)Activator.CreateInstance(type, sayi1, sayi2);
            //sonuc = cs.Bolme();
            var instance = Activator.CreateInstance(type, vs[0], vs[1]);
            sonuc = Convert.ToDouble(instance.GetType().GetMethod("Bolme").Invoke(instance, null));

            txtSonuc.Text = "";
            txtSonuc.Text = sonuc.ToString();

        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            //reflection örneği
            var type = typeof(DortIslem);
            var metods = type.GetMethods();
            foreach(var i in metods)
            {
                i.Name.ToString();
            }
            //calisma aninda aktif instance uretmek icin
            var instance = Activator.CreateInstance(type, vs[0], vs[1]);
            sonuc = Convert.ToDouble(instance.GetType().GetMethod("Carp").Invoke(instance, null));
            //DortIslem cs = (DortIslem)Activator.CreateInstance(type, sayi1, sayi2);
            //sonuc = cs.Carp();
            txtSonuc.Text = "";
            txtSonuc.Text = sonuc.ToString();
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            var type = typeof(DortIslem);
            //calisma aninda aktif instance uretmek icin
            var instance = Activator.CreateInstance(type, vs[0], vs[1]);
            //Metod info - GetMethod().Invoke
            sonuc = Convert.ToDouble(instance.GetType().GetMethod("Topla").Invoke(instance, null));
            //DortIslem cs = (DortIslem)Activator.CreateInstance(type, sayi1, sayi2);
            //sonuc = cs.Topla();
            txtSonuc.Text = "";
            txtSonuc.Text = sonuc.ToString();
        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            var type = typeof(DortIslem);
            //calisma aninda aktif instance uretmek icin
            var instance = Activator.CreateInstance(type, vs[0], vs[1]);
            sonuc = Convert.ToDouble(instance.GetType().GetMethod("Cikarma").Invoke(instance, null));
            //DortIslem cs = (DortIslem)Activator.CreateInstance(type, vs[0], vs[1]);
            //sonuc = cs.Cikarma();
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
