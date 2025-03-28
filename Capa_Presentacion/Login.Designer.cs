namespace Capa_Presentacion
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label1 = new Label();
            lbl_Usuario = new Label();
            txt_Usuario = new TextBox();
            lbl_Contraseña = new Label();
            txt_Contraseña = new TextBox();
            ckb_Mostrar = new CheckBox();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            btn_Login = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(368, 37);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(191, 33);
            label1.TabIndex = 2;
            label1.Text = "Login Account";
            // 
            // lbl_Usuario
            // 
            lbl_Usuario.AutoSize = true;
            lbl_Usuario.Font = new Font("Cambria", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_Usuario.Location = new Point(368, 105);
            lbl_Usuario.Margin = new Padding(4, 0, 4, 0);
            lbl_Usuario.Name = "lbl_Usuario";
            lbl_Usuario.Size = new Size(98, 28);
            lbl_Usuario.TabIndex = 3;
            lbl_Usuario.Text = "Usuario";
            // 
            // txt_Usuario
            // 
            txt_Usuario.Location = new Point(368, 157);
            txt_Usuario.Margin = new Padding(4, 3, 4, 3);
            txt_Usuario.Name = "txt_Usuario";
            txt_Usuario.Size = new Size(359, 36);
            txt_Usuario.TabIndex = 5;
            // 
            // lbl_Contraseña
            // 
            lbl_Contraseña.AutoSize = true;
            lbl_Contraseña.Font = new Font("Cambria", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_Contraseña.Location = new Point(368, 254);
            lbl_Contraseña.Margin = new Padding(4, 0, 4, 0);
            lbl_Contraseña.Name = "lbl_Contraseña";
            lbl_Contraseña.Size = new Size(137, 28);
            lbl_Contraseña.TabIndex = 6;
            lbl_Contraseña.Text = "Contraseña";
            // 
            // txt_Contraseña
            // 
            txt_Contraseña.Location = new Point(368, 295);
            txt_Contraseña.Margin = new Padding(4, 3, 4, 3);
            txt_Contraseña.Name = "txt_Contraseña";
            txt_Contraseña.PasswordChar = '*';
            txt_Contraseña.Size = new Size(359, 36);
            txt_Contraseña.TabIndex = 8;
            txt_Contraseña.TextChanged += textBox2_TextChanged;
            // 
            // ckb_Mostrar
            // 
            ckb_Mostrar.AutoSize = true;
            ckb_Mostrar.Font = new Font("Cambria", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            ckb_Mostrar.Location = new Point(612, 337);
            ckb_Mostrar.Margin = new Padding(4, 3, 4, 3);
            ckb_Mostrar.Name = "ckb_Mostrar";
            ckb_Mostrar.Size = new Size(127, 32);
            ckb_Mostrar.TabIndex = 9;
            ckb_Mostrar.Text = "Mostrar";
            ckb_Mostrar.UseVisualStyleBackColor = true;
            ckb_Mostrar.CheckedChanged += ckb_Mostrar_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(72, 37);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(166, 125);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(34, 26, 111);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(326, 497);
            panel1.TabIndex = 10;
            // 
            // btn_Login
            // 
            btn_Login.BackColor = Color.FromArgb(34, 26, 111);
            btn_Login.FlatAppearance.BorderSize = 0;
            btn_Login.FlatStyle = FlatStyle.Flat;
            btn_Login.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Login.ForeColor = Color.White;
            btn_Login.Location = new Point(368, 368);
            btn_Login.Margin = new Padding(4, 3, 4, 3);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(164, 46);
            btn_Login.TabIndex = 12;
            btn_Login.Text = "Login";
            btn_Login.UseVisualStyleBackColor = false;
            btn_Login.Click += button2_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(13F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(881, 497);
            Controls.Add(btn_Login);
            Controls.Add(panel1);
            Controls.Add(ckb_Mostrar);
            Controls.Add(txt_Contraseña);
            Controls.Add(lbl_Contraseña);
            Controls.Add(txt_Usuario);
            Controls.Add(lbl_Usuario);
            Controls.Add(label1);
            Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Login";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbl_Usuario;
        private TextBox txt_Usuario;
        private Label lbl_Contraseña;
        private TextBox txt_Contraseña;
        private CheckBox ckb_Mostrar;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button btn_Login;
    }
}
