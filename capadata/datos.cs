using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace capadata
{
    public class datos
    {
        SqlConnection Conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["Conexionsegura"].ToString());
        //roles 
        public DataTable listarrol()
        {
            DataTable resultado = new DataTable();
            try
            {
                SqlConnection connection = new SqlConnection(Conexion.ConnectionString);
                SqlCommand Comand = new SqlCommand();
                Comand.Connection = connection;
                Comand.CommandText = " select Id_rol, Nombre from Rol ";
                SqlDataAdapter Adapter = new SqlDataAdapter(Comand);
                Adapter.Fill(resultado);
                return resultado;
            }
            catch (Exception e)
            {
                return resultado;
            }
        }
        public DataTable listarfp()
        {
            DataTable resultado = new DataTable();
            try
            {
                SqlConnection connection = new SqlConnection(Conexion.ConnectionString);
                SqlCommand Comand = new SqlCommand();
                Comand.Connection = connection;
                Comand.CommandText = " select id_formapago, nombre from [dbo].[fomapago] ";
                SqlDataAdapter Adapter = new SqlDataAdapter(Comand);
                Adapter.Fill(resultado);
                return resultado;
            }
            catch (Exception e)
            {
                return resultado;
            }
        }
        // COMPAÑIAS 

        public DataTable listarcompañiasdrp()
        {
            DataTable resultado = new DataTable();
            try
            {
                SqlConnection connection = new SqlConnection(Conexion.ConnectionString);
                SqlCommand Comand = new SqlCommand();
                Comand.Connection = connection;
                Comand.CommandText = " select Id_compañia, Nombre from COMPAÑIA " +
                    " where estado  = 1 ";
                SqlDataAdapter Adapter = new SqlDataAdapter(Comand);
                Adapter.Fill(resultado);
                return resultado;
            }
            catch (Exception e)
            {
                return resultado;
            }
        }
        public DataTable listarproductos()
        {
            DataTable resultado = new DataTable();
            try
            {
                SqlConnection connection = new SqlConnection(Conexion.ConnectionString);
                SqlCommand Comand = new SqlCommand();
                Comand.Connection = connection;
                Comand.CommandText = " select id_producto, nombre_producto from producto " +
                    " where estado  = 1 ";
                SqlDataAdapter Adapter = new SqlDataAdapter(Comand);
                Adapter.Fill(resultado);
                return resultado;
            }
            catch (Exception e)
            {
                return resultado;
            }
        }

        public DataTable listarcompañias()
        {
            DataTable resultado = new DataTable();
            try
            {
                SqlConnection connection = new SqlConnection(Conexion.ConnectionString);
                SqlCommand Comand = new SqlCommand();
                Comand.Connection = connection;
                Comand.CommandText = " select * from COMPAÑIA " +
                    " where estado  = 1 ";
                SqlDataAdapter Adapter = new SqlDataAdapter(Comand);
                Adapter.Fill(resultado);
                return resultado;
            }
            catch (Exception e)
            {
                return resultado;
            }
        }
        public string buscarcompania(int id)
        {
            string result = "";
            DataTable resultado = new DataTable();
            try
            {
                SqlConnection connection = new SqlConnection(Conexion.ConnectionString);
                SqlCommand Comand = new SqlCommand();
                Comand.Connection = connection;
                Comand.CommandText = " Select Nombre from compañia where Id_compañia = " + id;
                SqlDataAdapter Adapter = new SqlDataAdapter(Comand);
                Adapter.Fill(resultado);
                result = Convert.ToString(resultado.Rows[0]["nombre"]);
                return result;
            }
            catch (Exception e)
            {
                return result;
            }
        }
         public string buscarcliente(string doc)
        {
            string result = "";
            DataTable resultado = new DataTable();
            try
            {
                SqlConnection connection = new SqlConnection(Conexion.ConnectionString);
                SqlCommand Comand = new SqlCommand();
                Comand.Connection = connection;
                Comand.CommandText = " Select id_persona from persona where documento = " + doc;
                SqlDataAdapter Adapter = new SqlDataAdapter(Comand);
                Adapter.Fill(resultado);
                result = Convert.ToString(resultado.Rows[0]["id_persona"]);
                return result;
            }
            catch (Exception e)
            {
                return result;
            }
        }



        // inhabilitar compañia
        public string inhabilitartarcompañias(int nit)
        {
            string result = "";
            try
            {
                string query = " update compañia set estado = 0 " +
                    " where Id_compañia = " + nit;
                SqlConnection connection = new SqlConnection(Conexion.ConnectionString);
                SqlCommand Comand = new SqlCommand(query, connection);
                SqlDataAdapter Adapter = new SqlDataAdapter(Comand);
                connection.Open();
                Comand.ExecuteNonQuery();
                return result;
            }
            catch (Exception e)
            {
                result = "no actualizo";
                return result;
            }
        }
        public string editarcompania(int id, string nombre, string direccion, string telefono, string nit)
        {
            string result = "";
            try
            {
                string query = " update  COMPAÑIA " +
                                     " set  nombre = '" + nombre + "', Direccion = '" + direccion + "', telefono = '" + telefono
                                     + "', nit = '" + nit + "'" +
                                     " where id_producto  = " + id;
                SqlConnection connection = new SqlConnection(Conexion.ConnectionString);
                SqlCommand Comand = new SqlCommand(query, connection);
                SqlDataAdapter Adapter = new SqlDataAdapter(Comand);
                connection.Open();
                Comand.ExecuteNonQuery();
                return result;
            }
            catch (Exception e)
            {
                result = "no actualizo";
                return result;
            }
        }
        public string insertarcompania(string nombre, string direccion, string telefono, string nit)
        {
            string result = "";
            try
            {
                string query = " INSERT INTO  [dbo].[COMPAÑIA] values ('" + nombre + "','" + direccion + "','" + telefono + "','" + nit + "', 1)";
                SqlConnection connection = new SqlConnection(Conexion.ConnectionString);
                SqlCommand Comand = new SqlCommand(query, connection);
                SqlDataAdapter Adapter = new SqlDataAdapter(Comand);
                connection.Open();
                Comand.ExecuteNonQuery();
                return result;
            }
            catch (Exception e)
            {
                result = "no actualizo";
                return result;
            }
        }

        // FIN COMPAÑIAS 

        // PRODUCTOS 

        public DataTable listarproductos(int id_com)
        {
            DataTable resultado = new DataTable();
            try
            {
                SqlConnection connection = new SqlConnection(Conexion.ConnectionString);
                SqlCommand Comand = new SqlCommand();
                Comand.Connection = connection;
                Comand.CommandText = " select * from producto " +
                    " where cod_compañia = " + id_com + "and estado = 1 ";
                SqlDataAdapter Adapter = new SqlDataAdapter(Comand);
                Adapter.Fill(resultado);
                return resultado;
            }
            catch (Exception e)
            {
                return resultado;
            }
        }

        public string inhabilitarproducto(int id_producto)
        {
            string result = "";
            try
            {
                string query = " update producto set estado = 0 " +
                    " where id_producto = " + id_producto;
                SqlConnection connection = new SqlConnection(Conexion.ConnectionString);
                SqlCommand Comand = new SqlCommand(query, connection);
                SqlDataAdapter Adapter = new SqlDataAdapter(Comand);
                connection.Open();
                Comand.ExecuteNonQuery();
                return result;
            }
            catch (Exception e)
            {
                result = "no actualizo";
                return result;
            }
        }

        public string editarproducto(int id, string nombre, string valor, int cod_beneficio1, int cod_beneficio2, int cod_beneficio3)
        {
            string result = "";
            try
            {
                string query = " update  producto " +
                                     " set  nombre = '" + nombre + "', valor_producto = '" + valor + "', cod_beneficio = " + cod_beneficio1
                                     + ", cod_segundo_beneficio = " + cod_beneficio2 + ", cod_tercer_beneficio = " + cod_beneficio3 +
                                     " where id_producto  = " + id;
                SqlConnection connection = new SqlConnection(Conexion.ConnectionString);
                SqlCommand Comand = new SqlCommand(query, connection);
                SqlDataAdapter Adapter = new SqlDataAdapter(Comand);
                connection.Open();
                Comand.ExecuteNonQuery();
                return result;
            }
            catch (Exception e)
            {
                result = "no actualizo";
                return result;
            }
        }
        public string insertarproducto(int cod_compania, string nombre, int prima, string cobertura)
        {
            string result = "";
            try
            {
                string query = " INSERT INTO  [dbo].[producto] values (" + cod_compania + ",'" + nombre + "'," + prima + ",'" + cobertura + "', 1 )";
                SqlConnection connection = new SqlConnection(Conexion.ConnectionString);
                SqlCommand Comand = new SqlCommand(query, connection);
                SqlDataAdapter Adapter = new SqlDataAdapter(Comand);
                connection.Open();
                Comand.ExecuteNonQuery();
                return result;
            }
            catch (Exception e)
            {
                result = "no actualizo";
                return result;
            }
        }
        //FIN PRODUCTOS

        //BENEFICIOS 
        public DataTable listarbeneficios()
        {
            DataTable resultado = new DataTable();
            try
            {
                SqlConnection connection = new SqlConnection(Conexion.ConnectionString);
                SqlCommand Comand = new SqlCommand();
                Comand.Connection = connection;
                Comand.CommandText = " select * from beneficio " +
                    " where estado = 1";
                SqlDataAdapter Adapter = new SqlDataAdapter(Comand);
                Adapter.Fill(resultado);
                return resultado;
            }
            catch (Exception e)
            {
                return resultado;
            }
        }

        public string inhabilitarbeneficio(int id_beneficio)
        {
            string result = "";
            try
            {
                string query = " update beneficio set estado = 0 " +
                    " where id_beneficio = " + id_beneficio;
                SqlConnection connection = new SqlConnection(Conexion.ConnectionString);
                SqlCommand Comand = new SqlCommand(query, connection);
                SqlDataAdapter Adapter = new SqlDataAdapter(Comand);
                connection.Open();
                Comand.ExecuteNonQuery();
                return result;
            }
            catch (Exception e)
            {
                result = "no actualizo";
                return result;
            }
        }

        public string editarbeneficio(int id_beneficio, string nombre, string descripcion)
        {
            string result = "";
            try
            {
                string query = " update  beneficio " +
                                     " set  Nombre = '" + nombre + "', descripcion = '" + descripcion +
                                     " where Id_beneficio = " + id_beneficio;
                SqlConnection connection = new SqlConnection(Conexion.ConnectionString);
                SqlCommand Comand = new SqlCommand(query, connection);
                SqlDataAdapter Adapter = new SqlDataAdapter(Comand);
                connection.Open();
                Comand.ExecuteNonQuery();
                return result;
            }
            catch (Exception e)
            {
                result = "no actualizo";
                return result;
            }
        }

        public string insertarbeneficio(string nombre, string descripcion)
        {
            string result = "";
            try
            {
                string query = " INSERT INTO  [dbo].[Beneficio] values ('" + nombre + "','" + descripcion + "', 1)";
                SqlConnection connection = new SqlConnection(Conexion.ConnectionString);
                SqlCommand Comand = new SqlCommand(query, connection);
                SqlDataAdapter Adapter = new SqlDataAdapter(Comand);
                connection.Open();
                Comand.ExecuteNonQuery();
                return result;
            }
            catch (Exception e)
            {
                result = "no actualizo";
                return result;
            }
        }
        // FIN BENEFICIOS 
        // VENTAS
        public DataTable listarventas()
        {
            DataTable resultado = new DataTable();
            try
            {
                SqlConnection connection = new SqlConnection(Conexion.ConnectionString);
                SqlCommand Comand = new SqlCommand();
                Comand.Connection = connection;
                Comand.CommandText = " select * from ventas";
                SqlDataAdapter Adapter = new SqlDataAdapter(Comand);
                Adapter.Fill(resultado);
                return resultado;
            }
            catch (Exception e)
            {
                return resultado;
            }
        }

        public string inhabilitarventa(int id_venta)
        {
            string result = "";
            try
            {
                string query = " update [dbo].[venta] set estado = 0 " +
                    " where id_venta = " + id_venta;
                SqlConnection connection = new SqlConnection(Conexion.ConnectionString);
                SqlCommand Comand = new SqlCommand(query, connection);
                SqlDataAdapter Adapter = new SqlDataAdapter(Comand);
                connection.Open();
                Comand.ExecuteNonQuery();
                return result;
            }
            catch (Exception e)
            {
                result = "no actualizo";
                return result;
            }
        }

        public string insertarcliente(string nombre, string apellido, int cod_doc, string documento, string correo, string telefono, int cod_rol, string contraseña, int cod_compania)
        {
            string result = "";
            try
            {
                string query = " INSERT INTO  [dbo].[persona] values ( '" + nombre + "','" + apellido + "'," + cod_doc + ",'" + documento + "','" + correo + "','" + telefono + "'," + cod_rol + ",'" + contraseña + "'," + cod_compania + ", 1 )";
                SqlConnection connection = new SqlConnection(Conexion.ConnectionString);
                SqlCommand Comand = new SqlCommand(query, connection);
                SqlDataAdapter Adapter = new SqlDataAdapter(Comand);
                connection.Open();
                Comand.ExecuteNonQuery();
                return result;
            }
            catch (Exception e)
            {
                result = "no actualizo";
                return result;
            }
        }
        public string insertarventa(int cod_sede, int cod_producto, int cod_forma_pago, int cod_asesor, int cod_cliente, string fecha, int valor_venta)
        {
            string result = "";
            try
            {
                string query = " INSERT INTO  [dbo].[venta] values (" + cod_sede + "," + cod_producto + "," + cod_forma_pago + "," + cod_asesor + "," + cod_cliente + ",'" + fecha + "'," + valor_venta + ", 1)";
                SqlConnection connection = new SqlConnection(Conexion.ConnectionString);
                SqlCommand Comand = new SqlCommand(query, connection);
                SqlDataAdapter Adapter = new SqlDataAdapter(Comand);
                connection.Open();
                Comand.ExecuteNonQuery();
                return result;
            }
            catch (Exception e)
            {
                result = "no actualizo";
                return result;
            }
        }
        // FIN ventas
    }
}
