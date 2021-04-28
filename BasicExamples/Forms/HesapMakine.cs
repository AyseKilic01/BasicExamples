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
        
        
        public HesapMakine()
        {
            InitializeComponent();
        }
        int Topla()
        {
            return 0;
        }
        void Bul()
        {
            DortIslem dortIslem = new DortIslem(int.Parse(btnSix.Text), int.Parse(btnThree.Text));
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {

            
        }
    }
}
