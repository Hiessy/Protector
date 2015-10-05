using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessObject;
using Entities;

public partial class Registracion : System.Web.UI.Page
{
    private boProtectors protector = new boProtectors();

    private void CargarDatos()
    {

        ProtectorEntity entidad = (ProtectorEntity)Context.Items["Protector"];
        TextNombre.Text = entidad.Nombre;
        TextApellido.Text = entidad.Apellido;
        TextBoxContrase.Text = entidad.Contrase;
        TextTipo.Text = entidad.Tipo;
        TextDireccion.Text = entidad.Direccion;
        TextOrg.Text = entidad.Organizacion;
        TextTelefono.Text = entidad.Telefono;
        TextCorreo.Text = entidad.Correo;

    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            ViewState.Add("Nuevo", true);
        }
    }

    protected void btnAceptar_Click(object sender, System.EventArgs e)
    {

        // Se crea un objeto empleado entidad y se le asignan los
        // datos ingresados por el usuario.
        ProtectorEntity entidad = new ProtectorEntity();
        entidad.Nombre = TextNombre.Text;
        entidad.Apellido = TextApellido.Text;
        entidad.Contrase = TextBoxContrase.Text;
        entidad.Tipo = TextTipo.Text;
        entidad.Direccion = TextDireccion.Text;
        entidad.Organizacion = TextOrg.Text;
        entidad.Telefono = TextTelefono.Text;
        entidad.Correo = TextCorreo.Text;

        if (Convert.ToBoolean(ViewState["Nuevo"]))
        {
            protector.Insertar(entidad);
        }
        // Server.Transfer("EmpleadoOk.aspx");
    }
    protected void TextTipo_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}