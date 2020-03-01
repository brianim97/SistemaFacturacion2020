namespace SistemaFacturacion
{
	partial class FrmCategorias
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
			this.tpVistaCategoria = new System.Windows.Forms.TabPage();
			this.tpCrearCategoria = new System.Windows.Forms.TabPage();
			this.dgvVistaCategorias = new System.Windows.Forms.DataGridView();
			this.tbVistaCategorias = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tbNombreCap = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tbDescripcioCat = new System.Windows.Forms.TextBox();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.tabControl1.SuspendLayout();
			this.tpVistaCategoria.SuspendLayout();
			this.tpCrearCategoria.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvVistaCategorias)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tpVistaCategoria);
			this.tabControl1.Controls.Add(this.tpCrearCategoria);
			this.tabControl1.Location = new System.Drawing.Point(2, 1);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(461, 328);
			this.tabControl1.TabIndex = 0;
			// 
			// tpVistaCategoria
			// 
			this.tpVistaCategoria.Controls.Add(this.label1);
			this.tpVistaCategoria.Controls.Add(this.tbVistaCategorias);
			this.tpVistaCategoria.Controls.Add(this.dgvVistaCategorias);
			this.tpVistaCategoria.Location = new System.Drawing.Point(4, 22);
			this.tpVistaCategoria.Name = "tpVistaCategoria";
			this.tpVistaCategoria.Padding = new System.Windows.Forms.Padding(3);
			this.tpVistaCategoria.Size = new System.Drawing.Size(453, 302);
			this.tpVistaCategoria.TabIndex = 0;
			this.tpVistaCategoria.Text = "Vista";
			this.tpVistaCategoria.UseVisualStyleBackColor = true;
			// 
			// tpCrearCategoria
			// 
			this.tpCrearCategoria.Controls.Add(this.label4);
			this.tpCrearCategoria.Controls.Add(this.btnGuardar);
			this.tpCrearCategoria.Controls.Add(this.btnLimpiar);
			this.tpCrearCategoria.Controls.Add(this.tbDescripcioCat);
			this.tpCrearCategoria.Controls.Add(this.label3);
			this.tpCrearCategoria.Controls.Add(this.tbNombreCap);
			this.tpCrearCategoria.Controls.Add(this.label2);
			this.tpCrearCategoria.Location = new System.Drawing.Point(4, 22);
			this.tpCrearCategoria.Name = "tpCrearCategoria";
			this.tpCrearCategoria.Padding = new System.Windows.Forms.Padding(3);
			this.tpCrearCategoria.Size = new System.Drawing.Size(453, 302);
			this.tpCrearCategoria.TabIndex = 1;
			this.tpCrearCategoria.Text = "Crear";
			this.tpCrearCategoria.UseVisualStyleBackColor = true;
			// 
			// dgvVistaCategorias
			// 
			this.dgvVistaCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvVistaCategorias.Location = new System.Drawing.Point(6, 45);
			this.dgvVistaCategorias.Name = "dgvVistaCategorias";
			this.dgvVistaCategorias.Size = new System.Drawing.Size(441, 251);
			this.dgvVistaCategorias.TabIndex = 0;
			// 
			// tbVistaCategorias
			// 
			this.tbVistaCategorias.Location = new System.Drawing.Point(162, 19);
			this.tbVistaCategorias.Name = "tbVistaCategorias";
			this.tbVistaCategorias.Size = new System.Drawing.Size(133, 20);
			this.tbVistaCategorias.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(178, 3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(101, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Escribe para buscar";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(62, 46);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Nombre";
			// 
			// tbNombreCap
			// 
			this.tbNombreCap.Location = new System.Drawing.Point(143, 43);
			this.tbNombreCap.Name = "tbNombreCap";
			this.tbNombreCap.Size = new System.Drawing.Size(215, 20);
			this.tbNombreCap.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(62, 103);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(63, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Descripcion";
			// 
			// tbDescripcioCat
			// 
			this.tbDescripcioCat.Location = new System.Drawing.Point(143, 96);
			this.tbDescripcioCat.Multiline = true;
			this.tbDescripcioCat.Name = "tbDescripcioCat";
			this.tbDescripcioCat.Size = new System.Drawing.Size(215, 65);
			this.tbDescripcioCat.TabIndex = 3;
			// 
			// btnGuardar
			// 
			this.btnGuardar.Location = new System.Drawing.Point(74, 211);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(139, 36);
			this.btnGuardar.TabIndex = 22;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.UseVisualStyleBackColor = true;
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.Location = new System.Drawing.Point(219, 211);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(139, 36);
			this.btnLimpiar.TabIndex = 21;
			this.btnLimpiar.Text = "Limpiar";
			this.btnLimpiar.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(364, 46);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(17, 24);
			this.label4.TabIndex = 23;
			this.label4.Text = "*";
			// 
			// FrmCategorias
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(461, 328);
			this.Controls.Add(this.tabControl1);
			this.Name = "FrmCategorias";
			this.Text = "Categorias";
			this.tabControl1.ResumeLayout(false);
			this.tpVistaCategoria.ResumeLayout(false);
			this.tpVistaCategoria.PerformLayout();
			this.tpCrearCategoria.ResumeLayout(false);
			this.tpCrearCategoria.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvVistaCategorias)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tpVistaCategoria;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbVistaCategorias;
		private System.Windows.Forms.DataGridView dgvVistaCategorias;
		private System.Windows.Forms.TabPage tpCrearCategoria;
		private System.Windows.Forms.TextBox tbDescripcioCat;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbNombreCap;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.Button btnLimpiar;
	}
}