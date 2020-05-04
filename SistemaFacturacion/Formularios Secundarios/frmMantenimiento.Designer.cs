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
			this.components = new System.ComponentModel.Container();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabImpExpProd = new System.Windows.Forms.TabPage();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.btnImportar = new System.Windows.Forms.Button();
			this.cbHojaExcel = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.btnUbicacionImportar = new System.Windows.Forms.Button();
			this.tbUbicacionImportar = new System.Windows.Forms.TextBox();
			this.dgvExcelImportar = new System.Windows.Forms.DataGridView();
			this.label5 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label6 = new System.Windows.Forms.Label();
			this.btnUbicacionExportar = new System.Windows.Forms.Button();
			this.tbUbicacion = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
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
			this.tabImgComercio = new System.Windows.Forms.TabPage();
			this.pbImg = new System.Windows.Forms.PictureBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnSeleccionar = new System.Windows.Forms.Button();
			this.tabConexionDB = new System.Windows.Forms.TabPage();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.tbContraseña = new System.Windows.Forms.TextBox();
			this.tbUsuario = new System.Windows.Forms.TextBox();
			this.tbIPNombreServidor = new System.Windows.Forms.TextBox();
			this.tbNombreDb = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.rbConexionRemota = new System.Windows.Forms.RadioButton();
			this.rbConexionLocal = new System.Windows.Forms.RadioButton();
			this.label9 = new System.Windows.Forms.Label();
			this.btnComprobarConexion = new System.Windows.Forms.Button();
			this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.stockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.preciocompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.precioventaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.categoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.proveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.productoImportBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.lblRegistros = new System.Windows.Forms.Label();
			this.tabControl1.SuspendLayout();
			this.tabImpExpProd.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvExcelImportar)).BeginInit();
			this.panel1.SuspendLayout();
			this.tabBackup.SuspendLayout();
			this.tabRestore.SuspendLayout();
			this.tabImgComercio.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbImg)).BeginInit();
			this.tabConexionDB.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.productoImportBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabImpExpProd);
			this.tabControl1.Controls.Add(this.tabBackup);
			this.tabControl1.Controls.Add(this.tabRestore);
			this.tabControl1.Controls.Add(this.tabImgComercio);
			this.tabControl1.Controls.Add(this.tabConexionDB);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(872, 488);
			this.tabControl1.TabIndex = 0;
			// 
			// tabImpExpProd
			// 
			this.tabImpExpProd.Controls.Add(this.panel2);
			this.tabImpExpProd.Controls.Add(this.panel1);
			this.tabImpExpProd.Location = new System.Drawing.Point(4, 22);
			this.tabImpExpProd.Name = "tabImpExpProd";
			this.tabImpExpProd.Size = new System.Drawing.Size(864, 462);
			this.tabImpExpProd.TabIndex = 3;
			this.tabImpExpProd.Text = "Importar/Exportar Productos";
			this.tabImpExpProd.UseVisualStyleBackColor = true;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.lblRegistros);
			this.panel2.Controls.Add(this.btnLimpiar);
			this.panel2.Controls.Add(this.btnImportar);
			this.panel2.Controls.Add(this.cbHojaExcel);
			this.panel2.Controls.Add(this.label8);
			this.panel2.Controls.Add(this.label7);
			this.panel2.Controls.Add(this.btnUbicacionImportar);
			this.panel2.Controls.Add(this.tbUbicacionImportar);
			this.panel2.Controls.Add(this.dgvExcelImportar);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 74);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(864, 388);
			this.panel2.TabIndex = 1;
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.Location = new System.Drawing.Point(426, 336);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(99, 23);
			this.btnLimpiar.TabIndex = 9;
			this.btnLimpiar.Text = "Limpiar";
			this.btnLimpiar.UseVisualStyleBackColor = true;
			this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
			// 
			// btnImportar
			// 
			this.btnImportar.Location = new System.Drawing.Point(321, 336);
			this.btnImportar.Name = "btnImportar";
			this.btnImportar.Size = new System.Drawing.Size(99, 23);
			this.btnImportar.TabIndex = 8;
			this.btnImportar.Text = "Importar";
			this.btnImportar.UseVisualStyleBackColor = true;
			this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
			// 
			// cbHojaExcel
			// 
			this.cbHojaExcel.FormattingEnabled = true;
			this.cbHojaExcel.Location = new System.Drawing.Point(117, 336);
			this.cbHojaExcel.Name = "cbHojaExcel";
			this.cbHojaExcel.Size = new System.Drawing.Size(198, 21);
			this.cbHojaExcel.TabIndex = 7;
			this.cbHojaExcel.SelectedIndexChanged += new System.EventHandler(this.cbHojaExcel_SelectedIndexChanged);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(16, 339);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(73, 13);
			this.label8.TabIndex = 6;
			this.label8.Text = "Hoja de Excel";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(16, 304);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(94, 13);
			this.label7.TabIndex = 5;
			this.label7.Text = "Ubicacion Archivo";
			// 
			// btnUbicacionImportar
			// 
			this.btnUbicacionImportar.Location = new System.Drawing.Point(714, 299);
			this.btnUbicacionImportar.Name = "btnUbicacionImportar";
			this.btnUbicacionImportar.Size = new System.Drawing.Size(99, 23);
			this.btnUbicacionImportar.TabIndex = 4;
			this.btnUbicacionImportar.Text = "...";
			this.btnUbicacionImportar.UseVisualStyleBackColor = true;
			this.btnUbicacionImportar.Click += new System.EventHandler(this.btnUbicacionImportar_Click);
			// 
			// tbUbicacionImportar
			// 
			this.tbUbicacionImportar.Location = new System.Drawing.Point(117, 301);
			this.tbUbicacionImportar.Name = "tbUbicacionImportar";
			this.tbUbicacionImportar.ReadOnly = true;
			this.tbUbicacionImportar.Size = new System.Drawing.Size(591, 20);
			this.tbUbicacionImportar.TabIndex = 3;
			// 
			// dgvExcelImportar
			// 
			this.dgvExcelImportar.AutoGenerateColumns = false;
			this.dgvExcelImportar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvExcelImportar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvExcelImportar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.marcaDataGridViewTextBoxColumn,
            this.stockDataGridViewTextBoxColumn,
            this.codigoDataGridViewTextBoxColumn,
            this.preciocompraDataGridViewTextBoxColumn,
            this.precioventaDataGridViewTextBoxColumn,
            this.categoriaDataGridViewTextBoxColumn,
            this.proveedorDataGridViewTextBoxColumn});
			this.dgvExcelImportar.DataSource = this.productoImportBindingSource;
			this.dgvExcelImportar.Location = new System.Drawing.Point(8, 29);
			this.dgvExcelImportar.Name = "dgvExcelImportar";
			this.dgvExcelImportar.Size = new System.Drawing.Size(848, 248);
			this.dgvExcelImportar.TabIndex = 2;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(16, 13);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(48, 13);
			this.label5.TabIndex = 1;
			this.label5.Text = "Importar:";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.btnUbicacionExportar);
			this.panel1.Controls.Add(this.tbUbicacion);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(864, 74);
			this.panel1.TabIndex = 0;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(16, 33);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(94, 13);
			this.label6.TabIndex = 3;
			this.label6.Text = "Ubicacion Archivo";
			// 
			// btnUbicacionExportar
			// 
			this.btnUbicacionExportar.Location = new System.Drawing.Point(714, 28);
			this.btnUbicacionExportar.Name = "btnUbicacionExportar";
			this.btnUbicacionExportar.Size = new System.Drawing.Size(99, 23);
			this.btnUbicacionExportar.TabIndex = 2;
			this.btnUbicacionExportar.Text = "...";
			this.btnUbicacionExportar.UseVisualStyleBackColor = true;
			// 
			// tbUbicacion
			// 
			this.tbUbicacion.Location = new System.Drawing.Point(117, 30);
			this.tbUbicacion.Name = "tbUbicacion";
			this.tbUbicacion.ReadOnly = true;
			this.tbUbicacion.Size = new System.Drawing.Size(591, 20);
			this.tbUbicacion.TabIndex = 1;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(16, 13);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(49, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "Exportar:";
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
			this.tabBackup.Size = new System.Drawing.Size(864, 462);
			this.tabBackup.TabIndex = 0;
			this.tabBackup.Text = "Backup DB";
			this.tabBackup.UseVisualStyleBackColor = true;
			// 
			// btnRealizarBackup
			// 
			this.btnRealizarBackup.Location = new System.Drawing.Point(341, 186);
			this.btnRealizarBackup.Name = "btnRealizarBackup";
			this.btnRealizarBackup.Size = new System.Drawing.Size(195, 51);
			this.btnRealizarBackup.TabIndex = 3;
			this.btnRealizarBackup.Text = "Realizar Backup de Base de Datos";
			this.btnRealizarBackup.UseVisualStyleBackColor = true;
			this.btnRealizarBackup.Click += new System.EventHandler(this.btnRealizarBackup_Click);
			// 
			// btnBuscarBackup
			// 
			this.btnBuscarBackup.Location = new System.Drawing.Point(572, 119);
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
			this.label1.Location = new System.Drawing.Point(219, 124);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Ubicacion:";
			// 
			// tbUbicacionBackup
			// 
			this.tbUbicacionBackup.Location = new System.Drawing.Point(283, 121);
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
			this.tabRestore.Size = new System.Drawing.Size(864, 462);
			this.tabRestore.TabIndex = 1;
			this.tabRestore.Text = "Restore DB";
			this.tabRestore.UseVisualStyleBackColor = true;
			// 
			// btnRealizarRestore
			// 
			this.btnRealizarRestore.Location = new System.Drawing.Point(341, 186);
			this.btnRealizarRestore.Name = "btnRealizarRestore";
			this.btnRealizarRestore.Size = new System.Drawing.Size(195, 51);
			this.btnRealizarRestore.TabIndex = 7;
			this.btnRealizarRestore.Text = "Realizar Restore de Base de Datos";
			this.btnRealizarRestore.UseVisualStyleBackColor = true;
			this.btnRealizarRestore.Click += new System.EventHandler(this.btnRealizarRestore_Click);
			// 
			// btnBuscarRestore
			// 
			this.btnBuscarRestore.Location = new System.Drawing.Point(572, 119);
			this.btnBuscarRestore.Name = "btnBuscarRestore";
			this.btnBuscarRestore.Size = new System.Drawing.Size(110, 23);
			this.btnBuscarRestore.TabIndex = 6;
			this.btnBuscarRestore.Text = "Buscar";
			this.btnBuscarRestore.UseVisualStyleBackColor = true;
			this.btnBuscarRestore.Click += new System.EventHandler(this.btnBuscarRestore_Click);
			// 
			// tbUbicacionRestore
			// 
			this.tbUbicacionRestore.Location = new System.Drawing.Point(283, 121);
			this.tbUbicacionRestore.Name = "tbUbicacionRestore";
			this.tbUbicacionRestore.ReadOnly = true;
			this.tbUbicacionRestore.Size = new System.Drawing.Size(283, 20);
			this.tbUbicacionRestore.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(219, 124);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Ubicacion:";
			// 
			// tabImgComercio
			// 
			this.tabImgComercio.Controls.Add(this.pbImg);
			this.tabImgComercio.Controls.Add(this.label3);
			this.tabImgComercio.Controls.Add(this.btnSeleccionar);
			this.tabImgComercio.Location = new System.Drawing.Point(4, 22);
			this.tabImgComercio.Name = "tabImgComercio";
			this.tabImgComercio.Padding = new System.Windows.Forms.Padding(3);
			this.tabImgComercio.Size = new System.Drawing.Size(864, 462);
			this.tabImgComercio.TabIndex = 2;
			this.tabImgComercio.Text = "Imagen Comercio";
			this.tabImgComercio.UseVisualStyleBackColor = true;
			// 
			// pbImg
			// 
			this.pbImg.Location = new System.Drawing.Point(251, 124);
			this.pbImg.Name = "pbImg";
			this.pbImg.Size = new System.Drawing.Size(373, 143);
			this.pbImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbImg.TabIndex = 8;
			this.pbImg.TabStop = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(387, 103);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(86, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Imagen Logotipo";
			// 
			// btnSeleccionar
			// 
			this.btnSeleccionar.Location = new System.Drawing.Point(534, 273);
			this.btnSeleccionar.Name = "btnSeleccionar";
			this.btnSeleccionar.Size = new System.Drawing.Size(90, 20);
			this.btnSeleccionar.TabIndex = 6;
			this.btnSeleccionar.Text = "Seleccionar";
			this.btnSeleccionar.UseVisualStyleBackColor = true;
			// 
			// tabConexionDB
			// 
			this.tabConexionDB.Controls.Add(this.btnGuardar);
			this.tabConexionDB.Controls.Add(this.tbContraseña);
			this.tabConexionDB.Controls.Add(this.tbUsuario);
			this.tabConexionDB.Controls.Add(this.tbIPNombreServidor);
			this.tabConexionDB.Controls.Add(this.tbNombreDb);
			this.tabConexionDB.Controls.Add(this.label12);
			this.tabConexionDB.Controls.Add(this.label11);
			this.tabConexionDB.Controls.Add(this.label10);
			this.tabConexionDB.Controls.Add(this.rbConexionRemota);
			this.tabConexionDB.Controls.Add(this.rbConexionLocal);
			this.tabConexionDB.Controls.Add(this.label9);
			this.tabConexionDB.Controls.Add(this.btnComprobarConexion);
			this.tabConexionDB.Location = new System.Drawing.Point(4, 22);
			this.tabConexionDB.Name = "tabConexionDB";
			this.tabConexionDB.Size = new System.Drawing.Size(864, 462);
			this.tabConexionDB.TabIndex = 4;
			this.tabConexionDB.Text = "Conexion DB";
			this.tabConexionDB.UseVisualStyleBackColor = true;
			this.tabConexionDB.Click += new System.EventHandler(this.tabConexionDB_Click);
			// 
			// btnGuardar
			// 
			this.btnGuardar.Location = new System.Drawing.Point(582, 212);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(198, 23);
			this.btnGuardar.TabIndex = 11;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// 
			// tbContraseña
			// 
			this.tbContraseña.Location = new System.Drawing.Point(225, 244);
			this.tbContraseña.Name = "tbContraseña";
			this.tbContraseña.Size = new System.Drawing.Size(244, 20);
			this.tbContraseña.TabIndex = 10;
			// 
			// tbUsuario
			// 
			this.tbUsuario.Location = new System.Drawing.Point(225, 198);
			this.tbUsuario.Name = "tbUsuario";
			this.tbUsuario.Size = new System.Drawing.Size(244, 20);
			this.tbUsuario.TabIndex = 9;
			// 
			// tbIPNombreServidor
			// 
			this.tbIPNombreServidor.Location = new System.Drawing.Point(225, 153);
			this.tbIPNombreServidor.Name = "tbIPNombreServidor";
			this.tbIPNombreServidor.Size = new System.Drawing.Size(244, 20);
			this.tbIPNombreServidor.TabIndex = 8;
			// 
			// tbNombreDb
			// 
			this.tbNombreDb.Location = new System.Drawing.Point(225, 111);
			this.tbNombreDb.Name = "tbNombreDb";
			this.tbNombreDb.Size = new System.Drawing.Size(244, 20);
			this.tbNombreDb.TabIndex = 7;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(93, 247);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(61, 13);
			this.label12.TabIndex = 6;
			this.label12.Text = "Contraseña";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(93, 201);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(43, 13);
			this.label11.TabIndex = 5;
			this.label11.Text = "Usuario";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(93, 156);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(101, 13);
			this.label10.TabIndex = 4;
			this.label10.Text = "IP/Nombre Servidor";
			// 
			// rbConexionRemota
			// 
			this.rbConexionRemota.AutoSize = true;
			this.rbConexionRemota.Location = new System.Drawing.Point(630, 167);
			this.rbConexionRemota.Name = "rbConexionRemota";
			this.rbConexionRemota.Size = new System.Drawing.Size(109, 17);
			this.rbConexionRemota.TabIndex = 3;
			this.rbConexionRemota.Text = "Conexion Remota";
			this.rbConexionRemota.UseVisualStyleBackColor = true;
			this.rbConexionRemota.CheckedChanged += new System.EventHandler(this.rbConexionRemota_CheckedChanged);
			// 
			// rbConexionLocal
			// 
			this.rbConexionLocal.AutoSize = true;
			this.rbConexionLocal.Checked = true;
			this.rbConexionLocal.Location = new System.Drawing.Point(630, 134);
			this.rbConexionLocal.Name = "rbConexionLocal";
			this.rbConexionLocal.Size = new System.Drawing.Size(98, 17);
			this.rbConexionLocal.TabIndex = 2;
			this.rbConexionLocal.TabStop = true;
			this.rbConexionLocal.Text = "Conexion Local";
			this.rbConexionLocal.UseVisualStyleBackColor = true;
			this.rbConexionLocal.CheckedChanged += new System.EventHandler(this.rbConexionLocal_CheckedChanged);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(93, 114);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(117, 13);
			this.label9.TabIndex = 1;
			this.label9.Text = "Nombre Base de Datos";
			// 
			// btnComprobarConexion
			// 
			this.btnComprobarConexion.Location = new System.Drawing.Point(582, 241);
			this.btnComprobarConexion.Name = "btnComprobarConexion";
			this.btnComprobarConexion.Size = new System.Drawing.Size(198, 23);
			this.btnComprobarConexion.TabIndex = 0;
			this.btnComprobarConexion.Text = "Comprobar Conexion";
			this.btnComprobarConexion.UseVisualStyleBackColor = true;
			this.btnComprobarConexion.Click += new System.EventHandler(this.btnComprobarConexion_Click);
			// 
			// nombreDataGridViewTextBoxColumn
			// 
			this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
			this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
			this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
			// 
			// marcaDataGridViewTextBoxColumn
			// 
			this.marcaDataGridViewTextBoxColumn.DataPropertyName = "Marca";
			this.marcaDataGridViewTextBoxColumn.HeaderText = "Marca";
			this.marcaDataGridViewTextBoxColumn.Name = "marcaDataGridViewTextBoxColumn";
			// 
			// stockDataGridViewTextBoxColumn
			// 
			this.stockDataGridViewTextBoxColumn.DataPropertyName = "Stock";
			this.stockDataGridViewTextBoxColumn.HeaderText = "Stock";
			this.stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
			// 
			// codigoDataGridViewTextBoxColumn
			// 
			this.codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
			this.codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
			this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
			// 
			// preciocompraDataGridViewTextBoxColumn
			// 
			this.preciocompraDataGridViewTextBoxColumn.DataPropertyName = "Precio_compra";
			this.preciocompraDataGridViewTextBoxColumn.HeaderText = "Precio_compra";
			this.preciocompraDataGridViewTextBoxColumn.Name = "preciocompraDataGridViewTextBoxColumn";
			// 
			// precioventaDataGridViewTextBoxColumn
			// 
			this.precioventaDataGridViewTextBoxColumn.DataPropertyName = "Precio_venta";
			this.precioventaDataGridViewTextBoxColumn.HeaderText = "Precio_venta";
			this.precioventaDataGridViewTextBoxColumn.Name = "precioventaDataGridViewTextBoxColumn";
			// 
			// categoriaDataGridViewTextBoxColumn
			// 
			this.categoriaDataGridViewTextBoxColumn.DataPropertyName = "Categoria";
			this.categoriaDataGridViewTextBoxColumn.HeaderText = "Categoria";
			this.categoriaDataGridViewTextBoxColumn.Name = "categoriaDataGridViewTextBoxColumn";
			// 
			// proveedorDataGridViewTextBoxColumn
			// 
			this.proveedorDataGridViewTextBoxColumn.DataPropertyName = "Proveedor";
			this.proveedorDataGridViewTextBoxColumn.HeaderText = "Proveedor";
			this.proveedorDataGridViewTextBoxColumn.Name = "proveedorDataGridViewTextBoxColumn";
			// 
			// productoImportBindingSource
			// 
			this.productoImportBindingSource.DataSource = typeof(SistemaFacturacion.ProductoImport);
			// 
			// lblRegistros
			// 
			this.lblRegistros.AutoSize = true;
			this.lblRegistros.Location = new System.Drawing.Point(711, 13);
			this.lblRegistros.Name = "lblRegistros";
			this.lblRegistros.Size = new System.Drawing.Size(54, 13);
			this.lblRegistros.TabIndex = 10;
			this.lblRegistros.Text = "Registros:";
			// 
			// frmMantenimiento
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(872, 488);
			this.Controls.Add(this.tabControl1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Name = "frmMantenimiento";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Mantenimiento";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMantenimiento_FormClosing);
			this.Load += new System.EventHandler(this.frmMantenimiento_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabImpExpProd.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvExcelImportar)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.tabBackup.ResumeLayout(false);
			this.tabBackup.PerformLayout();
			this.tabRestore.ResumeLayout(false);
			this.tabRestore.PerformLayout();
			this.tabImgComercio.ResumeLayout(false);
			this.tabImgComercio.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbImg)).EndInit();
			this.tabConexionDB.ResumeLayout(false);
			this.tabConexionDB.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.productoImportBindingSource)).EndInit();
			this.ResumeLayout(false);

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
		private System.Windows.Forms.TabPage tabImpExpProd;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.ComboBox cbHojaExcel;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button btnUbicacionImportar;
		private System.Windows.Forms.TextBox tbUbicacionImportar;
		private System.Windows.Forms.DataGridView dgvExcelImportar;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btnUbicacionExportar;
		private System.Windows.Forms.TextBox tbUbicacion;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TabPage tabImgComercio;
		private System.Windows.Forms.PictureBox pbImg;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnSeleccionar;
		private System.Windows.Forms.Button btnImportar;
		private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn preciocompraDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn precioventaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn categoriaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn proveedorDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource productoImportBindingSource;
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.TabPage tabConexionDB;
		private System.Windows.Forms.TextBox tbContraseña;
		private System.Windows.Forms.TextBox tbUsuario;
		private System.Windows.Forms.TextBox tbIPNombreServidor;
		private System.Windows.Forms.TextBox tbNombreDb;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.RadioButton rbConexionRemota;
		private System.Windows.Forms.RadioButton rbConexionLocal;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button btnComprobarConexion;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.Label lblRegistros;
	}
}