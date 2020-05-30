using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_2
{
    public partial class FormMain : Form
    {
        public List<CFigure> Templates;
        List<string> FigureNames;
        CFiguresList FiguresList;
        Bitmap Drawing;
        Graphics Canvas;
        Pen DrawingPen;
        SolidBrush DrawingBrush;
        int[] Parameters;
        // Массив параметров:
        //Parameters[0] - тип фигуры
        //Parameters[1] - цвет пера
        //Parameters[2] - толщина пера
        //Parameters[3] - цвет заливки
        //Parameters[4 - ...] - координаты для отрисовки

        int CurrentFigure;

        public FormMain()
        {
            InitializeComponent();
        }

        private void TextBoxX1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || (e.KeyChar == 8)) { return; }
            else { e.Handled = true; }
        }

        private void TextBoxY1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || (e.KeyChar == 8)) { return; }
            else { e.Handled = true; }
        }

        private void TextBoxX2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || (e.KeyChar == 8)) { return; }
            else { e.Handled = true; }
        }

        private void TextBoxY2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || (e.KeyChar == 8)) { return; }
            else { e.Handled = true; }
        }

        private void TextBoxWidth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || (e.KeyChar == 8)) { return; }
            else { e.Handled = true; }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            CurrentFigure = 0;
            Templates = new List<CFigure>();
            FigureNames = new List<string>();
            Parameters = new int[8];

            FiguresList = new CFiguresList();
            DrawingPen = new Pen(Color.FromArgb(0, 0, 0), 1);
            DrawingBrush = new SolidBrush(Color.FromArgb(255, 255, 255));

            Drawing = new Bitmap(PictureBoxDraw.Width, PictureBoxDraw.Height);
            Canvas = Graphics.FromImage(Drawing);

            Templates.Add(CRectangle.CreateTemplate());
            FigureNames.Add("Прямоугольник");
            Templates.Add(CEllipse.CreateTemplate());
            FigureNames.Add("Эллипс");
            Templates.Add(CLine.CreateTemplate());
            FigureNames.Add("Линия");
            Templates.Add(CTrapezium.CreateTemplate());
            FigureNames.Add("Трапеция");

            LabelCurrentFigure.Text = FigureNames[0];
            PictureBoxDraw.Image = Drawing;          
        }

        private void ButtonPenColor_Click(object sender, EventArgs e)
        {
            ColorDialogPen.ShowDialog();
        }

        private void ButtonBrushColor_Click(object sender, EventArgs e)
        {
            ColorDialogBrush.ShowDialog();
        }

        private void ButtonBrushColor_Paint(object sender, PaintEventArgs e)
        {
            FiguresList.Draw(Canvas, DrawingPen,DrawingBrush);
            PictureBoxDraw.Image = Drawing;
        }

        private void ButtonNextFigure_Click(object sender, EventArgs e)
        {
            if (CurrentFigure + 1 >= Templates.Count)
            {
                CurrentFigure = 0;
                LabelCurrentFigure.Text = FigureNames[0];
            }
            else
            {
                CurrentFigure++;
                LabelCurrentFigure.Text = FigureNames[CurrentFigure];
            }
        }

        private void ButtonPreviousFigure_Click(object sender, EventArgs e)
        {
            if (CurrentFigure <= 0)
            {
                CurrentFigure = Templates.Count - 1;
                LabelCurrentFigure.Text = FigureNames[Templates.Count - 1];
            }
            else
            {
                CurrentFigure--;
                LabelCurrentFigure.Text = FigureNames[CurrentFigure];
            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if ((TextBoxX1.Text != "") && (TextBoxY1.Text != "") && (TextBoxX2.Text != "") && (TextBoxY2.Text != "") && (TextBoxWidth.Text != ""))
            {
                Parameters[0] = CurrentFigure;

                Parameters[1] = ColorDialogPen.Color.ToArgb();
                Parameters[2] = int.Parse(TextBoxWidth.Text);

                Parameters[3] = ColorDialogBrush.Color.ToArgb();

                Parameters[4] = int.Parse(TextBoxX1.Text);
                Parameters[5] = int.Parse(TextBoxY1.Text);
                Parameters[6] = int.Parse(TextBoxX2.Text);
                Parameters[7] = int.Parse(TextBoxY2.Text);             

                FiguresList.Figures.Add(Templates[CurrentFigure].Create(Parameters));

                Refresh();

            }
            else
            {
                MessageBox.Show("Один из параметров не введен", "Внимание");//Один из параметров не введен
            }
        }

        private void PictureBoxDraw_MouseClick(object sender, MouseEventArgs e)
        {
            if (CheckBoxMouseControl.Checked)
            {
                if (e.Button == MouseButtons.Left)
                {
                    TextBoxX1.Text = e.X.ToString();
                    TextBoxY1.Text = e.Y.ToString();
                }
                if (e.Button == MouseButtons.Right)
                {
                    TextBoxX2.Text = e.X.ToString();
                    TextBoxY2.Text = e.Y.ToString();
                }
                if (e.Button == MouseButtons.Middle)
                {
                    ButtonAdd.PerformClick();
                }
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FiguresList.SaveProgress();
        }

        private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FiguresList.LoadProgress(Templates);
            Refresh();
        }

        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Управление мышью: \nЛевая кнопка - координаты 1 точки \nПравая кнопка - координаты 2 точки \nКолесико мыши создание фигуры", "Помощь");
        }
    }
}
