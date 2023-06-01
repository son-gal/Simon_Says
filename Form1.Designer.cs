namespace Simon_Says
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
            tableLayoutPanel1 = new TableLayoutPanel();
            pb_0 = new PictureBox();
            pb_1 = new PictureBox();
            pb_2 = new PictureBox();
            pb_3 = new PictureBox();
            lb_score = new Label();
            lb_high_score = new Label();
            btn = new Button();
            button1 = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_0).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_3).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(pb_0, 0, 0);
            tableLayoutPanel1.Controls.Add(pb_1, 1, 0);
            tableLayoutPanel1.Controls.Add(pb_2, 0, 1);
            tableLayoutPanel1.Controls.Add(pb_3, 1, 1);
            tableLayoutPanel1.Location = new Point(215, 81);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(342, 345);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // pb_0
            // 
            pb_0.Image = Properties.Resources.R1;
            pb_0.Location = new Point(3, 3);
            pb_0.Name = "pb_0";
            pb_0.Size = new Size(165, 166);
            pb_0.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_0.TabIndex = 0;
            pb_0.TabStop = false;
            pb_0.Click += pb_Click;
            pb_0.MouseDown += pb_0_MouseDown;
            pb_0.MouseUp += pb_0_MouseUp;
            // 
            // pb_1
            // 
            pb_1.Image = Properties.Resources.Y1;
            pb_1.Location = new Point(174, 3);
            pb_1.Name = "pb_1";
            pb_1.Size = new Size(165, 166);
            pb_1.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_1.TabIndex = 1;
            pb_1.TabStop = false;
            pb_1.Click += pb_Click;
            pb_1.MouseDown += pb_1_MouseDown;
            pb_1.MouseUp += pb_1_MouseUp;
            // 
            // pb_2
            // 
            pb_2.Image = Properties.Resources.B1;
            pb_2.Location = new Point(3, 175);
            pb_2.Name = "pb_2";
            pb_2.Size = new Size(165, 167);
            pb_2.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_2.TabIndex = 2;
            pb_2.TabStop = false;
            pb_2.Click += pb_Click;
            pb_2.MouseDown += pb_2_MouseDown;
            pb_2.MouseUp += pb_2_MouseUp;
            // 
            // pb_3
            // 
            pb_3.BackColor = Color.White;
            pb_3.Image = Properties.Resources.G1;
            pb_3.Location = new Point(174, 175);
            pb_3.Name = "pb_3";
            pb_3.Size = new Size(165, 167);
            pb_3.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_3.TabIndex = 3;
            pb_3.TabStop = false;
            pb_3.Click += pb_Click;
            pb_3.MouseDown += pb_3_MouseDown;
            pb_3.MouseUp += pb_3_MouseUp;
            // 
            // lb_score
            // 
            lb_score.AutoSize = true;
            lb_score.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lb_score.Location = new Point(295, 9);
            lb_score.Name = "lb_score";
            lb_score.Size = new Size(197, 62);
            lb_score.TabIndex = 1;
            lb_score.Text = "Score: 0";
            // 
            // lb_high_score
            // 
            lb_high_score.AutoSize = true;
            lb_high_score.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lb_high_score.Location = new Point(617, 9);
            lb_high_score.Name = "lb_high_score";
            lb_high_score.Size = new Size(113, 28);
            lb_high_score.TabIndex = 2;
            lb_high_score.Text = "High Score";
            // 
            // btn
            // 
            btn.Font = new Font("Segoe UI", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btn.Location = new Point(215, 438);
            btn.Name = "btn";
            btn.Size = new Size(168, 66);
            btn.TabIndex = 3;
            btn.Text = "Start\r\n";
            btn.UseVisualStyleBackColor = true;
            btn.Click += btn_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(389, 438);
            button1.Name = "button1";
            button1.Size = new Size(168, 66);
            button1.TabIndex = 4;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Submit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(787, 547);
            Controls.Add(button1);
            Controls.Add(btn);
            Controls.Add(lb_high_score);
            Controls.Add(lb_score);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pb_0).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pb_0;
        private PictureBox pb_1;
        private PictureBox pb_2;
        private PictureBox pb_3;
        private Label lb_score;
        private Label lb_high_score;
        private Button btn;
        private Button button1;
    }
}