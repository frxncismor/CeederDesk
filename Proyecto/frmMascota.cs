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
    public partial class frmMascota : Form
    {
   
        public frmMascota()
        {
            InitializeComponent();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInicio reg = new frmInicio();
            reg.ShowDialog();
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
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void showSelectedButton_Click(object sender, System.EventArgs e)
        {
        
        } 

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void frmMascota_Load(object sender, EventArgs e)
        {

        }
    }
}
