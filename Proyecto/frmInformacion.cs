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
    public partial class frmInformacion : Form
    {
        public frmInformacion()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGenral gene = new frmGenral();
            gene.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult resp;
            resp = MessageBox.Show("Desea salir de el programa?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resp == DialogResult.Yes)
                Application.Exit();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmGenral re = new frmGenral();
            re.ShowDialog();
        }
    }
}
