using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP02
{
    class Atlet
    {
        private string jmeno;
        private int unava;
        private int ubehnuto;
        private int naspano;
        public Atlet(string jmeno)
        {
            this.jmeno = jmeno;
        }

        public void Behej(int kilometry)
        {
            unava = 0;
            while (unava != 200 && kilometry != 0)
            {
                ubehnuto = ubehnuto + 1;
                unava = unava + 10;
                --kilometry;
            }
        }

        public void Spi(int hodiny)
        {
            unava = 200;
            naspano = 0;
            while (unava >= 0 && hodiny != 0)
            {
                naspano = naspano + 1;
                unava = unava - 100;
                --hodiny;
            }
        }

        public int ZjistiUnavu()
        {
            return unava;
        }


    }
}
