namespace CRUD_API
{
    partial class VentaPage
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
            dataGridViewVenta = new DataGridView();
            tbNombreVenta = new TextBox();
            tbCantidadVenta = new TextBox();
            tbPrecioVenta = new TextBox();
            dtpVenta = new DateTimePicker();
            nombre = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnEliminar = new Button();
            btnModificarVenta = new Button();
            btnAgregarVenta = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVenta).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewVenta
            // 
            dataGridViewVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVenta.Location = new Point(12, 12);
            dataGridViewVenta.Name = "dataGridViewVenta";
            dataGridViewVenta.RowHeadersWidth = 51;
            dataGridViewVenta.Size = new Size(849, 426);
            dataGridViewVenta.TabIndex = 0;
            dataGridViewVenta.CellClick += dataGridViewVenta_CellClick;
            // 
            // tbNombreVenta
            // 
            tbNombreVenta.BackColor = SystemColors.InactiveCaption;
            tbNombreVenta.Location = new Point(902, 83);
            tbNombreVenta.Name = "tbNombreVenta";
            tbNombreVenta.Size = new Size(225, 27);
            tbNombreVenta.TabIndex = 1;
            // 
            // tbCantidadVenta
            // 
            tbCantidadVenta.BackColor = SystemColors.InactiveCaption;
            tbCantidadVenta.Location = new Point(902, 30);
            tbCantidadVenta.Name = "tbCantidadVenta";
            tbCantidadVenta.Size = new Size(225, 27);
            tbCantidadVenta.TabIndex = 2;
            tbCantidadVenta.KeyPress += tbCantidadVenta_KeyPress;
            // 
            // tbPrecioVenta
            // 
            tbPrecioVenta.BackColor = SystemColors.InactiveCaption;
            tbPrecioVenta.Location = new Point(902, 133);
            tbPrecioVenta.Name = "tbPrecioVenta";
            tbPrecioVenta.Size = new Size(225, 27);
            tbPrecioVenta.TabIndex = 3;
            tbPrecioVenta.KeyPress += tbPrecioVenta_KeyPress;
            // 
            // dtpVenta
            // 
            dtpVenta.CustomFormat = "yyyy-MM-dd";
            dtpVenta.Format = DateTimePickerFormat.Custom;
            dtpVenta.Location = new Point(902, 188);
            dtpVenta.Name = "dtpVenta";
            dtpVenta.Size = new Size(250, 27);
            dtpVenta.TabIndex = 4;
            // 
            // nombre
            // 
            nombre.AutoSize = true;
            nombre.Location = new Point(902, 9);
            nombre.Name = "nombre";
            nombre.Size = new Size(127, 20);
            nombre.TabIndex = 5;
            nombre.Text = "Cantidad Vendida";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(902, 60);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 6;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(902, 110);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 7;
            label2.Text = "Precio Unitario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(902, 165);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 8;
            label3.Text = "Fecha";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(1128, 331);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificarVenta
            // 
            btnModificarVenta.Location = new Point(1010, 331);
            btnModificarVenta.Name = "btnModificarVenta";
            btnModificarVenta.Size = new Size(94, 29);
            btnModificarVenta.TabIndex = 10;
            btnModificarVenta.Text = "Modificar";
            btnModificarVenta.UseVisualStyleBackColor = true;
            btnModificarVenta.Click += btnModificarVenta_Click;
            // 
            // btnAgregarVenta
            // 
            btnAgregarVenta.Location = new Point(910, 331);
            btnAgregarVenta.Name = "btnAgregarVenta";
            btnAgregarVenta.Size = new Size(94, 29);
            btnAgregarVenta.TabIndex = 11;
            btnAgregarVenta.Text = "Agregar";
            btnAgregarVenta.UseVisualStyleBackColor = true;
            btnAgregarVenta.Click += btnAgregarVenta_Click;
            // 
            // button4
            // 
            button4.Location = new Point(1189, 146);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 12;
            button4.Text = "Limpiar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // VentaPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1322, 450);
            Controls.Add(button4);
            Controls.Add(btnAgregarVenta);
            Controls.Add(btnModificarVenta);
            Controls.Add(btnEliminar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(nombre);
            Controls.Add(dtpVenta);
            Controls.Add(tbPrecioVenta);
            Controls.Add(tbCantidadVenta);
            Controls.Add(tbNombreVenta);
            Controls.Add(dataGridViewVenta);
            Name = "VentaPage";
            Text = "VentaPage";
            ((System.ComponentModel.ISupportInitialize)dataGridViewVenta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewVenta;
        private TextBox tbNombreVenta;
        private TextBox tbCantidadVenta;
        private TextBox tbPrecioVenta;
        private DateTimePicker dtpVenta;
        private Label nombre;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnEliminar;
        private Button btnModificarVenta;
        private Button btnAgregarVenta;
        private Button button4;
    }
}