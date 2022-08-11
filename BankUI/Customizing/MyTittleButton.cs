using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Controls;
using System.Windows.Forms;

namespace BankUI.Customizing
{
    public class MyTittleButton : Button
    {
        protected override void OnMouseHover(EventArgs e)
        {
            base.OnMouseHover(e);

            using (Graphics gf = CreateGraphics())
            using (Pen pen = new Pen(SystemColors.GradientActiveCaption, 1))
            {
                for (int x = 0, y = Height; y >= 0; x += 5, y--)
                {

                    gf.DrawLine(pen, 0, Height - 1, 0, y);    // Y-Axis
                    gf.DrawLine(pen, 0, Height - 1, x, Height - 1); // X-Axis
                }
            }
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);

            using (Graphics gf = CreateGraphics())
            using (Pen pen = new Pen(SystemColors.Control, 1))
            {
                for (int x = Width - 1, y = 0 ; y >= Height - 1; x-=5, y++)
                {
                    gf.DrawLine(pen, 0, y, 0, Height - 1);            // Y-Axis
                    gf.DrawLine(pen, Width - 1, Height - 1, x, Height - 1); // X - Axis
                }
            }        
        }
    }
}
