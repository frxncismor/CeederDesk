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
    public partial class ReporteMediano : Form
    {
        public ReporteMediano()
        {
            InitializeComponent();
        }

        private void ReporteMediano_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetMediano.MASCOTAS' Puede moverla o quitarla según sea necesario.
            this.MASCOTASTableAdapter.Fill(this.DataSetMediano.MASCOTAS);
            // TODO: esta línea de código carga datos en la tabla 'Usuarios.Miniatura' Puede moverla o quitarla según sea necesario.
            this.MiniaturaTableAdapter.Fill(this.Usuarios.Miniatura);

            this.reportViewer1.RefreshReport();
        }
    }
}
