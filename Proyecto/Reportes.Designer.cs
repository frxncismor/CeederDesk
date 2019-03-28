namespace Proyecto
{
    partial class Reportes
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
            this.MiniaturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Usuarios = new Proyecto.Usuarios();
            this.reportViewer4 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.MiniaturaTableAdapter = new Proyecto.UsuariosTableAdapters.MiniaturaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.MiniaturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Usuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // MiniaturaBindingSource
            // 
            this.MiniaturaBindingSource.DataMember = "Miniatura";
            this.MiniaturaBindingSource.DataSource = this.Usuarios;
            // 
            // Usuarios
            // 
            this.Usuarios.DataSetName = "Usuarios";
            this.Usuarios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer4
            // 
            this.reportViewer4.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.MiniaturaBindingSource;
            this.reportViewer4.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer4.LocalReport.ReportEmbeddedResource = "Proyecto.Report1.rdlc";
            this.reportViewer4.Location = new System.Drawing.Point(0, 0);
            this.reportViewer4.Name = "reportViewer4";
            this.reportViewer4.ServerReport.BearerToken = null;
            this.reportViewer4.Size = new System.Drawing.Size(827, 392);
            this.reportViewer4.TabIndex = 0;
            // 
            // MiniaturaTableAdapter
            // 
            this.MiniaturaTableAdapter.ClearBeforeFill = true;
            // 
            // Reportes
            // 
            this.ClientSize = new System.Drawing.Size(827, 392);
            this.Controls.Add(this.reportViewer4);
            this.Name = "Reportes";
            this.Load += new System.EventHandler(this.Reportes_Load_3);
            ((System.ComponentModel.ISupportInitialize)(this.MiniaturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Usuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource USUARIOSBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer4;
        private System.Windows.Forms.BindingSource MiniaturaBindingSource;
        private Usuarios Usuarios;
        private UsuariosTableAdapters.MiniaturaTableAdapter MiniaturaTableAdapter;
    }
}