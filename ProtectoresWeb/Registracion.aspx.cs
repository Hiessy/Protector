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
        TextCorreo.Text = entidad.Correo;
        TextNombre.Text = entidad.Nombre;
        TextApellido.Text = entidad.Apellido;
        TextOrg.Text = entidad.Organizacion;
        TextBoxContrase.Text = entidad.Contrase;
        TextDireccion.Text = entidad.Direccion;
        TextTelefono.Text = entidad.Telefono;
        //TextTipo.Text = entidad.Tipo;
        
        

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

        // Se crea un objeto protector entidad y se le asignan los
        // datos ingresados por el usuario.
        ProtectorEntity entidad = new ProtectorEntity();
        
        entidad.Correo = TextCorreo.Text;
        entidad.Nombre = TextNombre.Text;
        entidad.Apellido = TextApellido.Text;
        entidad.Organizacion = TextOrg.Text;
        entidad.Contrase = TextBoxContrase.Text;
        entidad.Direccion = TextDireccion.Text;
        entidad.Telefono = TextTelefono.Text;
        //entidad.Tipo = TextTipo.Text;
        
        LblEstado.Text = "Ingreso correcto";

        if (Convert.ToBoolean(ViewState["Nuevo"]))
        {
            protector.Insertar(entidad);
        }
        // Server.Transfer("EmpleadoOk.aspx");
        TextCorreo.Text="";
        TextNombre.Text = "";
        TextApellido.Text ="";
        TextOrg.Text="";
        TextBoxContrase.Text="";
        TextDireccion.Text="";
        TextTelefono.Text = "";
    }
}