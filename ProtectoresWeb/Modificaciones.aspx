<%@ Page Title="" Language="C#" MasterPageFile="~/Protector.master" AutoEventWireup="true" CodeFile="Modificaciones.aspx.cs" Inherits="Modificaciones" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

 <div id="CenterHolder" class="fleft">   <br /> <br />
        <asp:Label ID="LabelNombre" runat="server" Text="Nombre: "></asp:Label>
        <asp:TextBox ID="TextNombre" runat="server" style="margin-left: 14px" Width="225px"></asp:TextBox>
        <br /> <br />
        
        <asp:Label ID="LabelApellido" runat="server" Text="Apellido: "></asp:Label>
        <asp:TextBox ID="TextApellido" runat="server" style="margin-left: 14px" Width="224px"></asp:TextBox>
        <br /><br />   
        
        <asp:Label ID="LabelContrase" runat="server" Text="Contraseña : "></asp:Label>
        <asp:TextBox ID="TextBoxContrase" runat="server" style="margin-left: 14px" Width="200px"></asp:TextBox>
        <br /><br />
    
       <asp:Label ID="LabelDireccion" runat="server" Text="Direccion: "></asp:Label>
        <asp:TextBox ID="TextDireccion" runat="server" style="margin-left: 14px" Width="217px" placeholder="Enter a location"></asp:TextBox>
        <br /><br />
            
        <asp:Label ID="LabeOrg" runat="server" Text="Organización: "></asp:Label>
        <asp:TextBox ID="TextOrg" runat="server" Width="208px"></asp:TextBox>
        <br /><br /> 

                
        <asp:Label ID="LabelCorreo" runat="server" Text="Correo Electronico: "></asp:Label>
        <asp:TextBox ID="TextCorreo" runat="server" Width="180px"></asp:TextBox>
        <br /><br /> 
    <asp:Button ID="BtnModificar" runat="server" Text="Modificar" />
    
    <asp:Button ID="BtnElimiar" runat="server" Text="Eliminar" />
    </div>

    </asp:Content>


