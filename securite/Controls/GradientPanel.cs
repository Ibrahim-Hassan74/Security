using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Security.Controls
{
    public class GradientPanel : Panel
    {
        public Color GradientTop { get; set; }
        public Color GradientBottom { get; set; }

        public GradientPanel()
        {
            this.Resize += GradientPanel_Resize;
        }

        private void GradientPanel_Resize(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            LinearGradientBrush linear = new LinearGradientBrush(
                                            this.ClientRectangle,       
                                            this.GradientTop,          
                                            this.GradientBottom,       
                                            90F);                      

            Graphics g = e.Graphics;

            g.FillRectangle(linear, this.ClientRectangle);

            base.OnPaint(e);
        }
    }
}
