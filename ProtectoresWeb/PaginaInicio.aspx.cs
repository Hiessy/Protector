using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PaginaInicio : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void BtnBuscar_Click(object sender, EventArgs e)
    {
        Response.Redirect("AutoCompletar.aspx");
    }
    protected void BtnDetectar_Click(object sender, EventArgs e)
    {
        Response.Redirect("AutoDetectar.aspx");
    }
}

