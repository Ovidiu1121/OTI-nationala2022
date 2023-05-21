using Subiect_OTI_nationala2022.state;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Subiect_OTI_nationala2022.panels
{
    public class PnlAside:Panel
    {
        private CheckBox checkBox;
        private Button btnincarcaharta;
        private Label lbladaugadeflector;
        private Panel pnldeflcetor;
        private Button btnrotestedeflector;
        private Button btncuratatot;
        private Label lblsticle;
        private Label lblsticlenr;
        private Label lblhartie;
        private Label lblhartier;
        private Label lblplastic;
        private Label lblplasticnr;
        private Button btnstart;
        private Button btnrestart;
        private Button btnsalvarejpg;
        private Button btngeneraretraseu;

        public PnlAside()
        {
            this.Size = new System.Drawing.Size(200, 749);
            this.Location = new System.Drawing.Point(1200, 0);
            this.BackgroundImage=Image.FromFile(Application.StartupPath+@"\Wood\Wood1.jpg");
            this.BackgroundImageLayout=ImageLayout.Stretch;

            this.checkBox = new CheckBox();
            this.Controls.Add(this.checkBox);
            this.checkBox.Location=new System.Drawing.Point(10, 10);
            this.checkBox.Size=new System.Drawing.Size(182, 24);
            this.checkBox.Text="Afiseaza linii de grid";
            this.checkBox.Font=new Font("Arial", 12, FontStyle.Bold);
            this.checkBox.ForeColor=System.Drawing.Color.White;
            this.checkBox.BackColor=System.Drawing.Color.Transparent;
            this.checkBox.CheckedChanged+=new EventHandler(checkBox1_CheckedChanged);

            this.lbladaugadeflector=new Label();
            this.Controls.Add(this.lbladaugadeflector);
            this.lbladaugadeflector.Location=new Point(10, 90);
            this.lbladaugadeflector.Size=new System.Drawing.Size(150, 20);
            this.lbladaugadeflector.Text="Adauga deflector";
            this.lbladaugadeflector.Font=new Font("Arial", 12, FontStyle.Bold);
            this.lbladaugadeflector.ForeColor=System.Drawing.Color.White;
            this.lbladaugadeflector.BackColor=System.Drawing.Color.Transparent;

            this.btnincarcaharta=new Button();
            this.Controls.Add(this.btnincarcaharta);
            this.btnincarcaharta.Location=new Point(10, 40);
            this.btnincarcaharta.Size=new Size(145, 43);
            this.btnincarcaharta.Text="Incarca harta";
            this.btnincarcaharta.Font=new Font("Arial", 10, FontStyle.Bold);

            this.pnldeflcetor=new PnlDeflector();
            this.Controls.Add(this.pnldeflcetor);
            this.pnldeflcetor.Location=new Point(60, 130);
            this.pnldeflcetor.Size=new Size(60, 60);

            this.btnrotestedeflector=new Button();
            this.Controls.Add(this.btnrotestedeflector);
            this.btnrotestedeflector.Location=new Point(10, 200);
            this.btnrotestedeflector.Size=new Size(147, 37);
            this.btnrotestedeflector.Text="Roteste deflector";
            this.btnrotestedeflector.Font=new Font("Arial", 10, FontStyle.Bold);

            this.btncuratatot=new Button();
            this.Controls.Add(this.btncuratatot);
            this.btncuratatot.Location=new Point(10, 250);
            this.btncuratatot.Size=new Size(147, 37);
            this.btncuratatot.Text="Curata tot";
            this.btncuratatot.Font=new Font("Arial", 10, FontStyle.Bold);

            this.lblsticle=new Label();
            this.Controls.Add(this.lblsticle);
            this.lblsticle.Location=new Point(10, 300);
            this.lblsticle.Size=new System.Drawing.Size(51, 20);
            this.lblsticle.Text="Sticle";
            this.lblsticle.Font=new Font("Arial", 12, FontStyle.Bold);
            this.lblsticle.ForeColor=System.Drawing.Color.White;
            this.lblsticle.BackColor=System.Drawing.Color.Transparent;

            this.lblhartie=new Label();
            this.Controls.Add(this.lblhartie);
            this.lblhartie.Location=new Point(10, 330);
            this.lblhartie.Size=new System.Drawing.Size(60, 20);
            this.lblhartie.Text="Hartie";
            this.lblhartie.Font=new Font("Arial", 12, FontStyle.Bold);
            this.lblhartie.ForeColor=System.Drawing.Color.White;
            this.lblhartie.BackColor=System.Drawing.Color.Transparent;

            this.lblplastic=new Label();
            this.Controls.Add(this.lblplastic);
            this.lblplastic.Location=new Point(10, 360);
            this.lblplastic.Size=new System.Drawing.Size(60, 20);
            this.lblplastic.Text="Plastic";
            this.lblplastic.Font=new Font("Arial", 12, FontStyle.Bold);
            this.lblplastic.ForeColor=System.Drawing.Color.White;
            this.lblplastic.BackColor=System.Drawing.Color.Transparent;

            this.btnstart=new Button();
            this.Controls.Add(this.btnstart);
            this.btnstart.Location=new Point(10, 390);
            this.btnstart.Size=new Size(160, 49);
            this.btnstart.Text="Start";
            this.btnstart.Font=new Font("Arial", 10, FontStyle.Bold);

            this.btnrestart=new Button();
            this.Controls.Add(this.btnrestart);
            this.btnrestart.Location=new Point(10, 450);
            this.btnrestart.Size=new Size(147, 33);
            this.btnrestart.Text="Restart";
            this.btnrestart.Font=new Font("Arial", 10, FontStyle.Bold);

            this.btnsalvarejpg=new Button();
            this.Controls.Add(this.btnsalvarejpg);
            this.btnsalvarejpg.Location=new Point(10, 490);
            this.btnsalvarejpg.Size=new Size(147, 33);
            this.btnsalvarejpg.Text="Salveaza jpg";
            this.btnsalvarejpg.Font=new Font("Arial", 10, FontStyle.Bold);

            this.btngeneraretraseu=new Button();
            this.Controls.Add(this.btngeneraretraseu);
            this.btngeneraretraseu.Location=new Point(10, 530);
            this.btngeneraretraseu.Size=new Size(147, 33);
            this.btngeneraretraseu.Text="Genereaza traseu";
            this.btngeneraretraseu.Font=new Font("Arial", 10, FontStyle.Bold);

            this.lblsticlenr=new Label();
            this.Controls.Add(this.lblsticlenr);
            this.lblsticlenr.Location=new Point(120, 300);
            this.lblsticlenr.Size=new System.Drawing.Size(40, 20);
            this.lblsticlenr.Text="00";
            this.lblsticlenr.Font=new Font("Arial", 12, FontStyle.Bold);
            this.lblsticlenr.ForeColor=System.Drawing.Color.White;
            this.lblsticlenr.BackColor=System.Drawing.Color.Transparent;

            this.lblhartie=new Label();
            this.Controls.Add(this.lblhartie);
            this.lblhartie.Location=new Point(120, 330);
            this.lblhartie.Size=new System.Drawing.Size(40, 20);
            this.lblhartie.Text="00";
            this.lblhartie.Font=new Font("Arial", 12, FontStyle.Bold);
            this.lblhartie.ForeColor=System.Drawing.Color.White;
            this.lblhartie.BackColor=System.Drawing.Color.Transparent;

            this.lblplastic=new Label();
            this.Controls.Add(this.lblplastic);
            this.lblplastic.Location=new Point(120, 360);
            this.lblplastic.Size=new System.Drawing.Size(40, 20);
            this.lblplastic.Text="00";
            this.lblplastic.Font=new Font("Arial", 12, FontStyle.Bold);
            this.lblplastic.ForeColor=System.Drawing.Color.White;
            this.lblplastic.BackColor=System.Drawing.Color.Transparent;

            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
             AppState.showGrid.OnNext(this.checkBox.Checked);
        }


    }
}
