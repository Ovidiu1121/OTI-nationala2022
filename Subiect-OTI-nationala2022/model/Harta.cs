using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subiect_OTI_nationala2022.model
{
    public class Harta
    {
        private string entitate;
        private int x;
        private int y;

        public Harta()
        {

        }

        public Harta(string entitate,int x, int y)
        {
            this.entitate = entitate;
            this.x = x;
            this.y = y;
        }

        public Harta(string prop)
        {
            string[] a = prop.Split(' ');

            this.entitate = a[0];
            this.x = int.Parse(a[1]);
            this.y = int.Parse(a[2]);

        }

        public string Entitate
        {
            get { return this.entitate; }
            set { this.entitate = value;}
        }

        public int X
        {
            get { return this.x; }
            set { this.x = value; }

        }

        public int Y
        {
            get { return this.y; }
            set { this.y = value; }
        }

        public string describe()
        {
            string text = "";

            text+=this.entitate+",";
            text+=this.x+",";
            text+=this.y;

            return text;
        }

    }
}
