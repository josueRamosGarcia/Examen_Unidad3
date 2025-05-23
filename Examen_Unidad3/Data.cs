using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_Unidad3
{
    internal class Data
    {
        String cadenaConexion = "Data Source=JOSUERAMOS\\SQLEXPRESS; initial catalog=tienda; integrated security=true; ";
        SqlConnection conexion;

        private SqlConnection abrirConexion()
        {
            try
            {
                conexion = new SqlConnection(cadenaConexion);
                conexion.Open();
                return conexion;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        private void cerrarConexion()
        {
            try
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                    conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public DataSet comandoOS(string comando)
        {
            try
            {
                DataSet ds = new DataSet();
                SqlDataAdapter comandoOS = new SqlDataAdapter(comando, abrirConexion());
                comandoOS.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                cerrarConexion();
            }
        }

        public bool ejecutar(string cmd)
        {
            try
            {
                SqlCommand comando = new SqlCommand(cmd, abrirConexion());
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
