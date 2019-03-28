using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Proyecto
{
    public partial class frmAdulto : Form
    {
        
        public frmAdulto()
        {
            InitializeComponent();
            
        }
        public void cargar_datos()
        {
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGenral ge = new frmGenral();
            ge.ShowDialog();
    
            }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMascota mas = new frmMascota();
            mas.ShowDialog();
        }

        private void frmAdulto_Load(object sender, EventArgs e)
        {

        }
    }
}
