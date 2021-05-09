using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExamples.ReflectionC
{
   public  class DortIslem
    {
        public DortIslem()
        {

        }
        private int _sayi1, _sayi2;
        public DortIslem(int sayi1, int sayi2)
        {
            _sayi1 = sayi1;
            _sayi2 = sayi2;

        }
        public int Topla()
        {
            return _sayi1 + _sayi2;
        }
        public int Carp()
        {
            return _sayi1 * _sayi2;
        }
        public double Bolme()
        {
            return _sayi1 / _sayi2;
        }
        public int Cikarma()
        {
            return _sayi1 - _sayi2;
        }

        public int Divide(int sayi1, int sayi2)
        {
            return sayi1 / sayi2;
        }

        public int RandomX(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
    }
}
