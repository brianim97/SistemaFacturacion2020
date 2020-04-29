namespace SistemaFacturacion
{
	partial class VistaClientesFacturacion
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
			this.tbBuscarClientesFacturacion = new System.Windows.Forms.TextBox();
			this.dgvVistaClienteFact = new System.Windows.Forms.DataGridView();
			this.rbNombre = new System.Windows.Forms.RadioButton();
			this.rbDNI = new System.Windows.Forms.RadioButton();
			((System.ComponentModel.ISupportInitialize)(this.dgvVistaClienteFact)).BeginInit();
			this.SuspendLayout();
			// 
			// tbBuscarClientesFacturacion
			// 
			this.tbBuscarClientesFacturacion.Location = new System.Drawing.Point(181, 19);
			this.tbBuscarClientesFacturacion.Name = "tbBuscarClientesFacturacion";
			this.tbBuscarClientesFacturacion.Size = new System.Drawing.Size(261, 20);
			this.tbBuscarClientesFacturacion.TabIndex = 3;
			this.tbBuscarClientesFacturacion.TextChanged += new System.EventHandler(this.tbBuscarClientesFacturacion_TextChanged);
			// 
			// dgvVistaClienteFact
			// 
			this.dgvVistaClienteFact.AllowUserToAddRows = false;
			this.dgvVistaClienteFact.AllowUserToDeleteRows = false;
			this.dgvVistaClienteFact.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvVistaClienteFact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvVistaClienteFact.Location = new System.Drawing.Point(12, 64);
			this.dgvVistaClienteFact.Name = "dgvVistaClienteFact";
			this.dgvVistaClienteFact.ReadOnly = true;
			this.dgvVistaClienteFact.Size = new System.Drawing.Size(610, 251);
			this.dgvVistaClienteFact.TabIndex = 2;
			this.dgvVistaClienteFact.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVistaClienteFact_CellDoubleClick);
			// 
			// rbNombre
			// 
			this.rbNombre.AutoSize = true;
			this.rbNombre.Checked = true;
			this.rbNombre.Location = new System.Drawing.Point(233, 45);
			this.rbNombre.Name = "rbNombre";
			this.rbNombre.Size = new System.Drawing.Size(62, 17);
			this.rbNombre.TabIndex = 4;
			this.rbNombre.Text = "Nombre";
			this.rbNombre.UseVisualStyleBackColor = true;
			// 
			// rbDNI
			// 
			this.rbDNI.AutoSize = true;
			this.rbDNI.Location = new System.Drawing.Point(301, 45);
			this.rbDNI.Name = "rbDNI";
			this.rbDNI.Size = new System.Drawing.Size(103, 17);
			this.rbDNI.TabIndex = 5;
			this.rbDNI.Text = "DNI/CUIT/CUIL";
			this.rbDNI.UseVisualStyleBackColor = true;
			// 
			// VistaClientesFacturacion
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(634, 335);
			this.Controls.Add(this.rbDNI);
			this.Controls.Add(this.rbNombre);
			this.Controls.Add(this.tbBuscarClientesFacturacion);
			this.Controls.Add(this.dgvVistaClienteFact);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Name = "VistaClientesFacturacion";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Seleccion de Cliente";
			this.Load += new System.EventHandler(this.VistaClientesFacturacion_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvVistaClienteFact)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tbBuscarClientesFacturacion;
		private System.Windows.Forms.DataGridView dgvVistaClienteFact;
		private System.Windows.Forms.RadioButton rbNombre;
		private System.Windows.Forms.RadioButton rbDNI;
	}
}