using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Subiect_OTI_nationala2022.panels
{
    public class PnlDeflector:Panel
    {
        public PnlDeflector()
        {
            this.Location=new System.Drawing.Point(0, 0);
            this.Size=new System.Drawing.Size(131, 108);
            this.BackColor=Color.Transparent;

            this.Paint+=new PaintEventHandler(panel_Paint);
        }
        private void panel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.White, 2); // Choose your desired pen color and thickness
            Brush brush = new SolidBrush(Color.White);

            // Define the triangle points
            Point[] trianglePoints = new Point[]
            {
                new Point(0,0), // Point A
                new Point(0,60), // Point B
                new Point(60, 60)  // Point C
            };

            // Draw the triangle
            g.DrawPolygon(pen, trianglePoints);
            g.FillPolygon(brush, trianglePoints);
        }

    }
}
