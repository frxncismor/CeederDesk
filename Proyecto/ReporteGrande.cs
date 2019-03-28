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
    public partial class ReporteGrande : Form
    {
        public ReporteGrande()
        {
            InitializeComponent();
        }

        private void ReporteGrande_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet2.SEXOS' Puede moverla o quitarla según sea necesario.
            this.SEXOSTableAdapter.Fill(this.DataSet2.SEXOS);
            // TODO: esta línea de código carga datos en la tabla 'DataSetMediano.MASCOTAS' Puede moverla o quitarla según sea necesario.
            this.MASCOTASTableAdapter.Fill(this.DataSetMediano.MASCOTAS);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
