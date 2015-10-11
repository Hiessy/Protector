<%@ Page Title="" Language="C#" MasterPageFile="~/Protector.master" AutoEventWireup="true" CodeFile="Registracion.aspx.cs" Inherits="Registracion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

   <div>
<form method="post" action ="Registracion.aspx" >
    
        <br /> <br />
        <asp:Label ID="LabelNombre" runat="server" Text="Nombre: "></asp:Label>
        <asp:TextBox ID="TextNombre" runat="server" style="margin-left: 14px" Width="225px"></asp:TextBox>
        <br /> <br />
        
        <asp:Label ID="LabelApellido" runat="server" Text="Apellido: "></asp:Label>
        <asp:TextBox ID="TextApellido" runat="server" style="margin-left: 14px" Width="224px"></asp:TextBox>
        <br /><br />   
        
        <asp:Label ID="LabelContrase" runat="server" Text="Contraseña : "></asp:Label>
        <asp:TextBox ID="TextBoxContrase" runat="server" style="margin-left: 14px" Width="200px"></asp:TextBox>
        <br /><br />
    
        <asp:Label ID="LabelContraseR" runat="server" Text="Repetir Contraseña: "></asp:Label>
        <asp:TextBox ID="TextContraseR" runat="server" style="margin-left: 14px" Width="160px"></asp:TextBox>
        <br /><br /> 
   
        <asp:Label ID="LabelTipo" runat="server" Text="Tipo de Animal: "></asp:Label>
        <asp:DropDownList ID="TextTipo" runat="server" Height="16px" Width="199px" 
             BackColor="Silver" >
            <asp:ListItem>..</asp:ListItem>
            <asp:ListItem>Perro</asp:ListItem>
            <asp:ListItem>Gato</asp:ListItem>
            <asp:ListItem>Otro</asp:ListItem>
        </asp:DropDownList>
        
        <!--Para la seleccion de otro debe agregar un campo para escribir-->
        
        <br /><br />
    
        <asp:Label ID="LabelDireccion" runat="server" Text="Direccion: "></asp:Label>
        <asp:TextBox ID="TextDireccion" runat="server" style="margin-left: 14px" Width="217px" placeholder="Enter a location"></asp:TextBox>
        <br /><br />
            
        <asp:Label ID="LabeOrg" runat="server" Text="Organización: "></asp:Label>
        <asp:TextBox ID="TextOrg" runat="server" Width="208px"></asp:TextBox>
        <br /><br /> 

        <asp:Label ID="LabelTelefono" runat="server" Text="Telefono: "></asp:Label>
        <asp:TextBox ID="TextTelefono" runat="server" Width="237px"></asp:TextBox>
        <br /><br />
        
        <asp:Label ID="LabelCorreo" runat="server" Text="Correo Electronico: "></asp:Label>
        <asp:TextBox ID="TextCorreo" runat="server" Width="180px"></asp:TextBox>
        <br /><br /> 
     
</form>
     
        <asp:Button ID="BtnAceptar" runat="server" Text="Aceptar" OnClick="btnAceptar_Click" style="margin-left: 200px" Width="78px"/>
     
       <asp:Label ID="LblEstado" runat="server"></asp:Label>
     
</div>
</asp:Content>

