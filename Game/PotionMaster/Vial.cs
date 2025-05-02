using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
namespace PotionMaster
{
    [Serializable]
    public partial class Vial : UserControl
    {
        public int segmentsCount = 0;
        public List<Color> segments = new List<Color>();
        public MainWindow parent;
        public Vial(List<Color> segments, int segmetnsCount, MainWindow parent)
        {
            this.segments = segments;
            this.segmentsCount = segmetnsCount;
            InitializeComponent();
            this.parent = parent;
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Invalidate();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graphics = e.Graphics;
            GraphicsPath path = new GraphicsPath();

            int vialWidth = (int)(this.Width * 0.7);
            int bottomRadius = this.Height / 10;
            int vialHeight = (int)(this.Height * 0.9) - 2 * bottomRadius;
            int totalVialHeight = vialHeight + 2 * bottomRadius;

            Point upperLeftCorner = new Point(this.Width / 2 - vialWidth / 2, this.Height / 2 - vialHeight / 2 - bottomRadius);
            Point lowerLeftCorner = new Point(upperLeftCorner.X, upperLeftCorner.Y + vialHeight - bottomRadius);
            Point upperRightCorner = new Point(upperLeftCorner.X + vialWidth, upperLeftCorner.Y);
            Point lowerRightCorner = new Point(upperLeftCorner.X + vialWidth, upperLeftCorner.Y + vialHeight - bottomRadius);

            path.StartFigure();
            path.AddLine(upperRightCorner, lowerRightCorner);
            path.AddArc(lowerLeftCorner.X, lowerLeftCorner.Y + bottomRadius, vialWidth, bottomRadius * 2, 0, 180); // Adding a half-arc for the bottom
            path.AddLine(lowerLeftCorner, upperLeftCorner);

            float gap = 3;
            float segmentHeight = (totalVialHeight - (gap * segmentsCount) - 5) / segmentsCount;

            graphics.SetClip(path);
            for (int i = 0; i < segments.Count; i++)
            {
                using (SolidBrush solidBrush = new SolidBrush(segments[i]))
                {
                    graphics.FillRectangle(solidBrush, upperLeftCorner.X, upperLeftCorner.Y + totalVialHeight - (segmentHeight * (i + 1) + gap * i), vialWidth, segmentHeight);
                }
            }
            graphics.ResetClip();

            graphics.SmoothingMode = SmoothingMode.AntiAlias;

            graphics.DrawPath(new Pen(Color.Black, 5), path);

        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left && segments.Count != 0)
            {
                this.DoDragDrop(this, DragDropEffects.Move);
            }
        }
        protected override void OnDragEnter(DragEventArgs e)
        {
            base.OnDragEnter(e);
            if (e.Data != null && e.Data.GetDataPresent(typeof(Vial)))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        protected override void OnDragDrop(DragEventArgs e)
        {
            base.OnDragDrop(e);

            if (!e.Data.GetDataPresent(typeof(Vial))) return;

            Vial source = e.Data.GetData(typeof(Vial)) as Vial;
            Vial sink = this;

            if (source == null || source == sink || source.segments.Count == 0) return;

            Color topColor = source.segments.Last();

            int pouringCount = CalculatePourCount(source, topColor);
            if (!CanPourSegments(sink, pouringCount, topColor)) return;

            MoveSegments(source, sink, pouringCount);
            InvalidateVials(source, sink);

            parent.AddLastMoveToStack(source, sink, pouringCount);
            parent.CheckWinningCondition();
        }

        private int CalculatePourCount(Vial source, Color topColor)
        {
            int pourCount = 1;

            // Check consecutive segments with matching color from the second-last segment
            for (int i = source.segments.Count - 2; i >= 0; i--)
            {
                if (source.segments[i] == topColor)
                {
                    pourCount++;
                }
                else
                {
                    break;
                }
            }
            return pourCount;
        }

        private bool CanPourSegments(Vial sink, int pourCount, Color topColor)
        {
            bool isSinkEmpty = sink.segments.Count == 0;
            bool hasMatchingTopColor = sink.segments.LastOrDefault() == topColor;
            bool hasCapacity = sink.segments.Count + pourCount <= sink.segmentsCount;

            // If the target vial is empty or has the same top color and there is enough space, return true
            return (isSinkEmpty || hasMatchingTopColor) && hasCapacity;
        }

        private void MoveSegments(Vial source, Vial sink, int pourCount)
        {
            // Remove the segments from the source vial and add them to the target vial
            for (int i = 0; i < pourCount; i++)
            {
                Color segment = source.segments.Last();
                source.segments.RemoveAt(source.segments.Count - 1);
                sink.segments.Add(segment);
            }
        }

        private void InvalidateVials(Vial source, Vial sink)
        {

            source.Invalidate();
            sink.Invalidate();
        }
    }
}
