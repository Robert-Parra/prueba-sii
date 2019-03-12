<%@ Page Title="" Language="C#" MasterPageFile="~/views/Master.Master" AutoEventWireup="true" CodeBehind="ventas.aspx.cs" Inherits="seguros_fala.views.ventas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../Css/Default.css" rel="stylesheet" />
    <h2>Ingreso de clientes</h2>
    <br />
    <div class="alert alert-danger" id="mensajeinsertar" runat="server" visible="False">
        <asp:Label Text="" runat="server" ID="lblinsertar" />
        <button type="button" class="close" data-dismiss="alert">&times;</button>
    </div>
    <div id="div1" runat="server" visible="false">
        <asp:Label ID="LBLNOMBRE" runat="server" CssClass="lblformulario" Text="Nombre"></asp:Label>
        <asp:TextBox ID="txtNombre" runat="server" CssClass=" TxtFormuario"></asp:TextBox>

        <asp:Label ID="Label6" runat="server" CssClass="lblformulario" Text="Rol:"></asp:Label>
        <asp:DropDownList ID="DrpRol" runat="server" CssClass=" dropdown">
        </asp:DropDownList><br />
        <br />

        <asp:Label ID="Label2" runat="server" Text="Apellido" CssClass="lblformulario"></asp:Label>
        <asp:TextBox ID="txtApellido" runat="server" CssClass=" TxtFormuario"></asp:TextBox><br />
        <br />

        <asp:Label ID="Label3" runat="server" Text="Documento" CssClass="lblformulario"></asp:Label>
        <asp:TextBox ID="TxtDoc" runat="server" CssClass="TxtFormuario"></asp:TextBox>
        <br />
        <br />


        <asp:Label ID="Label8" runat="server" Text="Tipo Documento" CssClass=" lblformulario"></asp:Label>
        <asp:DropDownList ID="DrpTipoDoc" runat="server" CssClass=" dropdown">
            <asp:ListItem Text="Cedula Ciudadana" Value="1" />
        </asp:DropDownList><br />
        <br />

        <asp:Label ID="Label4" runat="server" Text="Correo" CssClass="lblformulario"></asp:Label>
        <asp:TextBox ID="TxtCorreo" runat="server" TextMode="Email" CssClass=" TxtFormuario"></asp:TextBox><br />
        <br />

        <asp:Label ID="Label5" CssClass="lblformulario" runat="server" Text="Telefono"></asp:Label>
        <asp:TextBox ID="TxtTelefono" runat="server" MaxLength="10" CssClass=" TxtFormuario"></asp:TextBox><br />
        <asp:Label ID="Label1" runat="server" CssClass="lblformulario" Text="Compañia:"></asp:Label>
        <asp:DropDownList ID="drpcompañia" runat="server" CssClass=" dropdown">
        </asp:DropDownList><br />


        <br />
        <br />
        <br />
        <asp:Button ID="BtnGuardar" runat="server" Text="Guardar" CssClass=" btn btn-primary" OnClick="BtnGuardar_Click" />
    </div>

    <div id="divdos" runat="server" visible="false">
        <asp:Label ID="Label9" runat="server" Text="Documento Cliente" CssClass="lblformulario"></asp:Label>
        <asp:TextBox ID="txtcliente" runat="server" CssClass=" "></asp:TextBox><br />
        <br />

        <asp:Label ID="Label7" runat="server" Text="Compañia :" CssClass=" lblformulario"></asp:Label>
        <asp:DropDownList ID="drpproducto" runat="server" CssClass=" dropdown">
        </asp:DropDownList><br />
        <asp:Label ID="Label10" runat="server" Text="Medio de pago  :" CssClass=" lblformulario"></asp:Label>
        <asp:DropDownList ID="Drpformapago" runat="server" CssClass=" dropdown">
        </asp:DropDownList><br />
        <asp:Label ID="Label11" runat="server" Text="valor venta" CssClass="lblformulario"></asp:Label>
        <asp:TextBox ID="txtvalor" runat="server" CssClass=""></asp:TextBox><br />
        <br />
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Guardar" CssClass=" btn btn-primary"  OnClick="Button1_Click" />
    </div>
</asp:Content>
