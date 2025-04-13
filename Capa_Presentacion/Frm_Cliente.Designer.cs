namespace Capa_Presentacion
{
    partial class Frm_Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Cliente));
            txt_Direccion = new TextBox();
            txt_Email = new TextBox();
            label15 = new Label();
            label4 = new Label();
            txt_Telefono = new TextBox();
            label5 = new Label();
            txt_Apellido = new TextBox();
            label13 = new Label();
            txt_Nombre = new TextBox();
            lbl_Usuario = new Label();
            dgv_Cliente = new DataGridView();
            label14 = new Label();
            btn_Cancelar = new Button();
            btn_Eliminar_Producto = new Button();
            btn_Editar_Producto = new Button();
            btn_Agregar_Cliente = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_Cliente).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // txt_Direccion
            // 
            txt_Direccion.Location = new Point(496, 349);
            txt_Direccion.Margin = new Padding(4, 3, 4, 3);
            txt_Direccion.Name = "txt_Direccion";
            txt_Direccion.Size = new Size(220, 36);
            txt_Direccion.TabIndex = 66;
            // 
            // txt_Email
            // 
            txt_Email.Location = new Point(106, 349);
            txt_Email.Margin = new Padding(4, 3, 4, 3);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(220, 36);
            txt_Email.TabIndex = 64;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Cambria", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label15.Location = new Point(106, 303);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(74, 28);
            label15.TabIndex = 63;
            label15.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(496, 303);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(114, 28);
            label4.TabIndex = 58;
            label4.Text = "Direccion";
            // 
            // txt_Telefono
            // 
            txt_Telefono.Location = new Point(897, 244);
            txt_Telefono.Margin = new Padding(4, 3, 4, 3);
            txt_Telefono.Name = "txt_Telefono";
            txt_Telefono.Size = new Size(220, 36);
            txt_Telefono.TabIndex = 56;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cambria", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(897, 198);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(103, 28);
            label5.TabIndex = 55;
            label5.Text = "Telefono";
            // 
            // txt_Apellido
            // 
            txt_Apellido.Location = new Point(496, 244);
            txt_Apellido.Margin = new Padding(4, 3, 4, 3);
            txt_Apellido.Name = "txt_Apellido";
            txt_Apellido.Size = new Size(220, 36);
            txt_Apellido.TabIndex = 54;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Cambria", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label13.Location = new Point(496, 198);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(101, 28);
            label13.TabIndex = 53;
            label13.Text = "Apellido";
            // 
            // txt_Nombre
            // 
            txt_Nombre.Location = new Point(106, 244);
            txt_Nombre.Margin = new Padding(4, 3, 4, 3);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new Size(220, 36);
            txt_Nombre.TabIndex = 52;
            // 
            // lbl_Usuario
            // 
            lbl_Usuario.AutoSize = true;
            lbl_Usuario.Font = new Font("Cambria", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_Usuario.Location = new Point(106, 198);
            lbl_Usuario.Margin = new Padding(4, 0, 4, 0);
            lbl_Usuario.Name = "lbl_Usuario";
            lbl_Usuario.Size = new Size(99, 28);
            lbl_Usuario.TabIndex = 51;
            lbl_Usuario.Text = "Nombre";
            // 
            // dgv_Cliente
            // 
            dgv_Cliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Cliente.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_Cliente.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv_Cliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Cliente.Location = new Point(97, 511);
            dgv_Cliente.Name = "dgv_Cliente";
            dgv_Cliente.RowHeadersWidth = 62;
            dgv_Cliente.Size = new Size(1022, 225);
            dgv_Cliente.TabIndex = 67;
            dgv_Cliente.CellContentClick += dgv_Cliente_CellContentClick;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Cambria", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.Brown;
            label14.Location = new Point(58, 163);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(177, 23);
            label14.TabIndex = 70;
            label14.Text = "Gestion de Clientes";
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.BackColor = Color.FromArgb(198, 65, 66);
            btn_Cancelar.FlatAppearance.BorderSize = 0;
            btn_Cancelar.FlatStyle = FlatStyle.Flat;
            btn_Cancelar.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Cancelar.ForeColor = Color.White;
            btn_Cancelar.Location = new Point(423, 443);
            btn_Cancelar.Margin = new Padding(4, 2, 4, 2);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(164, 41);
            btn_Cancelar.TabIndex = 74;
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
            btn_Eliminar_Producto.Location = new Point(875, 443);
            btn_Eliminar_Producto.Margin = new Padding(4, 2, 4, 2);
            btn_Eliminar_Producto.Name = "btn_Eliminar_Producto";
            btn_Eliminar_Producto.Size = new Size(164, 41);
            btn_Eliminar_Producto.TabIndex = 73;
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
            btn_Editar_Producto.Location = new Point(643, 443);
            btn_Editar_Producto.Margin = new Padding(4, 2, 4, 2);
            btn_Editar_Producto.Name = "btn_Editar_Producto";
            btn_Editar_Producto.Size = new Size(164, 41);
            btn_Editar_Producto.TabIndex = 72;
            btn_Editar_Producto.Text = "Editar";
            btn_Editar_Producto.UseVisualStyleBackColor = false;
            btn_Editar_Producto.Click += btn_Editar_Producto_Click;
            // 
            // btn_Agregar_Cliente
            // 
            btn_Agregar_Cliente.BackColor = Color.FromArgb(19, 26, 97);
            btn_Agregar_Cliente.FlatAppearance.BorderSize = 0;
            btn_Agregar_Cliente.FlatStyle = FlatStyle.Flat;
            btn_Agregar_Cliente.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Agregar_Cliente.ForeColor = Color.White;
            btn_Agregar_Cliente.Location = new Point(198, 443);
            btn_Agregar_Cliente.Margin = new Padding(4, 2, 4, 2);
            btn_Agregar_Cliente.Name = "btn_Agregar_Cliente";
            btn_Agregar_Cliente.Size = new Size(164, 41);
            btn_Agregar_Cliente.TabIndex = 71;
            btn_Agregar_Cliente.Text = "Agregar";
            btn_Agregar_Cliente.UseVisualStyleBackColor = false;
            btn_Agregar_Cliente.Click += btn_Agregar_Cliente_Click;
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
            panel1.TabIndex = 75;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(40, 286);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(182, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 77;
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
            panel2.TabIndex = 76;
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
            // Frm_Cliente
            // 
            AutoScaleDimensions = new SizeF(13F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1480, 760);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btn_Cancelar);
            Controls.Add(btn_Eliminar_Producto);
            Controls.Add(btn_Editar_Producto);
            Controls.Add(btn_Agregar_Cliente);
            Controls.Add(label14);
            Controls.Add(dgv_Cliente);
            Controls.Add(txt_Direccion);
            Controls.Add(txt_Email);
            Controls.Add(label15);
            Controls.Add(label4);
            Controls.Add(txt_Telefono);
            Controls.Add(label5);
            Controls.Add(txt_Apellido);
            Controls.Add(label13);
            Controls.Add(txt_Nombre);
            Controls.Add(lbl_Usuario);
            Font = new Font("Cambria", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Frm_Cliente";
            Text = "Frm_Cliente";
            Load += Frm_Cliente_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgv_Cliente).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txt_Direccion;
        private TextBox txt_Email;
        private Label label15;
        private Label label4;
        private TextBox txt_Telefono;
        private Label label5;
        private TextBox txt_Apellido;
        private Label label13;
        private TextBox txt_Nombre;
        private Label lbl_Usuario;
        private DataGridView dgv_Cliente;
        private Label label14;
        private Button btn_Cancelar;
        private Button btn_Eliminar_Producto;
        private Button btn_Editar_Producto;
        private Button btn_Agregar_Cliente;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
    }
}