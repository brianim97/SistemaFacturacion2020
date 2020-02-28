namespace SistemaFacturacion
{
	partial class FrmVistaStock
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
			this.dgvVistaStock = new System.Windows.Forms.DataGridView();
			this.tbBuscarProducto = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lblTotalRegistros = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvVistaStock)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvVistaStock
			// 
			this.dgvVistaStock.AllowUserToAddRows = false;
			this.dgvVistaStock.AllowUserToDeleteRows = false;
			this.dgvVistaStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvVistaStock.Location = new System.Drawing.Point(12, 102);
			this.dgvVistaStock.Name = "dgvVistaStock";
			this.dgvVistaStock.ReadOnly = true;
			this.dgvVistaStock.Size = new System.Drawing.Size(838, 336);
			this.dgvVistaStock.TabIndex = 0;
			// 
			// tbBuscarProducto
			// 
			this.tbBuscarProducto.Location = new System.Drawing.Point(369, 58);
			this.tbBuscarProducto.Name = "tbBuscarProducto";
			this.tbBuscarProducto.Size = new System.Drawing.Size(166, 20);
			this.tbBuscarProducto.TabIndex = 1;
			this.tbBuscarProducto.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(401, 42);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(101, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Escribe para buscar";
			// 
			// lblTotalRegistros
			// 
			this.lblTotalRegistros.AutoSize = true;
			this.lblTotalRegistros.Location = new System.Drawing.Point(12, 86);
			this.lblTotalRegistros.Name = "lblTotalRegistros";
			this.lblTotalRegistros.Size = new System.Drawing.Size(54, 13);
			this.lblTotalRegistros.TabIndex = 3;
			this.lblTotalRegistros.Text = "Registros:";
			// 
			// FrmVistaStock
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(864, 450);
			this.Controls.Add(this.lblTotalRegistros);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbBuscarProducto);
			this.Controls.Add(this.dgvVistaStock);
			this.Name = "FrmVistaStock";
			this.Text = "Vista Stock";
			this.Load += new System.EventHandler(this.FrmVistaStock_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvVistaStock)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvVistaStock;
		private System.Windows.Forms.TextBox tbBuscarProducto;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblTotalRegistros;
	}
}