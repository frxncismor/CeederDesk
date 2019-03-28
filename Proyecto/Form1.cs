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
    public partial class frmInicio : Form
    {

        SqlConnection Conexion;
        private bool authenticated;

        public frmInicio()
        {
            InitializeComponent();
            Conexion = new SqlConnection(Properties.Settings.Default.Conexi);
            Conexion.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegistro re = new frmRegistro();
            re.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
                MessageBox.Show("Debe llenar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Conexion.Close();
                string strSQLogin = "[sp_UsuariosLogin]";
                SqlCommand cmd = new SqlCommand(strSQLogin, Conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter param;

                param = cmd.Parameters.Add("@Usuario", SqlDbType.VarChar, 30);
                param.Direction = ParameterDirection.Input;
                param.Value = textBox1.Text;
                param = cmd.Parameters.Add("@Pswd", SqlDbType.VarChar, -1);
                param.Direction = ParameterDirection.Input;
                param.Value = textBox2.Text;
                int added = 0;
                try
                {
                    Conexion.Open();
                    added = cmd.ExecuteNonQuery();
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        this.Hide();
                        frmMascota ini = new frmMascota();
                        ini.ShowDialog();
                    }
                    else
                    {
                        textBox1.Text = "";
                        textBox2.Text = "";
                        MessageBox.Show("El usuario o contraseña no existe");
                    }
                    //MessageBox.Show("¡Gracias por Registrarte!");
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

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult resp;
            resp = MessageBox.Show("Desea salir de el programa?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resp == DialogResult.Yes)
                Application.Exit();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
