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
    public partial class frmMosUsu : Form
    {
        SqlConnection Conexion;

        public frmMosUsu()
        {
            InitializeComponent();
            Conexion = new SqlConnection(Properties.Settings.Default.Conexi);
            Conexion.Open();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAjustes aju = new frmAjustes();
            aju.ShowDialog();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            Conexion.Close();
            string strSQLInsertUsuarios = "[sp_UsuariosTodoss]";
            SqlCommand cmd = new SqlCommand(strSQLInsertUsuarios, Conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter param;

            param = cmd.Parameters.Add("@Nombre", SqlDbType.VarChar, 100);
            param.Direction = ParameterDirection.Input;
            param.Value = txtUsuario.Text;
            param = cmd.Parameters.Add("@Email", SqlDbType.VarChar, 100);
            param.Direction = ParameterDirection.Input;
            param.Value = textBox1.Text;
            param = cmd.Parameters.Add("@Usuario", SqlDbType.VarChar, 30);
            param.Direction = ParameterDirection.Input;
            param.Value = txtNombre.Text;
            param = cmd.Parameters.Add("@Pswd", SqlDbType.VarChar, -1);
            param.Direction = ParameterDirection.Input;
            param.Value = txtContra.Text;
            int added = 0;
            try
            {
                Conexion.Open();
                added = cmd.ExecuteNonQuery();
                MessageBox.Show("¡Modificación exitosa!");
                this.Hide();
                frmAjustes aju = new frmAjustes();
                aju.ShowDialog();
            }
            catch (Exception err)
            {
                MessageBox.Show("¡Ups! Al parecer salió mal lo siguiente: " + err.Message);
            }
            finally
            {
                Conexion.Close();
            }
          
       

    }

    private void frmMosUsu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conexion.Close();
            string strSQLEliminarUsuarios = "[sp_UsuariosBaja]";
            SqlCommand cmd = new SqlCommand(strSQLEliminarUsuarios, Conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter param;

            param = cmd.Parameters.Add("@Usuario", SqlDbType.VarChar, 100);
            param.Direction = ParameterDirection.Input;
            param.Value = txtNombre.Text;
            int added = 0;
            try
            {
                Conexion.Open();
                added = cmd.ExecuteNonQuery();
                MessageBox.Show("¡Modificación exitosa!");
                this.Hide();
                frmAjustes aju = new frmAjustes();
                aju.ShowDialog();
            }
            catch (Exception err)
            {
                MessageBox.Show("¡Ups! Al parecer salió mal lo siguiente: " + err.Message);
            }
            finally
            {
                Conexion.Close();
            }


        }
    }
}
    

