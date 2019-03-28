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
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
        }

        private void Reportes_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void Reportes_Load_1(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet2.USUARIOS' Puede moverla o quitarla según sea necesario.
       

            this.reportViewer2.RefreshReport();
        }

        private void reportViewer2_Load(object sender, EventArgs e)
        {

        }

        private void Reportes_Load_2(object sender, EventArgs e)
        {

            this.reportViewer3.RefreshReport();
        }

        private void reportViewer3_Load(object sender, EventArgs e)
        {
            
        }

        private void Reportes_Load_3(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'Usuarios.Miniatura' Puede moverla o quitarla según sea necesario.
            this.MiniaturaTableAdapter.Fill(this.Usuarios.Miniatura);

            this.reportViewer4.RefreshReport();
        }
    }
}
