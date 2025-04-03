namespace Capa_Presentacion
{
    partial class Frm_Producto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Producto));
            cmb_Proveedor = new ComboBox();
            cmb_Categoria = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            txt_Stock = new TextBox();
            label5 = new Label();
            txt_Precio = new TextBox();
            label13 = new Label();
            txt_Producto = new TextBox();
            lbl_Usuario = new Label();
            btn_Eliminar_Producto = new Button();
            btn_Editar = new Button();
            btn_Agregar = new Button();
            dgv_Producto = new DataGridView();
            btn_Eliminar = new Button();
            panel1 = new Panel();
            btn_Volver = new Button();
            panel2 = new Panel();
            label1 = new Label();
            label14 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_Producto).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // cmb_Proveedor
            // 
            cmb_Proveedor.FormattingEnabled = true;
            cmb_Proveedor.Location = new Point(487, 355);
            cmb_Proveedor.Margin = new Padding(4, 2, 4, 2);
            cmb_Proveedor.Name = "cmb_Proveedor";
            cmb_Proveedor.Size = new Size(220, 36);
            cmb_Proveedor.TabIndex = 26;
            // 
            // cmb_Categoria
            // 
            cmb_Categoria.FormattingEnabled = true;
            cmb_Categoria.Location = new Point(97, 355);
            cmb_Categoria.Margin = new Padding(4, 2, 4, 2);
            cmb_Categoria.Name = "cmb_Categoria";
            cmb_Categoria.Size = new Size(220, 36);
            cmb_Categoria.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(487, 310);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(124, 28);
            label4.TabIndex = 24;
            label4.Text = "Proveedor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(97, 310);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(119, 28);
            label3.TabIndex = 23;
            label3.Text = "Categoria";
            // 
            // txt_Stock
            // 
            txt_Stock.Location = new Point(882, 251);
            txt_Stock.Margin = new Padding(4, 2, 4, 2);
            txt_Stock.Name = "txt_Stock";
            txt_Stock.Size = new Size(220, 36);
            txt_Stock.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cambria", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(882, 205);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(70, 28);
            label5.TabIndex = 21;
            label5.Text = "Stock";
            // 
            // txt_Precio
            // 
            txt_Precio.Location = new Point(487, 251);
            txt_Precio.Margin = new Padding(4, 2, 4, 2);
            txt_Precio.Name = "txt_Precio";
            txt_Precio.Size = new Size(220, 36);
            txt_Precio.TabIndex = 20;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Cambria", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label13.Location = new Point(487, 205);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(80, 28);
            label13.TabIndex = 19;
            label13.Text = "Precio";
            // 
            // txt_Producto
            // 
            txt_Producto.Location = new Point(97, 251);
            txt_Producto.Margin = new Padding(4, 2, 4, 2);
            txt_Producto.Name = "txt_Producto";
            txt_Producto.Size = new Size(220, 36);
            txt_Producto.TabIndex = 18;
            // 
            // lbl_Usuario
            // 
            lbl_Usuario.AutoSize = true;
            lbl_Usuario.Font = new Font("Cambria", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_Usuario.Location = new Point(97, 205);
            lbl_Usuario.Margin = new Padding(4, 0, 4, 0);
            lbl_Usuario.Name = "lbl_Usuario";
            lbl_Usuario.Size = new Size(111, 28);
            lbl_Usuario.TabIndex = 17;
            lbl_Usuario.Text = "Producto";
            // 
            // btn_Eliminar_Producto
            // 
            btn_Eliminar_Producto.BackColor = Color.FromArgb(198, 65, 66);
            btn_Eliminar_Producto.FlatAppearance.BorderSize = 0;
            btn_Eliminar_Producto.FlatStyle = FlatStyle.Flat;
            btn_Eliminar_Producto.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Eliminar_Producto.ForeColor = Color.White;
            btn_Eliminar_Producto.Location = new Point(882, 436);
            btn_Eliminar_Producto.Margin = new Padding(4, 2, 4, 2);
            btn_Eliminar_Producto.Name = "btn_Eliminar_Producto";
            btn_Eliminar_Producto.Size = new Size(164, 41);
            btn_Eliminar_Producto.TabIndex = 29;
            btn_Eliminar_Producto.Text = "Eliminar";
            btn_Eliminar_Producto.UseVisualStyleBackColor = false;
            // 
            // btn_Editar
            // 
            btn_Editar.BackColor = Color.FromArgb(19, 26, 97);
            btn_Editar.FlatAppearance.BorderSize = 0;
            btn_Editar.FlatStyle = FlatStyle.Flat;
            btn_Editar.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Editar.ForeColor = Color.White;
            btn_Editar.Location = new Point(656, 436);
            btn_Editar.Margin = new Padding(4, 2, 4, 2);
            btn_Editar.Name = "btn_Editar";
            btn_Editar.Size = new Size(164, 41);
            btn_Editar.TabIndex = 28;
            btn_Editar.Text = "Editar";
            btn_Editar.UseVisualStyleBackColor = false;
            // 
            // btn_Agregar
            // 
            btn_Agregar.BackColor = Color.FromArgb(19, 26, 97);
            btn_Agregar.FlatAppearance.BorderSize = 0;
            btn_Agregar.FlatStyle = FlatStyle.Flat;
            btn_Agregar.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Agregar.ForeColor = Color.White;
            btn_Agregar.Location = new Point(211, 436);
            btn_Agregar.Margin = new Padding(4, 2, 4, 2);
            btn_Agregar.Name = "btn_Agregar";
            btn_Agregar.Size = new Size(164, 41);
            btn_Agregar.TabIndex = 27;
            btn_Agregar.Text = "Agregar";
            btn_Agregar.UseVisualStyleBackColor = false;
            btn_Agregar.Click += btn_Agregar_Click;
            // 
            // dgv_Producto
            // 
            dgv_Producto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Producto.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_Producto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Producto.Location = new Point(97, 501);
            dgv_Producto.Margin = new Padding(4, 2, 4, 2);
            dgv_Producto.Name = "dgv_Producto";
            dgv_Producto.RowHeadersWidth = 62;
            dgv_Producto.Size = new Size(1022, 225);
            dgv_Producto.TabIndex = 30;
            dgv_Producto.CellContentClick += dgv_Producto_CellContentClick;
            // 
            // btn_Eliminar
            // 
            btn_Eliminar.BackColor = Color.FromArgb(198, 65, 66);
            btn_Eliminar.FlatAppearance.BorderSize = 0;
            btn_Eliminar.FlatStyle = FlatStyle.Flat;
            btn_Eliminar.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Eliminar.ForeColor = Color.White;
            btn_Eliminar.Location = new Point(436, 436);
            btn_Eliminar.Margin = new Padding(4, 2, 4, 2);
            btn_Eliminar.Name = "btn_Eliminar";
            btn_Eliminar.Size = new Size(164, 41);
            btn_Eliminar.TabIndex = 32;
            btn_Eliminar.Text = "Cancelar";
            btn_Eliminar.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(42, 28, 109);
            panel1.Controls.Add(btn_Volver);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(1226, 0);
            panel1.Margin = new Padding(4, 2, 4, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(254, 760);
            panel1.TabIndex = 48;
            // 
            // btn_Volver
            // 
            btn_Volver.BackColor = Color.FromArgb(42, 28, 109);
            btn_Volver.FlatAppearance.BorderSize = 0;
            btn_Volver.FlatStyle = FlatStyle.Flat;
            btn_Volver.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Volver.ForeColor = Color.White;
            btn_Volver.Image = (Image)resources.GetObject("btn_Volver.Image");
            btn_Volver.Location = new Point(46, 310);
            btn_Volver.Margin = new Padding(4, 2, 4, 2);
            btn_Volver.Name = "btn_Volver";
            btn_Volver.Size = new Size(183, 122);
            btn_Volver.TabIndex = 59;
            btn_Volver.UseVisualStyleBackColor = false;
            btn_Volver.Click += btn_Volver_Click;
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
            panel2.TabIndex = 49;
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
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Cambria", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.Brown;
            label14.Location = new Point(64, 169);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(101, 23);
            label14.TabIndex = 58;
            label14.Text = "Productos";
            // 
            // Frm_Producto
            // 
            AutoScaleDimensions = new SizeF(13F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1480, 760);
            Controls.Add(label14);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btn_Eliminar);
            Controls.Add(dgv_Producto);
            Controls.Add(btn_Eliminar_Producto);
            Controls.Add(btn_Editar);
            Controls.Add(btn_Agregar);
            Controls.Add(cmb_Proveedor);
            Controls.Add(cmb_Categoria);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txt_Stock);
            Controls.Add(label5);
            Controls.Add(txt_Precio);
            Controls.Add(label13);
            Controls.Add(txt_Producto);
            Controls.Add(lbl_Usuario);
            Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 2, 4, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Frm_Producto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_Producto";
            Load += Frm_Producto_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Producto).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cmb_Proveedor;
        private ComboBox cmb_Categoria;
        private Label label4;
        private Label label3;
        private TextBox txt_Stock;
        private Label label5;
        private TextBox txt_Precio;
        private Label label13;
        private TextBox txt_Producto;
        private Label lbl_Usuario;
        private Button btn_Eliminar_Producto;
        private Button btn_Editar;
        private Button btn_Agregar;
        private DataGridView dgv_Producto;
        private Button btn_Eliminar;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label14;
        private Button btn_Volver;
    }
}