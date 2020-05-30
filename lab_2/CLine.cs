using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lab_2
{
    class CLine : CFigure
    {
        public CLine(int[] Parameters)
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
            Canvas.DrawLine(DrawingPen, this.Parameters[4], this.Parameters[5],this.Parameters[6], this.Parameters[7]);
        }
        public override CFigure Create(int[] Parameters)
        {
            CLine Temp = new CLine(Parameters);
            return Temp;
        }
        public static CLine CreateTemplate()
        {
            int[] TempMas;
            TempMas = new int[8];

            for (int i = 1; i < 8; i++)
            {
                TempMas[i] = 0;
            }

            CLine Temp = new CLine(TempMas);
            return Temp;
        }
        public override int[] GetParameters()
        {
            return Parameters;
        }
    }
}
