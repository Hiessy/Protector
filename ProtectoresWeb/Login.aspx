<%@ Page Title="" Language="C#" MasterPageFile="~/Protector.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   
   
   <table id="Table1" cellspacing="1" cellpadding="1" border="0">
	    <tr>
		    <td>
			    <p align="right">
				    <asp:Label id="lblCorreo" runat="server">Correo electrónico:</asp:Label></p>
		    </td>
		    <td>
			    <asp:TextBox id="txtCorreo" runat="server" MaxLength="10"></asp:TextBox></td>
	    </tr>
	    <tr>
		    <td>
			    <P align="right">
				    <asp:Label id="lblClave" runat="server">Contraseña:</asp:Label></P>
		    </td>
		    <td>
			    <asp:TextBox id="txtClave" runat="server" MaxLength="20"></asp:TextBox></td>
	    </tr>
	   
	    <tr
		    <td></td>
		    <td>
			    <asp:Button id="btnIngresar" runat="server" Text="Ingresar" OnClick="btnIngresar_Click"></asp:Button>
			    <asp:Button id="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click"></asp:Button></td>
	    </tr>
	    <tr>
		   
				    
                </div>
		    </td>
	    </tr>
    </table>

</asp:Content>

