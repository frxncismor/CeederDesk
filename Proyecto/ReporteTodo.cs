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
    public partial class ReporteTodo : Form
    {
        public ReporteTodo()
        {
            InitializeComponent();
        }

        private void ReporteTodo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetTodo.DIETAS' Puede moverla o quitarla según sea necesario.
            this.DIETASTableAdapter.Fill(this.DataSetTodo.DIETAS);
            // TODO: esta línea de código carga datos en la tabla 'DataSetPequeño.Pequeño' Puede moverla o quitarla según sea necesario.
            this.PequeñoTableAdapter.Fill(this.DataSetPequeño.Pequeño);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
