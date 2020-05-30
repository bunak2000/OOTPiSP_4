using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lab_2
{
    public class CFigure
    {
        protected int[] Parameters;

        public virtual void Draw(Graphics Canvas, Pen DrawingPen, SolidBrush DrawingBrush)
        {
        }
        public CFigure()
        {
            this.Parameters = null;
        }
        public virtual CFigure Create(int[] Parameters)
        {
            return null;
        }
        public virtual int[] GetParameters()
        {
            return null;
        }
    }
}
