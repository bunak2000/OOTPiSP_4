using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Reflection;

namespace lab_2
{
    class CTrapezium : CFigure
    {
        public CTrapezium(int[] Parameters)
        {
            if (Parameters.Length >= 8)
            {
                this.Parameters = new int[8];

                for (int i = 0; i < 8; i++)
                {
                    this.Parameters[i] = Parameters[i];
                }
            }
        }
        public override void Draw(Graphics Canvas, Pen DrawingPen, SolidBrush DrawingBrush)
        {
            DrawingPen.Color = Color.FromArgb(this.Parameters[1]);
            DrawingPen.Width = this.Parameters[2];
            DrawingBrush.Color = Color.FromArgb(this.Parameters[3]);
            //Canvas.fill(DrawingBrush, this.Parameters[4], this.Parameters[5],
            //this.Parameters[6] - this.Parameters[4], this.Parameters[7] - this.Parameters[5]);
            //Canvas.DrawEllipse(DrawingPen, this.Parameters[4], this.Parameters[5],
            //  this.Parameters[6] - this.Parameters[4], this.Parameters[7] - this.Parameters[5]);
            Point[] Points;
            Points = new Point[5];

            Points[0].X = this.Parameters[4] + ((Math.Abs(this.Parameters[6] - this.Parameters[4]))/4);
            Points[0].Y = this.Parameters[5];
            Points[1].X = this.Parameters[6] - ((Math.Abs(this.Parameters[6] - this.Parameters[4])) / 4);
            Points[1].Y = this.Parameters[5];
            Points[2].X = this.Parameters[6];
            Points[2].Y = this.Parameters[7];
            Points[3].X = this.Parameters[4];
            Points[3].Y = this.Parameters[7];
            Points[4].X = Points[0].X;
            Points[4].Y = Points[0].Y;

            Canvas.FillPolygon(DrawingBrush, Points);
            Canvas.DrawLines(DrawingPen,Points);
            //Canvas.DrawCurve(DrawingPen,Points);
        }
        public override CFigure Create(int[] Parameters)
        {
            CTrapezium Temp = new CTrapezium(Parameters);
            return Temp;
        }
        public static CTrapezium CreateTemplate()
        {
            int[] TempMas;
            TempMas = new int[8];

            for (int i = 1; i < 8; i++)
            {
                TempMas[i] = 0;
            }

            CTrapezium Temp = new CTrapezium(TempMas);
            return Temp;
        }
        public override int[] GetParameters()
        {
            return Parameters;
        }
    }
}
