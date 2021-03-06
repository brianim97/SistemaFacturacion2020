﻿namespace SistemaFacturacion
{
	partial class FrmFacturacion
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnClientes = new System.Windows.Forms.Button();
			this.BtnEliminar = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.btnFacturar = new System.Windows.Forms.Button();
			this.btnColocar = new System.Windows.Forms.Button();
			this.btnBuscarClientes = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnBuscarProducto = new System.Windows.Forms.Button();
			this.lblClienteNombre = new System.Windows.Forms.Label();
			this.lblAtiende = new System.Windows.Forms.Label();
			this.tbCantidad = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.lblTotal = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.tbCodigoProd = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.pbLogoComercio = new System.Windows.Forms.PictureBox();
			this.tbDniCliente = new System.Windows.Forms.TextBox();
			this.dgvFacturacion = new System.Windows.Forms.DataGridView();
			this.ColCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColImporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbLogoComercio)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvFacturacion)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnClientes);
			this.panel1.Controls.Add(this.BtnEliminar);
			this.panel1.Controls.Add(this.button6);
			this.panel1.Controls.Add(this.button5);
			this.panel1.Controls.Add(this.btnFacturar);
			this.panel1.Controls.Add(this.btnColocar);
			this.panel1.Location = new System.Drawing.Point(0, 167);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(120, 377);
			this.panel1.TabIndex = 0;
			// 
			// btnClientes
			// 
			this.btnClientes.Location = new System.Drawing.Point(0, 171);
			this.btnClientes.Name = "btnClientes";
			this.btnClientes.Size = new System.Drawing.Size(115, 35);
			this.btnClientes.TabIndex = 8;
			this.btnClientes.Text = "CLIENTES";
			this.btnClientes.UseVisualStyleBackColor = true;
			this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click_1);
			// 
			// BtnEliminar
			// 
			this.BtnEliminar.Location = new System.Drawing.Point(0, 44);
			this.BtnEliminar.Name = "BtnEliminar";
			this.BtnEliminar.Size = new System.Drawing.Size(115, 35);
			this.BtnEliminar.TabIndex = 7;
			this.BtnEliminar.Text = "ELIMINAR";
			this.BtnEliminar.UseVisualStyleBackColor = true;
			this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(0, 85);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(115, 35);
			this.button6.TabIndex = 5;
			this.button6.Text = "PRODUCTOS";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(0, 130);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(115, 35);
			this.button5.TabIndex = 4;
			this.button5.Text = "NUEVO";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// btnFacturar
			// 
			this.btnFacturar.Location = new System.Drawing.Point(0, 254);
			this.btnFacturar.Name = "btnFacturar";
			this.btnFacturar.Size = new System.Drawing.Size(115, 122);
			this.btnFacturar.TabIndex = 1;
			this.btnFacturar.Text = "FACTURAR";
			this.btnFacturar.UseVisualStyleBackColor = true;
			this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
			// 
			// btnColocar
			// 
			this.btnColocar.Location = new System.Drawing.Point(0, 3);
			this.btnColocar.Name = "btnColocar";
			this.btnColocar.Size = new System.Drawing.Size(115, 35);
			this.btnColocar.TabIndex = 0;
			this.btnColocar.Text = "COLOCAR";
			this.btnColocar.UseVisualStyleBackColor = true;
			this.btnColocar.Click += new System.EventHandler(this.btnColocar_Click);
			// 
			// btnBuscarClientes
			// 
			this.btnBuscarClientes.Location = new System.Drawing.Point(352, 55);
			this.btnBuscarClientes.Name = "btnBuscarClientes";
			this.btnBuscarClientes.Size = new System.Drawing.Size(108, 27);
			this.btnBuscarClientes.TabIndex = 6;
			this.btnBuscarClientes.Text = "Buscar Cliente";
			this.btnBuscarClientes.UseVisualStyleBackColor = true;
			this.btnBuscarClientes.Click += new System.EventHandler(this.btnBuscarClientes_Click);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.btnBuscarProducto);
			this.panel2.Controls.Add(this.btnBuscarClientes);
			this.panel2.Controls.Add(this.lblClienteNombre);
			this.panel2.Controls.Add(this.lblAtiende);
			this.panel2.Controls.Add(this.panel1);
			this.panel2.Controls.Add(this.tbCantidad);
			this.panel2.Controls.Add(this.label10);
			this.panel2.Controls.Add(this.lblTotal);
			this.panel2.Controls.Add(this.label8);
			this.panel2.Controls.Add(this.tbCodigoProd);
			this.panel2.Controls.Add(this.label7);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.pbLogoComercio);
			this.panel2.Controls.Add(this.tbDniCliente);
			this.panel2.Controls.Add(this.dgvFacturacion);
			this.panel2.Location = new System.Drawing.Point(3, -2);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(849, 544);
			this.panel2.TabIndex = 1;
			this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
			// 
			// btnBuscarProducto
			// 
			this.btnBuscarProducto.Location = new System.Drawing.Point(254, 171);
			this.btnBuscarProducto.Name = "btnBuscarProducto";
			this.btnBuscarProducto.Size = new System.Drawing.Size(261, 22);
			this.btnBuscarProducto.TabIndex = 8;
			this.btnBuscarProducto.Text = "Buscar Producto";
			this.btnBuscarProducto.UseVisualStyleBackColor = true;
			this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarDescr_Click);
			// 
			// lblClienteNombre
			// 
			this.lblClienteNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblClienteNombre.Font = new System.Drawing.Font("Multicolore", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblClienteNombre.Location = new System.Drawing.Point(105, 88);
			this.lblClienteNombre.Name = "lblClienteNombre";
			this.lblClienteNombre.Size = new System.Drawing.Size(355, 29);
			this.lblClienteNombre.TabIndex = 29;
			// 
			// lblAtiende
			// 
			this.lblAtiende.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblAtiende.Font = new System.Drawing.Font("Multicolore", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAtiende.Location = new System.Drawing.Point(105, 23);
			this.lblAtiende.Name = "lblAtiende";
			this.lblAtiende.Size = new System.Drawing.Size(355, 29);
			this.lblAtiende.TabIndex = 28;
			// 
			// tbCantidad
			// 
			this.tbCantidad.Location = new System.Drawing.Point(617, 172);
			this.tbCantidad.Name = "tbCantidad";
			this.tbCantidad.Size = new System.Drawing.Size(78, 20);
			this.tbCantidad.TabIndex = 27;
			this.tbCantidad.Text = "1";
			this.tbCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label10.Location = new System.Drawing.Point(246, 201);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(259, 24);
			this.label10.TabIndex = 24;
			this.label10.Text = "DESCRIPCION";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblTotal
			// 
			this.lblTotal.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.lblTotal.Font = new System.Drawing.Font("Multicolore", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTotal.Location = new System.Drawing.Point(720, 501);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(126, 30);
			this.lblTotal.TabIndex = 23;
			this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Multicolore", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(648, 508);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(66, 18);
			this.label8.TabIndex = 22;
			this.label8.Text = "TOTAL:";
			// 
			// tbCodigoProd
			// 
			this.tbCodigoProd.Location = new System.Drawing.Point(128, 172);
			this.tbCodigoProd.Name = "tbCodigoProd";
			this.tbCodigoProd.Size = new System.Drawing.Size(120, 20);
			this.tbCodigoProd.TabIndex = 21;
			this.tbCodigoProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.tbCodigoProd.TextChanged += new System.EventHandler(this.tbCodigoProd_TextChanged);
			this.tbCodigoProd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCodigoProd_KeyPress);
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label7.Location = new System.Drawing.Point(690, 201);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(156, 24);
			this.label7.TabIndex = 18;
			this.label7.Text = "IMPORTE";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label6.Location = new System.Drawing.Point(617, 201);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(78, 24);
			this.label6.TabIndex = 17;
			this.label6.Text = "CANTIDAD";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label4.Location = new System.Drawing.Point(126, 201);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(122, 24);
			this.label4.TabIndex = 16;
			this.label4.Text = "CODIGO";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(14, 94);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(52, 13);
			this.label3.TabIndex = 15;
			this.label3.Text = "CLIENTE";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(14, 63);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(85, 13);
			this.label2.TabIndex = 14;
			this.label2.Text = "DNI/CUIT/CUIL";
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label5.Location = new System.Drawing.Point(502, 201);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(119, 24);
			this.label5.TabIndex = 13;
			this.label5.Text = "PRECIO";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(14, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(70, 13);
			this.label1.TabIndex = 9;
			this.label1.Text = "LE ATIENDE";
			// 
			// pbLogoComercio
			// 
			this.pbLogoComercio.Location = new System.Drawing.Point(473, 3);
			this.pbLogoComercio.Name = "pbLogoComercio";
			this.pbLogoComercio.Size = new System.Drawing.Size(373, 143);
			this.pbLogoComercio.TabIndex = 8;
			this.pbLogoComercio.TabStop = false;
			// 
			// tbDniCliente
			// 
			this.tbDniCliente.Font = new System.Drawing.Font("Multicolore", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbDniCliente.Location = new System.Drawing.Point(105, 56);
			this.tbDniCliente.Name = "tbDniCliente";
			this.tbDniCliente.Size = new System.Drawing.Size(246, 26);
			this.tbDniCliente.TabIndex = 7;
			this.tbDniCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDniCliente_KeyPress);
			// 
			// dgvFacturacion
			// 
			this.dgvFacturacion.AllowUserToAddRows = false;
			this.dgvFacturacion.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvFacturacion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvFacturacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvFacturacion.ColumnHeadersVisible = false;
			this.dgvFacturacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColCodigo,
            this.ColDescripcion,
            this.ColPrecio,
            this.ColCantidad,
            this.ColImporte});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvFacturacion.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgvFacturacion.Location = new System.Drawing.Point(126, 225);
			this.dgvFacturacion.Name = "dgvFacturacion";
			this.dgvFacturacion.ReadOnly = true;
			this.dgvFacturacion.RowHeadersVisible = false;
			this.dgvFacturacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvFacturacion.Size = new System.Drawing.Size(720, 268);
			this.dgvFacturacion.TabIndex = 0;
			// 
			// ColCodigo
			// 
			this.ColCodigo.FillWeight = 83.33334F;
			this.ColCodigo.HeaderText = "Codigo";
			this.ColCodigo.Name = "ColCodigo";
			this.ColCodigo.ReadOnly = true;
			this.ColCodigo.Width = 120;
			// 
			// ColDescripcion
			// 
			this.ColDescripcion.FillWeight = 188.6093F;
			this.ColDescripcion.HeaderText = "Descripcion";
			this.ColDescripcion.Name = "ColDescripcion";
			this.ColDescripcion.ReadOnly = true;
			this.ColDescripcion.Width = 272;
			// 
			// ColPrecio
			// 
			this.ColPrecio.FillWeight = 61.01797F;
			this.ColPrecio.HeaderText = "Precio";
			this.ColPrecio.Name = "ColPrecio";
			this.ColPrecio.ReadOnly = true;
			this.ColPrecio.Width = 87;
			// 
			// ColCantidad
			// 
			this.ColCantidad.FillWeight = 73.93642F;
			this.ColCantidad.HeaderText = "Cantidad";
			this.ColCantidad.Name = "ColCantidad";
			this.ColCantidad.ReadOnly = true;
			this.ColCantidad.Width = 107;
			// 
			// ColImporte
			// 
			this.ColImporte.FillWeight = 93.10295F;
			this.ColImporte.HeaderText = "Importe";
			this.ColImporte.Name = "ColImporte";
			this.ColImporte.ReadOnly = true;
			this.ColImporte.Width = 134;
			// 
			// FrmFacturacion
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(851, 543);
			this.Controls.Add(this.panel2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.MaximizeBox = false;
			this.Name = "FrmFacturacion";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Facturacion";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmFacturacion_FormClosing);
			this.Load += new System.EventHandler(this.FrmFacturacion_Load);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbLogoComercio)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvFacturacion)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button BtnEliminar;
		private System.Windows.Forms.Button btnBuscarClientes;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button btnFacturar;
		private System.Windows.Forms.Button btnColocar;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.DataGridView dgvFacturacion;
		private System.Windows.Forms.Label lblAtiende;
		private System.Windows.Forms.TextBox tbCantidad;
		private System.Windows.Forms.Label lblTotal;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox tbCodigoProd;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pbLogoComercio;
		private System.Windows.Forms.TextBox tbDniCliente;
		private System.Windows.Forms.Label lblClienteNombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColCodigo;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColDescripcion;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColPrecio;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColCantidad;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColImporte;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnBuscarProducto;
		private System.Windows.Forms.Button btnClientes;
	}
}