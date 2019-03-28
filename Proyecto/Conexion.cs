using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto
{
    class Conexion
    {
        private SqlConnection conexion;
        string Cadena;


        public void Conectar()
        {

            Cadena = "Data Source=.;Initial Catalog=CEEDER;Integrated Security=True";
            conexion = new SqlConnection(Cadena);
            conexion.Open();
        }

        internal static void Open()
        {
            throw new NotImplementedException();
        }


        public void Desconectar()
        {
            conexion.Close();
        }

        public void Altas(string Nom, string Usu, string Ema, string Con)
        {
            Conectar();
            string strSQLInsertUsuarios = "[sp_UsuariosAlta]";
            SqlCommand cmd = new SqlCommand(strSQLInsertUsuarios, conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter param;

            param = cmd.Parameters.Add("@Nombre", SqlDbType.VarChar, 100);
            param.Direction = ParameterDirection.Input;
            param.Value = Nom;
            param = cmd.Parameters.Add("@Email", SqlDbType.VarChar, 100);
            param.Direction = ParameterDirection.Input;
            param.Value = Ema;
            param = cmd.Parameters.Add("@Usuario", SqlDbType.VarChar, 30);
            param.Direction = ParameterDirection.Input;
            param.Value = Usu;
            param = cmd.Parameters.Add("@Pswd", SqlDbType.VarChar, -1);
            param.Direction = ParameterDirection.Input;
            param.Value = Con;
            int added = 0;
            try
            {
                conexion.Open();
                added = cmd.ExecuteNonQuery();
                MessageBox.Show("¡Gracias por Registrarte!");
            }
            catch (Exception err)
            {
                MessageBox.Show("¡Ups! Al parecer salió mal lo siguiente: " + err.Message);
            }
            finally
            {
                conexion.Close();
            }
            Desconectar();
        }

        public void modidfi(string Nom, string Usu, string Ema, string Con)
        {
            conexion.Close();
            string strSQLInsertUsuarios = "[sp_UsuariosTodoss]";
            SqlCommand cmd = new SqlCommand(strSQLInsertUsuarios, conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter param;

            param = cmd.Parameters.Add("@Nombre", SqlDbType.VarChar, 100);
            param.Direction = ParameterDirection.Input;
            param.Value = Nom;
            param = cmd.Parameters.Add("@Email", SqlDbType.VarChar, 100);
            param.Direction = ParameterDirection.Input;
            param.Value = Ema;
            param = cmd.Parameters.Add("@Usuario", SqlDbType.VarChar, 30);
            param.Direction = ParameterDirection.Input;
            param.Value = Usu;
            param = cmd.Parameters.Add("@Pswd", SqlDbType.VarChar, -1);
            param.Direction = ParameterDirection.Input;
            param.Value = Con;
            int added = 0;
            try
            {
                conexion.Open();
                added = cmd.ExecuteNonQuery();
                MessageBox.Show("¡Modificación exitosa!");
            }
            catch (Exception err)
            {
                MessageBox.Show("¡Ups! Al parecer salió mal lo siguiente: " + err.Message);
            }
            finally
            {
                conexion.Close();
            }
        }
        

        
    }
}