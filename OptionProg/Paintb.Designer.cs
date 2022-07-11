namespace Principal
{
    partial class Paintb
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Paintb));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PicColbtn = new System.Windows.Forms.Button();
            this.Savebtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Linebtn = new System.Windows.Forms.Button();
            this.Rectanglebtn = new System.Windows.Forms.Button();
            this.Ellipsebtn = new System.Windows.Forms.Button();
            this.Erasebtn = new System.Windows.Forms.Button();
            this.Pencilbtn = new System.Windows.Forms.Button();
            this.Fillbtn = new System.Windows.Forms.Button();
            this.BtnColor = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.Pic = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(859, 100);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.PicColbtn);
            this.panel2.Controls.Add(this.Savebtn);
            this.panel2.Controls.Add(this.clearBtn);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.Linebtn);
            this.panel2.Controls.Add(this.Rectanglebtn);
            this.panel2.Controls.Add(this.Ellipsebtn);
            this.panel2.Controls.Add(this.Erasebtn);
            this.panel2.Controls.Add(this.Pencilbtn);
            this.panel2.Controls.Add(this.Fillbtn);
            this.panel2.Controls.Add(this.BtnColor);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(859, 100);
            this.panel2.TabIndex = 1;
            // 
            // PicColbtn
            // 
            this.PicColbtn.Location = new System.Drawing.Point(215, 35);
            this.PicColbtn.Name = "PicColbtn";
            this.PicColbtn.Size = new System.Drawing.Size(40, 37);
            this.PicColbtn.TabIndex = 12;
            this.PicColbtn.UseVisualStyleBackColor = true;
            // 
            // Savebtn
            // 
            this.Savebtn.BackColor = System.Drawing.Color.Transparent;
            this.Savebtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.Savebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Savebtn.ForeColor = System.Drawing.Color.White;
            this.Savebtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Savebtn.Location = new System.Drawing.Point(761, 26);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(86, 26);
            this.Savebtn.TabIndex = 11;
            this.Savebtn.Text = "Save";
            this.Savebtn.UseVisualStyleBackColor = false;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.Transparent;
            this.clearBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.clearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.ForeColor = System.Drawing.Color.White;
            this.clearBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.clearBtn.Location = new System.Drawing.Point(761, 58);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(86, 26);
            this.clearBtn.TabIndex = 10;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Principal.Properties.Resources.color_palette;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // Linebtn
            // 
            this.Linebtn.BackColor = System.Drawing.Color.Transparent;
            this.Linebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Linebtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.Linebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Linebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Linebtn.ForeColor = System.Drawing.Color.White;
            this.Linebtn.Image = global::Principal.Properties.Resources.line;
            this.Linebtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Linebtn.Location = new System.Drawing.Point(689, 20);
            this.Linebtn.Name = "Linebtn";
            this.Linebtn.Size = new System.Drawing.Size(60, 64);
            this.Linebtn.TabIndex = 7;
            this.Linebtn.Text = "Line";
            this.Linebtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Linebtn.UseVisualStyleBackColor = false;
            this.Linebtn.Click += new System.EventHandler(this.Linebtn_Click);
            // 
            // Rectanglebtn
            // 
            this.Rectanglebtn.BackColor = System.Drawing.Color.Transparent;
            this.Rectanglebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Rectanglebtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.Rectanglebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Rectanglebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Rectanglebtn.ForeColor = System.Drawing.Color.White;
            this.Rectanglebtn.Image = global::Principal.Properties.Resources.rectangle;
            this.Rectanglebtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Rectanglebtn.Location = new System.Drawing.Point(600, 20);
            this.Rectanglebtn.Name = "Rectanglebtn";
            this.Rectanglebtn.Size = new System.Drawing.Size(83, 64);
            this.Rectanglebtn.TabIndex = 6;
            this.Rectanglebtn.Text = "Rectangle";
            this.Rectanglebtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Rectanglebtn.UseVisualStyleBackColor = false;
            this.Rectanglebtn.Click += new System.EventHandler(this.Rectanglebtn_Click);
            // 
            // Ellipsebtn
            // 
            this.Ellipsebtn.BackColor = System.Drawing.Color.Transparent;
            this.Ellipsebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Ellipsebtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.Ellipsebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Ellipsebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ellipsebtn.ForeColor = System.Drawing.Color.White;
            this.Ellipsebtn.Image = global::Principal.Properties.Resources.circle;
            this.Ellipsebtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Ellipsebtn.Location = new System.Drawing.Point(534, 20);
            this.Ellipsebtn.Name = "Ellipsebtn";
            this.Ellipsebtn.Size = new System.Drawing.Size(60, 64);
            this.Ellipsebtn.TabIndex = 5;
            this.Ellipsebtn.Text = "Ellipse";
            this.Ellipsebtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Ellipsebtn.UseVisualStyleBackColor = false;
            this.Ellipsebtn.Click += new System.EventHandler(this.Ellipsebtn_Click);
            // 
            // Erasebtn
            // 
            this.Erasebtn.BackColor = System.Drawing.Color.Transparent;
            this.Erasebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Erasebtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.Erasebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Erasebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Erasebtn.ForeColor = System.Drawing.Color.White;
            this.Erasebtn.Image = global::Principal.Properties.Resources.eraser;
            this.Erasebtn.Location = new System.Drawing.Point(468, 20);
            this.Erasebtn.Name = "Erasebtn";
            this.Erasebtn.Size = new System.Drawing.Size(60, 64);
            this.Erasebtn.TabIndex = 4;
            this.Erasebtn.Text = "Eraser";
            this.Erasebtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Erasebtn.UseVisualStyleBackColor = false;
            this.Erasebtn.Click += new System.EventHandler(this.Erasebtn_Click);
            // 
            // Pencilbtn
            // 
            this.Pencilbtn.BackColor = System.Drawing.Color.Transparent;
            this.Pencilbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pencilbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.Pencilbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Pencilbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pencilbtn.ForeColor = System.Drawing.Color.White;
            this.Pencilbtn.Image = global::Principal.Properties.Resources.pencil;
            this.Pencilbtn.Location = new System.Drawing.Point(402, 20);
            this.Pencilbtn.Name = "Pencilbtn";
            this.Pencilbtn.Size = new System.Drawing.Size(60, 64);
            this.Pencilbtn.TabIndex = 3;
            this.Pencilbtn.Text = "Pencil";
            this.Pencilbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Pencilbtn.UseVisualStyleBackColor = false;
            this.Pencilbtn.Click += new System.EventHandler(this.Pencilbtn_Click);
            // 
            // Fillbtn
            // 
            this.Fillbtn.BackColor = System.Drawing.Color.Transparent;
            this.Fillbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Fillbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.Fillbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Fillbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Fillbtn.ForeColor = System.Drawing.Color.White;
            this.Fillbtn.Image = global::Principal.Properties.Resources.bucket;
            this.Fillbtn.Location = new System.Drawing.Point(336, 20);
            this.Fillbtn.Name = "Fillbtn";
            this.Fillbtn.Size = new System.Drawing.Size(60, 64);
            this.Fillbtn.TabIndex = 2;
            this.Fillbtn.Text = "Fill";
            this.Fillbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Fillbtn.UseVisualStyleBackColor = false;
            this.Fillbtn.Click += new System.EventHandler(this.Fillbtn_Click);
            // 
            // BtnColor
            // 
            this.BtnColor.BackColor = System.Drawing.Color.Transparent;
            this.BtnColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnColor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.BtnColor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnColor.ForeColor = System.Drawing.Color.White;
            this.BtnColor.Image = global::Principal.Properties.Resources.color;
            this.BtnColor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnColor.Location = new System.Drawing.Point(270, 20);
            this.BtnColor.Name = "BtnColor";
            this.BtnColor.Size = new System.Drawing.Size(60, 64);
            this.BtnColor.TabIndex = 1;
            this.BtnColor.Text = "Color";
            this.BtnColor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnColor.UseVisualStyleBackColor = false;
            this.BtnColor.Click += new System.EventHandler(this.BtnColor_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(265, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(490, 82);
            this.panel4.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3.Controls.Add(this.guna2Button1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 479);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(859, 23);
            this.panel3.TabIndex = 1;
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Image = global::Principal.Properties.Resources._return;
            this.guna2Button1.Location = new System.Drawing.Point(0, 0);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(92, 23);
            this.guna2Button1.TabIndex = 0;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // Pic
            // 
            this.Pic.BackColor = System.Drawing.Color.White;
            this.Pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pic.Location = new System.Drawing.Point(0, 100);
            this.Pic.Name = "Pic";
            this.Pic.Size = new System.Drawing.Size(859, 379);
            this.Pic.TabIndex = 2;
            this.Pic.TabStop = false;
            this.Pic.Click += new System.EventHandler(this.Pic_Click);
            this.Pic.Paint += new System.Windows.Forms.PaintEventHandler(this.Pic_Paint);
            this.Pic.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Pic_MouseClick);
            this.Pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pic_MouseDown_1);
            this.Pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Pic_MouseMove_1);
            this.Pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Pic_MouseUp_1);
            // 
            // Paintb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 502);
            this.Controls.Add(this.Pic);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Paintb";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paintboard";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button Linebtn;
        private Button Rectanglebtn;
        private Button Ellipsebtn;
        private Button Erasebtn;
        private Button Pencilbtn;
        private Button Fillbtn;
        private Button BtnColor;
        private Button PicColor;
        private Panel panel4;
        private Panel panel3;
        private PictureBox Pic;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private PictureBox pictureBox1;
        private Button Savebtn;
        private Button clearBtn;
        private Button PicColbtn;
    }
}