namespace Proyecto
{
    partial class ReporteGrande
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
            this.SEXOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet2 = new Proyecto.DataSet2();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSetMediano = new Proyecto.DataSetMediano();
            this.MASCOTASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MASCOTASTableAdapter = new Proyecto.DataSetMedianoTableAdapters.MASCOTASTableAdapter();
            this.SEXOSTableAdapter = new Proyecto.DataSet2TableAdapters.SEXOSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SEXOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetMediano)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MASCOTASBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // SEXOSBindingSource
            // 
            this.SEXOSBindingSource.DataMember = "SEXOS";
            this.SEXOSBindingSource.DataSource = this.DataSet2;
            // 
            // DataSet2
            // 
            this.DataSet2.DataSetName = "DataSet2";
            this.DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SEXOSBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Proyecto.ReportGrande.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(851, 369);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // DataSetMediano
            // 
            this.DataSetMediano.DataSetName = "DataSetMediano";
            this.DataSetMediano.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MASCOTASBindingSource
            // 
            this.MASCOTASBindingSource.DataMember = "MASCOTAS";
            this.MASCOTASBindingSource.DataSource = this.DataSetMediano;
            // 
            // MASCOTASTableAdapter
            // 
            this.MASCOTASTableAdapter.ClearBeforeFill = true;
            // 
            // SEXOSTableAdapter
            // 
            this.SEXOSTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteGrande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 369);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteGrande";
            this.Text = "ReporteGrande";
            this.Load += new System.EventHandler(this.ReporteGrande_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SEXOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetMediano)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MASCOTASBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource MASCOTASBindingSource;
        private DataSetMediano DataSetMediano;
        private DataSetMedianoTableAdapters.MASCOTASTableAdapter MASCOTASTableAdapter;
        private System.Windows.Forms.BindingSource SEXOSBindingSource;
        private DataSet2 DataSet2;
        private DataSet2TableAdapters.SEXOSTableAdapter SEXOSTableAdapter;
    }
}