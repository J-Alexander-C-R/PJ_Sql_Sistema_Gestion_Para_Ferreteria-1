namespace Capa_Presentacion
{
    partial class Frm_Consulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Consulta));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label1 = new Label();
            button2 = new Button();
            btn_Empleado = new Button();
            button3 = new Button();
            button4 = new Button();
            button6 = new Button();
            dgv_conulta = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_conulta).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(42, 28, 109);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(1203, 0);
            panel1.Margin = new Padding(4, 2, 4, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(277, 760);
            panel1.TabIndex = 70;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(50, 318);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(182, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 72;
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
            panel2.Size = new Size(1203, 150);
            panel2.TabIndex = 71;
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
            // button2
            // 
            button2.BackColor = Color.FromArgb(42, 28, 109);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Cambria", 12F, FontStyle.Bold | FontStyle.Italic);
            button2.ForeColor = Color.White;
            button2.Location = new Point(104, 222);
            button2.Margin = new Padding(4, 2, 4, 2);
            button2.Name = "button2";
            button2.Size = new Size(148, 44);
            button2.TabIndex = 76;
            button2.Text = "Producto";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btn_Empleado
            // 
            btn_Empleado.BackColor = Color.FromArgb(42, 28, 109);
            btn_Empleado.FlatAppearance.BorderSize = 0;
            btn_Empleado.FlatStyle = FlatStyle.Flat;
            btn_Empleado.Font = new Font("Cambria", 12F, FontStyle.Bold | FontStyle.Italic);
            btn_Empleado.ForeColor = Color.White;
            btn_Empleado.Location = new Point(104, 318);
            btn_Empleado.Margin = new Padding(4, 2, 4, 2);
            btn_Empleado.Name = "btn_Empleado";
            btn_Empleado.Size = new Size(148, 44);
            btn_Empleado.TabIndex = 78;
            btn_Empleado.Text = "Empleado";
            btn_Empleado.UseVisualStyleBackColor = false;
            btn_Empleado.Click += btn_Empleado_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(42, 28, 109);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Cambria", 12F, FontStyle.Bold | FontStyle.Italic);
            button3.ForeColor = Color.White;
            button3.Location = new Point(104, 413);
            button3.Margin = new Padding(4, 2, 4, 2);
            button3.Name = "button3";
            button3.Size = new Size(148, 44);
            button3.TabIndex = 79;
            button3.Text = "Cliente";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(42, 28, 109);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Cambria", 12F, FontStyle.Bold | FontStyle.Italic);
            button4.ForeColor = Color.White;
            button4.Location = new Point(104, 512);
            button4.Margin = new Padding(4, 2, 4, 2);
            button4.Name = "button4";
            button4.Size = new Size(148, 44);
            button4.TabIndex = 80;
            button4.Text = "Proveedor";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(42, 28, 109);
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Cambria", 12F, FontStyle.Bold | FontStyle.Italic);
            button6.ForeColor = Color.White;
            button6.Location = new Point(104, 610);
            button6.Margin = new Padding(4, 2, 4, 2);
            button6.Name = "button6";
            button6.Size = new Size(148, 44);
            button6.TabIndex = 82;
            button6.Text = "Categoria";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // dgv_conulta
            // 
            dgv_conulta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_conulta.Location = new Point(330, 248);
            dgv_conulta.Name = "dgv_conulta";
            dgv_conulta.RowHeadersWidth = 62;
            dgv_conulta.Size = new Size(799, 366);
            dgv_conulta.TabIndex = 83;
            // 
            // Frm_Consulta
            // 
            AutoScaleDimensions = new SizeF(13F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1480, 760);
            Controls.Add(dgv_conulta);
            Controls.Add(button6);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(btn_Empleado);
            Controls.Add(button2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Cambria", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Frm_Consulta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_Consulta";
            Load += Frm_Consulta_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_conulta).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
        private Button button2;
        private Button btn_Empleado;
        private Button button3;
        private Button button4;
        private Button button6;
        private DataGridView dgv_conulta;
    }
}