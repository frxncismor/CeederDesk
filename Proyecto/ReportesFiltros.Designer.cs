namespace Proyecto
{
    partial class ReportesFiltros
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DataSetPequeño = new Proyecto.DataSetPequeño();
            this.PequeñoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PequeñoTableAdapter = new Proyecto.DataSetPequeñoTableAdapters.PequeñoTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetPequeño)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PequeñoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(29, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(110, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(113, 20);
            this.textBox1.TabIndex = 2;
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
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Proyecto.ReportSize.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(77, 60);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 3;
            // 
            // ReportesFiltros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 327);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ReportesFiltros";
            this.Text = "ReportesFiltros";
            this.Load += new System.EventHandler(this.ReportesFiltros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetPequeño)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PequeñoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource PequeñoBindingSource;
        private DataSetPequeño DataSetPequeño;
        private DataSetPequeñoTableAdapters.PequeñoTableAdapter PequeñoTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}