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
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            txt_Stock = new TextBox();
            label5 = new Label();
            txt_Precio = new TextBox();
            label13 = new Label();
            txt_Producto = new TextBox();
            lbl_Usuario = new Label();
            btn_Eliminar_Producto = new Button();
            btn_Editar_Producto = new Button();
            btn_Agregar_Producto = new Button();
            dgv_Producto = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_Producto).BeginInit();
            SuspendLayout();
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(476, 197);
            comboBox2.Margin = new Padding(4, 2, 4, 2);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(220, 36);
            comboBox2.TabIndex = 26;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(86, 197);
            comboBox1.Margin = new Padding(4, 2, 4, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(220, 36);
            comboBox1.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(476, 152);
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
            label3.Location = new Point(86, 152);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(119, 28);
            label3.TabIndex = 23;
            label3.Text = "Categoria";
            // 
            // txt_Stock
            // 
            txt_Stock.Location = new Point(871, 93);
            txt_Stock.Margin = new Padding(4, 2, 4, 2);
            txt_Stock.Name = "txt_Stock";
            txt_Stock.Size = new Size(220, 36);
            txt_Stock.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cambria", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(871, 47);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(70, 28);
            label5.TabIndex = 21;
            label5.Text = "Stock";
            // 
            // txt_Precio
            // 
            txt_Precio.Location = new Point(476, 93);
            txt_Precio.Margin = new Padding(4, 2, 4, 2);
            txt_Precio.Name = "txt_Precio";
            txt_Precio.Size = new Size(220, 36);
            txt_Precio.TabIndex = 20;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Cambria", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label13.Location = new Point(476, 47);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(80, 28);
            label13.TabIndex = 19;
            label13.Text = "Precio";
            // 
            // txt_Producto
            // 
            txt_Producto.Location = new Point(86, 93);
            txt_Producto.Margin = new Padding(4, 2, 4, 2);
            txt_Producto.Name = "txt_Producto";
            txt_Producto.Size = new Size(220, 36);
            txt_Producto.TabIndex = 18;
            // 
            // lbl_Usuario
            // 
            lbl_Usuario.AutoSize = true;
            lbl_Usuario.Font = new Font("Cambria", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_Usuario.Location = new Point(86, 47);
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
            btn_Eliminar_Producto.Location = new Point(871, 278);
            btn_Eliminar_Producto.Margin = new Padding(4, 2, 4, 2);
            btn_Eliminar_Producto.Name = "btn_Eliminar_Producto";
            btn_Eliminar_Producto.Size = new Size(164, 41);
            btn_Eliminar_Producto.TabIndex = 29;
            btn_Eliminar_Producto.Text = "Eliminar";
            btn_Eliminar_Producto.UseVisualStyleBackColor = false;
            // 
            // btn_Editar_Producto
            // 
            btn_Editar_Producto.BackColor = Color.FromArgb(19, 26, 97);
            btn_Editar_Producto.FlatAppearance.BorderSize = 0;
            btn_Editar_Producto.FlatStyle = FlatStyle.Flat;
            btn_Editar_Producto.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Editar_Producto.ForeColor = Color.White;
            btn_Editar_Producto.Location = new Point(645, 278);
            btn_Editar_Producto.Margin = new Padding(4, 2, 4, 2);
            btn_Editar_Producto.Name = "btn_Editar_Producto";
            btn_Editar_Producto.Size = new Size(164, 41);
            btn_Editar_Producto.TabIndex = 28;
            btn_Editar_Producto.Text = "Editar";
            btn_Editar_Producto.UseVisualStyleBackColor = false;
            // 
            // btn_Agregar_Producto
            // 
            btn_Agregar_Producto.BackColor = Color.FromArgb(19, 26, 97);
            btn_Agregar_Producto.FlatAppearance.BorderSize = 0;
            btn_Agregar_Producto.FlatStyle = FlatStyle.Flat;
            btn_Agregar_Producto.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Agregar_Producto.ForeColor = Color.White;
            btn_Agregar_Producto.Location = new Point(200, 278);
            btn_Agregar_Producto.Margin = new Padding(4, 2, 4, 2);
            btn_Agregar_Producto.Name = "btn_Agregar_Producto";
            btn_Agregar_Producto.Size = new Size(164, 41);
            btn_Agregar_Producto.TabIndex = 27;
            btn_Agregar_Producto.Text = "Agregar";
            btn_Agregar_Producto.UseVisualStyleBackColor = false;
            // 
            // dgv_Producto
            // 
            dgv_Producto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Producto.Location = new Point(86, 343);
            dgv_Producto.Margin = new Padding(4, 2, 4, 2);
            dgv_Producto.Name = "dgv_Producto";
            dgv_Producto.RowHeadersWidth = 62;
            dgv_Producto.Size = new Size(1022, 225);
            dgv_Producto.TabIndex = 30;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(198, 65, 66);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(425, 278);
            button1.Margin = new Padding(4, 2, 4, 2);
            button1.Name = "button1";
            button1.Size = new Size(164, 41);
            button1.TabIndex = 32;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = false;
            // 
            // Frm_Producto
            // 
            AutoScaleDimensions = new SizeF(13F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1480, 760);
            Controls.Add(button1);
            Controls.Add(dgv_Producto);
            Controls.Add(btn_Eliminar_Producto);
            Controls.Add(btn_Editar_Producto);
            Controls.Add(btn_Agregar_Producto);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label4;
        private Label label3;
        private TextBox txt_Stock;
        private Label label5;
        private TextBox txt_Precio;
        private Label label13;
        private TextBox txt_Producto;
        private Label lbl_Usuario;
        private Button btn_Eliminar_Producto;
        private Button btn_Editar_Producto;
        private Button btn_Agregar_Producto;
        private DataGridView dgv_Producto;
        private Button button1;
    }
}