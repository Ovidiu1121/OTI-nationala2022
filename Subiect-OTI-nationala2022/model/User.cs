using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subiect_OTI_nationala2022.model
{
    public class User
    {

        private string nume;
        private string parola;

        public User()
        {

        }

        public User(string nume,string parola)
        {
            this.nume = nume;
            this.parola = parola;
        }

        public User(string prop)
        {
            string[] a = prop.Split(' ');

            this.nume = a[0];
            this.parola=a[1];


        }

        public string describe()
        {
            string text = "";

            text+=this.nume+",";
            text+=this.parola+"\n";

            return text;
        }

        public string Nume
        {
            get { return this.nume; }
            set { this.nume = value; }
        }

        public string Parola
        {
            get { return this.parola; }
            set { this.parola = value;}
        }

        public string save()
        {
            string text = "";

            text+=this.nume;
            text+=this.parola;

            return text;
        }

    }
}
