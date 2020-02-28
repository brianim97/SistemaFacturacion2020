namespace SistemaFacturacion
{
	partial class frmCargarProducto
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
			this.label1 = new System.Windows.Forms.Label();
			this.tbNombre = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cbCategoria = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tbMarca = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.tbPrecioCompra = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.tbPrecioVenta = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.dtpFecha_Vencimiento = new System.Windows.Forms.DateTimePicker();
			this.label8 = new System.Windows.Forms.Label();
			this.cbProveedor = new System.Windows.Forms.ComboBox();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.tbStock = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(15, 42);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nombre";
			// 
			// tbNombre
			// 
			this.tbNombre.Location = new System.Drawing.Point(74, 39);
			this.tbNombre.Name = "tbNombre";
			this.tbNombre.Size = new System.Drawing.Size(251, 20);
			this.tbNombre.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(15, 85);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Categoria";
			// 
			// cbCategoria
			// 
			this.cbCategoria.FormattingEnabled = true;
			this.cbCategoria.Location = new System.Drawing.Point(74, 82);
			this.cbCategoria.Name = "cbCategoria";
			this.cbCategoria.Size = new System.Drawing.Size(242, 21);
			this.cbCategoria.TabIndex = 3;
	
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(15, 130);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(37, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Marca";
			// 
			// tbMarca
			// 
			this.tbMarca.Location = new System.Drawing.Point(74, 127);
			this.tbMarca.Name = "tbMarca";
			this.tbMarca.Size = new System.Drawing.Size(251, 20);
			this.tbMarca.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(15, 173);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(35, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Stock";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(15, 215);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(43, 26);
			this.label5.TabIndex = 9;
			this.label5.Text = "Precio\r\nCompra\r\n";
			// 
			// tbPrecioCompra
			// 
			this.tbPrecioCompra.Location = new System.Drawing.Point(74, 215);
			this.tbPrecioCompra.Name = "tbPrecioCompra";
			this.tbPrecioCompra.Size = new System.Drawing.Size(120, 20);
			this.tbPrecioCompra.TabIndex = 10;
			this.tbPrecioCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPrecioCompra_KeyPress);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(15, 264);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(37, 39);
			this.label6.TabIndex = 11;
			this.label6.Text = "Precio\r\nVenta\r\n\r\n";
			// 
			// tbPrecioVenta
			// 
			this.tbPrecioVenta.Location = new System.Drawing.Point(74, 264);
			this.tbPrecioVenta.Name = "tbPrecioVenta";
			this.tbPrecioVenta.Size = new System.Drawing.Size(120, 20);
			this.tbPrecioVenta.TabIndex = 12;
			this.tbPrecioVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPrecioVenta_KeyPress);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(424, 33);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(68, 26);
			this.label7.TabIndex = 13;
			this.label7.Text = "Fecha \r\nVecnimiento ";
			// 
			// dtpFecha_Vencimiento
			// 
			this.dtpFecha_Vencimiento.Location = new System.Drawing.Point(505, 36);
			this.dtpFecha_Vencimiento.Name = "dtpFecha_Vencimiento";
			this.dtpFecha_Vencimiento.Size = new System.Drawing.Size(200, 20);
			this.dtpFecha_Vencimiento.TabIndex = 14;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(424, 85);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(56, 13);
			this.label8.TabIndex = 15;
			this.label8.Text = "Proveedor";
			// 
			// cbProveedor
			// 
			this.cbProveedor.FormattingEnabled = true;
			this.cbProveedor.Location = new System.Drawing.Point(505, 82);
			this.cbProveedor.Name = "cbProveedor";
			this.cbProveedor.Size = new System.Drawing.Size(200, 21);
			this.cbProveedor.TabIndex = 16;
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.Location = new System.Drawing.Point(521, 218);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(139, 36);
			this.btnLimpiar.TabIndex = 18;
			this.btnLimpiar.Text = "Limpiar";
			this.btnLimpiar.UseVisualStyleBackColor = true;
			this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
			// 
			// btnGuardar
			// 
			this.btnGuardar.Location = new System.Drawing.Point(521, 173);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(139, 36);
			this.btnGuardar.TabIndex = 20;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
			// 
			// tbStock
			// 
			this.tbStock.Location = new System.Drawing.Point(74, 170);
			this.tbStock.Name = "tbStock";
			this.tbStock.Size = new System.Drawing.Size(120, 20);
			this.tbStock.TabIndex = 21;
		
			this.tbStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbStock_KeyPress);
			// 
			// frmCargarProducto
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 324);
			this.Controls.Add(this.tbStock);
			this.Controls.Add(this.btnLimpiar);
			this.Controls.Add(this.cbProveedor);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.dtpFecha_Vencimiento);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.tbPrecioVenta);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.tbPrecioCompra);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.tbMarca);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.cbCategoria);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tbNombre);
			this.Controls.Add(this.label1);
			this.Name = "frmCargarProducto";
			this.Text = "Cargar Producto";
			this.Load += new System.EventHandler(this.frmCargarProducto_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbNombre;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cbCategoria;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbMarca;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox tbPrecioCompra;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox tbPrecioVenta;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.DateTimePicker dtpFecha_Vencimiento;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ComboBox cbProveedor;
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.TextBox tbStock;
	}
}