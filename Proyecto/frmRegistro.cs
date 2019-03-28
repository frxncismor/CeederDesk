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
    public partial class frmRegistro : Form
    {
        SqlConnection Conexion;

        public frmRegistro()
        {
            InitializeComponent();
            Conexion = new SqlConnection(Properties.Settings.Default.Conexi);
            Conexion.Open();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInicio ini = new frmInicio();
            ini.ShowDialog();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtNombre.Text == "" || txtContra.Text == "" || txtEmail.Text == "")
                MessageBox.Show("Debe llenar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Conexion.Close();
                string strSQLInsertUsuarios = "[sp_UsuariosAlta]";
                SqlCommand cmd = new SqlCommand(strSQLInsertUsuarios, Conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter param;

                param = cmd.Parameters.Add("@Nombre", SqlDbType.VarChar, 100);
                param.Direction = ParameterDirection.Input;
                param.Value = txtNombre.Text;
                param = cmd.Parameters.Add("@Email", SqlDbType.VarChar, 100);
                param.Direction = ParameterDirection.Input;
                param.Value = txtEmail.Text;
                param = cmd.Parameters.Add("@Usuario", SqlDbType.VarChar, 30);
                param.Direction = ParameterDirection.Input;
                param.Value = txtUsuario.Text;
                param = cmd.Parameters.Add("@Pswd", SqlDbType.VarChar, -1);
                param.Direction = ParameterDirection.Input;
                param.Value = txtContra.Text;
                int added = 0;
                try
                {
                    Conexion.Open();
                    added = cmd.ExecuteNonQuery();
                    MessageBox.Show("¡Gracias por Registrarte!");
                }
                catch (Exception err)
                {
                    MessageBox.Show("¡Ups! Al parecer salió mal lo siguiente: " + err.Message);
                }
                finally
                {
                    Conexion.Close();
                }

                this.Hide();
                frmInicio mas = new frmInicio();
                mas.ShowDialog();
            }
        }


        private void frmRegistro_Load(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
    
 
