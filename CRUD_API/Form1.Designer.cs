namespace CRUD_API
{
    partial class Form1
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
            tbUsuarioLogin = new TextBox();
            tbContraseñaLogin = new TextBox();
            btnLogin = new Button();
            label1 = new Label();
            label2 = new Label();
            btnRegistro = new Button();
            SuspendLayout();
            // 
            // tbUsuarioLogin
            // 
            tbUsuarioLogin.BackColor = SystemColors.ScrollBar;
            tbUsuarioLogin.Location = new Point(98, 91);
            tbUsuarioLogin.Name = "tbUsuarioLogin";
            tbUsuarioLogin.Size = new Size(241, 27);
            tbUsuarioLogin.TabIndex = 0;
            // 
            // tbContraseñaLogin
            // 
            tbContraseñaLogin.BackColor = SystemColors.ScrollBar;
            tbContraseñaLogin.Location = new Point(98, 191);
            tbContraseñaLogin.Name = "tbContraseñaLogin";
            tbContraseñaLogin.PasswordChar = '*';
            tbContraseñaLogin.Size = new Size(241, 27);
            tbContraseñaLogin.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(168, 285);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 46);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Ingresar";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(98, 51);
            label1.Name = "label1";
            label1.Size = new Size(132, 20);
            label1.TabIndex = 3;
            label1.Text = "Correo Electronico";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(98, 157);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 4;
            label2.Text = "Contraseña";
            // 
            // btnRegistro
            // 
            btnRegistro.Location = new Point(116, 372);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(196, 29);
            btnRegistro.TabIndex = 5;
            btnRegistro.Text = "Registrate Aqui";
            btnRegistro.UseVisualStyleBackColor = true;
            btnRegistro.Click += btnRegistro_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 413);
            Controls.Add(btnRegistro);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLogin);
            Controls.Add(tbContraseñaLogin);
            Controls.Add(tbUsuarioLogin);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbUsuarioLogin;
        private TextBox tbContraseñaLogin;
        private Button btnLogin;
        private Label label1;
        private Label label2;
        private Button btnRegistro;
    }
}
