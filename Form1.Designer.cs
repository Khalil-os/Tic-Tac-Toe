namespace Tic_Tac_Toe
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Title = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTurn = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbWiner = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Col11 = new System.Windows.Forms.PictureBox();
            this.Col12 = new System.Windows.Forms.PictureBox();
            this.Col13 = new System.Windows.Forms.PictureBox();
            this.Col23 = new System.Windows.Forms.PictureBox();
            this.Col22 = new System.Windows.Forms.PictureBox();
            this.Col21 = new System.Windows.Forms.PictureBox();
            this.Col33 = new System.Windows.Forms.PictureBox();
            this.Col32 = new System.Windows.Forms.PictureBox();
            this.Col31 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbNWP2 = new System.Windows.Forms.Label();
            this.lbNDraw = new System.Windows.Forms.Label();
            this.lbNWP1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Col11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Col12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Col13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Col23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Col22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Col21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Col33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Col32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Col31)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Mistral", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(283, 26);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(834, 171);
            this.Title.TabIndex = 0;
            this.Title.Text = "Tic-Tac-Toe Game";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tic_Tac_Toe.Properties.Resources.tic_tac_toe;
            this.pictureBox1.Location = new System.Drawing.Point(39, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Mistral", 40F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(42, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 95);
            this.label2.TabIndex = 2;
            this.label2.Text = "Turn";
            // 
            // lbTurn
            // 
            this.lbTurn.AutoSize = true;
            this.lbTurn.BackColor = System.Drawing.Color.Transparent;
            this.lbTurn.Font = new System.Drawing.Font("Mistral", 40F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTurn.ForeColor = System.Drawing.Color.White;
            this.lbTurn.Location = new System.Drawing.Point(23, 317);
            this.lbTurn.Name = "lbTurn";
            this.lbTurn.Size = new System.Drawing.Size(266, 95);
            this.lbTurn.TabIndex = 3;
            this.lbTurn.Text = "Player 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Mistral", 40F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(42, 423);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 95);
            this.label3.TabIndex = 4;
            this.label3.Text = "Winner";
            // 
            // lbWiner
            // 
            this.lbWiner.AutoSize = true;
            this.lbWiner.BackColor = System.Drawing.Color.Transparent;
            this.lbWiner.Font = new System.Drawing.Font("Mistral", 40F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWiner.ForeColor = System.Drawing.Color.Lime;
            this.lbWiner.Location = new System.Drawing.Point(23, 529);
            this.lbWiner.Name = "lbWiner";
            this.lbWiner.Size = new System.Drawing.Size(329, 95);
            this.lbWiner.TabIndex = 5;
            this.lbWiner.Text = "In Progress";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Matura MT Script Capitals", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(39, 635);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(313, 96);
            this.button1.TabIndex = 6;
            this.button1.Text = "Restart Game";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Col11
            // 
            this.Col11.Image = global::Tic_Tac_Toe.Properties.Resources.question_mark_96;
            this.Col11.Location = new System.Drawing.Point(392, 200);
            this.Col11.Name = "Col11";
            this.Col11.Size = new System.Drawing.Size(156, 144);
            this.Col11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Col11.TabIndex = 7;
            this.Col11.TabStop = false;
            this.Col11.Click += new System.EventHandler(this.Col11_Click);
            // 
            // Col12
            // 
            this.Col12.Image = global::Tic_Tac_Toe.Properties.Resources.question_mark_96;
            this.Col12.Location = new System.Drawing.Point(680, 200);
            this.Col12.Name = "Col12";
            this.Col12.Size = new System.Drawing.Size(156, 144);
            this.Col12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Col12.TabIndex = 8;
            this.Col12.TabStop = false;
            this.Col12.Click += new System.EventHandler(this.Col12_Click);
            // 
            // Col13
            // 
            this.Col13.Image = global::Tic_Tac_Toe.Properties.Resources.question_mark_96;
            this.Col13.Location = new System.Drawing.Point(951, 200);
            this.Col13.Name = "Col13";
            this.Col13.Size = new System.Drawing.Size(156, 144);
            this.Col13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Col13.TabIndex = 9;
            this.Col13.TabStop = false;
            this.Col13.Click += new System.EventHandler(this.Col13_Click);
            // 
            // Col23
            // 
            this.Col23.Image = global::Tic_Tac_Toe.Properties.Resources.question_mark_96;
            this.Col23.Location = new System.Drawing.Point(951, 393);
            this.Col23.Name = "Col23";
            this.Col23.Size = new System.Drawing.Size(156, 144);
            this.Col23.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Col23.TabIndex = 12;
            this.Col23.TabStop = false;
            this.Col23.Click += new System.EventHandler(this.Col23_Click);
            // 
            // Col22
            // 
            this.Col22.Image = global::Tic_Tac_Toe.Properties.Resources.question_mark_96;
            this.Col22.Location = new System.Drawing.Point(680, 393);
            this.Col22.Name = "Col22";
            this.Col22.Size = new System.Drawing.Size(156, 144);
            this.Col22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Col22.TabIndex = 11;
            this.Col22.TabStop = false;
            this.Col22.Click += new System.EventHandler(this.Col22_Click);
            // 
            // Col21
            // 
            this.Col21.Image = global::Tic_Tac_Toe.Properties.Resources.question_mark_96;
            this.Col21.Location = new System.Drawing.Point(392, 393);
            this.Col21.Name = "Col21";
            this.Col21.Size = new System.Drawing.Size(156, 144);
            this.Col21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Col21.TabIndex = 10;
            this.Col21.TabStop = false;
            this.Col21.Click += new System.EventHandler(this.Col21_Click);
            // 
            // Col33
            // 
            this.Col33.Image = global::Tic_Tac_Toe.Properties.Resources.question_mark_96;
            this.Col33.Location = new System.Drawing.Point(951, 587);
            this.Col33.Name = "Col33";
            this.Col33.Size = new System.Drawing.Size(156, 144);
            this.Col33.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Col33.TabIndex = 15;
            this.Col33.TabStop = false;
            this.Col33.Click += new System.EventHandler(this.Col33_Click);
            // 
            // Col32
            // 
            this.Col32.Image = global::Tic_Tac_Toe.Properties.Resources.question_mark_96;
            this.Col32.Location = new System.Drawing.Point(680, 587);
            this.Col32.Name = "Col32";
            this.Col32.Size = new System.Drawing.Size(156, 144);
            this.Col32.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Col32.TabIndex = 14;
            this.Col32.TabStop = false;
            this.Col32.Click += new System.EventHandler(this.Col32_Click);
            // 
            // Col31
            // 
            this.Col31.Image = global::Tic_Tac_Toe.Properties.Resources.question_mark_96;
            this.Col31.Location = new System.Drawing.Point(392, 586);
            this.Col31.Name = "Col31";
            this.Col31.Size = new System.Drawing.Size(156, 144);
            this.Col31.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Col31.TabIndex = 13;
            this.Col31.TabStop = false;
            this.Col31.Click += new System.EventHandler(this.Col31_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Mistral", 40F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1169, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 95);
            this.label1.TabIndex = 16;
            this.label1.Text = "Player 1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Mistral", 40F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1169, 393);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(286, 95);
            this.label4.TabIndex = 17;
            this.label4.Text = "Player 2:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Mistral", 40F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1214, 586);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 95);
            this.label5.TabIndex = 18;
            this.label5.Text = "Draw:";
            // 
            // lbNWP2
            // 
            this.lbNWP2.AutoSize = true;
            this.lbNWP2.BackColor = System.Drawing.Color.Transparent;
            this.lbNWP2.Font = new System.Drawing.Font("Mistral", 40F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNWP2.ForeColor = System.Drawing.Color.White;
            this.lbNWP2.Location = new System.Drawing.Point(1460, 393);
            this.lbNWP2.Name = "lbNWP2";
            this.lbNWP2.Size = new System.Drawing.Size(77, 95);
            this.lbNWP2.TabIndex = 19;
            this.lbNWP2.Text = "0";
            // 
            // lbNDraw
            // 
            this.lbNDraw.AutoSize = true;
            this.lbNDraw.BackColor = System.Drawing.Color.Transparent;
            this.lbNDraw.Font = new System.Drawing.Font("Mistral", 40F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNDraw.ForeColor = System.Drawing.Color.White;
            this.lbNDraw.Location = new System.Drawing.Point(1460, 587);
            this.lbNDraw.Name = "lbNDraw";
            this.lbNDraw.Size = new System.Drawing.Size(77, 95);
            this.lbNDraw.TabIndex = 20;
            this.lbNDraw.Text = "0";
            // 
            // lbNWP1
            // 
            this.lbNWP1.AutoSize = true;
            this.lbNWP1.BackColor = System.Drawing.Color.Transparent;
            this.lbNWP1.Font = new System.Drawing.Font("Mistral", 40F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNWP1.ForeColor = System.Drawing.Color.White;
            this.lbNWP1.Location = new System.Drawing.Point(1460, 200);
            this.lbNWP1.Name = "lbNWP1";
            this.lbNWP1.Size = new System.Drawing.Size(77, 95);
            this.lbNWP1.TabIndex = 21;
            this.lbNWP1.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1612, 769);
            this.Controls.Add(this.lbNWP1);
            this.Controls.Add(this.lbNDraw);
            this.Controls.Add(this.lbNWP2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Col33);
            this.Controls.Add(this.Col32);
            this.Controls.Add(this.Col31);
            this.Controls.Add(this.Col23);
            this.Controls.Add(this.Col22);
            this.Controls.Add(this.Col21);
            this.Controls.Add(this.Col13);
            this.Controls.Add(this.Col12);
            this.Controls.Add(this.Col11);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbWiner);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbTurn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Tic-Tac-Toe";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Col11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Col12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Col13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Col23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Col22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Col21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Col33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Col32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Col31)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTurn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbWiner;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox Col11;
        private System.Windows.Forms.PictureBox Col12;
        private System.Windows.Forms.PictureBox Col13;
        private System.Windows.Forms.PictureBox Col23;
        private System.Windows.Forms.PictureBox Col22;
        private System.Windows.Forms.PictureBox Col21;
        private System.Windows.Forms.PictureBox Col33;
        private System.Windows.Forms.PictureBox Col32;
        private System.Windows.Forms.PictureBox Col31;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbNWP2;
        private System.Windows.Forms.Label lbNDraw;
        private System.Windows.Forms.Label lbNWP1;
    }
}

