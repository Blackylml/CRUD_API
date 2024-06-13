namespace CRUD_API
{
    partial class Registro
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
            tbCorreo = new TextBox();
            tbContraseña = new TextBox();
            tbContraseñaConfirmar = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnRegistro = new Button();
            btnRegreso = new Button();
            label4 = new Label();
            tbNombre = new TextBox();
            SuspendLayout();
            // 
            // tbCorreo
            // 
            tbCorreo.BackColor = SystemColors.InactiveCaption;
            tbCorreo.Location = new Point(105, 120);
            tbCorreo.Name = "tbCorreo";
            tbCorreo.Size = new Size(224, 27);
            tbCorreo.TabIndex = 1;
            tbCorreo.Leave += tbCorreo_Leave;
            // 
            // tbContraseña
            // 
            tbContraseña.BackColor = SystemColors.InactiveCaption;
            tbContraseña.Location = new Point(105, 180);
            tbContraseña.Name = "tbContraseña";
            tbContraseña.PasswordChar = '*';
            tbContraseña.Size = new Size(224, 27);
            tbContraseña.TabIndex = 1;
            // 
            // tbContraseñaConfirmar
            // 
            tbContraseñaConfirmar.BackColor = SystemColors.InactiveCaption;
            tbContraseñaConfirmar.Location = new Point(105, 244);
            tbContraseñaConfirmar.Name = "tbContraseñaConfirmar";
            tbContraseñaConfirmar.PasswordChar = '*';
            tbContraseñaConfirmar.Size = new Size(224, 27);
            tbContraseñaConfirmar.TabIndex = 2;
            tbContraseñaConfirmar.Leave += tbContraseñaConfirmar_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(105, 97);
            label1.Name = "label1";
            label1.Size = new Size(132, 20);
            label1.TabIndex = 3;
            label1.Text = "Correo Electronico";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(105, 157);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 4;
            label2.Text = "Contraseña";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(105, 221);
            label3.Name = "label3";
            label3.Size = new Size(153, 20);
            label3.TabIndex = 5;
            label3.Text = "Confirmar Contraseña";
            // 
            // btnRegistro
            // 
            btnRegistro.Location = new Point(166, 304);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(94, 29);
            btnRegistro.TabIndex = 6;
            btnRegistro.Text = "Registro";
            btnRegistro.UseVisualStyleBackColor = true;
            btnRegistro.Click += btnRegistro_Click;
            // 
            // btnRegreso
            // 
            btnRegreso.Location = new Point(345, 358);
            btnRegreso.Name = "btnRegreso";
            btnRegreso.Size = new Size(94, 29);
            btnRegreso.TabIndex = 7;
            btnRegreso.Text = "Regresar";
            btnRegreso.UseVisualStyleBackColor = true;
            btnRegreso.Click += btnRegreso_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(105, 44);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 9;
            label4.Text = "Nombre";
            // 
            // tbNombre
            // 
            tbNombre.BackColor = SystemColors.InactiveCaption;
            tbNombre.Location = new Point(105, 67);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(224, 27);
            tbNombre.TabIndex = 0;
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 413);
            Controls.Add(label4);
            Controls.Add(tbNombre);
            Controls.Add(btnRegreso);
            Controls.Add(btnRegistro);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbContraseñaConfirmar);
            Controls.Add(tbContraseña);
            Controls.Add(tbCorreo);
            Name = "Registro";
            Text = "Registro";
            Load += Registro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbCorreo;
        private TextBox tbContraseña;
        private TextBox tbContraseñaConfirmar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnRegistro;
        private Button btnRegreso;
        private Label label4;
        private TextBox tbNombre;
    }
}