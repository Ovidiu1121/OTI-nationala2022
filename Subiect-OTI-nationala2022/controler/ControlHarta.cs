using Subiect_OTI_nationala2022.model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Subiect_OTI_nationala2022.controler
{
    public class ControlHarta
    {
        public List<Harta> lista = new List<Harta>();
        public Random r=new Random();  
        
        public ControlHarta()
        {
            this.load();
        }

        public void load()
        {
           string path = Application.StartupPath+@"\Harta"+r.Next(1, 3)+".txt";
        StreamReader read = new StreamReader(path);

            string line = "";

            while ((line=read.ReadLine())!=null)
            {
                Harta harta = new Harta(line);
                lista.Add(harta);
            }
            read.Close();
        }

        public string afisare()
        {
            string text = "";

            for(int i = 0; i<lista.Count; i++)
            {
                text+=lista[i].describe()+"\n";
            }
            return text;
        }

        public List<Harta> getLista()
        {
            return lista;
        }

    }
}
