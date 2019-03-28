using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class frmReportes : Form
    {
        public frmReportes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGenral gen =new frmGenral();
            gen.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnMiniatura_Click(object sender, EventArgs e)
        {
            Reportes reportes = new Reportes();
            reportes.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReportePequeño pe = new ReportePequeño();
            pe.ShowDialog();
        }

        private void btnMediano_Click(object sender, EventArgs e)
        {
            ReporteMediano me = new ReporteMediano();
            me.ShowDialog();
        }

        private void btnGrande_Click(object sender, EventArgs e)
        {
            ReporteGrande ga = new ReporteGrande();
            ga.ShowDialog();
        }

        private void btnTodo_Click(object sender, EventArgs e)
        {
            ReporteTodo to = new ReporteTodo();
            to.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ReportesFiltros ne = new ReportesFiltros();
            ne.ShowDialog();
        }

        private void frmReportes_Load(object sender, EventArgs e)
        {

        }
    }
}
