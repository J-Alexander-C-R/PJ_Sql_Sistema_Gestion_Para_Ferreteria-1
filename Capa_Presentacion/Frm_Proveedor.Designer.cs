namespace Capa_Presentacion
{
    partial class Frm_Proveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Proveedor));
            label14 = new Label();
            dgv_Proveedor = new DataGridView();
            label4 = new Label();
            txt_Email = new TextBox();
            label5 = new Label();
            label13 = new Label();
            txt_Empresa = new TextBox();
            lbl_Usuario = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label1 = new Label();
            btn_Cancelar = new Button();
            btn_Eliminar_Producto = new Button();
            btn_Editar_Producto = new Button();
            btn_Agregar_Proveedor = new Button();
            txt_Direccion = new TextBox();
            txt_Telefono = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgv_Proveedor).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Cambria", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.Brown;
            label14.Location = new Point(57, 167);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(122, 23);
            label14.TabIndex = 46;
            label14.Text = "Proveedores";
            // 
            // dgv_Proveedor
            // 
            dgv_Proveedor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Proveedor.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_Proveedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Proveedor.Location = new Point(95, 511);
            dgv_Proveedor.Margin = new Padding(4, 2, 4, 2);
            dgv_Proveedor.Name = "dgv_Proveedor";
            dgv_Proveedor.RowHeadersWidth = 62;
            dgv_Proveedor.Size = new Size(1022, 225);
            dgv_Proveedor.TabIndex = 45;
            dgv_Proveedor.CellContentClick += dgv_Proveedor_CellContentClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(485, 308);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(114, 28);
            label4.TabIndex = 39;
            label4.Text = "Direccion";
            // 
            // txt_Email
            // 
            txt_Email.Location = new Point(880, 249);
            txt_Email.Margin = new Padding(4, 2, 4, 2);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(220, 36);
            txt_Email.TabIndex = 37;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cambria", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(880, 203);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(74, 28);
            label5.TabIndex = 36;
            label5.Text = "Email";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Cambria", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label13.Location = new Point(485, 203);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(103, 28);
            label13.TabIndex = 34;
            label13.Text = "Telefono";
            // 
            // txt_Empresa
            // 
            txt_Empresa.Location = new Point(95, 249);
            txt_Empresa.Margin = new Padding(4, 2, 4, 2);
            txt_Empresa.Name = "txt_Empresa";
            txt_Empresa.Size = new Size(220, 36);
            txt_Empresa.TabIndex = 33;
            // 
            // lbl_Usuario
            // 
            lbl_Usuario.AutoSize = true;
            lbl_Usuario.Font = new Font("Cambria", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_Usuario.Location = new Point(95, 203);
            lbl_Usuario.Margin = new Padding(4, 0, 4, 0);
            lbl_Usuario.Name = "lbl_Usuario";
            lbl_Usuario.Size = new Size(108, 28);
            lbl_Usuario.TabIndex = 32;
            lbl_Usuario.Text = "Empresa";
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
            panel1.TabIndex = 47;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(35, 290);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(182, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 53;
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
            panel2.TabIndex = 48;
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
            // btn_Cancelar
            // 
            btn_Cancelar.BackColor = Color.FromArgb(198, 65, 66);
            btn_Cancelar.FlatAppearance.BorderSize = 0;
            btn_Cancelar.FlatStyle = FlatStyle.Flat;
            btn_Cancelar.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Cancelar.ForeColor = Color.White;
            btn_Cancelar.Location = new Point(418, 432);
            btn_Cancelar.Margin = new Padding(4, 2, 4, 2);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(164, 41);
            btn_Cancelar.TabIndex = 52;
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
            btn_Eliminar_Producto.Location = new Point(864, 432);
            btn_Eliminar_Producto.Margin = new Padding(4, 2, 4, 2);
            btn_Eliminar_Producto.Name = "btn_Eliminar_Producto";
            btn_Eliminar_Producto.Size = new Size(164, 41);
            btn_Eliminar_Producto.TabIndex = 51;
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
            btn_Editar_Producto.Location = new Point(638, 432);
            btn_Editar_Producto.Margin = new Padding(4, 2, 4, 2);
            btn_Editar_Producto.Name = "btn_Editar_Producto";
            btn_Editar_Producto.Size = new Size(164, 41);
            btn_Editar_Producto.TabIndex = 50;
            btn_Editar_Producto.Text = "Editar";
            btn_Editar_Producto.UseVisualStyleBackColor = false;
            btn_Editar_Producto.Click += btn_Editar_Producto_Click;
            // 
            // btn_Agregar_Proveedor
            // 
            btn_Agregar_Proveedor.BackColor = Color.FromArgb(19, 26, 97);
            btn_Agregar_Proveedor.FlatAppearance.BorderSize = 0;
            btn_Agregar_Proveedor.FlatStyle = FlatStyle.Flat;
            btn_Agregar_Proveedor.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Agregar_Proveedor.ForeColor = Color.White;
            btn_Agregar_Proveedor.Location = new Point(193, 432);
            btn_Agregar_Proveedor.Margin = new Padding(4, 2, 4, 2);
            btn_Agregar_Proveedor.Name = "btn_Agregar_Proveedor";
            btn_Agregar_Proveedor.Size = new Size(164, 41);
            btn_Agregar_Proveedor.TabIndex = 49;
            btn_Agregar_Proveedor.Text = "Agregar";
            btn_Agregar_Proveedor.UseVisualStyleBackColor = false;
            btn_Agregar_Proveedor.Click += btn_Agregar_Proveedor_Click;
            // 
            // txt_Direccion
            // 
            txt_Direccion.Location = new Point(485, 354);
            txt_Direccion.Margin = new Padding(4, 2, 4, 2);
            txt_Direccion.Name = "txt_Direccion";
            txt_Direccion.Size = new Size(220, 36);
            txt_Direccion.TabIndex = 53;
            // 
            // txt_Telefono
            // 
            txt_Telefono.Location = new Point(485, 233);
            txt_Telefono.Margin = new Padding(4, 2, 4, 2);
            txt_Telefono.Name = "txt_Telefono";
            txt_Telefono.Size = new Size(220, 36);
            txt_Telefono.TabIndex = 55;
            // 
            // Frm_Proveedor
            // 
            AutoScaleDimensions = new SizeF(13F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1480, 760);
            ControlBox = false;
            Controls.Add(txt_Telefono);
            Controls.Add(txt_Direccion);
            Controls.Add(btn_Cancelar);
            Controls.Add(btn_Eliminar_Producto);
            Controls.Add(btn_Editar_Producto);
            Controls.Add(btn_Agregar_Proveedor);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label14);
            Controls.Add(dgv_Proveedor);
            Controls.Add(label4);
            Controls.Add(txt_Email);
            Controls.Add(label5);
            Controls.Add(label13);
            Controls.Add(txt_Empresa);
            Controls.Add(lbl_Usuario);
            Font = new Font("Cambria", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Frm_Proveedor";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Frm_Proveedor_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Proveedor).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label14;
        private DataGridView dgv_Proveedor;
        private ComboBox comboBox2;
        private Label label4;
        private TextBox txt_Email;
        private Label label5;
        private Label label13;
        private TextBox txt_Empresa;
        private Label lbl_Usuario;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Button btn_Cancelar;
        private Button btn_Eliminar_Producto;
        private Button btn_Editar_Producto;
        private Button btn_Agregar_Proveedor;
        private PictureBox pictureBox1;
        private TextBox txt_Direccion;
        private TextBox txt_Telefono;
    }
}