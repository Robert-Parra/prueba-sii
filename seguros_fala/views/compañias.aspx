<%@ Page Title="" Language="C#" MasterPageFile="~/views/Master.Master" AutoEventWireup="true" CodeBehind="compañias.aspx.cs" Inherits="seguros_fala.views.compañias" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="divfiltros" style="margin-left: 30%">
        <asp:Button ID="bntinsertar" CssClass="btn btn-primary" Style="margin-left: 10%; display: inline-block;" Text="agregar compañia" runat="server" OnClick="bntinsertar_Click" />
        <asp:Button ID="btnventas" CssClass="btn btn-primary" Style="margin-left: 10%; display: inline-block;" Text="agregar Venta" runat="server"  OnClick="btnventas_Click" />
    </div>
    <div id="Modall" class="modaluno" runat="server" visible="false">
        <div class="modalinsertar">
            <div class="modalheader">
                <asp:Button Text="X" ID="btncerrarmodal" runat="server" OnClick="btncerrarmodal_Click" CssClass="close" />
                <h2>Ingrese nueva compañia
                </h2>
                <div id="modal_body" class="modalbody">
                    <div class="contenido_body">
                        <div class="alert alert-danger" id="mensajeinsertar" runat="server" visible="False">
                            <asp:Label Text="" runat="server" ID="lblinsertar" />
                            <button type="button" class="close" data-dismiss="alert">&times;</button>
                        </div>

                        <asp:Label Text="Nombre" CssClass="lblacompañado" ID="Label1" runat="server" />


                        <asp:TextBox runat="server" ID="txtnombre" CssClass="txtacompañado" Style="width: 50%" Text="" placeholder="Ingrese el nombre " />

                        <asp:Label Text="Direccion" CssClass="lblformulario" runat="server" />
                        <asp:TextBox runat="server" CssClass="TxtFormuario" Text="" ID="txtdireccion" />

                        <asp:Label Text="Telefono" CssClass="lblformulario" runat="server" />
                        <asp:TextBox runat="server" ID="txttelefono" CssClass="TxtFormuario" Text="" />

                        <asp:Label Text="nit" CssClass="lblformulario" runat="server" />
                        <asp:TextBox runat="server" ID="txtnit" CssClass="TxtFormuario" Text="" />

                        <br />
                        <br />
                    </div>
                </div>
            </div>
            <div class="modalfooter">
                <asp:Button Text="Salir" CssClass="btnfooterModalleft" ID="btnSalirModal" runat="server" OnClick="btnSalirModal_Click" />
                <asp:Button Text="Guardar" CssClass="btnfooterModalright" ID="btninsertarPersona" runat="server" OnClick="btninsertarPersona_Click" />
            </div>
        </div>
    </div>
    <div id="divGV">
        <asp:GridView Width="85%" ID="gvcompania" CssClass="table table-hover align-center" Style="margin: auto;" runat="server" PageSize="4" AllowPaging="true"
            AutoGenerateColumns="false" DataKeyNames="Id_compañia" PagerSettings-Position="Bottom" PagerStyle-Height="15px"
            PagerStyle-Width="10" OnPageIndexChanging="gvcompañia_PageIndexChanging" OnRowDeleting="gvcompañia_RowDeleting"
            OnSelectedIndexChanged="gvcompañia_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="Id_compañia" ItemStyle-CssClass="visible-md-block" ControlStyle-CssClass="visible-md-block" HeaderText="id" HeaderStyle-BackColor="#000000" HeaderStyle-CssClass=" visible-md-block" />
                <asp:BoundField DataField="Nombre" HeaderText="Nombre" HeaderStyle-CssClass=" text-center" HeaderStyle-Font-Size="15px" HeaderStyle-BackColor="#006699" />
                <asp:BoundField DataField="Direccion" HeaderText="Rol" HeaderStyle-CssClass=" text-center" HeaderStyle-Font-Size="15px" HeaderStyle-BackColor="#006699" />
                <asp:BoundField DataField="telefono" HeaderText="telefono" HeaderStyle-CssClass=" text-center" HeaderStyle-Font-Size="15px" HeaderStyle-BackColor="#006699" />
                <asp:TemplateField ControlStyle-Width="230px" HeaderStyle-Width="230px" HeaderText="Accion" HeaderStyle-BackColor="#006699" HeaderStyle-CssClass=" text-center" HeaderStyle-Font-Size="15px">
                    <ItemTemplate>
                        <asp:Button ID="btn" Text="Ver" runat="server" Style="background-color: #10849a; color: #FFF; border-radius: 10px; width: 80px; display: inline-block" CommandName="Select"/>
                        <asp:Button ID="btninahbilitar" Text="inhabilitar" runat="server" Style="background-color: #10849a; color: #FFF; border-radius: 10px; width: 80px; display: inline-block" CommandName="Delete" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
