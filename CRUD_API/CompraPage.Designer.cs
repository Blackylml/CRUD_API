namespace CRUD_API
{
    partial class PageCompra
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
            dataGridViewCompra = new DataGridView();
            tbCantidadComprada = new TextBox();
            tbNombre = new TextBox();
            tbPrecioUnitario = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnAgregarCompra = new Button();
            btnModificarCompra = new Button();
            btnEliminarCompra = new Button();
            btnLimpiarCompra = new Button();
            btnRegresarCompra = new Button();
            dtpFecha = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCompra).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewCompra
            // 
            dataGridViewCompra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCompra.Location = new Point(12, 12);
            dataGridViewCompra.Name = "dataGridViewCompra";
            dataGridViewCompra.RowHeadersWidth = 51;
            dataGridViewCompra.Size = new Size(849, 426);
            dataGridViewCompra.TabIndex = 0;
            dataGridViewCompra.CellClick += dataGridViewCompra_CellClick;
            // 
            // tbCantidadComprada
            // 
            tbCantidadComprada.BackColor = SystemColors.InactiveCaption;
            tbCantidadComprada.Location = new Point(884, 37);
            tbCantidadComprada.Name = "tbCantidadComprada";
            tbCantidadComprada.Size = new Size(211, 27);
            tbCantidadComprada.TabIndex = 1;
            tbCantidadComprada.KeyPress += tbCantidadComprada_KeyPress;
            // 
            // tbNombre
            // 
            tbNombre.BackColor = SystemColors.InactiveCaption;
            tbNombre.Location = new Point(884, 105);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(211, 27);
            tbNombre.TabIndex = 2;
            // 
            // tbPrecioUnitario
            // 
            tbPrecioUnitario.BackColor = SystemColors.InactiveCaption;
            tbPrecioUnitario.Location = new Point(884, 242);
            tbPrecioUnitario.Name = "tbPrecioUnitario";
            tbPrecioUnitario.Size = new Size(211, 27);
            tbPrecioUnitario.TabIndex = 4;
            tbPrecioUnitario.KeyPress += tbPrecioUnitario_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(884, 14);
            label1.Name = "label1";
            label1.Size = new Size(143, 20);
            label1.TabIndex = 5;
            label1.Text = "Cantidad Comprada";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(884, 82);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 6;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(884, 155);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 7;
            label3.Text = "Fecha";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(884, 219);
            label4.Name = "label4";
            label4.Size = new Size(107, 20);
            label4.TabIndex = 8;
            label4.Text = "Precio Unitario";
            // 
            // btnAgregarCompra
            // 
            btnAgregarCompra.Location = new Point(933, 315);
            btnAgregarCompra.Name = "btnAgregarCompra";
            btnAgregarCompra.Size = new Size(94, 29);
            btnAgregarCompra.TabIndex = 9;
            btnAgregarCompra.Text = "Agregar";
            btnAgregarCompra.UseVisualStyleBackColor = true;
            btnAgregarCompra.Click += btnAgregarCompra_Click;
            // 
            // btnModificarCompra
            // 
            btnModificarCompra.Location = new Point(1043, 315);
            btnModificarCompra.Name = "btnModificarCompra";
            btnModificarCompra.Size = new Size(94, 29);
            btnModificarCompra.TabIndex = 10;
            btnModificarCompra.Text = "Modificar";
            btnModificarCompra.UseVisualStyleBackColor = true;
            btnModificarCompra.Click += btnModificarCompra_Click;
            // 
            // btnEliminarCompra
            // 
            btnEliminarCompra.Location = new Point(1160, 315);
            btnEliminarCompra.Name = "btnEliminarCompra";
            btnEliminarCompra.Size = new Size(94, 29);
            btnEliminarCompra.TabIndex = 11;
            btnEliminarCompra.Text = "Eliminar";
            btnEliminarCompra.UseVisualStyleBackColor = true;
            btnEliminarCompra.Click += btnEliminarCompra_Click;
            // 
            // btnLimpiarCompra
            // 
            btnLimpiarCompra.Location = new Point(1160, 240);
            btnLimpiarCompra.Name = "btnLimpiarCompra";
            btnLimpiarCompra.Size = new Size(94, 29);
            btnLimpiarCompra.TabIndex = 12;
            btnLimpiarCompra.Text = "Limpiar";
            btnLimpiarCompra.UseVisualStyleBackColor = true;
            btnLimpiarCompra.Click += btnLimpiarCompra_Click;
            // 
            // btnRegresarCompra
            // 
            btnRegresarCompra.Location = new Point(1300, 428);
            btnRegresarCompra.Name = "btnRegresarCompra";
            btnRegresarCompra.Size = new Size(10, 10);
            btnRegresarCompra.TabIndex = 13;
            btnRegresarCompra.Text = "Regresar";
            btnRegresarCompra.UseVisualStyleBackColor = true;
            btnRegresarCompra.Click += btnRegresarCompra_Click;
            // 
            // dtpFecha
            // 
            dtpFecha.CustomFormat = "yyyy-MM-dd";
            dtpFecha.Location = new Point(884, 178);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(250, 27);
            dtpFecha.TabIndex = 14;
            // 
            // PageCompra
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1322, 450);
            Controls.Add(dtpFecha);
            Controls.Add(btnRegresarCompra);
            Controls.Add(btnLimpiarCompra);
            Controls.Add(btnEliminarCompra);
            Controls.Add(btnModificarCompra);
            Controls.Add(btnAgregarCompra);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbPrecioUnitario);
            Controls.Add(tbNombre);
            Controls.Add(tbCantidadComprada);
            Controls.Add(dataGridViewCompra);
            Name = "PageCompra";
            Text = "CompraPage";
            ((System.ComponentModel.ISupportInitialize)dataGridViewCompra).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewCompra;
        private TextBox tbCantidadComprada;
        private TextBox tbNombre;
        private TextBox tbPrecioUnitario;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnAgregarCompra;
        private Button btnModificarCompra;
        private Button btnEliminarCompra;
        private Button btnLimpiarCompra;
        private Button btnRegresarCompra;
        private DateTimePicker dtpFecha;
    }
}