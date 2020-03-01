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
			this.statusStrip.SuspendLayout();
			this.menuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// statusStrip
			// 
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
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vistaStockToolStripMenuItem});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(632, 24);
			this.menuStrip.TabIndex = 0;
			this.menuStrip.Text = "MenuStrip";
			// 
			// vistaStockToolStripMenuItem
			// 
			this.vistaStockToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarToolStripMenuItem,
            this.categoriasToolStripMenuItem});
			this.vistaStockToolStripMenuItem.Name = "vistaStockToolStripMenuItem";
			this.vistaStockToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
			this.vistaStockToolStripMenuItem.Text = "INICIO";
			// 
			// cargarToolStripMenuItem
			// 
			this.cargarToolStripMenuItem.Name = "cargarToolStripMenuItem";
			this.cargarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.cargarToolStripMenuItem.Text = "Productos";
			this.cargarToolStripMenuItem.Click += new System.EventHandler(this.cargarToolStripMenuItem_Click);
			// 
			// categoriasToolStripMenuItem
			// 
			this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
			this.categoriasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.categoriasToolStripMenuItem.Text = "Categorias";
			this.categoriasToolStripMenuItem.Click += new System.EventHandler(this.categoriasToolStripMenuItem_Click);
			// 
			// MDIParent1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(632, 453);
			this.Controls.Add(this.statusStrip);
			this.Controls.Add(this.menuStrip);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip;
			this.Name = "MDIParent1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SISTEMA WAKE";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
	}
}



