using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PripremaZaProvjeruZnanja
{
    class Vozilo
    {
        private String Vrsta, Marka,Naziv;
       private DateTime GodinaProizvodnje;
       private int Snaga;

        public Vozilo(string vrsta, string marka, string naziv, DateTime godinaProizvodnje, int snaga)
        {
            Vrsta = vrsta;
            Marka = marka;
            Naziv = naziv;
            GodinaProizvodnje = godinaProizvodnje;
            Snaga = snaga;
        }

        public int Snaga1 { get => Snaga; set => Snaga = value; }
        public string Vrsta1 { get => Vrsta; set => Vrsta = value; }
        public string Marka1 { get => Marka; set => Marka = value; }
        public string Naziv1 { get => Naziv; set => Naziv = value; }
        public DateTime GodinaProizvodnje1 { get => GodinaProizvodnje; set => GodinaProizvodnje = value; }


        public override string ToString()
        {
            String ispis = " Vrsta: " + this.Vrsta + " Marka: " + this.Marka + "Naziv: " + this.Naziv + " Godina Proizvodnje: " + this.GodinaProizvodnje.Year + " Snaga: " + this.Snaga;
            return ispis;
        }
    }
}
