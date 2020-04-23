namespace SistemaFacturacion
{
	partial class FrmAccesoProgramador
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAccesoProgramador));
			this.tbContraseña = new System.Windows.Forms.TextBox();
			this.btnIngresar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// tbContraseña
			// 
			this.tbContraseña.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.tbContraseña.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbContraseña.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.tbContraseña.Location = new System.Drawing.Point(73, 117);
			this.tbContraseña.Name = "tbContraseña";
			this.tbContraseña.PasswordChar = '◘';
			this.tbContraseña.Size = new System.Drawing.Size(180, 26);
			this.tbContraseña.TabIndex = 6;
			this.tbContraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbContraseña_KeyPress);
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
			this.btnIngresar.Location = new System.Drawing.Point(-3, 149);
			this.btnIngresar.Name = "btnIngresar";
			this.btnIngresar.Size = new System.Drawing.Size(161, 35);
			this.btnIngresar.TabIndex = 5;
			this.btnIngresar.Text = "INGRESAR";
			this.btnIngresar.UseVisualStyleBackColor = false;
			this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
			// 
			// btnCancelar
			// 
			this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
			this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Default;
			this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
			this.btnCancelar.FlatAppearance.BorderSize = 0;
			this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(73)))), ((int)(((byte)(205)))));
			this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(73)))), ((int)(((byte)(205)))));
			this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancelar.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancelar.ForeColor = System.Drawing.Color.LightGray;
			this.btnCancelar.Location = new System.Drawing.Point(164, 149);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(164, 35);
			this.btnCancelar.TabIndex = 8;
			this.btnCancelar.Text = "CANCELAR";
			this.btnCancelar.UseVisualStyleBackColor = false;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(112, 1);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(112, 110);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 9;
			this.pictureBox1.TabStop = false;
			// 
			// FrmAccesoProgramador
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlText;
			this.ClientSize = new System.Drawing.Size(329, 187);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.tbContraseña);
			this.Controls.Add(this.btnIngresar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmAccesoProgramador";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Acceso Programador";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox tbContraseña;
		private System.Windows.Forms.Button btnIngresar;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}