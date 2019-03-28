namespace Proyecto
{
    partial class ReporteTodo
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
            this.DataSetPequeño = new Proyecto.DataSetPequeño();
            this.PequeñoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PequeñoTableAdapter = new Proyecto.DataSetPequeñoTableAdapters.PequeñoTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSetTodo = new Proyecto.DataSetTodo();
            this.DIETASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DIETASTableAdapter = new Proyecto.DataSetTodoTableAdapters.DIETASTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetPequeño)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PequeñoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetTodo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DIETASBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DIETASBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Proyecto.ReportTodo.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(552, 331);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSetTodo
            // 
            this.DataSetTodo.DataSetName = "DataSetTodo";
            this.DataSetTodo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DIETASBindingSource
            // 
            this.DIETASBindingSource.DataMember = "DIETAS";
            this.DIETASBindingSource.DataSource = this.DataSetTodo;
            // 
            // DIETASTableAdapter
            // 
            this.DIETASTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteTodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 331);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteTodo";
            this.Text = "ReporteTodo";
            this.Load += new System.EventHandler(this.ReporteTodo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetPequeño)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PequeñoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetTodo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DIETASBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource PequeñoBindingSource;
        private DataSetPequeño DataSetPequeño;
        private DataSetPequeñoTableAdapters.PequeñoTableAdapter PequeñoTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DIETASBindingSource;
        private DataSetTodo DataSetTodo;
        private DataSetTodoTableAdapters.DIETASTableAdapter DIETASTableAdapter;
    }
}