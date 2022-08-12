namespace Paint_App
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Top_Panel = new System.Windows.Forms.Panel();
            this.Exit_Button = new System.Windows.Forms.Button();
            this.Clear_Button = new System.Windows.Forms.Button();
            this.Save_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Canvas_Panel = new System.Windows.Forms.Panel();
            this.Toolbox_Panel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Colorbox = new System.Windows.Forms.PictureBox();
            this.Pencil_Size = new System.Windows.Forms.NumericUpDown();
            this.Eraser_Button = new System.Windows.Forms.PictureBox();
            this.Pencil_Button = new System.Windows.Forms.PictureBox();
            this.Top_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Canvas_Panel.SuspendLayout();
            this.Toolbox_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Colorbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pencil_Size)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Eraser_Button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pencil_Button)).BeginInit();
            this.SuspendLayout();
            // 
            // Top_Panel
            // 
            this.Top_Panel.BackColor = System.Drawing.Color.Teal;
            this.Top_Panel.Controls.Add(this.Exit_Button);
            this.Top_Panel.Controls.Add(this.Clear_Button);
            this.Top_Panel.Controls.Add(this.Save_Button);
            this.Top_Panel.Controls.Add(this.label1);
            this.Top_Panel.Controls.Add(this.pictureBox1);
            this.Top_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Top_Panel.Location = new System.Drawing.Point(0, 0);
            this.Top_Panel.Name = "Top_Panel";
            this.Top_Panel.Size = new System.Drawing.Size(977, 63);
            this.Top_Panel.TabIndex = 0;
            this.Top_Panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.Top_Panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            this.Top_Panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseUp);
            // 
            // Exit_Button
            // 
            this.Exit_Button.Location = new System.Drawing.Point(918, 17);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(38, 33);
            this.Exit_Button.TabIndex = 4;
            this.Exit_Button.Text = "X";
            this.Exit_Button.UseVisualStyleBackColor = true;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // Clear_Button
            // 
            this.Clear_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Clear_Button.Location = new System.Drawing.Point(776, 16);
            this.Clear_Button.Name = "Clear_Button";
            this.Clear_Button.Size = new System.Drawing.Size(88, 34);
            this.Clear_Button.TabIndex = 3;
            this.Clear_Button.Text = "Wyczyść";
            this.Clear_Button.UseVisualStyleBackColor = true;
            this.Clear_Button.Click += new System.EventHandler(this.Clear_Button_Click);
            // 
            // Save_Button
            // 
            this.Save_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Save_Button.Location = new System.Drawing.Point(658, 16);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(96, 34);
            this.Save_Button.TabIndex = 2;
            this.Save_Button.Text = "Zapisz";
            this.Save_Button.UseVisualStyleBackColor = true;
            this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(84, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Paint Application";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Canvas_Panel
            // 
            this.Canvas_Panel.BackColor = System.Drawing.Color.White;
            this.Canvas_Panel.Controls.Add(this.Toolbox_Panel);
            this.Canvas_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Canvas_Panel.Location = new System.Drawing.Point(0, 63);
            this.Canvas_Panel.Name = "Canvas_Panel";
            this.Canvas_Panel.Size = new System.Drawing.Size(977, 538);
            this.Canvas_Panel.TabIndex = 1;
            this.Canvas_Panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseDown);
            this.Canvas_Panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseMove);
            // 
            // Toolbox_Panel
            // 
            this.Toolbox_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Toolbox_Panel.Controls.Add(this.label2);
            this.Toolbox_Panel.Controls.Add(this.Colorbox);
            this.Toolbox_Panel.Controls.Add(this.Pencil_Size);
            this.Toolbox_Panel.Controls.Add(this.Eraser_Button);
            this.Toolbox_Panel.Controls.Add(this.Pencil_Button);
            this.Toolbox_Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Toolbox_Panel.Location = new System.Drawing.Point(0, 0);
            this.Toolbox_Panel.Name = "Toolbox_Panel";
            this.Toolbox_Panel.Size = new System.Drawing.Size(73, 538);
            this.Toolbox_Panel.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 393);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Color:";
            // 
            // Colorbox
            // 
            this.Colorbox.BackColor = System.Drawing.Color.Black;
            this.Colorbox.Location = new System.Drawing.Point(6, 414);
            this.Colorbox.Name = "Colorbox";
            this.Colorbox.Size = new System.Drawing.Size(61, 59);
            this.Colorbox.TabIndex = 8;
            this.Colorbox.TabStop = false;
            this.Colorbox.Click += new System.EventHandler(this.Colorbox_Click);
            // 
            // Pencil_Size
            // 
            this.Pencil_Size.Location = new System.Drawing.Point(6, 182);
            this.Pencil_Size.Name = "Pencil_Size";
            this.Pencil_Size.Size = new System.Drawing.Size(61, 22);
            this.Pencil_Size.TabIndex = 7;
            this.Pencil_Size.ValueChanged += new System.EventHandler(this.pencilsize_changed);
            // 
            // Eraser_Button
            // 
            this.Eraser_Button.BackColor = System.Drawing.Color.LightBlue;
            this.Eraser_Button.Image = ((System.Drawing.Image)(resources.GetObject("Eraser_Button.Image")));
            this.Eraser_Button.Location = new System.Drawing.Point(5, 101);
            this.Eraser_Button.Name = "Eraser_Button";
            this.Eraser_Button.Size = new System.Drawing.Size(62, 59);
            this.Eraser_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Eraser_Button.TabIndex = 6;
            this.Eraser_Button.TabStop = false;
            this.Eraser_Button.Click += new System.EventHandler(this.Eraser_Button_Click);
            // 
            // Pencil_Button
            // 
            this.Pencil_Button.BackColor = System.Drawing.Color.LightBlue;
            this.Pencil_Button.Image = ((System.Drawing.Image)(resources.GetObject("Pencil_Button.Image")));
            this.Pencil_Button.Location = new System.Drawing.Point(5, 23);
            this.Pencil_Button.Name = "Pencil_Button";
            this.Pencil_Button.Size = new System.Drawing.Size(62, 59);
            this.Pencil_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pencil_Button.TabIndex = 5;
            this.Pencil_Button.TabStop = false;
            this.Pencil_Button.Click += new System.EventHandler(this.Pencil_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 601);
            this.Controls.Add(this.Canvas_Panel);
            this.Controls.Add(this.Top_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Top_Panel.ResumeLayout(false);
            this.Top_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Canvas_Panel.ResumeLayout(false);
            this.Toolbox_Panel.ResumeLayout(false);
            this.Toolbox_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Colorbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pencil_Size)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Eraser_Button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pencil_Button)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Top_Panel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel Canvas_Panel;
        private System.Windows.Forms.Panel Toolbox_Panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Exit_Button;
        private System.Windows.Forms.Button Clear_Button;
        private System.Windows.Forms.Button Save_Button;
        private System.Windows.Forms.PictureBox Colorbox;
        private System.Windows.Forms.NumericUpDown Pencil_Size;
        private System.Windows.Forms.PictureBox Eraser_Button;
        private System.Windows.Forms.PictureBox Pencil_Button;
        private System.Windows.Forms.Label label2;
    }
}

