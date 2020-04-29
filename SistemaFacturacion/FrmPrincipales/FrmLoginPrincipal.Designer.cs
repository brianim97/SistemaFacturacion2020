namespace SistemaFacturacion
{
	partial class FrmLoginPrincipal
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLoginPrincipal));
			this.btnIngresar = new System.Windows.Forms.Button();
			this.tbUsuario = new System.Windows.Forms.TextBox();
			this.tbContraseña = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.btnAccProgramador = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnIngresar
			// 
			this.btnIngresar.BackColor = System.Drawing.Color.Transparent;
			this.btnIngresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnIngresar.Cursor = System.Windows.Forms.Cursors.Default;
			this.btnIngresar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
			this.btnIngresar.FlatAppearance.BorderSize = 0;
			this.btnIngresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(73)))), ((int)(((byte)(205)))));
			this.btnIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(73)))), ((int)(((byte)(205)))));
			this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnIngresar.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnIngresar.ForeColor = System.Drawing.Color.LightGray;
			this.btnIngresar.Location = new System.Drawing.Point(0, 419);
			this.btnIngresar.Name = "btnIngresar";
			this.btnIngresar.Size = new System.Drawing.Size(400, 41);
			this.btnIngresar.TabIndex = 0;
			this.btnIngresar.Text = "INGRESAR";
			this.btnIngresar.UseVisualStyleBackColor = false;
			this.btnIngresar.Click += new System.EventHandler(this.btnIniciar_Click);
			// 
			// tbUsuario
			// 
			this.tbUsuario.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.tbUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbUsuario.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.tbUsuario.Location = new System.Drawing.Point(22, 292);
			this.tbUsuario.Multiline = true;
			this.tbUsuario.Name = "tbUsuario";
			this.tbUsuario.Size = new System.Drawing.Size(352, 29);
			this.tbUsuario.TabIndex = 1;
			// 
			// tbContraseña
			// 
			this.tbContraseña.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.tbContraseña.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbContraseña.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.tbContraseña.Location = new System.Drawing.Point(22, 367);
			this.tbContraseña.Multiline = true;
			this.tbContraseña.Name = "tbContraseña";
			this.tbContraseña.PasswordChar = '•';
			this.tbContraseña.Size = new System.Drawing.Size(352, 29);
			this.tbContraseña.TabIndex = 2;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Transparent;
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue;
			this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(73)))), ((int)(((byte)(205)))));
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Gill Sans MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.DimGray;
			this.button1.Location = new System.Drawing.Point(369, 0);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(31, 30);
			this.button1.TabIndex = 3;
			this.button1.Text = "X";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Transparent;
			this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue;
			this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(73)))), ((int)(((byte)(205)))));
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.DimGray;
			this.button2.Location = new System.Drawing.Point(339, -1);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(30, 31);
			this.button2.TabIndex = 4;
			this.button2.Text = "_";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.Transparent;
			this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.button3.Cursor = System.Windows.Forms.Cursors.Default;
			this.button3.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue;
			this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.ForeColor = System.Drawing.Color.LightGray;
			this.button3.Location = new System.Drawing.Point(383, 467);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(17, 71);
			this.button3.TabIndex = 5;
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// btnAccProgramador
			// 
			this.btnAccProgramador.BackColor = System.Drawing.Color.Transparent;
			this.btnAccProgramador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnAccProgramador.Cursor = System.Windows.Forms.Cursors.Default;
			this.btnAccProgramador.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
			this.btnAccProgramador.FlatAppearance.BorderSize = 0;
			this.btnAccProgramador.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(73)))), ((int)(((byte)(205)))));
			this.btnAccProgramador.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(73)))), ((int)(((byte)(205)))));
			this.btnAccProgramador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAccProgramador.Font = new System.Drawing.Font("Gill Sans MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAccProgramador.ForeColor = System.Drawing.Color.LightGray;
			this.btnAccProgramador.Location = new System.Drawing.Point(0, 508);
			this.btnAccProgramador.Name = "btnAccProgramador";
			this.btnAccProgramador.Size = new System.Drawing.Size(135, 30);
			this.btnAccProgramador.TabIndex = 6;
			this.btnAccProgramador.Text = "Acceso Programador";
			this.btnAccProgramador.UseVisualStyleBackColor = false;
			this.btnAccProgramador.Click += new System.EventHandler(this.btnAccProgramador_Click);
			// 
			// FrmLoginPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(400, 550);
			this.Controls.Add(this.btnAccProgramador);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.tbContraseña);
			this.Controls.Add(this.tbUsuario);
			this.Controls.Add(this.btnIngresar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FrmLoginPrincipal";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Load += new System.EventHandler(this.FrmLoginPrincipal_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnIngresar;
		private System.Windows.Forms.TextBox tbUsuario;
		private System.Windows.Forms.TextBox tbContraseña;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button btnAccProgramador;
	}
}