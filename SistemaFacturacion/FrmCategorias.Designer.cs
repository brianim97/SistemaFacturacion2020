namespace SistemaFacturacion
{
	partial class FrmCategoria
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
			this.tabCategorias = new System.Windows.Forms.TabControl();
			this.tpVistaCategoria = new System.Windows.Forms.TabPage();
			this.btnEditar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.tbBuscarCategoria = new System.Windows.Forms.TextBox();
			this.dgvVistaCategoria = new System.Windows.Forms.DataGridView();
			this.tpCrearCategoria = new System.Windows.Forms.TabPage();
			this.tbDescripcion = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.tbNombre = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.tabCategorias.SuspendLayout();
			this.tpVistaCategoria.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvVistaCategoria)).BeginInit();
			this.tpCrearCategoria.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabCategorias
			// 
			this.tabCategorias.Controls.Add(this.tpVistaCategoria);
			this.tabCategorias.Controls.Add(this.tpCrearCategoria);
			this.tabCategorias.Location = new System.Drawing.Point(2, 1);
			this.tabCategorias.Name = "tabCategorias";
			this.tabCategorias.SelectedIndex = 0;
			this.tabCategorias.Size = new System.Drawing.Size(563, 328);
			this.tabCategorias.TabIndex = 0;
			// 
			// tpVistaCategoria
			// 
			this.tpVistaCategoria.Controls.Add(this.btnEditar);
			this.tpVistaCategoria.Controls.Add(this.label1);
			this.tpVistaCategoria.Controls.Add(this.tbBuscarCategoria);
			this.tpVistaCategoria.Controls.Add(this.dgvVistaCategoria);
			this.tpVistaCategoria.Location = new System.Drawing.Point(4, 22);
			this.tpVistaCategoria.Name = "tpVistaCategoria";
			this.tpVistaCategoria.Padding = new System.Windows.Forms.Padding(3);
			this.tpVistaCategoria.Size = new System.Drawing.Size(555, 302);
			this.tpVistaCategoria.TabIndex = 0;
			this.tpVistaCategoria.Text = "Vista";
			this.tpVistaCategoria.UseVisualStyleBackColor = true;
			// 
			// btnEditar
			// 
			this.btnEditar.Location = new System.Drawing.Point(349, 6);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(139, 36);
			this.btnEditar.TabIndex = 23;
			this.btnEditar.Text = "Editar";
			this.btnEditar.UseVisualStyleBackColor = true;
			this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(58, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(101, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Escribe para buscar";
			// 
			// tbBuscarCategoria
			// 
			this.tbBuscarCategoria.Location = new System.Drawing.Point(165, 15);
			this.tbBuscarCategoria.Name = "tbBuscarCategoria";
			this.tbBuscarCategoria.Size = new System.Drawing.Size(148, 20);
			this.tbBuscarCategoria.TabIndex = 1;
			this.tbBuscarCategoria.TextChanged += new System.EventHandler(this.tbVistaCategorias_TextChanged);
			// 
			// dgvVistaCategoria
			// 
			this.dgvVistaCategoria.AllowUserToAddRows = false;
			this.dgvVistaCategoria.AllowUserToDeleteRows = false;
			this.dgvVistaCategoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvVistaCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvVistaCategoria.Location = new System.Drawing.Point(6, 45);
			this.dgvVistaCategoria.Name = "dgvVistaCategoria";
			this.dgvVistaCategoria.ReadOnly = true;
			this.dgvVistaCategoria.Size = new System.Drawing.Size(542, 251);
			this.dgvVistaCategoria.TabIndex = 0;
			this.dgvVistaCategoria.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVistaCategorias_CellDoubleClick);
			// 
			// tpCrearCategoria
			// 
			this.tpCrearCategoria.Controls.Add(this.tbDescripcion);
			this.tpCrearCategoria.Controls.Add(this.label5);
			this.tpCrearCategoria.Controls.Add(this.tbNombre);
			this.tpCrearCategoria.Controls.Add(this.label3);
			this.tpCrearCategoria.Controls.Add(this.btnGuardar);
			this.tpCrearCategoria.Controls.Add(this.btnLimpiar);
			this.tpCrearCategoria.Location = new System.Drawing.Point(4, 22);
			this.tpCrearCategoria.Name = "tpCrearCategoria";
			this.tpCrearCategoria.Padding = new System.Windows.Forms.Padding(3);
			this.tpCrearCategoria.Size = new System.Drawing.Size(555, 302);
			this.tpCrearCategoria.TabIndex = 1;
			this.tpCrearCategoria.Text = "Crear";
			this.tpCrearCategoria.UseVisualStyleBackColor = true;
			// 
			// tbDescripcion
			// 
			this.tbDescripcion.AllowDrop = true;
			this.tbDescripcion.Location = new System.Drawing.Point(200, 110);
			this.tbDescripcion.Multiline = true;
			this.tbDescripcion.Name = "tbDescripcion";
			this.tbDescripcion.Size = new System.Drawing.Size(215, 44);
			this.tbDescripcion.TabIndex = 27;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(128, 113);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(63, 13);
			this.label5.TabIndex = 26;
			this.label5.Text = "Descripcion";
			// 
			// tbNombre
			// 
			this.tbNombre.Location = new System.Drawing.Point(200, 71);
			this.tbNombre.Name = "tbNombre";
			this.tbNombre.Size = new System.Drawing.Size(215, 20);
			this.tbNombre.TabIndex = 25;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(128, 74);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(44, 13);
			this.label3.TabIndex = 24;
			this.label3.Text = "Nombre";
			// 
			// btnGuardar
			// 
			this.btnGuardar.Location = new System.Drawing.Point(131, 213);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(139, 36);
			this.btnGuardar.TabIndex = 22;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.Location = new System.Drawing.Point(276, 213);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(139, 36);
			this.btnLimpiar.TabIndex = 21;
			this.btnLimpiar.Text = "Limpiar";
			this.btnLimpiar.UseVisualStyleBackColor = true;
			this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
			// 
			// FrmCategoria
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(566, 328);
			this.Controls.Add(this.tabCategorias);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.MaximizeBox = false;
			this.Name = "FrmCategoria";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Categorias";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCategoria_FormClosing);
			this.Load += new System.EventHandler(this.FrmCategorias_Load);
			this.tabCategorias.ResumeLayout(false);
			this.tpVistaCategoria.ResumeLayout(false);
			this.tpVistaCategoria.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvVistaCategoria)).EndInit();
			this.tpCrearCategoria.ResumeLayout(false);
			this.tpCrearCategoria.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabCategorias;
		private System.Windows.Forms.TabPage tpVistaCategoria;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbBuscarCategoria;
		private System.Windows.Forms.DataGridView dgvVistaCategoria;
		private System.Windows.Forms.TabPage tpCrearCategoria;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.Button btnEditar;
		private System.Windows.Forms.TextBox tbDescripcion;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox tbNombre;
		private System.Windows.Forms.Label label3;
	}
}