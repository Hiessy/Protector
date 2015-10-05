<%@ Page Title="" Language="C#" MasterPageFile="~/Protector.master" AutoEventWireup="true" CodeFile="PaginaInicio.aspx.cs" Inherits="PaginaInicio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 
    <div>
    <br />
    <asp:LinkButton ID="LnkReg" runat="server"  Text="Registración" Width="108px" PostBackUrl="~/Registracion.aspx" />
    <br />
    <br /></div>
    
    <div>
    <br />
    <asp:Button ID="BtnBuscar" runat="server" OnClick="BtnBuscar_Click" Text="Buscar" Width="108px" />
        <br />
    <br />
      
    </div>
     <div>
    <br />
    <asp:Button ID="BtnDetectar" runat="server" OnClick="BtnDetectar_Click" Text="Auto Detectar" Width="108px" />
        <br />
    <br />
         </div>

</asp:Content>

