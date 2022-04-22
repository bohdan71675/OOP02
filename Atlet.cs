using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP02
{
    class Atlet
    {
        private int unava = 0;
        private string prijmeni;
        public string Jmeno { get; }  //jmeno nastavuje pouze kontruktor(a nemam metodu se Jmenem) proto nepotrebuju: private set;

        public string Prijmeni 
        {
            get
            {
                return prijmeni;
            }
            set
            {
                string p = value;
                Char.ToUpper(p[0]);
                prijmeni = p[0] + p.Substring(1);
            }
        }


        public Atlet(string jmeno, string prijmeni)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
        }

        public void Behej(int kilometry)
        {
            while (unava != 200 && kilometry != 0)
            {
                unava = unava + 10;
                --kilometry;
            }
            if (unava == 200)
            {
                System.Windows.Forms.MessageBox.Show("Atlet je prilis unaveny");
            }
        }

        public void Spi(int hodiny)
        {
            while (unava >= 0 && hodiny != 0)
            {
                if (unava >= 100)
                {
                    unava = unava - 100;
                }
                else
                {
                    unava = 0;
                }
                --hodiny;
            }
        }

        public int GetUnava()
        {
            return unava;
        }

        public override string ToString()
        {
            string s = "\nUnava atleta: " + GetUnava();

            return base.ToString() + s;
        }
    }
}
