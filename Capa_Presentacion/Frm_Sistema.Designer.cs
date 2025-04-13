namespace Capa_Presentacion
{
    partial class Frm_Sistema
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Sistema));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(42, 28, 109);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(1226, 0);
            panel1.Margin = new Padding(4, 2, 4, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(254, 760);
            panel1.TabIndex = 76;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(37, 303);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(182, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 78;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(28, 200, 215);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4, 2, 4, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1226, 150);
            panel2.TabIndex = 77;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(267, 27);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(750, 84);
            label1.TabIndex = 2;
            label1.Text = "Gestion de Ferreterias";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 176);
            label2.Name = "label2";
            label2.Size = new Size(140, 28);
            label2.TabIndex = 78;
            label2.Text = "Integrantes";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 234);
            label3.Name = "label3";
            label3.Size = new Size(271, 28);
            label3.TabIndex = 79;
            label3.Text = "John Cedano 2023-3781";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 293);
            label4.Name = "label4";
            label4.Size = new Size(294, 28);
            label4.TabIndex = 80;
            label4.Text = "Maikor Adonis 2023-3679";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(57, 357);
            label5.Name = "label5";
            label5.Size = new Size(319, 28);
            label5.TabIndex = 81;
            label5.Text = "Samuel Gonzalez 2023-3976";
            // 
            // Frm_Sistema
            // 
            AutoScaleDimensions = new SizeF(13F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1480, 760);
            ControlBox = false;
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Cambria", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Frm_Sistema";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_Sistema";
            Load += Frm_Sistema_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}