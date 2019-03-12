using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using capadata;
namespace capanegocio
{
    public class Negocio
    {
        capadata.datos data = new datos();
        public DataTable listarrol()
        {
            DataTable Dt = data.listarrol();
            return Dt;
        }
         public DataTable listarfp()
        {
            DataTable Dt = data.listarfp();
            return Dt;
        }
        public DataTable listarcompañiasdrp()
        {
            DataTable Dt = data.listarcompañiasdrp();
            return Dt;
        }
        public DataTable listarproductosdrp()
        {
            DataTable Dt = data.listarproductos();
            return Dt;
        }
        public DataTable listarcompañias()
        {
            
            DataTable Dt = data.listarcompañias();
            return Dt;
        }
        public DataTable listarproductoss(int id_compa)
        {
            DataTable Dt = data.listarproductos(id_compa);
            return Dt;
        }
        public DataTable listarbeneficios(int estado)
        {
            DataTable Dt = data.listarbeneficios();
            return Dt;
        }
        public DataTable listarventas(int estado)
        {
            DataTable Dt = data.listarventas();
            return Dt;
        }

        public string inhabilitar_compa(int id)
        {
            string result = data.inhabilitartarcompañias(id);
            return result;
        }
        public string inhabilitar_producto(int id)
        {
            string result = data.inhabilitarproducto(id);
            return result;
        }
        public string inhabilitar_beneficio(int id)
        {
            string result = data.inhabilitarbeneficio(id);
            return result;
        }
        public string inhabilitar_venta(int id)
        {
            string result = data.inhabilitarventa(id);
            return result;
        }
        public string editar_comapnia(int id, string nombre, string direccion, string telefono, string nit)
        {
            string result = data.editarcompania( id,nombre,direccion,telefono,nit);
            return result;
        }
        public string editar_producto(int id, string nombre, string valor, int cod_beneficio1, int cod_beneficio2, int cod_beneficio3)
        {
            string result = data.editarproducto(id,nombre,valor,cod_beneficio1,cod_beneficio2,cod_beneficio3);
            return result;
        }
        public string editar_beneficio(int id_beneficio, string nombre, string descripcion)
        {
            string result = data. editarbeneficio(id_beneficio,nombre,descripcion);
            return result;
        }

        public string insertar_comapnia(string nombre, string direccion, string telefono, string nit)
        {
            string result = data.insertarcompania( nombre, direccion, telefono, nit);
            return result;
        }
        public string insertar_producto(int cod_compania, string nombre, int prima,string cobertura)
        {
            string result = data.insertarproducto(cod_compania, nombre,  prima, cobertura);
            return result;
        }
        public string insertar_beneficio(string nombre, string descripcion)
        {
            string result = data.insertarbeneficio( nombre, descripcion);
            return result;
        }
        public string insertar_cliente(string nombre, string apellido, int cod_doc, string documento, string correo, string telefono, int cod_rol, string contraseña, int cod_compania)
        {
            string result = data.insertarcliente(nombre, apellido, cod_doc, documento, correo, telefono, cod_rol, contraseña, cod_compania);
            return result;
        }
        public string insertar_venta(int cod_sede, int cod_producto, int cod_forma_pago, int cod_asesor, int cod_cliente, string fecha, int valor_venta)
        {
            string result = data.insertarventa(cod_sede,cod_producto,cod_forma_pago,cod_asesor,cod_cliente, fecha,valor_venta);
            return result;
        }
        public string buscarcompania(int id)
        {
            string result = data.buscarcompania(id);
            return result;
        }
        public string buscarcliente(string doc)
        {
            string result = data.buscarcliente(doc);
            return result;
        }
        
    }
}
