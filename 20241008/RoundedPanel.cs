using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class RoundedPanel : Panel
{
    // Property for the corner radius
    public int CornerRadius { get; set; } = 30;

    public RoundedPanel()
    {
        this.BackColor = Color.White;
        this.DoubleBuffered = true; // Reduces flickering
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        // Create a rectangle to represent the panel area
        Rectangle panelRect = new Rectangle(0, 0, this.Width, this.Height);

        // Create a GraphicsPath for the rounded corners
        using (GraphicsPath path = GetRoundedRectPath(panelRect, CornerRadius))
        {
            // Set smoothing mode for smoother borders
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Clear the panel area and fill with background color
            e.Graphics.Clear(this.Parent.BackColor);
            using (SolidBrush brush = new SolidBrush(this.BackColor))
            {
                e.Graphics.FillPath(brush, path);
            }

            // Optional: Draw a border around the panel (customize as needed)
            using (Pen pen = new Pen(Color.Gray, 2))
            {
                e.Graphics.DrawPath(pen, path);
            }
        }
    }

    // Method to create a rounded rectangle path
    private GraphicsPath GetRoundedRectPath(Rectangle rect, int radius)
    {
        int diameter = radius * 2;
        GraphicsPath path = new GraphicsPath();

        // Top-left arc
        path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
        // Top-right arc
        path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
        // Bottom-right arc
        path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
        // Bottom-left arc
        path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
        path.CloseFigure();

        return path;
    }
}