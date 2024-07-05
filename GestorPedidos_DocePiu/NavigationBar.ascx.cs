using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GestorPedidos_DocePiu
{
    public partial class NavigationBar : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lnkRealizarPedido_Click(object sender, EventArgs e)
        {
            Response.Redirect("Pedido.aspx");
        }

        protected void lnkMisPedidos_Click(object sender, EventArgs e)
        {
            Response.Redirect("VPedidos.aspx");
        }

        protected void lnkMiPerfil_Click(object sender, EventArgs e)
        {
            Response.Redirect("VPerfil.aspx");
        }
    }
}