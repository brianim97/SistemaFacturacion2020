namespace SistemaFacturacion.Formularios_Secundarios
{
	partial class frmRegistroAcciones
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
			this.dgvRegistroAcciones = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgvRegistroAcciones)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvRegistroAcciones
			// 
			this.dgvRegistroAcciones.AllowUserToAddRows = false;
			this.dgvRegistroAcciones.AllowUserToDeleteRows = false;
			this.dgvRegistroAcciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvRegistroAcciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvRegistroAcciones.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvRegistroAcciones.Location = new System.Drawing.Point(0, 0);
			this.dgvRegistroAcciones.Name = "dgvRegistroAcciones";
			this.dgvRegistroAcciones.ReadOnly = true;
			this.dgvRegistroAcciones.Size = new System.Drawing.Size(666, 365);
			this.dgvRegistroAcciones.TabIndex = 2;
			// 
			// frmRegistroAcciones
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(666, 365);
			this.Controls.Add(this.dgvRegistroAcciones);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Name = "frmRegistroAcciones";
			this.Text = "Registro Acciones de Sistema";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRegistroAcciones_FormClosing);
			this.Load += new System.EventHandler(this.frmRegistroAcciones_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvRegistroAcciones)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.DataGridView dgvRegistroAcciones;
	}
}