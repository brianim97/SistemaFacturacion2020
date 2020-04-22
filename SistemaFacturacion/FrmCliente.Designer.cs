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
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.btnEditar = new System.Windows.Forms.Button();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.rbDni = new System.Windows.Forms.RadioButton();
			this.rbNombre = new System.Windows.Forms.RadioButton();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.tbTelefono = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.tbDireccion = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.tbNombre = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.tbDni = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tbBuscarCliente = new System.Windows.Forms.TextBox();
			this.dgvVistaCliente = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvVistaCliente)).BeginInit();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.btnEliminar);
			this.splitContainer1.Panel1.Controls.Add(this.btnGuardar);
			this.splitContainer1.Panel1.Controls.Add(this.btnEditar);
			this.splitContainer1.Panel1.Controls.Add(this.btnLimpiar);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.rbDni);
			this.splitContainer1.Panel2.Controls.Add(this.rbNombre);
			this.splitContainer1.Panel2.Controls.Add(this.panel1);
			this.splitContainer1.Panel2.Controls.Add(this.label1);
			this.splitContainer1.Panel2.Controls.Add(this.tbBuscarCliente);
			this.splitContainer1.Panel2.Controls.Add(this.dgvVistaCliente);
			this.splitContainer1.Size = new System.Drawing.Size(659, 485);
			this.splitContainer1.SplitterDistance = 106;
			this.splitContainer1.TabIndex = 0;
			// 
			// btnEliminar
			// 
			this.btnEliminar.Location = new System.Drawing.Point(3, 288);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(100, 36);
			this.btnEliminar.TabIndex = 34;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// btnGuardar
			// 
			this.btnGuardar.Location = new System.Drawing.Point(3, 162);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(100, 36);
			this.btnGuardar.TabIndex = 33;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// 
			// btnEditar
			// 
			this.btnEditar.Location = new System.Drawing.Point(3, 246);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(100, 36);
			this.btnEditar.TabIndex = 27;
			this.btnEditar.Text = "Editar";
			this.btnEditar.UseVisualStyleBackColor = true;
			this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.Location = new System.Drawing.Point(3, 204);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(100, 36);
			this.btnLimpiar.TabIndex = 32;
			this.btnLimpiar.Text = "Limpiar";
			this.btnLimpiar.UseVisualStyleBackColor = true;
			this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
			// 
			// rbDni
			// 
			this.rbDni.AutoSize = true;
			this.rbDni.Location = new System.Drawing.Point(322, 221);
			this.rbDni.Name = "rbDni";
			this.rbDni.Size = new System.Drawing.Size(44, 17);
			this.rbDni.TabIndex = 30;
			this.rbDni.Text = "DNI";
			this.rbDni.UseVisualStyleBackColor = true;
			// 
			// rbNombre
			// 
			this.rbNombre.AutoSize = true;
			this.rbNombre.Checked = true;
			this.rbNombre.Location = new System.Drawing.Point(225, 221);
			this.rbNombre.Name = "rbNombre";
			this.rbNombre.Size = new System.Drawing.Size(62, 17);
			this.rbNombre.TabIndex = 29;
			this.rbNombre.TabStop = true;
			this.rbNombre.Text = "Nombre";
			this.rbNombre.UseVisualStyleBackColor = true;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.tbTelefono);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.tbDireccion);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.tbNombre);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.tbDni);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(542, 171);
			this.panel1.TabIndex = 28;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(410, 98);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(17, 24);
			this.label8.TabIndex = 42;
			this.label8.Text = "*";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(410, 56);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(17, 24);
			this.label7.TabIndex = 41;
			this.label7.Text = "*";
			// 
			// tbTelefono
			// 
			this.tbTelefono.Location = new System.Drawing.Point(189, 131);
			this.tbTelefono.Name = "tbTelefono";
			this.tbTelefono.Size = new System.Drawing.Size(215, 20);
			this.tbTelefono.TabIndex = 40;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(117, 134);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(49, 13);
			this.label6.TabIndex = 39;
			this.label6.Text = "Telefono";
			// 
			// tbDireccion
			// 
			this.tbDireccion.Location = new System.Drawing.Point(189, 95);
			this.tbDireccion.Name = "tbDireccion";
			this.tbDireccion.Size = new System.Drawing.Size(215, 20);
			this.tbDireccion.TabIndex = 38;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(117, 98);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(52, 13);
			this.label5.TabIndex = 37;
			this.label5.Text = "Direccion";
			// 
			// tbNombre
			// 
			this.tbNombre.Location = new System.Drawing.Point(189, 56);
			this.tbNombre.Name = "tbNombre";
			this.tbNombre.Size = new System.Drawing.Size(215, 20);
			this.tbNombre.TabIndex = 36;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(117, 59);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(44, 13);
			this.label3.TabIndex = 35;
			this.label3.Text = "Nombre";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(410, 21);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(17, 24);
			this.label4.TabIndex = 34;
			this.label4.Text = "*";
			// 
			// tbDni
			// 
			this.tbDni.Location = new System.Drawing.Point(189, 18);
			this.tbDni.Name = "tbDni";
			this.tbDni.Size = new System.Drawing.Size(215, 20);
			this.tbDni.TabIndex = 31;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(117, 21);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(26, 13);
			this.label2.TabIndex = 30;
			this.label2.Text = "DNI";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(120, 198);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(101, 13);
			this.label1.TabIndex = 26;
			this.label1.Text = "Escribe para buscar";
			// 
			// tbBuscarCliente
			// 
			this.tbBuscarCliente.Location = new System.Drawing.Point(225, 195);
			this.tbBuscarCliente.Name = "tbBuscarCliente";
			this.tbBuscarCliente.Size = new System.Drawing.Size(182, 20);
			this.tbBuscarCliente.TabIndex = 25;
			this.tbBuscarCliente.TextChanged += new System.EventHandler(this.tbBuscarCliente_TextChanged);
			// 
			// dgvVistaCliente
			// 
			this.dgvVistaCliente.AllowUserToAddRows = false;
			this.dgvVistaCliente.AllowUserToDeleteRows = false;
			this.dgvVistaCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvVistaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvVistaCliente.Location = new System.Drawing.Point(3, 243);
			this.dgvVistaCliente.Name = "dgvVistaCliente";
			this.dgvVistaCliente.ReadOnly = true;
			this.dgvVistaCliente.Size = new System.Drawing.Size(542, 239);
			this.dgvVistaCliente.TabIndex = 24;
			this.dgvVistaCliente.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVistaCliente_CellDoubleClick);
			// 
			// FrmClientes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(659, 485);
			this.Controls.Add(this.splitContainer1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.MaximizeBox = false;
			this.Name = "FrmClientes";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Clientes";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmClientes_FormClosing);
			this.Load += new System.EventHandler(this.Clientes_Load);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvVistaCliente)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnEditar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbBuscarCliente;
		private System.Windows.Forms.DataGridView dgvVistaCliente;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.TextBox tbTelefono;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox tbDireccion;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox tbNombre;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tbDni;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.RadioButton rbDni;
		private System.Windows.Forms.RadioButton rbNombre;
		private System.Windows.Forms.Button btnEliminar;
	}
}