namespace CRUD_API
{
    partial class PageProveedor
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
            dataGridViewProveedor = new DataGridView();
            btnAgregarProveedor = new Button();
            btnModificarProveedor = new Button();
            btnEliminarProveedor = new Button();
            btnRegresarProveedor = new Button();
            btnLimpiarProveedor = new Button();
            tbNombreProveedor = new TextBox();
            tbDireccionProveedor = new TextBox();
            tbCorreoElectronicoProveedor = new TextBox();
            tbTelefonoProveedor = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProveedor).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewProveedor
            // 
            dataGridViewProveedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProveedor.Location = new Point(12, 12);
            dataGridViewProveedor.Name = "dataGridViewProveedor";
            dataGridViewProveedor.RowHeadersWidth = 51;
            dataGridViewProveedor.Size = new Size(883, 426);
            dataGridViewProveedor.TabIndex = 0;
            dataGridViewProveedor.CellClick += dataGridViewProveedor_CellClick;
            // 
            // btnAgregarProveedor
            // 
            btnAgregarProveedor.Location = new Point(938, 345);
            btnAgregarProveedor.Name = "btnAgregarProveedor";
            btnAgregarProveedor.Size = new Size(94, 29);
            btnAgregarProveedor.TabIndex = 1;
            btnAgregarProveedor.Text = "Agregar";
            btnAgregarProveedor.UseVisualStyleBackColor = true;
            btnAgregarProveedor.Click += btnAgregarProveedor_Click;
            // 
            // btnModificarProveedor
            // 
            btnModificarProveedor.Location = new Point(1039, 345);
            btnModificarProveedor.Name = "btnModificarProveedor";
            btnModificarProveedor.Size = new Size(94, 29);
            btnModificarProveedor.TabIndex = 2;
            btnModificarProveedor.Text = "Modificar";
            btnModificarProveedor.UseVisualStyleBackColor = true;
            btnModificarProveedor.Click += btnModificarProveedor_Click;
            // 
            // btnEliminarProveedor
            // 
            btnEliminarProveedor.Location = new Point(1139, 345);
            btnEliminarProveedor.Name = "btnEliminarProveedor";
            btnEliminarProveedor.Size = new Size(94, 29);
            btnEliminarProveedor.TabIndex = 3;
            btnEliminarProveedor.Text = "Eliminar";
            btnEliminarProveedor.UseVisualStyleBackColor = true;
            btnEliminarProveedor.Click += btnEliminarProveedor_Click;
            // 
            // btnRegresarProveedor
            // 
            btnRegresarProveedor.Location = new Point(1300, 12);
            btnRegresarProveedor.Name = "btnRegresarProveedor";
            btnRegresarProveedor.Size = new Size(10, 25);
            btnRegresarProveedor.TabIndex = 4;
            btnRegresarProveedor.Text = "Regresar";
            btnRegresarProveedor.UseVisualStyleBackColor = true;
            btnRegresarProveedor.Click += btnRegresarProveedor_Click;
            // 
            // btnLimpiarProveedor
            // 
            btnLimpiarProveedor.Location = new Point(1205, 277);
            btnLimpiarProveedor.Name = "btnLimpiarProveedor";
            btnLimpiarProveedor.Size = new Size(94, 29);
            btnLimpiarProveedor.TabIndex = 5;
            btnLimpiarProveedor.Text = "Limpiar";
            btnLimpiarProveedor.UseVisualStyleBackColor = true;
            btnLimpiarProveedor.Click += btnLimpiarProveedor_Click;
            // 
            // tbNombreProveedor
            // 
            tbNombreProveedor.BackColor = SystemColors.InactiveCaption;
            tbNombreProveedor.Location = new Point(938, 60);
            tbNombreProveedor.Name = "tbNombreProveedor";
            tbNombreProveedor.Size = new Size(276, 27);
            tbNombreProveedor.TabIndex = 6;
            // 
            // tbDireccionProveedor
            // 
            tbDireccionProveedor.BackColor = SystemColors.InactiveCaption;
            tbDireccionProveedor.Location = new Point(938, 107);
            tbDireccionProveedor.Name = "tbDireccionProveedor";
            tbDireccionProveedor.Size = new Size(276, 27);
            tbDireccionProveedor.TabIndex = 7;
            // 
            // tbCorreoElectronicoProveedor
            // 
            tbCorreoElectronicoProveedor.BackColor = SystemColors.InactiveCaption;
            tbCorreoElectronicoProveedor.Location = new Point(938, 157);
            tbCorreoElectronicoProveedor.Name = "tbCorreoElectronicoProveedor";
            tbCorreoElectronicoProveedor.Size = new Size(276, 27);
            tbCorreoElectronicoProveedor.TabIndex = 8;
            tbCorreoElectronicoProveedor.Validating += tbCorreoElectronicoProveedor_Validating;
            // 
            // tbTelefonoProveedor
            // 
            tbTelefonoProveedor.BackColor = SystemColors.InactiveCaption;
            tbTelefonoProveedor.Location = new Point(938, 204);
            tbTelefonoProveedor.Name = "tbTelefonoProveedor";
            tbTelefonoProveedor.Size = new Size(276, 27);
            tbTelefonoProveedor.TabIndex = 9;
            tbTelefonoProveedor.KeyPress += tbTelefonoProveedor_KeyPress;
            tbTelefonoProveedor.Validating += tbTelefonoProveedor_Validating;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(938, 37);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 10;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(938, 90);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 11;
            label2.Text = "Direccion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(938, 137);
            label3.Name = "label3";
            label3.Size = new Size(132, 20);
            label3.TabIndex = 12;
            label3.Text = "Correo Electronico";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(938, 187);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 13;
            label4.Text = "Telefono";
            // 
            // PageProveedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1322, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbTelefonoProveedor);
            Controls.Add(tbCorreoElectronicoProveedor);
            Controls.Add(tbDireccionProveedor);
            Controls.Add(tbNombreProveedor);
            Controls.Add(btnLimpiarProveedor);
            Controls.Add(btnRegresarProveedor);
            Controls.Add(btnEliminarProveedor);
            Controls.Add(btnModificarProveedor);
            Controls.Add(btnAgregarProveedor);
            Controls.Add(dataGridViewProveedor);
            Name = "PageProveedor";
            Text = "PageProveedor";
            ((System.ComponentModel.ISupportInitialize)dataGridViewProveedor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewProveedor;
        private Button btnAgregarProveedor;
        private Button btnModificarProveedor;
        private Button btnEliminarProveedor;
        private Button btnRegresarProveedor;
        private Button btnLimpiarProveedor;
        private TextBox tbNombreProveedor;
        private TextBox tbDireccionProveedor;
        private TextBox tbCorreoElectronicoProveedor;
        private TextBox tbTelefonoProveedor;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}