using Subiect_OTI_nationala2022.controler;
using Subiect_OTI_nationala2022.model;
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
    public class PnlBoard:Panel
    {
        public PnlBoard()
        {
            this.Location=new System.Drawing.Point(0, 0) ;
            this.Size=new System.Drawing.Size(1200, 600);
            this.BackgroundImage=Image.FromFile(Application.StartupPath+@"\Background\Back2.jpg");
            this.BackgroundImageLayout=ImageLayout.Stretch;


            AppState.showGrid.Subscribe(value =>
            {

                if (value.Equals(true))
                {
                    this.BringToFront();
                    this.Paint+=new PaintEventHandler(grid_Paint);
                    this.BackgroundImage=Image.FromFile(Application.StartupPath+@"\Background\Back2.jpg");
                }
                else
                {
                    this.Paint-=new PaintEventHandler(grid_Paint);
                    this.Invalidate();
                }

            });

            AppState.showHarta.Subscribe(value =>
            {
                if (value.Equals(true))
                {
                    ControlHarta control = new ControlHarta();
                    List<Harta> lista = control.getLista();

                    this.BringToFront();

                    foreach (Harta harta in lista)
                    {
                        PictureBox pictureBox = new PictureBox();
                        if (harta.Entitate.Equals("Robot"))
                        {
                            pictureBox.Image = Image.FromFile(Application.StartupPath +@"\Robot\Robot.png");
                        }
                        else if (harta.Entitate.Equals("Sticla")||harta.Entitate.Equals("Hartie")||harta.Entitate.Equals("Plastic"))
                        {
                            pictureBox.Image = Image.FromFile(Application.StartupPath +@"\MaterialeReciclabile\"+harta.Entitate+".png");
                        }
                        else
                        {
                            pictureBox.Image = Image.FromFile(Application.StartupPath +@"\Meduze\"+harta.Entitate+".png");
                        }
                        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox.Size = new System.Drawing.Size(60, 60);
                        pictureBox.Location = new Point(harta.X*60, harta.Y*60);
                        this.Controls.Add(pictureBox);

                    }
                }
            });



        }

        private void grid_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Pen pen = new Pen(Color.White, 2);

            int width = 1200;
            int height = 600;
            int cellSize = 60;
            int numCellsX = width / cellSize;
            int numCellsY = height / cellSize;

            for (int x = 0; x < numCellsX; x++)
            {
                int xPos = x * cellSize;
                g.DrawLine(pen, xPos, 0, xPos, height);
            }

            for (int y = 0; y < numCellsY; y++)
            {
                int yPos = y * cellSize;
                g.DrawLine(pen, 0, yPos, width, yPos);
            }
            
        }




    }
}
