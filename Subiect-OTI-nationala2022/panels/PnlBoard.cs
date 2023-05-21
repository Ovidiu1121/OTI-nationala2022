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

        }

        private void grid_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Pen pen = new Pen(Color.Black, 2);

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
