using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using capanegocio;

namespace seguros_fala.views
{
    public partial class ventas : System.Web.UI.Page
    {
        capanegocio.Negocio objnegocio = new Negocio();
        protected void Page_Load(object sender, EventArgs e)
        {
            div1.Visible = true;
            if (!IsPostBack)
            {
                cargarDrpd_vistas();
                cargarDrpd_vistasrol();
            }
        }
        private void cargarDrpd_vistas()
        {
            // compañia
            drpcompañia.DataSource = objnegocio.listarcompañiasdrp();
            drpcompañia.DataValueField = "Id_compañia";
            drpcompañia.DataTextField = "Nombre";
            drpcompañia.DataBind();
        }
        private void cargarDrpd_vistasrol()
        {
            // Roles 
            DrpRol.DataSource = objnegocio.listarrol();
            DrpRol.DataValueField = "Id_rol";
            DrpRol.DataTextField = "Nombre";
            DrpRol.DataBind();
        }
        private void caregardrpproduct()
        {
            // compañia
            drpproducto.DataSource = objnegocio.listarproductosdrp();
            drpproducto.DataValueField = "id_producto";
            drpproducto.DataTextField = "nombre_producto";
            drpproducto.DataBind();
        }
        private void cargarDrpformapago()
        {
            // Roles 
            Drpformapago.DataSource = objnegocio.listarfp();
            Drpformapago.DataValueField = "id_formapago";
            Drpformapago.DataTextField = "nombre";
            Drpformapago.DataBind();
        }

        protected void BtnGuardar_Click(object sender, EventArgs e)
        {
            string resultado = objnegocio.insertar_cliente(txtNombre.Text, txtApellido.Text, int.Parse(DrpTipoDoc.SelectedValue), TxtDoc.Text, TxtCorreo.Text, TxtTelefono.Text, int.Parse(DrpRol.SelectedValue), "", int.Parse(drpcompañia.SelectedValue));
            if (resultado == "")
            {
                lblinsertar.Text = "el cliente se registro con exito !!";
                mensajeinsertar.Visible = true;
                div1.Visible = false;
                divdos.Visible = true;
                caregardrpproduct();
                cargarDrpformapago();
            }
            else
                {
                lblinsertar.Text = "el cliente no se registro";
                mensajeinsertar.Visible = true;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int cod_cliente = int.Parse(objnegocio.buscarcliente((txtcliente.Text)));
            string resultado = objnegocio.insertar_venta(int.Parse(drpcompañia.SelectedValue), int.Parse(drpproducto.SelectedValue), int.Parse(Drpformapago.SelectedValue), 1, cod_cliente, DateTime.Today.ToString(), int.Parse(txtvalor.Text) );
            if (resultado == "")
            {
                lblinsertar.Text = "la venta se registro con exito !!";
                mensajeinsertar.Visible = true;
                div1.Visible = false;
                divdos.Visible = true;
            }
            else
            {
                lblinsertar.Text = "la venta no se registro";
                mensajeinsertar.Visible = true;
            }
            //Response.Redirect("compañias.aspx");
        }
    }
}