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
    public partial class frmGenral : Form
    {
       

        public frmGenral()
        {
            InitializeComponent();
         
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult resp;
            resp = MessageBox.Show("Desea salir de el programa?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resp == DialogResult.Yes)
                Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAjustes reg = new frmAjustes();
            reg.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInformacion inf = new frmInformacion();
            inf.ShowDialog();
        }

        private void frmGenral_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void button5_MouseClick(object sender, MouseEventArgs e)
        {

            this.button3.BackColor = Color.Red;
        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {

            this.button3.BackColor = Color.Green;
        }

        private void frmGenral_Load(object sender, EventArgs e)
        {

        }

        private void frmGenral_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
             this.Hide();
            frmCacho v = new frmCacho();
            frmAdulto a = new frmAdulto();
            
           
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmReportes rep = new frmReportes();
            rep.ShowDialog();
        }
    }
}
