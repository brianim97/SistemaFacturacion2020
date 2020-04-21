namespace SistemaFacturacion
{
	partial class FrmProveedores
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
			this.tabProveedor = new System.Windows.Forms.TabControl();
			this.tpVistaCategoria = new System.Windows.Forms.TabPage();
			this.btnEditar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.tbVistaProveedor = new System.Windows.Forms.TextBox();
			this.dgvVistaProveedor = new System.Windows.Forms.DataGridView();
			this.tpCrearCategoria = new System.Windows.Forms.TabPage();
			this.label4 = new System.Windows.Forms.Label();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.tbContactoProveedor = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tbNombreProveedor = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tabProveedor.SuspendLayout();
			this.tpVistaCategoria.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvVistaProveedor)).BeginInit();
			this.tpCrearCategoria.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabProveedor
			// 
			this.tabProveedor.Controls.Add(this.tpVistaCategoria);
			this.tabProveedor.Controls.Add(this.tpCrearCategoria);
			this.tabProveedor.Location = new System.Drawing.Point(2, 0);
			this.tabProveedor.Name = "tabProveedor";
			this.tabProveedor.SelectedIndex = 0;
			this.tabProveedor.Size = new System.Drawing.Size(563, 328);
			this.tabProveedor.TabIndex = 1;
			// 
			// tpVistaCategoria
			// 
			this.tpVistaCategoria.Controls.Add(this.btnEditar);
			this.tpVistaCategoria.Controls.Add(this.label1);
			this.tpVistaCategoria.Controls.Add(this.tbVistaProveedor);
			this.tpVistaCategoria.Controls.Add(this.dgvVistaProveedor);
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
			// tbVistaProveedor
			// 
			this.tbVistaProveedor.Location = new System.Drawing.Point(165, 15);
			this.tbVistaProveedor.Name = "tbVistaProveedor";
			this.tbVistaProveedor.Size = new System.Drawing.Size(148, 20);
			this.tbVistaProveedor.TabIndex = 1;
			this.tbVistaProveedor.TextChanged += new System.EventHandler(this.tbVistaProveedor_TextChanged);
			// 
			// dgvVistaProveedor
			// 
			this.dgvVistaProveedor.AllowUserToAddRows = false;
			this.dgvVistaProveedor.AllowUserToDeleteRows = false;
			this.dgvVistaProveedor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvVistaProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvVistaProveedor.Location = new System.Drawing.Point(6, 45);
			this.dgvVistaProveedor.Name = "dgvVistaProveedor";
			this.dgvVistaProveedor.ReadOnly = true;
			this.dgvVistaProveedor.Size = new System.Drawing.Size(542, 251);
			this.dgvVistaProveedor.TabIndex = 0;
			this.dgvVistaProveedor.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVistaProveedor_CellDoubleClick);
			// 
			// tpCrearCategoria
			// 
			this.tpCrearCategoria.Controls.Add(this.label4);
			this.tpCrearCategoria.Controls.Add(this.btnGuardar);
			this.tpCrearCategoria.Controls.Add(this.btnLimpiar);
			this.tpCrearCategoria.Controls.Add(this.tbContactoProveedor);
			this.tpCrearCategoria.Controls.Add(this.label3);
			this.tpCrearCategoria.Controls.Add(this.tbNombreProveedor);
			this.tpCrearCategoria.Controls.Add(this.label2);
			this.tpCrearCategoria.Location = new System.Drawing.Point(4, 22);
			this.tpCrearCategoria.Name = "tpCrearCategoria";
			this.tpCrearCategoria.Padding = new System.Windows.Forms.Padding(3);
			this.tpCrearCategoria.Size = new System.Drawing.Size(555, 302);
			this.tpCrearCategoria.TabIndex = 1;
			this.tpCrearCategoria.Text = "Crear";
			this.tpCrearCategoria.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(415, 48);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(17, 24);
			this.label4.TabIndex = 23;
			this.label4.Text = "*";
			// 
			// btnGuardar
			// 
			this.btnGuardar.Location = new System.Drawing.Point(125, 213);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(139, 36);
			this.btnGuardar.TabIndex = 22;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.Location = new System.Drawing.Point(270, 213);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(139, 36);
			this.btnLimpiar.TabIndex = 21;
			this.btnLimpiar.Text = "Limpiar";
			this.btnLimpiar.UseVisualStyleBackColor = true;
			this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
			// 
			// tbContactoProveedor
			// 
			this.tbContactoProveedor.Location = new System.Drawing.Point(194, 98);
			this.tbContactoProveedor.Multiline = true;
			this.tbContactoProveedor.Name = "tbContactoProveedor";
			this.tbContactoProveedor.Size = new System.Drawing.Size(215, 65);
			this.tbContactoProveedor.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(122, 101);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(50, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Contacto";
			// 
			// tbNombreProveedor
			// 
			this.tbNombreProveedor.Location = new System.Drawing.Point(194, 45);
			this.tbNombreProveedor.Name = "tbNombreProveedor";
			this.tbNombreProveedor.Size = new System.Drawing.Size(215, 20);
			this.tbNombreProveedor.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(122, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Nombre";
			// 
			// FrmProveedores
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(566, 328);
			this.Controls.Add(this.tabProveedor);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.MinimizeBox = false;
			this.Name = "FrmProveedores";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Proveedores";
			this.Load += new System.EventHandler(this.FrmProveedores_Load);
			this.tabProveedor.ResumeLayout(false);
			this.tpVistaCategoria.ResumeLayout(false);
			this.tpVistaCategoria.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvVistaProveedor)).EndInit();
			this.tpCrearCategoria.ResumeLayout(false);
			this.tpCrearCategoria.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabProveedor;
		private System.Windows.Forms.TabPage tpVistaCategoria;
		private System.Windows.Forms.Button btnEditar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbVistaProveedor;
		private System.Windows.Forms.DataGridView dgvVistaProveedor;
		private System.Windows.Forms.TabPage tpCrearCategoria;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.TextBox tbContactoProveedor;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbNombreProveedor;
		private System.Windows.Forms.Label label2;
	}
}