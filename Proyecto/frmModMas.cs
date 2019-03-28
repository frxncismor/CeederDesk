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
    public partial class frmModMas : Form
    {
        public frmModMas()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGenral ge = new frmGenral();
            ge.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (rdCachorro.Checked)
            {
                this.Hide();
                frmCacho ca = new frmCacho();
                ca.ShowDialog();
            }
            if (rdAdulto.Checked)
            {
                this.Hide();
                frmAdulto ad = new frmAdulto();
                ad.ShowDialog();
            }
        }
    }
}
