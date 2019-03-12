using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using capanegocio;

namespace seguros_fala.views
{
    public partial class compañias : System.Web.UI.Page
    {
        capanegocio.Negocio objnegocio = new Negocio();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                llenarGridview();
                //cargarDrpd_vistas();
            }
        }
        private void llenarGridview()
        {
            DataTable Dt = new DataTable();
            Dt = objnegocio.listarcompañias();
            gvcompania.DataSource = Dt;
            gvcompania.DataBind();
        }

        protected void gvcompañia_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView gvcompania = (GridView)sender;
            gvcompania.PageIndex = e.NewPageIndex;
            llenarGridview();
        }

        protected void gvcompañia_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(gvcompania.DataKeys[e.RowIndex].Values[0]);
            objnegocio.inhabilitar_compa(id);
            llenarGridview();
        }

        protected void gvcompañia_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow GVrow = gvcompania.SelectedRow;
            int id = Convert.ToInt32(gvcompania.DataKeys[GVrow.RowIndex].Value);
           // string nom = GVrow.FindControl("Nombre").ToString();
           // string aid = gvcompania.DataKeys[Convert.ToInt32(GVrow.FindControl(""))].ToString();
          //      Value.ToString();
            Session["id_compania"] = id;
           // Session["com`pañia"] = aid;
            Response.Redirect("compañia_individual.aspx");
        }

        protected void bntinsertar_Click(object sender, EventArgs e)
        {
            Modall.Visible = true;
        }

        protected void btncerrarmodal_Click(object sender, EventArgs e)
        {
            Modall.Visible = false;
        }

        protected void btninsertarPersona_Click(object sender, EventArgs e)
        {
            if (objnegocio.insertar_comapnia(txtnombre.Text, txtdireccion.Text, txttelefono.Text, txtnit.Text) == "")
            {
                lblinsertar.Text = "LA COMPAÑIA SE INSERTO DE FORMA CORRECTA ";
                mensajeinsertar.Visible = true;
            }
            else
            {
                lblinsertar.Text = "El empleado ya existe!!";
                mensajeinsertar.Visible = true;
            }
        }

        protected void btnSalirModal_Click(object sender, EventArgs e)
        {
            Modall.Visible = false;
        }

        protected void btnventas_Click(object sender, EventArgs e)
        {
            Response.Redirect("ventas.aspx");
        }
    }
            
}