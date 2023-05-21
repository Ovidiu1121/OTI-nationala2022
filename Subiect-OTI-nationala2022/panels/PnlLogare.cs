using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Subiect_OTI_nationala2022.panels
{
    public class PnlLogare : Panel
    {
        private Label lbluseri;
        private Label lblparola;
        private TextBox txtbox;
        private ComboBox cmb;
        private Label lbldescriere;
        private List<PictureBox> pictureBoxes;
        public FrmHome frmHome;

        public PnlLogare(FrmHome frmHome)
        {
            this.frmHome = frmHome;
            this.Location=new System.Drawing.Point(0,0);
            this.Size=new System.Drawing.Size(818, 497);

            this.lbluseri = new Label();
            this.Controls.Add(this.lbluseri);
            this.lbluseri.Location=new System.Drawing.Point(139, 22);
            this.lbluseri.Size=new System.Drawing.Size(80, 20);
            this.lbluseri.Text="Utilizatori";
            this.lbluseri.Font=new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Regular);



        }






    }
}
