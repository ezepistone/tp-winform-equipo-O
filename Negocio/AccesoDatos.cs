using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class AccesoDatos
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;

        public SqlDataReader Lector
        {
            get { return lector; }
        }

        public AccesoDatos()
        {
            comando = new SqlCommand();
        }

        public void SetearParametro(string nombre, object valor)
        {
            comando.Parameters.AddWithValue(nombre, valor);
        }

        public void SetearConsulta(string consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
            comando.Parameters.Clear();
        }

        public void ejecutarLectura()
        {
            try
            {
                abrirConexion();
                comando.Connection = conexion;
                lector = comando.ExecuteReader();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void ejecutarAccion()
        {
            try
            {
                abrirConexion();
                comando.Connection = conexion;
                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public object ejecutarScalar()
        {
            try
            {
                abrirConexion();
                comando.Connection = conexion;
                return comando.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void cerrarConexion()
        {
            if (lector != null)
                lector.Close();
            conexion.Close();
        }

        public void abrirConexion()
        {
            if (conexion != null && conexion.State == ConnectionState.Open)
                return;

            string cadenaConexion1 = "server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true; TrustServerCertificate=True;";
            string cadenaConexion2 = "server=localhost; database=CATALOGO_P3_DB; integrated security=true; TrustServerCertificate=True;";

            try
            {
                conexion = new SqlConnection(cadenaConexion1);
                conexion.Open();
            }
            catch (Exception)
            {
                conexion = new SqlConnection(cadenaConexion2);
                conexion.Open();
            }
        }
    }
}