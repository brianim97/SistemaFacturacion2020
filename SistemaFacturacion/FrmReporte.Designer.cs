﻿namespace SistemaFacturacion
{
	partial class FrmReporte
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
			Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
			this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
			this.DataSet1 = new SistemaFacturacion.DataSet1();
			this.DatosFacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.DatosFacturaTableAdapter = new SistemaFacturacion.DataSet1TableAdapters.DatosFacturaTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DatosFacturaBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// reportViewer1
			// 
			this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
			reportDataSource1.Name = "DataSet1";
			reportDataSource1.Value = this.DatosFacturaBindingSource;
			this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
			this.reportViewer1.LocalReport.ReportEmbeddedResource = "SistemaFacturacion.Report1.rdlc";
			this.reportViewer1.Location = new System.Drawing.Point(0, 0);
			this.reportViewer1.Name = "reportViewer1";
			this.reportViewer1.ServerReport.BearerToken = null;
			this.reportViewer1.Size = new System.Drawing.Size(871, 530);
			this.reportViewer1.TabIndex = 0;
			// 
			// DataSet1
			// 
			this.DataSet1.DataSetName = "DataSet1";
			this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// DatosFacturaBindingSource
			// 
			this.DatosFacturaBindingSource.DataMember = "DatosFactura";
			this.DatosFacturaBindingSource.DataSource = this.DataSet1;
			// 
			// DatosFacturaTableAdapter
			// 
			this.DatosFacturaTableAdapter.ClearBeforeFill = true;
			// 
			// FrmReporte
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(871, 530);
			this.Controls.Add(this.reportViewer1);
			this.Name = "FrmReporte";
			this.Text = "FrmReporte";
			this.Load += new System.EventHandler(this.FrmReporte_Load);
			((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DatosFacturaBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.BindingSource DatosFacturaBindingSource;
		private DataSet1 DataSet1;
		private DataSet1TableAdapters.DatosFacturaTableAdapter DatosFacturaTableAdapter;
		public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
	}
}