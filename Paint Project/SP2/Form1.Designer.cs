namespace SP2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            colorBox = new TextBox();
            Square = new Button();
            Circle = new Button();
            rubber = new Button();
            Line = new Button();
            Pic = new PictureBox();
            label2 = new Label();
            LineSize = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Pic).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuText;
            panel1.Controls.Add(LineSize);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(colorBox);
            panel1.Controls.Add(Square);
            panel1.Controls.Add(Circle);
            panel1.Controls.Add(rubber);
            panel1.Controls.Add(Line);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(880, 94);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.HighlightText;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(87, 35);
            label1.TabIndex = 7;
            label1.Text = "Color: ";
            // 
            // colorBox
            // 
            colorBox.Location = new Point(105, 34);
            colorBox.Name = "colorBox";
            colorBox.Size = new Size(125, 27);
            colorBox.TabIndex = 6;
            colorBox.TextChanged += colorBox_TextChanged;
            // 
            // Square
            // 
            Square.Location = new Point(700, 12);
            Square.Name = "Square";
            Square.Size = new Size(81, 70);
            Square.TabIndex = 5;
            Square.Text = "Square";
            Square.UseVisualStyleBackColor = true;
            Square.Click += Square_Click;
            // 
            // Circle
            // 
            Circle.Location = new Point(613, 12);
            Circle.Name = "Circle";
            Circle.Size = new Size(81, 70);
            Circle.TabIndex = 4;
            Circle.Text = "Circle";
            Circle.UseVisualStyleBackColor = true;
            Circle.Click += Circle_Click;
            // 
            // rubber
            // 
            rubber.Location = new Point(787, 12);
            rubber.Name = "rubber";
            rubber.Size = new Size(81, 70);
            rubber.TabIndex = 3;
            rubber.Text = "Erase";
            rubber.UseVisualStyleBackColor = true;
            rubber.Click += rubber_Click;
            // 
            // Line
            // 
            Line.Location = new Point(526, 12);
            Line.Name = "Line";
            Line.Size = new Size(81, 70);
            Line.TabIndex = 2;
            Line.Text = "Line";
            Line.UseVisualStyleBackColor = true;
            Line.Click += Line_Click;
            // 
            // Pic
            // 
            Pic.Dock = DockStyle.Fill;
            Pic.Location = new Point(0, 94);
            Pic.Name = "Pic";
            Pic.Size = new Size(880, 436);
            Pic.TabIndex = 1;
            Pic.TabStop = false;
            Pic.MouseDown += Pic_MouseDown;
            Pic.MouseMove += Pic_MouseMove;
            Pic.MouseUp += Pic_MouseUp;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Menu;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(236, 26);
            label2.Name = "label2";
            label2.Size = new Size(115, 35);
            label2.TabIndex = 8;
            label2.Text = "Line Size:";
            // 
            // LineSize
            // 
            LineSize.Location = new Point(357, 34);
            LineSize.Name = "LineSize";
            LineSize.Size = new Size(125, 27);
            LineSize.TabIndex = 9;
            LineSize.TextChanged += LineSize_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 530);
            Controls.Add(Pic);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Pic).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button Line;
        private PictureBox Pic;
        private Button rubber;
        private Button Circle;
        private Button Square;
        private Label label1;
        private TextBox colorBox;
        private TextBox LineSize;
        private Label label2;
    }
}
