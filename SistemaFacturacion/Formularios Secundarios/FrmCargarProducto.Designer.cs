﻿namespace SistemaFacturacion
{
	partial class frmProducto
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
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.tabProducto = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnEditar = new System.Windows.Forms.Button();
			this.lblTotalRegistros = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.tbBuscarProducto = new System.Windows.Forms.TextBox();
			this.dgvVistaStock = new System.Windows.Forms.DataGridView();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.label17 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.tbCodigo = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.tbStock = new System.Windows.Forms.TextBox();
			this.cbProveedor = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.tbPrecioVenta = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.tbPrecioCompra = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.tbMarca = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.cbCategoria = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tbNombre = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tabProducto.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvVistaStock)).BeginInit();
			this.tabPage2.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.Location = new System.Drawing.Point(435, 339);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(139, 36);
			this.btnLimpiar.TabIndex = 18;
			this.btnLimpiar.Text = "Limpiar";
			this.btnLimpiar.UseVisualStyleBackColor = true;
			this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
			// 
			// btnGuardar
			// 
			this.btnGuardar.Location = new System.Drawing.Point(290, 339);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(139, 36);
			this.btnGuardar.TabIndex = 20;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
			// 
			// tabProducto
			// 
			this.tabProducto.Controls.Add(this.tabPage1);
			this.tabProducto.Controls.Add(this.tabPage2);
			this.tabProducto.Location = new System.Drawing.Point(2, 2);
			this.tabProducto.Name = "tabProducto";
			this.tabProducto.SelectedIndex = 0;
			this.tabProducto.Size = new System.Drawing.Size(865, 451);
			this.tabProducto.TabIndex = 22;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.btnEliminar);
			this.tabPage1.Controls.Add(this.btnEditar);
			this.tabPage1.Controls.Add(this.lblTotalRegistros);
			this.tabPage1.Controls.Add(this.label9);
			this.tabPage1.Controls.Add(this.tbBuscarProducto);
			this.tabPage1.Controls.Add(this.dgvVistaStock);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(857, 425);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Stock";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// btnEliminar
			// 
			this.btnEliminar.Location = new System.Drawing.Point(517, 385);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(149, 34);
			this.btnEliminar.TabIndex = 9;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// btnEditar
			// 
			this.btnEditar.Location = new System.Drawing.Point(190, 384);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(149, 35);
			this.btnEditar.TabIndex = 8;
			this.btnEditar.Text = "Editar";
			this.btnEditar.UseVisualStyleBackColor = true;
			this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
			// 
			// lblTotalRegistros
			// 
			this.lblTotalRegistros.AutoSize = true;
			this.lblTotalRegistros.Location = new System.Drawing.Point(9, 55);
			this.lblTotalRegistros.Name = "lblTotalRegistros";
			this.lblTotalRegistros.Size = new System.Drawing.Size(54, 13);
			this.lblTotalRegistros.TabIndex = 7;
			this.lblTotalRegistros.Text = "Registros:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(377, 22);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(101, 13);
			this.label9.TabIndex = 6;
			this.label9.Text = "Escribe para buscar";
			// 
			// tbBuscarProducto
			// 
			this.tbBuscarProducto.Location = new System.Drawing.Point(345, 38);
			this.tbBuscarProducto.Name = "tbBuscarProducto";
			this.tbBuscarProducto.Size = new System.Drawing.Size(166, 20);
			this.tbBuscarProducto.TabIndex = 5;
			this.tbBuscarProducto.TextChanged += new System.EventHandler(this.tbBuscarProducto_TextChanged);
			// 
			// dgvVistaStock
			// 
			this.dgvVistaStock.AllowUserToAddRows = false;
			this.dgvVistaStock.AllowUserToDeleteRows = false;
			this.dgvVistaStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvVistaStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvVistaStock.Location = new System.Drawing.Point(12, 71);
			this.dgvVistaStock.Name = "dgvVistaStock";
			this.dgvVistaStock.ReadOnly = true;
			this.dgvVistaStock.Size = new System.Drawing.Size(838, 307);
			this.dgvVistaStock.TabIndex = 4;
			this.dgvVistaStock.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVistaStock_CellDoubleClick);
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.label17);
			this.tabPage2.Controls.Add(this.label16);
			this.tabPage2.Controls.Add(this.label15);
			this.tabPage2.Controls.Add(this.label14);
			this.tabPage2.Controls.Add(this.label13);
			this.tabPage2.Controls.Add(this.label12);
			this.tabPage2.Controls.Add(this.label11);
			this.tabPage2.Controls.Add(this.tbCodigo);
			this.tabPage2.Controls.Add(this.label10);
			this.tabPage2.Controls.Add(this.tbStock);
			this.tabPage2.Controls.Add(this.cbProveedor);
			this.tabPage2.Controls.Add(this.label8);
			this.tabPage2.Controls.Add(this.tbPrecioVenta);
			this.tabPage2.Controls.Add(this.label6);
			this.tabPage2.Controls.Add(this.tbPrecioCompra);
			this.tabPage2.Controls.Add(this.label5);
			this.tabPage2.Controls.Add(this.label4);
			this.tabPage2.Controls.Add(this.tbMarca);
			this.tabPage2.Controls.Add(this.label3);
			this.tabPage2.Controls.Add(this.cbCategoria);
			this.tabPage2.Controls.Add(this.label2);
			this.tabPage2.Controls.Add(this.tbNombre);
			this.tabPage2.Controls.Add(this.label1);
			this.tabPage2.Controls.Add(this.btnGuardar);
			this.tabPage2.Controls.Add(this.btnLimpiar);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(857, 425);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Cargar ";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(635, 165);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(11, 13);
			this.label17.TabIndex = 45;
			this.label17.Text = "*";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(635, 116);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(11, 13);
			this.label16.TabIndex = 44;
			this.label16.Text = "*";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(750, 68);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(11, 13);
			this.label15.TabIndex = 43;
			this.label15.Text = "*";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(360, 71);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(11, 13);
			this.label14.TabIndex = 42;
			this.label14.Text = "*";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(245, 247);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(11, 13);
			this.label13.TabIndex = 41;
			this.label13.Text = "*";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(319, 159);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(11, 13);
			this.label12.TabIndex = 40;
			this.label12.Text = "*";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(338, 116);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(11, 13);
			this.label11.TabIndex = 39;
			this.label11.Text = "*";
			// 
			// tbCodigo
			// 
			this.tbCodigo.Location = new System.Drawing.Point(154, 68);
			this.tbCodigo.Name = "tbCodigo";
			this.tbCodigo.Size = new System.Drawing.Size(200, 20);
			this.tbCodigo.TabIndex = 38;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(95, 68);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(40, 13);
			this.label10.TabIndex = 37;
			this.label10.Text = "Codigo";
			// 
			// tbStock
			// 
			this.tbStock.Location = new System.Drawing.Point(154, 244);
			this.tbStock.Name = "tbStock";
			this.tbStock.Size = new System.Drawing.Size(85, 20);
			this.tbStock.TabIndex = 36;
			// 
			// cbProveedor
			// 
			this.cbProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbProveedor.FormattingEnabled = true;
			this.cbProveedor.Location = new System.Drawing.Point(544, 65);
			this.cbProveedor.Name = "cbProveedor";
			this.cbProveedor.Size = new System.Drawing.Size(200, 21);
			this.cbProveedor.TabIndex = 35;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(468, 68);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(56, 13);
			this.label8.TabIndex = 34;
			this.label8.Text = "Proveedor";
			// 
			// tbPrecioVenta
			// 
			this.tbPrecioVenta.Location = new System.Drawing.Point(544, 162);
			this.tbPrecioVenta.Name = "tbPrecioVenta";
			this.tbPrecioVenta.Size = new System.Drawing.Size(85, 20);
			this.tbPrecioVenta.TabIndex = 32;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(468, 162);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(37, 39);
			this.label6.TabIndex = 31;
			this.label6.Text = "Precio\r\nVenta\r\n\r\n";
			// 
			// tbPrecioCompra
			// 
			this.tbPrecioCompra.Location = new System.Drawing.Point(544, 113);
			this.tbPrecioCompra.Name = "tbPrecioCompra";
			this.tbPrecioCompra.Size = new System.Drawing.Size(85, 20);
			this.tbPrecioCompra.TabIndex = 30;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(468, 113);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(43, 26);
			this.label5.TabIndex = 29;
			this.label5.Text = "Precio\r\nCompra\r\n";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(95, 247);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(35, 13);
			this.label4.TabIndex = 28;
			this.label4.Text = "Stock";
			// 
			// tbMarca
			// 
			this.tbMarca.Location = new System.Drawing.Point(154, 201);
			this.tbMarca.Name = "tbMarca";
			this.tbMarca.Size = new System.Drawing.Size(120, 20);
			this.tbMarca.TabIndex = 27;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(95, 204);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(37, 13);
			this.label3.TabIndex = 26;
			this.label3.Text = "Marca";
			// 
			// cbCategoria
			// 
			this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbCategoria.FormattingEnabled = true;
			this.cbCategoria.Location = new System.Drawing.Point(154, 156);
			this.cbCategoria.Name = "cbCategoria";
			this.cbCategoria.Size = new System.Drawing.Size(159, 21);
			this.cbCategoria.TabIndex = 25;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(95, 159);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 13);
			this.label2.TabIndex = 24;
			this.label2.Text = "Categoria";
			// 
			// tbNombre
			// 
			this.tbNombre.Location = new System.Drawing.Point(154, 113);
			this.tbNombre.Name = "tbNombre";
			this.tbNombre.Size = new System.Drawing.Size(178, 20);
			this.tbNombre.TabIndex = 23;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(95, 116);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 13);
			this.label1.TabIndex = 22;
			this.label1.Text = "Nombre";
			// 
			// frmProducto
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(864, 451);
			this.Controls.Add(this.tabProducto);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.MaximizeBox = false;
			this.Name = "frmProducto";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Productos";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmProducto_FormClosing);
			this.Load += new System.EventHandler(this.frmCargarProducto_Load);
			this.tabProducto.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvVistaStock)).EndInit();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.TabControl tabProducto;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TextBox tbStock;
		private System.Windows.Forms.ComboBox cbProveedor;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox tbPrecioVenta;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox tbPrecioCompra;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tbMarca;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cbCategoria;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbNombre;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblTotalRegistros;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox tbBuscarProducto;
		private System.Windows.Forms.DataGridView dgvVistaStock;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnEditar;
		private System.Windows.Forms.TextBox tbCodigo;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
	}
}