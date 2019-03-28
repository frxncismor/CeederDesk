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
    public partial class ReportePequeño : Form
    {
        public ReportePequeño()
        {
            InitializeComponent();
        }

        private void ReportePequeño_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetPequeño.Pequeño' Puede moverla o quitarla según sea necesario.
            this.PequeñoTableAdapter.Fill(this.DataSetPequeño.Pequeño);
            // TODO: esta línea de código carga datos en la tabla 'Usuarios.Miniatura' Puede moverla o quitarla según sea necesario.
            this.MiniaturaTableAdapter.Fill(this.Usuarios.Miniatura);

            this.reportViewer1.RefreshReport();
        }
    }
}
