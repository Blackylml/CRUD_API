namespace CRUD_API
{
    partial class ProductoPage
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
            dataGridViewProducto = new DataGridView();
            tbNombreProducto = new TextBox();
            tbPrecioProducto = new TextBox();
            tbCantidadProducto = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnAgregarProducto = new Button();
            btnModificarProcuto = new Button();
            btnEliminarProducto = new Button();
            btnRegresarProducto = new Button();
            btnLimpiarProducto = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducto).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewProducto
            // 
            dataGridViewProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducto.Location = new Point(12, 12);
            dataGridViewProducto.Name = "dataGridViewProducto";
            dataGridViewProducto.RowHeadersWidth = 51;
            dataGridViewProducto.Size = new Size(849, 426);
            dataGridViewProducto.TabIndex = 0;
            // 
            // tbNombreProducto
            // 
            tbNombreProducto.BackColor = SystemColors.InactiveCaption;
            tbNombreProducto.Location = new Point(927, 47);
            tbNombreProducto.Name = "tbNombreProducto";
            tbNombreProducto.Size = new Size(251, 27);
            tbNombreProducto.TabIndex = 1;
            // 
            // tbPrecioProducto
            // 
            tbPrecioProducto.BackColor = SystemColors.InactiveCaption;
            tbPrecioProducto.Location = new Point(927, 116);
            tbPrecioProducto.Name = "tbPrecioProducto";
            tbPrecioProducto.Size = new Size(251, 27);
            tbPrecioProducto.TabIndex = 2;
            tbPrecioProducto.KeyPress += tbPrecioProducto_KeyPress;
            // 
            // tbCantidadProducto
            // 
            tbCantidadProducto.BackColor = SystemColors.InactiveCaption;
            tbCantidadProducto.Location = new Point(927, 187);
            tbCantidadProducto.Name = "tbCantidadProducto";
            tbCantidadProducto.Size = new Size(251, 27);
            tbCantidadProducto.TabIndex = 3;
            tbCantidadProducto.KeyDown += tbCantidadProducto_KeyDown;
            tbCantidadProducto.KeyPress += tbCantidadProducto_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(927, 24);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 4;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(927, 93);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 5;
            label2.Text = "Precio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(927, 164);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 6;
            label3.Text = "Cantidad";
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.Location = new Point(952, 353);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(94, 29);
            btnAgregarProducto.TabIndex = 7;
            btnAgregarProducto.Text = "Agregar";
            btnAgregarProducto.UseVisualStyleBackColor = true;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // btnModificarProcuto
            // 
            btnModificarProcuto.Location = new Point(1084, 353);
            btnModificarProcuto.Name = "btnModificarProcuto";
            btnModificarProcuto.Size = new Size(94, 29);
            btnModificarProcuto.TabIndex = 8;
            btnModificarProcuto.Text = "Modificar";
            btnModificarProcuto.UseVisualStyleBackColor = true;
            btnModificarProcuto.Click += btnModificarProcuto_Click;
            // 
            // btnEliminarProducto
            // 
            btnEliminarProducto.Location = new Point(1216, 353);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Size = new Size(94, 29);
            btnEliminarProducto.TabIndex = 9;
            btnEliminarProducto.Text = "Eliminar";
            btnEliminarProducto.UseVisualStyleBackColor = true;
            btnEliminarProducto.Click += btnEliminarProducto_Click;
            // 
            // btnRegresarProducto
            // 
            btnRegresarProducto.Location = new Point(1276, 32);
            btnRegresarProducto.Name = "btnRegresarProducto";
            btnRegresarProducto.Size = new Size(14, 12);
            btnRegresarProducto.TabIndex = 10;
            btnRegresarProducto.Text = "Regresar";
            btnRegresarProducto.UseVisualStyleBackColor = true;
            // 
            // btnLimpiarProducto
            // 
            btnLimpiarProducto.Location = new Point(1216, 291);
            btnLimpiarProducto.Name = "btnLimpiarProducto";
            btnLimpiarProducto.Size = new Size(94, 29);
            btnLimpiarProducto.TabIndex = 11;
            btnLimpiarProducto.Text = "Limpiar";
            btnLimpiarProducto.UseVisualStyleBackColor = true;
            btnLimpiarProducto.Click += btnLimpiarProducto_Click;
            // 
            // ProductoPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1322, 450);
            Controls.Add(btnLimpiarProducto);
            Controls.Add(btnRegresarProducto);
            Controls.Add(btnEliminarProducto);
            Controls.Add(btnModificarProcuto);
            Controls.Add(btnAgregarProducto);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbCantidadProducto);
            Controls.Add(tbPrecioProducto);
            Controls.Add(tbNombreProducto);
            Controls.Add(dataGridViewProducto);
            Name = "ProductoPage";
            Text = "ProductoPage";
            Load += ProductoPage_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewProducto;
        private TextBox tbNombreProducto;
        private TextBox tbPrecioProducto;
        private TextBox tbCantidadProducto;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnAgregarProducto;
        private Button btnModificarProcuto;
        private Button btnEliminarProducto;
        private Button btnRegresarProducto;
        private Button btnLimpiarProducto;
    }
}