﻿namespace Capa_Presentacion
{
    partial class Frm_Categoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Categoria));
            label4 = new Label();
            label3 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            dgv_Categoria = new DataGridView();
            btn_Cancelar = new Button();
            btn_Eliminar_Producto = new Button();
            btn_Editar_Producto = new Button();
            btn_Agregar_Categoria = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label1 = new Label();
            txt_Categoria = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgv_Categoria).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(508, 235);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(119, 28);
            label4.TabIndex = 32;
            label4.Text = "Categoria";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Brown;
            label3.Location = new Point(54, 167);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(202, 23);
            label3.TabIndex = 38;
            label3.Text = "Gestion de Categorias";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // dgv_Categoria
            // 
            dgv_Categoria.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Categoria.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_Categoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Categoria.Location = new Point(235, 492);
            dgv_Categoria.Margin = new Padding(4, 2, 4, 2);
            dgv_Categoria.Name = "dgv_Categoria";
            dgv_Categoria.RowHeadersWidth = 62;
            dgv_Categoria.Size = new Size(766, 189);
            dgv_Categoria.TabIndex = 39;
            dgv_Categoria.CellContentClick += dgv_Categoria_CellContentClick;
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.BackColor = Color.FromArgb(198, 65, 66);
            btn_Cancelar.FlatAppearance.BorderSize = 0;
            btn_Cancelar.FlatStyle = FlatStyle.Flat;
            btn_Cancelar.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Cancelar.ForeColor = Color.White;
            btn_Cancelar.Location = new Point(442, 371);
            btn_Cancelar.Margin = new Padding(4, 2, 4, 2);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(164, 41);
            btn_Cancelar.TabIndex = 56;
            btn_Cancelar.Text = "Cancelar";
            btn_Cancelar.UseVisualStyleBackColor = false;
            btn_Cancelar.Click += btn_Cancelar_Click;
            // 
            // btn_Eliminar_Producto
            // 
            btn_Eliminar_Producto.BackColor = Color.FromArgb(198, 65, 66);
            btn_Eliminar_Producto.FlatAppearance.BorderSize = 0;
            btn_Eliminar_Producto.FlatStyle = FlatStyle.Flat;
            btn_Eliminar_Producto.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Eliminar_Producto.ForeColor = Color.White;
            btn_Eliminar_Producto.Location = new Point(888, 371);
            btn_Eliminar_Producto.Margin = new Padding(4, 2, 4, 2);
            btn_Eliminar_Producto.Name = "btn_Eliminar_Producto";
            btn_Eliminar_Producto.Size = new Size(164, 41);
            btn_Eliminar_Producto.TabIndex = 55;
            btn_Eliminar_Producto.Text = "Eliminar";
            btn_Eliminar_Producto.UseVisualStyleBackColor = false;
            btn_Eliminar_Producto.Click += btn_Eliminar_Producto_Click;
            // 
            // btn_Editar_Producto
            // 
            btn_Editar_Producto.BackColor = Color.FromArgb(19, 26, 97);
            btn_Editar_Producto.FlatAppearance.BorderSize = 0;
            btn_Editar_Producto.FlatStyle = FlatStyle.Flat;
            btn_Editar_Producto.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Editar_Producto.ForeColor = Color.White;
            btn_Editar_Producto.Location = new Point(662, 371);
            btn_Editar_Producto.Margin = new Padding(4, 2, 4, 2);
            btn_Editar_Producto.Name = "btn_Editar_Producto";
            btn_Editar_Producto.Size = new Size(164, 41);
            btn_Editar_Producto.TabIndex = 54;
            btn_Editar_Producto.Text = "Editar";
            btn_Editar_Producto.UseVisualStyleBackColor = false;
            btn_Editar_Producto.Click += btn_Editar_Producto_Click;
            // 
            // btn_Agregar_Categoria
            // 
            btn_Agregar_Categoria.BackColor = Color.FromArgb(19, 26, 97);
            btn_Agregar_Categoria.FlatAppearance.BorderSize = 0;
            btn_Agregar_Categoria.FlatStyle = FlatStyle.Flat;
            btn_Agregar_Categoria.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Agregar_Categoria.ForeColor = Color.White;
            btn_Agregar_Categoria.Location = new Point(217, 371);
            btn_Agregar_Categoria.Margin = new Padding(4, 2, 4, 2);
            btn_Agregar_Categoria.Name = "btn_Agregar_Categoria";
            btn_Agregar_Categoria.Size = new Size(164, 41);
            btn_Agregar_Categoria.TabIndex = 53;
            btn_Agregar_Categoria.Text = "Agregar";
            btn_Agregar_Categoria.UseVisualStyleBackColor = false;
            btn_Agregar_Categoria.Click += btn_Agregar_Categoria_Click;
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
            panel1.TabIndex = 71;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(42, 280);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(182, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 73;
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
            panel2.TabIndex = 72;
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
            // txt_Categoria
            // 
            txt_Categoria.Location = new Point(508, 280);
            txt_Categoria.Name = "txt_Categoria";
            txt_Categoria.Size = new Size(220, 36);
            txt_Categoria.TabIndex = 74;
            // 
            // Frm_Categoria
            // 
            AutoScaleDimensions = new SizeF(13F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1480, 760);
            ControlBox = false;
            Controls.Add(txt_Categoria);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btn_Cancelar);
            Controls.Add(btn_Eliminar_Producto);
            Controls.Add(btn_Editar_Producto);
            Controls.Add(btn_Agregar_Categoria);
            Controls.Add(dgv_Categoria);
            Controls.Add(label3);
            Controls.Add(label4);
            Font = new Font("Cambria", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Frm_Categoria";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Frm_Categoria_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Categoria).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label4;
        private Label label3;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private DataGridView dgv_Categoria;
        private Button btn_Cancelar;
        private Button btn_Eliminar_Producto;
        private Button btn_Editar_Producto;
        private Button btn_Agregar_Categoria;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox txt_Categoria;
    }
}