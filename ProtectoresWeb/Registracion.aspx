<%@ Page Title="" Language="C#" MasterPageFile="~/Protector.master" AutoEventWireup="true" CodeFile="Registracion.aspx.cs" Inherits="Registracion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

   <div id="registration_form">
<form method="post" action ="Registracion.aspx" >
    <div id="registration_fields">
        <br /> <br />
        <asp:Label ID="LabelNombre" class="textname" runat="server" Text="Nombre: "></asp:Label>
        <asp:TextBox ID="TextNombre" class = "textbox" runat="server" ></asp:TextBox>
        <br /> <br />
        
        <asp:Label ID="LabelApellido" class="textname" runat="server" Text="Apellido: "></asp:Label>
        <asp:TextBox ID="TextApellido" class = "textbox" runat="server"></asp:TextBox>
        <br /><br />   
        
        <asp:Label ID="LabelContrase" class="textname" runat="server" Text="Contraseña : "></asp:Label>
        <asp:TextBox ID="TextBoxContrase" class = "textbox" runat="server"></asp:TextBox>
        <br /><br />
    
        <asp:Label ID="LabelContraseR" class="textname" runat="server" Text="Repetir Contraseña: "></asp:Label>
        <asp:TextBox ID="TextContraseR" class = "textbox" runat="server"></asp:TextBox>
        <br /><br /> 
         
        <asp:Label ID="LabelDireccion" class="textname" runat="server" Text="Direccion: "></asp:Label>
        <asp:TextBox ID="TextDireccion" class = "textbox" runat="server"></asp:TextBox>
        <br /><br />
            
        <asp:Label ID="LabeOrg" class="textname" runat="server" Text="Organización: "></asp:Label>
        <asp:TextBox ID="TextOrg" class = "textbox" runat="server"></asp:TextBox>
        <br /><br /> 

        <asp:Label ID="LabelTelefono" class="textname" runat="server" Text="Telefono: "></asp:Label>
        <asp:TextBox ID="TextTelefono" class = "textbox" runat="server"></asp:TextBox>
        <br /><br />
        
        <asp:Label ID="LabelCorreo" class="textname" runat="server" Text="Correo Electronico: "></asp:Label>
        <asp:TextBox ID="TextCorreo" class = "textbox" runat="server"></asp:TextBox>
        <br /><br />  

          <asp:Label ID="LabelTipo" class="textname" runat="server" Text="Tipo de Animal: "></asp:Label>
        <asp:DropDownList ID="TextTipo" class = "dropdownbox" runat="server">
            <asp:ListItem>..</asp:ListItem>
            <asp:ListItem>Perro</asp:ListItem>
            <asp:ListItem>Gato</asp:ListItem>
            <asp:ListItem>Otro</asp:ListItem>
        </asp:DropDownList>       
     </div>

     <div id="checkbox">
    <asp:CheckBox ID="CheckBox_Protector" Text="Protector" runat="server" />
    <asp:CheckBox ID="CheckBox_Adoptador" Text="Adoptador" runat="server" />
     </div>
</form>
     
       <asp:Button ID="BtnAceptar" runat="server" class="button" Text="Aceptar" OnClick="btnAceptar_Click"/>     
       <asp:Label ID="LblEstado" runat="server"></asp:Label>
     
</div>
</asp:Content>

