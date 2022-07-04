using System.Drawing;
using System.Windows.Forms;

namespace BankUI.Customizing
{
    public class MenuStripColor : ProfessionalColorTable
    {
        public override Color MenuBorder => Color.FromArgb(100, 100, 100);


        public override Color ImageMarginGradientBegin => Color.FromArgb(100, 100, 100);
        public override Color ImageMarginGradientMiddle => Color.FromArgb(100, 100, 100);
        public override Color ImageMarginGradientEnd => Color.FromArgb(100, 100, 100);

        public override Color MenuItemBorder => Color.FromArgb(120, 120, 120);
        public override Color MenuItemSelected => Color.FromArgb(64, 64, 64);
        public override Color MenuItemSelectedGradientBegin => Color.FromArgb(100, 100, 100);
        public override Color MenuItemSelectedGradientEnd => Color.FromArgb(100, 100, 100);
        public override Color MenuItemPressedGradientBegin => Color.FromArgb(100, 100, 100);
        public override Color MenuItemPressedGradientEnd => Color.FromArgb(100, 100, 100);
        public override Color MenuItemPressedGradientMiddle => Color.FromArgb(100, 100, 100);


        public override Color ButtonPressedBorder => Color.FromArgb(64, 64, 64);

        public override Color ToolStripBorder => Color.FromArgb(0, 0, 0);

        public override Color ToolStripDropDownBackground => Color.FromArgb(100, 100, 100);


        public override Color ToolStripGradientBegin => Color.FromArgb(64, 64, 64);

        public override Color ToolStripGradientEnd => Color.FromArgb(64, 64, 64);

        public override Color ToolStripGradientMiddle => Color.FromArgb(64, 64, 64);
    }
}
