namespace Proyecto
{
    partial class ReportePequeño
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
            this.Usuarios = new Proyecto.Usuarios();
            this.MiniaturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MiniaturaTableAdapter = new Proyecto.UsuariosTableAdapters.MiniaturaTableAdapter();
            this.DataSetPequeño = new Proyecto.DataSetPequeño();
            this.PequeñoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PequeñoTableAdapter = new Proyecto.DataSetPequeñoTableAdapters.PequeñoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Usuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MiniaturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetPequeño)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PequeñoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.PequeñoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Proyecto.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(825, 369);
            this.reportViewer1.TabIndex = 0;
            // 
            // Usuarios
            // 
            this.Usuarios.DataSetName = "Usuarios";
            this.Usuarios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MiniaturaBindingSource
            // 
            this.MiniaturaBindingSource.DataMember = "Miniatura";
            this.MiniaturaBindingSource.DataSource = this.Usuarios;
            // 
            // MiniaturaTableAdapter
            // 
            this.MiniaturaTableAdapter.ClearBeforeFill = true;
            // 
            // DataSetPequeño
            // 
            this.DataSetPequeño.DataSetName = "DataSetPequeño";
            this.DataSetPequeño.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PequeñoBindingSource
            // 
            this.PequeñoBindingSource.DataMember = "Pequeño";
            this.PequeñoBindingSource.DataSource = this.DataSetPequeño;
            // 
            // PequeñoTableAdapter
            // 
            this.PequeñoTableAdapter.ClearBeforeFill = true;
            // 
            // ReportePequeño
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 369);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ReportePequeño";
            this.Text = "ReportePequeño";
            this.Load += new System.EventHandler(this.ReportePequeño_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Usuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MiniaturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetPequeño)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PequeñoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource MiniaturaBindingSource;
        private Usuarios Usuarios;
        private UsuariosTableAdapters.MiniaturaTableAdapter MiniaturaTableAdapter;
        private System.Windows.Forms.BindingSource PequeñoBindingSource;
        private DataSetPequeño DataSetPequeño;
        private DataSetPequeñoTableAdapters.PequeñoTableAdapter PequeñoTableAdapter;
    }
}