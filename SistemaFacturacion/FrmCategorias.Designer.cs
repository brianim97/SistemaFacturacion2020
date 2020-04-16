namespace SistemaFacturacion
{
	partial class FrmClientes
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
			this.tbBuscarCliente = new System.Windows.Forms.TextBox();
			this.dgvVistaCliente = new System.Windows.Forms.DataGridView();
			this.tpCrearCategoria = new System.Windows.Forms.TabPage();
			this.label4 = new System.Windows.Forms.Label();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.tbDni = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tbNombre = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tbDireccion = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.tbTelefono = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.tabCategorias.SuspendLayout();
			this.tpVistaCategoria.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvVistaCliente)).BeginInit();
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
			this.tpVistaCategoria.Controls.Add(this.tbBuscarCliente);
			this.tpVistaCategoria.Controls.Add(this.dgvVistaCliente);
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
			// tbBuscarCliente
			// 
			this.tbBuscarCliente.Location = new System.Drawing.Point(165, 15);
			this.tbBuscarCliente.Name = "tbBuscarCliente";
			this.tbBuscarCliente.Size = new System.Drawing.Size(148, 20);
			this.tbBuscarCliente.TabIndex = 1;
			this.tbBuscarCliente.TextChanged += new System.EventHandler(this.tbVistaCategorias_TextChanged);
			// 
			// dgvVistaCliente
			// 
			this.dgvVistaCliente.AllowUserToAddRows = false;
			this.dgvVistaCliente.AllowUserToDeleteRows = false;
			this.dgvVistaCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvVistaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvVistaCliente.Location = new System.Drawing.Point(6, 45);
			this.dgvVistaCliente.Name = "dgvVistaCliente";
			this.dgvVistaCliente.ReadOnly = true;
			this.dgvVistaCliente.Size = new System.Drawing.Size(542, 251);
			this.dgvVistaCliente.TabIndex = 0;
			this.dgvVistaCliente.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVistaCategorias_CellDoubleClick);
			// 
			// tpCrearCategoria
			// 
			this.tpCrearCategoria.Controls.Add(this.tbTelefono);
			this.tpCrearCategoria.Controls.Add(this.label6);
			this.tpCrearCategoria.Controls.Add(this.tbDireccion);
			this.tpCrearCategoria.Controls.Add(this.label5);
			this.tpCrearCategoria.Controls.Add(this.tbNombre);
			this.tpCrearCategoria.Controls.Add(this.label3);
			this.tpCrearCategoria.Controls.Add(this.label4);
			this.tpCrearCategoria.Controls.Add(this.btnGuardar);
			this.tpCrearCategoria.Controls.Add(this.btnLimpiar);
			this.tpCrearCategoria.Controls.Add(this.tbDni);
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
			this.label4.Location = new System.Drawing.Point(421, 48);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(17, 24);
			this.label4.TabIndex = 23;
			this.label4.Text = "*";
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
			// tbDni
			// 
			this.tbDni.Location = new System.Drawing.Point(200, 45);
			this.tbDni.Name = "tbDni";
			this.tbDni.Size = new System.Drawing.Size(215, 20);
			this.tbDni.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(128, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(26, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "DNI";
			// 
			// tbNombre
			// 
			this.tbNombre.Location = new System.Drawing.Point(200, 83);
			this.tbNombre.Name = "tbNombre";
			this.tbNombre.Size = new System.Drawing.Size(215, 20);
			this.tbNombre.TabIndex = 25;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(128, 86);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(44, 13);
			this.label3.TabIndex = 24;
			this.label3.Text = "Nombre";
			// 
			// tbDireccion
			// 
			this.tbDireccion.Location = new System.Drawing.Point(200, 122);
			this.tbDireccion.Name = "tbDireccion";
			this.tbDireccion.Size = new System.Drawing.Size(215, 20);
			this.tbDireccion.TabIndex = 27;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(128, 125);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(52, 13);
			this.label5.TabIndex = 26;
			this.label5.Text = "Direccion";
			// 
			// tbTelefono
			// 
			this.tbTelefono.Location = new System.Drawing.Point(200, 158);
			this.tbTelefono.Name = "tbTelefono";
			this.tbTelefono.Size = new System.Drawing.Size(215, 20);
			this.tbTelefono.TabIndex = 29;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(128, 161);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(49, 13);
			this.label6.TabIndex = 28;
			this.label6.Text = "Telefono";
			// 
			// FrmClientes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(566, 328);
			this.Controls.Add(this.tabCategorias);
			this.Name = "FrmClientes";
			this.Text = "Clientes";
			this.Load += new System.EventHandler(this.FrmCategorias_Load);
			this.tabCategorias.ResumeLayout(false);
			this.tpVistaCategoria.ResumeLayout(false);
			this.tpVistaCategoria.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvVistaCliente)).EndInit();
			this.tpCrearCategoria.ResumeLayout(false);
			this.tpCrearCategoria.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabCategorias;
		private System.Windows.Forms.TabPage tpVistaCategoria;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbBuscarCliente;
		private System.Windows.Forms.DataGridView dgvVistaCliente;
		private System.Windows.Forms.TabPage tpCrearCategoria;
		private System.Windows.Forms.TextBox tbDni;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.Button btnEditar;
		private System.Windows.Forms.TextBox tbTelefono;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox tbDireccion;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox tbNombre;
		private System.Windows.Forms.Label label3;
	}
}