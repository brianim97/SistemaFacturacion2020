namespace SistemaFacturacion
{
	partial class MDIParent1
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
			this.components = new System.ComponentModel.Container();
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.vistaStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cargarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.categoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.facturacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip.SuspendLayout();
			this.menuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// statusStrip
			// 
			this.statusStrip.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
			this.statusStrip.Location = new System.Drawing.Point(0, 431);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.Size = new System.Drawing.Size(632, 22);
			this.statusStrip.TabIndex = 2;
			this.statusStrip.Text = "StatusStrip";
			// 
			// toolStripStatusLabel
			// 
			this.toolStripStatusLabel.Name = "toolStripStatusLabel";
			this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
			this.toolStripStatusLabel.Text = "Status";
			// 
			// menuStrip
			// 
			this.menuStrip.BackColor = System.Drawing.Color.MidnightBlue;
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vistaStockToolStripMenuItem});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.menuStrip.Size = new System.Drawing.Size(632, 24);
			this.menuStrip.TabIndex = 0;
			this.menuStrip.Text = "MenuStrip";
			// 
			// vistaStockToolStripMenuItem
			// 
			this.vistaStockToolStripMenuItem.BackColor = System.Drawing.Color.Navy;
			this.vistaStockToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarToolStripMenuItem,
            this.categoriasToolStripMenuItem,
            this.proveedoresToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.cerrarSesionToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.facturacionToolStripMenuItem,
            this.salirToolStripMenuItem});
			this.vistaStockToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.vistaStockToolStripMenuItem.Name = "vistaStockToolStripMenuItem";
			this.vistaStockToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
			this.vistaStockToolStripMenuItem.Text = "INICIO";
			// 
			// cargarToolStripMenuItem
			// 
			this.cargarToolStripMenuItem.BackColor = System.Drawing.Color.Navy;
			this.cargarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.cargarToolStripMenuItem.Name = "cargarToolStripMenuItem";
			this.cargarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.cargarToolStripMenuItem.Text = "Productos";
			this.cargarToolStripMenuItem.Click += new System.EventHandler(this.cargarToolStripMenuItem_Click);
			// 
			// categoriasToolStripMenuItem
			// 
			this.categoriasToolStripMenuItem.BackColor = System.Drawing.Color.Navy;
			this.categoriasToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
			this.categoriasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.categoriasToolStripMenuItem.Text = "Categorias";
			this.categoriasToolStripMenuItem.Click += new System.EventHandler(this.categoriasToolStripMenuItem_Click);
			// 
			// proveedoresToolStripMenuItem
			// 
			this.proveedoresToolStripMenuItem.BackColor = System.Drawing.Color.Navy;
			this.proveedoresToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
			this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.proveedoresToolStripMenuItem.Text = "Proveedores";
			this.proveedoresToolStripMenuItem.Click += new System.EventHandler(this.proveedoresToolStripMenuItem_Click);
			// 
			// usuariosToolStripMenuItem
			// 
			this.usuariosToolStripMenuItem.BackColor = System.Drawing.Color.Navy;
			this.usuariosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
			this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.usuariosToolStripMenuItem.Text = "Usuarios";
			this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
			// 
			// cerrarSesionToolStripMenuItem
			// 
			this.cerrarSesionToolStripMenuItem.BackColor = System.Drawing.Color.Navy;
			this.cerrarSesionToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
			this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
			this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
			// 
			// clientesToolStripMenuItem
			// 
			this.clientesToolStripMenuItem.BackColor = System.Drawing.Color.Navy;
			this.clientesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
			this.clientesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.clientesToolStripMenuItem.Text = "Clientes";
			this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
			// 
			// facturacionToolStripMenuItem
			// 
			this.facturacionToolStripMenuItem.BackColor = System.Drawing.Color.Navy;
			this.facturacionToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.facturacionToolStripMenuItem.Name = "facturacionToolStripMenuItem";
			this.facturacionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.facturacionToolStripMenuItem.Text = "Facturacion";
			this.facturacionToolStripMenuItem.Click += new System.EventHandler(this.facturacionToolStripMenuItem_Click);
			// 
			// salirToolStripMenuItem
			// 
			this.salirToolStripMenuItem.BackColor = System.Drawing.Color.Navy;
			this.salirToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
			this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.salirToolStripMenuItem.Text = "Salir";
			this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
			// 
			// MDIParent1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(632, 453);
			this.ControlBox = false;
			this.Controls.Add(this.statusStrip);
			this.Controls.Add(this.menuStrip);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip;
			this.Name = "MDIParent1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SISTEMA WAKE";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MDIParent1_FormClosed);
			this.Load += new System.EventHandler(this.MDIParent1_Load);
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		#endregion
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem vistaStockToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cargarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem categoriasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem facturacionToolStripMenuItem;
	}
}



