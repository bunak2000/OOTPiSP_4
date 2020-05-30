using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab_2
{
    class CFiguresList
    {
        public List<CFigure> Figures;

        public CFiguresList()
        {
            Figures = new List<CFigure>();
        }
        public void Draw(Graphics Canvas, Pen DrawingPen, SolidBrush DrawingBrush)
        {
            for (int i = 1; i <= this.Figures.Count; i++)
            {
                Figures[i - 1].Draw(Canvas, DrawingPen,DrawingBrush);
            }
        }
        public void SaveProgress()
        {
            StreamWriter stream = new StreamWriter("data.txt", false, System.Text.Encoding.Default);

            int[] Params;

            for (int i = 1; i <= this.Figures.Count; i++)
            {
                Params = Figures[i - 1].GetParameters();
                stream.WriteLine(Params[0]);
                stream.WriteLine(Params[1]);
                stream.WriteLine(Params[2]);
                stream.WriteLine(Params[3]);
                for (int j = 4; j < Params.Length; j++)
                {
                    stream.Write(Params[j].ToString() + "/");
                }
                stream.WriteLine();
                stream.WriteLine("|");

            }
            stream.Close();
        }
        public void LoadProgress(List<CFigure> template)
        {
            StreamReader stream = new StreamReader("data.txt", System.Text.Encoding.Default);
            int[] Parameters = new int[8];
            int temp_pos = 0;
            string line, temp_int;

            temp_int = "";

            while (!stream.EndOfStream)
            {
                line = stream.ReadLine();
                Parameters[0] = int.Parse(line);
                line = stream.ReadLine();
                Parameters[1] = int.Parse(line);
                line = stream.ReadLine();
                Parameters[2] = int.Parse(line);
                line = stream.ReadLine();
                Parameters[3] = int.Parse(line);
                line = stream.ReadLine();
                for (int i = 0; i < line.Length; i++)
                {
                    if (line[i] != '/')
                    {
                        temp_int = temp_int + line[i];
                    }
                    else
                    {
                        Parameters[temp_pos+4] = int.Parse(temp_int);
                        temp_int = "";
                        temp_pos++;
                    }
                }
                line = stream.ReadLine();

                Figures.Add(template[Parameters[0]].Create(Parameters));
                temp_pos = 0;
            }

            stream.Close();
        }
    }
}
