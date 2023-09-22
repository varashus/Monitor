using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monitor
{
    class Vasar
    {
        

        public string gyartoja { get; set; }
        public string tipusa { get; set; }
        public double merete { get; set; }
        public double ara { get; set; }
        public string gamer { get; set; }
        public double afa { get;}


        public double brutto(double ara, double afa)
        {
            return (ara / afa) * 100;
        }




        public Vasar(string sor)
        {
            string[] r = sor.Split(';');
            this.gyartoja = r[0];
            this.tipusa = r[1];
            this.merete = double.Parse(r[2]);
            this.ara = double.Parse(r[3]);
            if (r.Length == 4)
            {
                this.gamer = "gamer";
            }
            if (r.Length == 5)
            {
                this.gamer = null;
            }
            this.afa = 27;
            

        }
       


    }
}
