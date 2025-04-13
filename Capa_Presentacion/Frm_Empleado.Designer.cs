namespace Capa_Presentacion
{
    partial class Frm_Empleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Empleado));
            label4 = new Label();
            label3 = new Label();
            txt_Telefono = new TextBox();
            label5 = new Label();
            txt_Apellido = new TextBox();
            label13 = new Label();
            txt_Nombre = new TextBox();
            lbl_Usuario = new Label();
            dgv_Empleado = new DataGridView();
            txt_Email = new TextBox();
            label15 = new Label();
            txt_Cedula = new TextBox();
            btn_Cancelar = new Button();
            btn_Eliminar_Producto = new Button();
            btn_Editar_Producto = new Button();
            btn_Agregar_Empleado = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label1 = new Label();
            label14 = new Label();
            lbl_Direccion = new Label();
            txt_Direccion = new TextBox();
            Cmb_Cargo = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgv_Empleado).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(675, 312);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(77, 28);
            label4.TabIndex = 39;
            label4.Text = "Cargo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(95, 312);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(86, 28);
            label3.TabIndex = 38;
            label3.Text = "Cedula";
            // 
            // txt_Telefono
            // 
            txt_Telefono.Location = new Point(675, 253);
            txt_Telefono.Margin = new Padding(4, 3, 4, 3);
            txt_Telefono.Name = "txt_Telefono";
            txt_Telefono.Size = new Size(220, 36);
            txt_Telefono.TabIndex = 37;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cambria", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(675, 207);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(103, 28);
            label5.TabIndex = 36;
            label5.Text = "Telefono";
            // 
            // txt_Apellido
            // 
            txt_Apellido.Location = new Point(387, 253);
            txt_Apellido.Margin = new Padding(4, 3, 4, 3);
            txt_Apellido.Name = "txt_Apellido";
            txt_Apellido.Size = new Size(220, 36);
            txt_Apellido.TabIndex = 35;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Cambria", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label13.Location = new Point(387, 207);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(101, 28);
            label13.TabIndex = 34;
            label13.Text = "Apellido";
            // 
            // txt_Nombre
            // 
            txt_Nombre.Location = new Point(95, 253);
            txt_Nombre.Margin = new Padding(4, 3, 4, 3);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new Size(220, 36);
            txt_Nombre.TabIndex = 33;
            // 
            // lbl_Usuario
            // 
            lbl_Usuario.AutoSize = true;
            lbl_Usuario.Font = new Font("Cambria", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_Usuario.Location = new Point(95, 207);
            lbl_Usuario.Margin = new Padding(4, 0, 4, 0);
            lbl_Usuario.Name = "lbl_Usuario";
            lbl_Usuario.Size = new Size(99, 28);
            lbl_Usuario.TabIndex = 32;
            lbl_Usuario.Text = "Nombre";
            // 
            // dgv_Empleado
            // 
            dgv_Empleado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Empleado.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_Empleado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Empleado.Location = new Point(95, 517);
            dgv_Empleado.Name = "dgv_Empleado";
            dgv_Empleado.RowHeadersWidth = 62;
            dgv_Empleado.Size = new Size(1022, 225);
            dgv_Empleado.TabIndex = 46;
            dgv_Empleado.CellContentClick += dgv_Empleado_CellContentClick;
            // 
            // txt_Email
            // 
            txt_Email.Location = new Point(387, 358);
            txt_Email.Margin = new Padding(4, 3, 4, 3);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(220, 36);
            txt_Email.TabIndex = 48;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Cambria", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label15.Location = new Point(387, 312);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(74, 28);
            label15.TabIndex = 47;
            label15.Text = "Email";
            // 
            // txt_Cedula
            // 
            txt_Cedula.Location = new Point(95, 358);
            txt_Cedula.Margin = new Padding(4, 3, 4, 3);
            txt_Cedula.Name = "txt_Cedula";
            txt_Cedula.Size = new Size(220, 36);
            txt_Cedula.TabIndex = 49;
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.BackColor = Color.FromArgb(198, 65, 66);
            btn_Cancelar.FlatAppearance.BorderSize = 0;
            btn_Cancelar.FlatStyle = FlatStyle.Flat;
            btn_Cancelar.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Cancelar.ForeColor = Color.White;
            btn_Cancelar.Location = new Point(414, 445);
            btn_Cancelar.Margin = new Padding(4, 2, 4, 2);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(164, 41);
            btn_Cancelar.TabIndex = 54;
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
            btn_Eliminar_Producto.Location = new Point(860, 445);
            btn_Eliminar_Producto.Margin = new Padding(4, 2, 4, 2);
            btn_Eliminar_Producto.Name = "btn_Eliminar_Producto";
            btn_Eliminar_Producto.Size = new Size(164, 41);
            btn_Eliminar_Producto.TabIndex = 53;
            btn_Eliminar_Producto.Text = "Eliminar";
            btn_Eliminar_Producto.UseVisualStyleBackColor = false;
            btn_Eliminar_Producto.Click += btn_Eliminar_Empleado_Click;
            // 
            // btn_Editar_Producto
            // 
            btn_Editar_Producto.BackColor = Color.FromArgb(19, 26, 97);
            btn_Editar_Producto.FlatAppearance.BorderSize = 0;
            btn_Editar_Producto.FlatStyle = FlatStyle.Flat;
            btn_Editar_Producto.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Editar_Producto.ForeColor = Color.White;
            btn_Editar_Producto.Location = new Point(634, 445);
            btn_Editar_Producto.Margin = new Padding(4, 2, 4, 2);
            btn_Editar_Producto.Name = "btn_Editar_Producto";
            btn_Editar_Producto.Size = new Size(164, 41);
            btn_Editar_Producto.TabIndex = 52;
            btn_Editar_Producto.Text = "Editar";
            btn_Editar_Producto.UseVisualStyleBackColor = false;
            btn_Editar_Producto.Click += btn_Editar_Empleado_Click;
            // 
            // btn_Agregar_Empleado
            // 
            btn_Agregar_Empleado.BackColor = Color.FromArgb(19, 26, 97);
            btn_Agregar_Empleado.FlatAppearance.BorderSize = 0;
            btn_Agregar_Empleado.FlatStyle = FlatStyle.Flat;
            btn_Agregar_Empleado.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Agregar_Empleado.ForeColor = Color.White;
            btn_Agregar_Empleado.Location = new Point(189, 445);
            btn_Agregar_Empleado.Margin = new Padding(4, 2, 4, 2);
            btn_Agregar_Empleado.Name = "btn_Agregar_Empleado";
            btn_Agregar_Empleado.Size = new Size(164, 41);
            btn_Agregar_Empleado.TabIndex = 51;
            btn_Agregar_Empleado.Text = "Agregar";
            btn_Agregar_Empleado.UseVisualStyleBackColor = false;
            btn_Agregar_Empleado.Click += btn_Agregar_Empleado_Click;
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
            panel1.TabIndex = 55;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(39, 312);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(182, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 58;
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
            panel2.TabIndex = 56;
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
            label14.Location = new Point(55, 162);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(111, 23);
            label14.TabIndex = 57;
            label14.Text = " Empleados";
            // 
            // lbl_Direccion
            // 
            lbl_Direccion.AutoSize = true;
            lbl_Direccion.Font = new Font("Cambria", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_Direccion.Location = new Point(960, 207);
            lbl_Direccion.Margin = new Padding(4, 0, 4, 0);
            lbl_Direccion.Name = "lbl_Direccion";
            lbl_Direccion.Size = new Size(114, 28);
            lbl_Direccion.TabIndex = 58;
            lbl_Direccion.Text = "Direccion\r\n";
            // 
            // txt_Direccion
            // 
            txt_Direccion.Location = new Point(960, 253);
            txt_Direccion.Margin = new Padding(4, 3, 4, 3);
            txt_Direccion.Name = "txt_Direccion";
            txt_Direccion.Size = new Size(220, 36);
            txt_Direccion.TabIndex = 59;
            // 
            // Cmb_Cargo
            // 
            Cmb_Cargo.DropDownStyle = ComboBoxStyle.DropDownList;
            Cmb_Cargo.FormattingEnabled = true;
            Cmb_Cargo.Items.AddRange(new object[] { "Gerente", "Supervisor", "Almacen", "Caja", "Servicio", "Transporte", "Despachador" });
            Cmb_Cargo.Location = new Point(675, 358);
            Cmb_Cargo.Name = "Cmb_Cargo";
            Cmb_Cargo.Size = new Size(220, 36);
            Cmb_Cargo.TabIndex = 60;
            // 
            // Frm_Empleado
            // 
            AutoScaleDimensions = new SizeF(13F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1480, 760);
            ControlBox = false;
            Controls.Add(Cmb_Cargo);
            Controls.Add(txt_Direccion);
            Controls.Add(lbl_Direccion);
            Controls.Add(label14);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btn_Cancelar);
            Controls.Add(btn_Eliminar_Producto);
            Controls.Add(btn_Editar_Producto);
            Controls.Add(btn_Agregar_Empleado);
            Controls.Add(txt_Cedula);
            Controls.Add(txt_Email);
            Controls.Add(label15);
            Controls.Add(dgv_Empleado);
            Controls.Add(label4);
            Controls.Add(label3);
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
            Name = "Frm_Empleado";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Frm_Empleado_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Empleado).EndInit();
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
        private TextBox txt_Telefono;
        private Label label5;
        private TextBox txt_Apellido;
        private Label label13;
        private TextBox txt_Nombre;
        private Label lbl_Usuario;
        private DataGridView dgv_Empleado;
        private TextBox txt_Email;
        private Label label15;
        private TextBox txt_Cedula;
        private Button btn_Cancelar;
        private Button btn_Eliminar_Producto;
        private Button btn_Editar_Producto;
        private Button btn_Agregar_Empleado;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label14;
        private PictureBox pictureBox1;
        private Label lbl_Direccion;
        private TextBox txt_Direccion;
        private ComboBox Cmb_Cargo;
    }
}