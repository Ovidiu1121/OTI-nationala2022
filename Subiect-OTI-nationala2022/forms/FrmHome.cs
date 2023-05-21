using Subiect_OTI_nationala2022.panels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Subiect_OTI_nationala2022
{
    public partial class FrmHome : Form
    {
        public Panel pnlLogare;

        public FrmHome()
        {
            InitializeComponent();

            this.Size = new System.Drawing.Size(1400, 640);

            pnlLogare=new PnlLogare(this);
            Panel pnldeflector = new PnlDeflector();
            Panel pnlAside = new PnlAside();
            Panel pnlBoard = new PnlBoard();

            this.Controls.Add(pnlAside);
            this.Controls.Add(pnlBoard);


        }

        private void FrmHome_Load(object sender, EventArgs e)
        {

        }
    }
}
