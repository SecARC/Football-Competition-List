using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace week13_1
{
    public class RoundButton: Button
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath g = new GraphicsPath();
            g.AddEllipse(5, 5, ClientSize.Width - 10, ClientSize.Height - 10);

            this.Region = new System.Drawing.Region(g);

            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBilinear;
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.CompositingQuality = CompositingQuality.HighQuality;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

            base.OnPaint(e);
        }
    }
}
