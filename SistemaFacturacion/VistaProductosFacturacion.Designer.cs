namespace SistemaFacturacion
{
	partial class VistaProductosFacturacion
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
			this.dgvVistaProdFact = new System.Windows.Forms.DataGridView();
			this.tbBuscarProductosFacturacion = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvVistaProdFact)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvVistaProdFact
			// 
			this.dgvVistaProdFact.AllowUserToAddRows = false;
			this.dgvVistaProdFact.AllowUserToDeleteRows = false;
			this.dgvVistaProdFact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvVistaProdFact.Location = new System.Drawing.Point(12, 72);
			this.dgvVistaProdFact.Name = "dgvVistaProdFact";
			this.dgvVistaProdFact.ReadOnly = true;
			this.dgvVistaProdFact.Size = new System.Drawing.Size(610, 251);
			this.dgvVistaProdFact.TabIndex = 0;
			this.dgvVistaProdFact.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVistaProdFact_CellDoubleClick);
			// 
			// tbBuscarProductosFacturacion
			// 
			this.tbBuscarProductosFacturacion.Location = new System.Drawing.Point(181, 27);
			this.tbBuscarProductosFacturacion.Name = "tbBuscarProductosFacturacion";
			this.tbBuscarProductosFacturacion.Size = new System.Drawing.Size(261, 20);
			this.tbBuscarProductosFacturacion.TabIndex = 1;
			this.tbBuscarProductosFacturacion.TextChanged += new System.EventHandler(this.tbBuscarProductosFacturacion_TextChanged);
			// 
			// VistaProductosFacturacion
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(634, 335);
			this.Controls.Add(this.tbBuscarProductosFacturacion);
			this.Controls.Add(this.dgvVistaProdFact);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.MaximizeBox = false;
			this.Name = "VistaProductosFacturacion";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Load += new System.EventHandler(this.VistaProductosFacturacion_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvVistaProdFact)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvVistaProdFact;
		private System.Windows.Forms.TextBox tbBuscarProductosFacturacion;
	}
}