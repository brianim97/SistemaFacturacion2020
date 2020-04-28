namespace SistemaFacturacion
{
	partial class frmMantenimiento
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabBackup = new System.Windows.Forms.TabPage();
			this.btnRealizarBackup = new System.Windows.Forms.Button();
			this.btnBuscarBackup = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.tbUbicacionBackup = new System.Windows.Forms.TextBox();
			this.tabRestore = new System.Windows.Forms.TabPage();
			this.btnRealizarRestore = new System.Windows.Forms.Button();
			this.btnBuscarRestore = new System.Windows.Forms.Button();
			this.tbUbicacionRestore = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.pbImg = new System.Windows.Forms.PictureBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnSeleccionar = new System.Windows.Forms.Button();
			this.tabControl1.SuspendLayout();
			this.tabBackup.SuspendLayout();
			this.tabRestore.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbImg)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabBackup);
			this.tabControl1.Controls.Add(this.tabRestore);
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(522, 202);
			this.tabControl1.TabIndex = 0;
			// 
			// tabBackup
			// 
			this.tabBackup.Controls.Add(this.btnRealizarBackup);
			this.tabBackup.Controls.Add(this.btnBuscarBackup);
			this.tabBackup.Controls.Add(this.label1);
			this.tabBackup.Controls.Add(this.tbUbicacionBackup);
			this.tabBackup.Location = new System.Drawing.Point(4, 22);
			this.tabBackup.Name = "tabBackup";
			this.tabBackup.Padding = new System.Windows.Forms.Padding(3);
			this.tabBackup.Size = new System.Drawing.Size(514, 176);
			this.tabBackup.TabIndex = 0;
			this.tabBackup.Text = "Backup DB";
			this.tabBackup.UseVisualStyleBackColor = true;
			// 
			// btnRealizarBackup
			// 
			this.btnRealizarBackup.Location = new System.Drawing.Point(147, 98);
			this.btnRealizarBackup.Name = "btnRealizarBackup";
			this.btnRealizarBackup.Size = new System.Drawing.Size(195, 51);
			this.btnRealizarBackup.TabIndex = 3;
			this.btnRealizarBackup.Text = "Realizar Backup de Base de Datos";
			this.btnRealizarBackup.UseVisualStyleBackColor = true;
			this.btnRealizarBackup.Click += new System.EventHandler(this.btnRealizarBackup_Click);
			// 
			// btnBuscarBackup
			// 
			this.btnBuscarBackup.Location = new System.Drawing.Point(378, 31);
			this.btnBuscarBackup.Name = "btnBuscarBackup";
			this.btnBuscarBackup.Size = new System.Drawing.Size(110, 23);
			this.btnBuscarBackup.TabIndex = 2;
			this.btnBuscarBackup.Text = "Buscar";
			this.btnBuscarBackup.UseVisualStyleBackColor = true;
			this.btnBuscarBackup.Click += new System.EventHandler(this.btnBuscarBackup_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(25, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Ubicacion:";
			// 
			// tbUbicacionBackup
			// 
			this.tbUbicacionBackup.Location = new System.Drawing.Point(89, 33);
			this.tbUbicacionBackup.Name = "tbUbicacionBackup";
			this.tbUbicacionBackup.ReadOnly = true;
			this.tbUbicacionBackup.Size = new System.Drawing.Size(283, 20);
			this.tbUbicacionBackup.TabIndex = 1;
			// 
			// tabRestore
			// 
			this.tabRestore.Controls.Add(this.btnRealizarRestore);
			this.tabRestore.Controls.Add(this.btnBuscarRestore);
			this.tabRestore.Controls.Add(this.tbUbicacionRestore);
			this.tabRestore.Controls.Add(this.label2);
			this.tabRestore.Location = new System.Drawing.Point(4, 22);
			this.tabRestore.Name = "tabRestore";
			this.tabRestore.Padding = new System.Windows.Forms.Padding(3);
			this.tabRestore.Size = new System.Drawing.Size(514, 176);
			this.tabRestore.TabIndex = 1;
			this.tabRestore.Text = "Restore DB";
			this.tabRestore.UseVisualStyleBackColor = true;
			// 
			// btnRealizarRestore
			// 
			this.btnRealizarRestore.Location = new System.Drawing.Point(148, 96);
			this.btnRealizarRestore.Name = "btnRealizarRestore";
			this.btnRealizarRestore.Size = new System.Drawing.Size(195, 51);
			this.btnRealizarRestore.TabIndex = 7;
			this.btnRealizarRestore.Text = "Realizar Restore de Base de Datos";
			this.btnRealizarRestore.UseVisualStyleBackColor = true;
			this.btnRealizarRestore.Click += new System.EventHandler(this.btnRealizarRestore_Click);
			// 
			// btnBuscarRestore
			// 
			this.btnBuscarRestore.Location = new System.Drawing.Point(379, 29);
			this.btnBuscarRestore.Name = "btnBuscarRestore";
			this.btnBuscarRestore.Size = new System.Drawing.Size(110, 23);
			this.btnBuscarRestore.TabIndex = 6;
			this.btnBuscarRestore.Text = "Buscar";
			this.btnBuscarRestore.UseVisualStyleBackColor = true;
			this.btnBuscarRestore.Click += new System.EventHandler(this.btnBuscarRestore_Click);
			// 
			// tbUbicacionRestore
			// 
			this.tbUbicacionRestore.Location = new System.Drawing.Point(90, 31);
			this.tbUbicacionRestore.Name = "tbUbicacionRestore";
			this.tbUbicacionRestore.ReadOnly = true;
			this.tbUbicacionRestore.Size = new System.Drawing.Size(283, 20);
			this.tbUbicacionRestore.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(26, 34);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Ubicacion:";
			// 
			// pbImg
			// 
			this.pbImg.Location = new System.Drawing.Point(64, 234);
			this.pbImg.Name = "pbImg";
			this.pbImg.Size = new System.Drawing.Size(373, 143);
			this.pbImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbImg.TabIndex = 5;
			this.pbImg.TabStop = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(200, 213);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(86, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Imagen Logotipo";
			// 
			// btnSeleccionar
			// 
			this.btnSeleccionar.Location = new System.Drawing.Point(347, 383);
			this.btnSeleccionar.Name = "btnSeleccionar";
			this.btnSeleccionar.Size = new System.Drawing.Size(90, 20);
			this.btnSeleccionar.TabIndex = 3;
			this.btnSeleccionar.Text = "Seleccionar";
			this.btnSeleccionar.UseVisualStyleBackColor = true;
			this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
			// 
			// frmMantenimiento
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(525, 433);
			this.Controls.Add(this.pbImg);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnSeleccionar);
			this.Controls.Add(this.tabControl1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Name = "frmMantenimiento";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Mantenimiento";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMantenimiento_FormClosing);
			this.Load += new System.EventHandler(this.frmMantenimiento_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabBackup.ResumeLayout(false);
			this.tabBackup.PerformLayout();
			this.tabRestore.ResumeLayout(false);
			this.tabRestore.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbImg)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabBackup;
		private System.Windows.Forms.Button btnRealizarBackup;
		private System.Windows.Forms.Button btnBuscarBackup;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbUbicacionBackup;
		private System.Windows.Forms.TabPage tabRestore;
		private System.Windows.Forms.Button btnRealizarRestore;
		private System.Windows.Forms.Button btnBuscarRestore;
		private System.Windows.Forms.TextBox tbUbicacionRestore;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pbImg;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnSeleccionar;
	}
}