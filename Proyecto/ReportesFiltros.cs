using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Resources;
using System.Windows.Forms;


namespace Proyecto
{
    public partial class ReportesFiltros : Form
    {
        public object ReportViewer1 { get; private set; }

        public ReportesFiltros()
        {
            InitializeComponent();
           
        }

        private void ReportesFiltros_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetPequeño.Pequeño' Puede moverla o quitarla según sea necesario.
            this.PequeñoTableAdapter.Fill(this.DataSetPequeño.Pequeño);

            this.reportViewer1.RefreshReport();

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            //CEEDERDataSet.SIZESDataTable dt = new CEEDERDataSet.SIZESDataTable();
            //CEEDERDataSetTableAdapters.SIZESTableAdapter da = new CEEDERDataSetTableAdapters.SIZESTableAdapter();
            //da.Fill(dt);
            //ReportDataSource RD = new ReportDataSource();
            //RD.Value = dt;
            //RD.Name = "DataSet1";
            //reportViewer1.LocalReport.DataSources.Clear();
            //reportViewer1.LocalReport.DataSources.Add(RD);
            //reportViewer1.LocalReport.ReportEmbeddedResource = "ReportSize.rdlc";
            //reportViewer1.LocalReport.ReportPath = @"ReportSize.rdlc";
            //reportViewer1.LocalReport.Refresh();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string datos = (textBox1.Text);
            ReportParameter p1 = new ReportParameter("FiltroNombre",datos.ToString());
            reportViewer1.LocalReport.SetParameters(p1);
            reportViewer1.LocalReport.Refresh();

        }
    }
}
