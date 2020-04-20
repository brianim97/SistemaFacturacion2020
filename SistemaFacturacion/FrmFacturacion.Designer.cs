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
			this.panel1 = new System.Windows.Forms.Panel();
			this.BtnEliminar = new System.Windows.Forms.Button();
			this.btnClientes = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.btnColocar = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.lblClienteNombre = new System.Windows.Forms.Label();
			this.lblAtiende = new System.Windows.Forms.Label();
			this.tbCantidad = new System.Windows.Forms.TextBox();
			this.tbPrecio = new System.Windows.Forms.TextBox();
			this.tbDescripcion = new System.Windows.Forms.TextBox();
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
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.tbDniCliente = new System.Windows.Forms.TextBox();
			this.dgvFacturacion = new System.Windows.Forms.DataGridView();
			this.ColCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColImporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvFacturacion)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.BtnEliminar);
			this.panel1.Controls.Add(this.btnClientes);
			this.panel1.Controls.Add(this.button6);
			this.panel1.Controls.Add(this.button5);
			this.panel1.Controls.Add(this.button4);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.btnColocar);
			this.panel1.Location = new System.Drawing.Point(0, 167);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(122, 372);
			this.panel1.TabIndex = 0;
			// 
			// BtnEliminar
			// 
			this.BtnEliminar.Location = new System.Drawing.Point(0, 44);
			this.BtnEliminar.Name = "BtnEliminar";
			this.BtnEliminar.Size = new System.Drawing.Size(115, 35);
			this.BtnEliminar.TabIndex = 7;
			this.BtnEliminar.Text = "ELIMINAR";
			this.BtnEliminar.UseVisualStyleBackColor = true;
			// 
			// btnClientes
			// 
			this.btnClientes.Location = new System.Drawing.Point(0, 85);
			this.btnClientes.Name = "btnClientes";
			this.btnClientes.Size = new System.Drawing.Size(115, 35);
			this.btnClientes.TabIndex = 6;
			this.btnClientes.Text = "CLIENTES";
			this.btnClientes.UseVisualStyleBackColor = true;
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(0, 126);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(115, 35);
			this.button6.TabIndex = 5;
			this.button6.Text = "PRODUCTOS";
			this.button6.UseVisualStyleBackColor = true;
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(0, 167);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(115, 35);
			this.button5.TabIndex = 4;
			this.button5.Text = "NUEVO";
			this.button5.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(0, 334);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(115, 35);
			this.button4.TabIndex = 3;
			this.button4.Text = "SALIR";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(0, 208);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(115, 122);
			this.button2.TabIndex = 1;
			this.button2.Text = "FACTURAR";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// btnColocar
			// 
			this.btnColocar.Location = new System.Drawing.Point(0, 3);
			this.btnColocar.Name = "btnColocar";
			this.btnColocar.Size = new System.Drawing.Size(115, 35);
			this.btnColocar.TabIndex = 0;
			this.btnColocar.Text = "COLOCAR";
			this.btnColocar.UseVisualStyleBackColor = true;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.lblClienteNombre);
			this.panel2.Controls.Add(this.lblAtiende);
			this.panel2.Controls.Add(this.panel1);
			this.panel2.Controls.Add(this.tbCantidad);
			this.panel2.Controls.Add(this.tbPrecio);
			this.panel2.Controls.Add(this.tbDescripcion);
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
			this.panel2.Controls.Add(this.pictureBox1);
			this.panel2.Controls.Add(this.tbDniCliente);
			this.panel2.Controls.Add(this.dgvFacturacion);
			this.panel2.Location = new System.Drawing.Point(3, -2);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(849, 544);
			this.panel2.TabIndex = 1;
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
			this.tbCantidad.Location = new System.Drawing.Point(617, 167);
			this.tbCantidad.Name = "tbCantidad";
			this.tbCantidad.Size = new System.Drawing.Size(96, 20);
			this.tbCantidad.TabIndex = 27;
			// 
			// tbPrecio
			// 
			this.tbPrecio.Location = new System.Drawing.Point(521, 167);
			this.tbPrecio.Name = "tbPrecio";
			this.tbPrecio.Size = new System.Drawing.Size(90, 20);
			this.tbPrecio.TabIndex = 26;
			// 
			// tbDescripcion
			// 
			this.tbDescripcion.Location = new System.Drawing.Point(252, 167);
			this.tbDescripcion.Name = "tbDescripcion";
			this.tbDescripcion.Size = new System.Drawing.Size(263, 20);
			this.tbDescripcion.TabIndex = 25;
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(246, 190);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(259, 24);
			this.label10.TabIndex = 24;
			this.label10.Text = "DESCRIPCION";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblTotal
			// 
			this.lblTotal.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.lblTotal.Location = new System.Drawing.Point(720, 496);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(126, 35);
			this.lblTotal.TabIndex = 23;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(660, 508);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(45, 13);
			this.label8.TabIndex = 22;
			this.label8.Text = "TOTAL:";
			// 
			// tbCodigoProd
			// 
			this.tbCodigoProd.Location = new System.Drawing.Point(128, 167);
			this.tbCodigoProd.Name = "tbCodigoProd";
			this.tbCodigoProd.Size = new System.Drawing.Size(120, 20);
			this.tbCodigoProd.TabIndex = 21;
			this.tbCodigoProd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCodigoProd_KeyPress);
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(690, 190);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(156, 24);
			this.label7.TabIndex = 18;
			this.label7.Text = "IMPORTE";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(617, 190);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(78, 24);
			this.label6.TabIndex = 17;
			this.label6.Text = "CANTIDAD";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(123, 190);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(125, 24);
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
			this.label5.Location = new System.Drawing.Point(502, 190);
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
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(473, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(373, 129);
			this.pictureBox1.TabIndex = 8;
			this.pictureBox1.TabStop = false;
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
			this.dgvFacturacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvFacturacion.ColumnHeadersVisible = false;
			this.dgvFacturacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColCodigo,
            this.ColDescripcion,
            this.ColPrecio,
            this.ColCantidad,
            this.ColImporte});
			this.dgvFacturacion.Location = new System.Drawing.Point(126, 189);
			this.dgvFacturacion.Name = "dgvFacturacion";
			this.dgvFacturacion.RowHeadersVisible = false;
			this.dgvFacturacion.Size = new System.Drawing.Size(720, 304);
			this.dgvFacturacion.TabIndex = 0;
			// 
			// ColCodigo
			// 
			this.ColCodigo.FillWeight = 83.33334F;
			this.ColCodigo.HeaderText = "Codigo";
			this.ColCodigo.Name = "ColCodigo";
			this.ColCodigo.Width = 120;
			// 
			// ColDescripcion
			// 
			this.ColDescripcion.FillWeight = 188.6093F;
			this.ColDescripcion.HeaderText = "Descripcion";
			this.ColDescripcion.Name = "ColDescripcion";
			this.ColDescripcion.Width = 272;
			// 
			// ColPrecio
			// 
			this.ColPrecio.FillWeight = 61.01797F;
			this.ColPrecio.HeaderText = "Precio";
			this.ColPrecio.Name = "ColPrecio";
			this.ColPrecio.Width = 87;
			// 
			// ColCantidad
			// 
			this.ColCantidad.FillWeight = 73.93642F;
			this.ColCantidad.HeaderText = "Cantidad";
			this.ColCantidad.Name = "ColCantidad";
			this.ColCantidad.Width = 107;
			// 
			// ColImporte
			// 
			this.ColImporte.FillWeight = 93.10295F;
			this.ColImporte.HeaderText = "Importe";
			this.ColImporte.Name = "ColImporte";
			this.ColImporte.Width = 134;
			// 
			// FrmFacturacion
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(851, 543);
			this.Controls.Add(this.panel2);
			this.Name = "FrmFacturacion";
			this.Text = "Facturacion";
			this.Load += new System.EventHandler(this.FrmFacturacion_Load);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvFacturacion)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button BtnEliminar;
		private System.Windows.Forms.Button btnClientes;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button btnColocar;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.DataGridView dgvFacturacion;
		private System.Windows.Forms.Label lblAtiende;
		private System.Windows.Forms.TextBox tbCantidad;
		private System.Windows.Forms.TextBox tbPrecio;
		private System.Windows.Forms.TextBox tbDescripcion;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label lblTotal;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox tbCodigoProd;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox tbDniCliente;
		private System.Windows.Forms.Label lblClienteNombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColCodigo;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColDescripcion;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColPrecio;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColCantidad;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColImporte;
	}
}