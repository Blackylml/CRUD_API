namespace CRUD_API
{
    partial class PageCliente
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
            dataGridViewCliente = new DataGridView();
            tbNombre = new TextBox();
            tbDireccion = new TextBox();
            tbCorreoElectronico = new TextBox();
            tbTelefono = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btnAgregarCliente = new Button();
            btnModificarCliente = new Button();
            btnEliminarCliente = new Button();
            btnRegresarCliente = new Button();
            btnLimpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCliente).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewCliente
            // 
            dataGridViewCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCliente.Location = new Point(12, 12);
            dataGridViewCliente.Name = "dataGridViewCliente";
            dataGridViewCliente.RowHeadersWidth = 51;
            dataGridViewCliente.Size = new Size(883, 426);
            dataGridViewCliente.TabIndex = 0;
            dataGridViewCliente.CellClick += dataGridViewCliente_CellClick;
            // 
            // tbNombre
            // 
            tbNombre.BackColor = SystemColors.InactiveCaption;
            tbNombre.Location = new Point(926, 49);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(210, 27);
            tbNombre.TabIndex = 1;
            // 
            // tbDireccion
            // 
            tbDireccion.BackColor = SystemColors.InactiveCaption;
            tbDireccion.Location = new Point(926, 107);
            tbDireccion.Name = "tbDireccion";
            tbDireccion.Size = new Size(210, 27);
            tbDireccion.TabIndex = 2;
            // 
            // tbCorreoElectronico
            // 
            tbCorreoElectronico.BackColor = SystemColors.InactiveCaption;
            tbCorreoElectronico.Location = new Point(926, 162);
            tbCorreoElectronico.Name = "tbCorreoElectronico";
            tbCorreoElectronico.Size = new Size(210, 27);
            tbCorreoElectronico.TabIndex = 3;
            tbCorreoElectronico.Validating += tbCorreoElectronico_Validating;
            // 
            // tbTelefono
            // 
            tbTelefono.BackColor = SystemColors.InactiveCaption;
            tbTelefono.Location = new Point(926, 214);
            tbTelefono.Name = "tbTelefono";
            tbTelefono.Size = new Size(210, 27);
            tbTelefono.TabIndex = 4;
            tbTelefono.KeyPress += tbTelefono_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(926, 26);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 5;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(926, 84);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 6;
            label2.Text = "Direccion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(926, 139);
            label3.Name = "label3";
            label3.Size = new Size(132, 20);
            label3.TabIndex = 7;
            label3.Text = "Correo Electronico";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(926, 192);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 8;
            label4.Text = "Telefono";
            // 
            // btnAgregarCliente
            // 
            btnAgregarCliente.Location = new Point(952, 299);
            btnAgregarCliente.Name = "btnAgregarCliente";
            btnAgregarCliente.Size = new Size(94, 29);
            btnAgregarCliente.TabIndex = 9;
            btnAgregarCliente.Text = "Agregar";
            btnAgregarCliente.UseVisualStyleBackColor = true;
            btnAgregarCliente.Click += btnAgregarCliente_Click;
            // 
            // btnModificarCliente
            // 
            btnModificarCliente.Location = new Point(1076, 299);
            btnModificarCliente.Name = "btnModificarCliente";
            btnModificarCliente.Size = new Size(94, 29);
            btnModificarCliente.TabIndex = 10;
            btnModificarCliente.Text = "Modificar";
            btnModificarCliente.UseVisualStyleBackColor = true;
            btnModificarCliente.Click += btnModificarCliente_Click;
            // 
            // btnEliminarCliente
            // 
            btnEliminarCliente.Location = new Point(1196, 299);
            btnEliminarCliente.Name = "btnEliminarCliente";
            btnEliminarCliente.Size = new Size(94, 29);
            btnEliminarCliente.TabIndex = 11;
            btnEliminarCliente.Text = "Eliminar";
            btnEliminarCliente.UseVisualStyleBackColor = true;
            btnEliminarCliente.Click += btnEliminarCliente_Click;
            // 
            // btnRegresarCliente
            // 
            btnRegresarCliente.Location = new Point(1280, 12);
            btnRegresarCliente.Name = "btnRegresarCliente";
            btnRegresarCliente.Size = new Size(10, 12);
            btnRegresarCliente.TabIndex = 12;
            btnRegresarCliente.Text = "Regresar";
            btnRegresarCliente.UseVisualStyleBackColor = true;
            btnRegresarCliente.Click += btnRegresarCliente_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(1196, 201);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 13;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // PageCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1322, 450);
            Controls.Add(btnLimpiar);
            Controls.Add(btnRegresarCliente);
            Controls.Add(btnEliminarCliente);
            Controls.Add(btnModificarCliente);
            Controls.Add(btnAgregarCliente);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbTelefono);
            Controls.Add(tbCorreoElectronico);
            Controls.Add(tbDireccion);
            Controls.Add(tbNombre);
            Controls.Add(dataGridViewCliente);
            Name = "PageCliente";
            Text = "PageCliente";
            Load += PageCliente_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCliente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewCliente;
        private TextBox tbNombre;
        private TextBox tbDireccion;
        private TextBox tbCorreoElectronico;
        private TextBox tbTelefono;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnAgregarCliente;
        private Button btnModificarCliente;
        private Button btnEliminarCliente;
        private Button btnRegresarCliente;
        private Button btnLimpiar;
    }
}