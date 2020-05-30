namespace lab_2
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.PanelMain = new System.Windows.Forms.Panel();
            this.CheckBoxMouseControl = new System.Windows.Forms.CheckBox();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ButtonBrushColor = new System.Windows.Forms.Button();
            this.ButtonPenColor = new System.Windows.Forms.Button();
            this.TextBoxWidth = new System.Windows.Forms.TextBox();
            this.LabelWidthInfo = new System.Windows.Forms.Label();
            this.TextBoxY2 = new System.Windows.Forms.TextBox();
            this.TextBoxX2 = new System.Windows.Forms.TextBox();
            this.TextBoxY1 = new System.Windows.Forms.TextBox();
            this.TextBoxX1 = new System.Windows.Forms.TextBox();
            this.LabelY2Info = new System.Windows.Forms.Label();
            this.LabelX2Info = new System.Windows.Forms.Label();
            this.LabelEnterCoordinatesInfo2 = new System.Windows.Forms.Label();
            this.LabelY1Info = new System.Windows.Forms.Label();
            this.LabelX1Info = new System.Windows.Forms.Label();
            this.LabelEnterCoordinatesInfo1 = new System.Windows.Forms.Label();
            this.ButtonPreviousFigure = new System.Windows.Forms.Button();
            this.ButtonNextFigure = new System.Windows.Forms.Button();
            this.LabelCurrentFigure = new System.Windows.Forms.Label();
            this.LabelCurrentFigureInfo = new System.Windows.Forms.Label();
            this.PictureBoxDraw = new System.Windows.Forms.PictureBox();
            this.ColorDialogPen = new System.Windows.Forms.ColorDialog();
            this.ColorDialogBrush = new System.Windows.Forms.ColorDialog();
            this.MenuStripMain = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxDraw)).BeginInit();
            this.MenuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMain
            // 
            this.PanelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.PanelMain.Controls.Add(this.CheckBoxMouseControl);
            this.PanelMain.Controls.Add(this.ButtonAdd);
            this.PanelMain.Controls.Add(this.ButtonBrushColor);
            this.PanelMain.Controls.Add(this.ButtonPenColor);
            this.PanelMain.Controls.Add(this.TextBoxWidth);
            this.PanelMain.Controls.Add(this.LabelWidthInfo);
            this.PanelMain.Controls.Add(this.TextBoxY2);
            this.PanelMain.Controls.Add(this.TextBoxX2);
            this.PanelMain.Controls.Add(this.TextBoxY1);
            this.PanelMain.Controls.Add(this.TextBoxX1);
            this.PanelMain.Controls.Add(this.LabelY2Info);
            this.PanelMain.Controls.Add(this.LabelX2Info);
            this.PanelMain.Controls.Add(this.LabelEnterCoordinatesInfo2);
            this.PanelMain.Controls.Add(this.LabelY1Info);
            this.PanelMain.Controls.Add(this.LabelX1Info);
            this.PanelMain.Controls.Add(this.LabelEnterCoordinatesInfo1);
            this.PanelMain.Controls.Add(this.ButtonPreviousFigure);
            this.PanelMain.Controls.Add(this.ButtonNextFigure);
            this.PanelMain.Controls.Add(this.LabelCurrentFigure);
            this.PanelMain.Controls.Add(this.LabelCurrentFigureInfo);
            this.PanelMain.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelMain.Location = new System.Drawing.Point(781, 24);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(255, 602);
            this.PanelMain.TabIndex = 0;
            // 
            // CheckBoxMouseControl
            // 
            this.CheckBoxMouseControl.AutoSize = true;
            this.CheckBoxMouseControl.Location = new System.Drawing.Point(45, 248);
            this.CheckBoxMouseControl.Name = "CheckBoxMouseControl";
            this.CheckBoxMouseControl.Size = new System.Drawing.Size(186, 17);
            this.CheckBoxMouseControl.TabIndex = 19;
            this.CheckBoxMouseControl.Text = "Использовать мышь для ввода";
            this.CheckBoxMouseControl.UseVisualStyleBackColor = true;
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(80, 403);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(95, 25);
            this.ButtonAdd.TabIndex = 18;
            this.ButtonAdd.Text = "Добавить";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ButtonBrushColor
            // 
            this.ButtonBrushColor.Location = new System.Drawing.Point(143, 335);
            this.ButtonBrushColor.Name = "ButtonBrushColor";
            this.ButtonBrushColor.Size = new System.Drawing.Size(95, 25);
            this.ButtonBrushColor.TabIndex = 17;
            this.ButtonBrushColor.Text = "Цвет заливки";
            this.ButtonBrushColor.UseVisualStyleBackColor = true;
            this.ButtonBrushColor.Click += new System.EventHandler(this.ButtonBrushColor_Click);
            this.ButtonBrushColor.Paint += new System.Windows.Forms.PaintEventHandler(this.ButtonBrushColor_Paint);
            // 
            // ButtonPenColor
            // 
            this.ButtonPenColor.Location = new System.Drawing.Point(19, 335);
            this.ButtonPenColor.Name = "ButtonPenColor";
            this.ButtonPenColor.Size = new System.Drawing.Size(95, 25);
            this.ButtonPenColor.TabIndex = 16;
            this.ButtonPenColor.Text = "Цвет пера";
            this.ButtonPenColor.UseVisualStyleBackColor = true;
            this.ButtonPenColor.Click += new System.EventHandler(this.ButtonPenColor_Click);
            // 
            // TextBoxWidth
            // 
            this.TextBoxWidth.Location = new System.Drawing.Point(85, 309);
            this.TextBoxWidth.Name = "TextBoxWidth";
            this.TextBoxWidth.Size = new System.Drawing.Size(90, 20);
            this.TextBoxWidth.TabIndex = 15;
            this.TextBoxWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxWidth_KeyPress);
            // 
            // LabelWidthInfo
            // 
            this.LabelWidthInfo.AutoSize = true;
            this.LabelWidthInfo.Location = new System.Drawing.Point(73, 293);
            this.LabelWidthInfo.Name = "LabelWidthInfo";
            this.LabelWidthInfo.Size = new System.Drawing.Size(119, 13);
            this.LabelWidthInfo.TabIndex = 14;
            this.LabelWidthInfo.Text = "Введите ширину пера:";
            // 
            // TextBoxY2
            // 
            this.TextBoxY2.Location = new System.Drawing.Point(163, 212);
            this.TextBoxY2.Name = "TextBoxY2";
            this.TextBoxY2.Size = new System.Drawing.Size(50, 20);
            this.TextBoxY2.TabIndex = 13;
            this.TextBoxY2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxY2_KeyPress);
            // 
            // TextBoxX2
            // 
            this.TextBoxX2.Location = new System.Drawing.Point(64, 212);
            this.TextBoxX2.Name = "TextBoxX2";
            this.TextBoxX2.Size = new System.Drawing.Size(50, 20);
            this.TextBoxX2.TabIndex = 12;
            this.TextBoxX2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxX2_KeyPress);
            // 
            // TextBoxY1
            // 
            this.TextBoxY1.Location = new System.Drawing.Point(163, 151);
            this.TextBoxY1.Name = "TextBoxY1";
            this.TextBoxY1.Size = new System.Drawing.Size(50, 20);
            this.TextBoxY1.TabIndex = 11;
            this.TextBoxY1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxY1_KeyPress);
            // 
            // TextBoxX1
            // 
            this.TextBoxX1.Location = new System.Drawing.Point(64, 151);
            this.TextBoxX1.Name = "TextBoxX1";
            this.TextBoxX1.Size = new System.Drawing.Size(50, 20);
            this.TextBoxX1.TabIndex = 10;
            this.TextBoxX1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxX1_KeyPress);
            // 
            // LabelY2Info
            // 
            this.LabelY2Info.AutoSize = true;
            this.LabelY2Info.Location = new System.Drawing.Point(140, 215);
            this.LabelY2Info.Name = "LabelY2Info";
            this.LabelY2Info.Size = new System.Drawing.Size(17, 13);
            this.LabelY2Info.TabIndex = 9;
            this.LabelY2Info.Text = "Y:";
            // 
            // LabelX2Info
            // 
            this.LabelX2Info.AutoSize = true;
            this.LabelX2Info.Location = new System.Drawing.Point(42, 215);
            this.LabelX2Info.Name = "LabelX2Info";
            this.LabelX2Info.Size = new System.Drawing.Size(17, 13);
            this.LabelX2Info.TabIndex = 8;
            this.LabelX2Info.Text = "Х:";
            // 
            // LabelEnterCoordinatesInfo2
            // 
            this.LabelEnterCoordinatesInfo2.AutoSize = true;
            this.LabelEnterCoordinatesInfo2.Location = new System.Drawing.Point(42, 196);
            this.LabelEnterCoordinatesInfo2.Name = "LabelEnterCoordinatesInfo2";
            this.LabelEnterCoordinatesInfo2.Size = new System.Drawing.Size(171, 13);
            this.LabelEnterCoordinatesInfo2.TabIndex = 7;
            this.LabelEnterCoordinatesInfo2.Text = "Введите координаты 2-ой точки:";
            // 
            // LabelY1Info
            // 
            this.LabelY1Info.AutoSize = true;
            this.LabelY1Info.Location = new System.Drawing.Point(140, 154);
            this.LabelY1Info.Name = "LabelY1Info";
            this.LabelY1Info.Size = new System.Drawing.Size(17, 13);
            this.LabelY1Info.TabIndex = 6;
            this.LabelY1Info.Text = "Y:";
            // 
            // LabelX1Info
            // 
            this.LabelX1Info.AutoSize = true;
            this.LabelX1Info.Location = new System.Drawing.Point(42, 154);
            this.LabelX1Info.Name = "LabelX1Info";
            this.LabelX1Info.Size = new System.Drawing.Size(17, 13);
            this.LabelX1Info.TabIndex = 5;
            this.LabelX1Info.Text = "Х:";
            // 
            // LabelEnterCoordinatesInfo1
            // 
            this.LabelEnterCoordinatesInfo1.AutoSize = true;
            this.LabelEnterCoordinatesInfo1.Location = new System.Drawing.Point(42, 135);
            this.LabelEnterCoordinatesInfo1.Name = "LabelEnterCoordinatesInfo1";
            this.LabelEnterCoordinatesInfo1.Size = new System.Drawing.Size(171, 13);
            this.LabelEnterCoordinatesInfo1.TabIndex = 4;
            this.LabelEnterCoordinatesInfo1.Text = "Введите координаты 1-ой точки:";
            // 
            // ButtonPreviousFigure
            // 
            this.ButtonPreviousFigure.Location = new System.Drawing.Point(45, 67);
            this.ButtonPreviousFigure.Name = "ButtonPreviousFigure";
            this.ButtonPreviousFigure.Size = new System.Drawing.Size(25, 25);
            this.ButtonPreviousFigure.TabIndex = 3;
            this.ButtonPreviousFigure.Text = "<";
            this.ButtonPreviousFigure.UseVisualStyleBackColor = true;
            this.ButtonPreviousFigure.Click += new System.EventHandler(this.ButtonPreviousFigure_Click);
            // 
            // ButtonNextFigure
            // 
            this.ButtonNextFigure.Location = new System.Drawing.Point(188, 67);
            this.ButtonNextFigure.Name = "ButtonNextFigure";
            this.ButtonNextFigure.Size = new System.Drawing.Size(25, 25);
            this.ButtonNextFigure.TabIndex = 2;
            this.ButtonNextFigure.Text = ">";
            this.ButtonNextFigure.UseVisualStyleBackColor = true;
            this.ButtonNextFigure.Click += new System.EventHandler(this.ButtonNextFigure_Click);
            // 
            // LabelCurrentFigure
            // 
            this.LabelCurrentFigure.AutoSize = true;
            this.LabelCurrentFigure.Location = new System.Drawing.Point(73, 73);
            this.LabelCurrentFigure.Name = "LabelCurrentFigure";
            this.LabelCurrentFigure.Size = new System.Drawing.Size(56, 13);
            this.LabelCurrentFigure.TabIndex = 1;
            this.LabelCurrentFigure.Text = "Rectangle";
            // 
            // LabelCurrentFigureInfo
            // 
            this.LabelCurrentFigureInfo.AutoSize = true;
            this.LabelCurrentFigureInfo.Location = new System.Drawing.Point(82, 45);
            this.LabelCurrentFigureInfo.Name = "LabelCurrentFigureInfo";
            this.LabelCurrentFigureInfo.Size = new System.Drawing.Size(94, 13);
            this.LabelCurrentFigureInfo.TabIndex = 0;
            this.LabelCurrentFigureInfo.Text = "Текущая фигура:";
            // 
            // PictureBoxDraw
            // 
            this.PictureBoxDraw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBoxDraw.Location = new System.Drawing.Point(0, 24);
            this.PictureBoxDraw.Name = "PictureBoxDraw";
            this.PictureBoxDraw.Size = new System.Drawing.Size(781, 602);
            this.PictureBoxDraw.TabIndex = 1;
            this.PictureBoxDraw.TabStop = false;
            this.PictureBoxDraw.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PictureBoxDraw_MouseClick);
            // 
            // MenuStripMain
            // 
            this.MenuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.MenuStripMain.Location = new System.Drawing.Point(0, 0);
            this.MenuStripMain.Name = "MenuStripMain";
            this.MenuStripMain.Size = new System.Drawing.Size(1036, 24);
            this.MenuStripMain.TabIndex = 2;
            this.MenuStripMain.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveToolStripMenuItem,
            this.LoadToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.FileToolStripMenuItem.Text = "Файл";
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SaveToolStripMenuItem.Text = "Сохранить";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // LoadToolStripMenuItem
            // 
            this.LoadToolStripMenuItem.Name = "LoadToolStripMenuItem";
            this.LoadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.LoadToolStripMenuItem.Text = "Загрузить";
            this.LoadToolStripMenuItem.Click += new System.EventHandler(this.LoadToolStripMenuItem_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.HelpToolStripMenuItem.Text = "Помощь";
            this.HelpToolStripMenuItem.Click += new System.EventHandler(this.HelpToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 626);
            this.Controls.Add(this.PictureBoxDraw);
            this.Controls.Add(this.PanelMain);
            this.Controls.Add(this.MenuStripMain);
            this.MainMenuStrip = this.MenuStripMain;
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.PanelMain.ResumeLayout(false);
            this.PanelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxDraw)).EndInit();
            this.MenuStripMain.ResumeLayout(false);
            this.MenuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelMain;
        private System.Windows.Forms.Label LabelY2Info;
        private System.Windows.Forms.Label LabelX2Info;
        private System.Windows.Forms.Label LabelEnterCoordinatesInfo2;
        private System.Windows.Forms.Label LabelY1Info;
        private System.Windows.Forms.Label LabelX1Info;
        private System.Windows.Forms.Label LabelEnterCoordinatesInfo1;
        private System.Windows.Forms.Button ButtonPreviousFigure;
        private System.Windows.Forms.Button ButtonNextFigure;
        private System.Windows.Forms.Label LabelCurrentFigure;
        private System.Windows.Forms.Label LabelCurrentFigureInfo;
        private System.Windows.Forms.TextBox TextBoxWidth;
        private System.Windows.Forms.Label LabelWidthInfo;
        private System.Windows.Forms.TextBox TextBoxY2;
        private System.Windows.Forms.TextBox TextBoxX2;
        private System.Windows.Forms.TextBox TextBoxY1;
        private System.Windows.Forms.TextBox TextBoxX1;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Button ButtonBrushColor;
        private System.Windows.Forms.Button ButtonPenColor;
        private System.Windows.Forms.PictureBox PictureBoxDraw;
        private System.Windows.Forms.ColorDialog ColorDialogPen;
        private System.Windows.Forms.ColorDialog ColorDialogBrush;
        private System.Windows.Forms.CheckBox CheckBoxMouseControl;
        private System.Windows.Forms.MenuStrip MenuStripMain;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
    }
}

