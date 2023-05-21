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
    public class ControlUseri
    {
        public List<User> lista;
        public string path = Application.StartupPath+@"\Useri.txt";

        public ControlUseri()
        {
            load();
        }

        public void load()
        {
            lista=new List<User>();
            StreamReader read = new StreamReader(path);

            string line = "";

            while ((line = read.ReadLine()) != null)
            {
                User a = new User(line);

                lista.Add(a);
            }
            read.Close();
        }

        public string afisare()
        {
            string text = "";

            for (int i = 0; i < lista.Count; i++)
            {
                text += lista[i].describe();
            }
            return text;
        }

    }
}
