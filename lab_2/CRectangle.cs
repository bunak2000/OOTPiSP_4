using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lab_2
{
    class CRectangle : CFigure
    {

        public CRectangle(int[] Parameters) 
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
            Canvas.FillRectangle(DrawingBrush, this.Parameters[4]+1, this.Parameters[5]+1, 
                this.Parameters[6]-this.Parameters[4] - 1, this.Parameters[7]-this.Parameters[5]-1);
            Canvas.DrawRectangle(DrawingPen, this.Parameters[4], this.Parameters[5], 
                this.Parameters[6] - this.Parameters[4], this.Parameters[7] - this.Parameters[5]);
        }
        public override CFigure Create(int[] Parameters)
        {
            CRectangle Temp = new CRectangle(Parameters);
            return Temp;
        }
        public static CRectangle CreateTemplate()
        {
            int[] TempMas;
            TempMas = new int[8];

            for (int i = 0; i < 8; i++)
            {
                TempMas[i] = 0;
            }

            CRectangle Temp = new CRectangle(TempMas);
            return Temp;
        }
        public override int[] GetParameters()
        {
            return Parameters;
        }
    }
}
