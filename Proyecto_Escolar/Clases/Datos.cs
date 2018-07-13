using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Proyecto_Escolar.Clases
{
    public class Datos
    {
        static SqlConnection conexion = new SqlConnection();
        public static void AbrirConexion()
        {
            conexion.ConnectionString = @"Data Source=DESKTOP-27PSK2P; Initial Catalog=ProyectoEscuela; Integrated Security=yes";
            conexion.Open();
        }
        public static void CerrarConexion()
        {
            conexion.Close();
        }
        public static string IniciarSesion(string usuario, string contraseña)
        {
            int logueado = 0;
            string mensaje = "";
            AbrirConexion();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Loguear";
            cmd.Connection = conexion;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@usuario", usuario));
            cmd.Parameters.Add(new SqlParameter("@contraseña", contraseña));
            //parametros de salida
            SqlParameter plogueado = new SqlParameter("@logueado", 0);
            plogueado.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(plogueado);
            //parametro de salida
            SqlParameter pmensaje = new SqlParameter("@mensaje", SqlDbType.VarChar);
            pmensaje.Direction = ParameterDirection.Output;
            pmensaje.Size = 40;
            cmd.Parameters.Add(pmensaje);

            cmd.ExecuteNonQuery();
            CerrarConexion();

            logueado = Int32.Parse(cmd.Parameters["@logueado"].Value.ToString());
            if (logueado>0)
            {
                mensaje = cmd.Parameters["@mensaje"].Value.ToString();
                return mensaje;
            }
            else
            {
                return mensaje = "";

            }
          
        }
        public static DataTable ObtenerMaterias()
        {
            DataTable tabla = new DataTable();
            AbrirConexion();
            SqlCommand cmd = new SqlCommand("sp_ObtenerMaterias", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(tabla);
            CerrarConexion();
            return tabla;
        }
        }
    }

