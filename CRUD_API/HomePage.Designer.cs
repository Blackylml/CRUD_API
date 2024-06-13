namespace CRUD_API
{
    partial class HomePage
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
            btnCliente = new Button();
            btnCompra = new Button();
            btnProducto = new Button();
            btnProveedor = new Button();
            btnVenta = new Button();
            SuspendLayout();
            // 
            // btnCliente
            // 
            btnCliente.Location = new Point(40, 16);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(200, 100);
            btnCliente.TabIndex = 0;
            btnCliente.Text = "Cliente";
            btnCliente.UseVisualStyleBackColor = true;
            btnCliente.Click += btnCliente_Click;
            // 
            // btnCompra
            // 
            btnCompra.Location = new Point(246, 16);
            btnCompra.Name = "btnCompra";
            btnCompra.Size = new Size(200, 100);
            btnCompra.TabIndex = 1;
            btnCompra.Text = "Compra";
            btnCompra.UseVisualStyleBackColor = true;
            btnCompra.Click += btnCompra_Click;
            // 
            // btnProducto
            // 
            btnProducto.Location = new Point(452, 16);
            btnProducto.Name = "btnProducto";
            btnProducto.Size = new Size(200, 100);
            btnProducto.TabIndex = 2;
            btnProducto.Text = "Producto";
            btnProducto.UseVisualStyleBackColor = true;
            btnProducto.Click += btnProducto_Click;
            // 
            // btnProveedor
            // 
            btnProveedor.Location = new Point(147, 122);
            btnProveedor.Name = "btnProveedor";
            btnProveedor.Size = new Size(200, 100);
            btnProveedor.TabIndex = 3;
            btnProveedor.Text = "Proveedor";
            btnProveedor.UseVisualStyleBackColor = true;
            btnProveedor.Click += button4_Click;
            // 
            // btnVenta
            // 
            btnVenta.Location = new Point(353, 122);
            btnVenta.Name = "btnVenta";
            btnVenta.Size = new Size(200, 100);
            btnVenta.TabIndex = 4;
            btnVenta.Text = "Venta";
            btnVenta.UseVisualStyleBackColor = true;
            btnVenta.Click += btnVenta_Click;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(717, 258);
            Controls.Add(btnVenta);
            Controls.Add(btnProveedor);
            Controls.Add(btnProducto);
            Controls.Add(btnCompra);
            Controls.Add(btnCliente);
            Name = "HomePage";
            Text = "HomePage";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCliente;
        private Button btnCompra;
        private Button btnProducto;
        private Button btnProveedor;
        private Button btnVenta;
    }
}