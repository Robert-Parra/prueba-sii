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
    public partial class compañia_individual : System.Web.UI.Page
    {
        capanegocio.Negocio objnegocio = new Negocio();
        protected void Page_Load(object sender, EventArgs e)
        {
          //  lbltitulo.Text = Session["id_compania"].ToString();;
            if (!IsPostBack)
            {
                consultarcompañia(int.Parse(Session["id_compania"].ToString()));
                llenarGridview();
            }
        }
        private void consultarcompañia(int id )
        {
            lbltitulo.Text = objnegocio.buscarcompania(id);
        }
        private void llenarGridview()
        {
            DataTable Dt = new DataTable();
            Dt = objnegocio.listarproductoss(int.Parse(Session["id_compania"].ToString()));
            gvcompania.DataSource = Dt;
            gvcompania.DataBind();
        }

        protected void gvcompania_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {

        }
        protected void gvcompania_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(gvcompania.DataKeys[e.RowIndex].Values[0]);
            objnegocio.inhabilitar_producto(id);
            llenarGridview();
        }
        protected void gvcompania_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void bntinsertar_Click(object sender, EventArgs e)
        {
            Modalinsert.Visible = true;
        }

        protected void btnSalirModal_Click(object sender, EventArgs e)
        {
            Modalinsert.Visible = false;
        }

        protected void btninsertarPersona_Click(object sender, EventArgs e)
        {
            if (objnegocio.insertar_producto( int.Parse(Session["id_compania"].ToString()), txtnombre.Text, int.Parse(txtprima.Text) ,txtcobertura.Text) == "")
            {
                lblinsertar.Text = "LA COMPAÑIA SE INSERTO DE FORMA CORRECTA ";
                mensajeinsertar.Visible = true;
            }
            else
            {
                lblinsertar.Text = "El empleado ya existe!!";
                mensajeinsertar.Visible = true;
            }
            Modalinsert.Visible = false;
            llenarGridview();
        }

        protected void btncerrarmodal_Click(object sender, EventArgs e)
        {
            Modalinsert.Visible = false;
        }
    }
}