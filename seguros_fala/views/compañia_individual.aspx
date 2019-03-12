<%@ Page Title="" Language="C#" MasterPageFile="~/views/Master.Master" AutoEventWireup="true" CodeBehind="compañia_individual.aspx.cs" Inherits="seguros_fala.views.compañia_individual" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1 id="titulo" runat="server">
        <asp:Label ID="lbltitulo" Text="text" runat="server" />
    </h1>
    <div class="divfiltros" style="margin-left: 30%">
        <asp:Button ID="bntinsertar" CssClass="btn btn-primary" Style="margin-left: 10%; display: inline-block;" Text="Agregar Producto" runat="server"  OnClick="bntinsertar_Click"/>
    </div>

     <div id="Modalinsert" class="modaluno" runat="server" visible="false">
        <div class="modalinsertar">
            <div class="modalheader">
                <asp:Button Text="X" ID="btncerrarmodal" runat="server"  OnClick="btncerrarmodal_Click" CssClass="close" />
                <h2>Ingrese nueva producto
                </h2>
                <div id="modal_body" class="modalbody">
                    <div class="contenido_body">
                        <div class="alert alert-danger" id="mensajeinsertar" runat="server" visible="False">
                            <asp:Label Text="" runat="server" ID="lblinsertar" />
                            <button type="button" class="close" data-dismiss="alert">&times;</button>
                        </div>
                        <asp:Label Text="Nombre" CssClass="lblacompañado" ID="Label1" runat="server" />
                        <asp:TextBox runat="server" ID="txtnombre" CssClass="txtacompañado" Style="width: 50%" Text="" placeholder="Ingrese el nombre " />

                        <asp:Label Text="Prima" CssClass="lblformulario" runat="server"  placeholder="Ingrese  prima  "/>
                        <asp:TextBox runat="server"  CssClass=" TxtFormuario" Text="" ID="txtprima" />

                        <asp:Label Text="cobertura" CssClass="lblformulario" runat="server" placeholder="Ingrese  cobertura "/>
                        <asp:TextBox runat="server"  ID="txtcobertura" CssClass="TxtFormuario" Text="" />
                        <br />
                        <br />
                    </div>
                </div>
            </div>
            <div class="modalfooter">
                <asp:Button Text="Salir" CssClass="btnfooterModalleft" ID="btnSalirModal" runat="server"  OnClick="btnSalirModal_Click" />
                <asp:Button Text="Guardar" CssClass="btnfooterModalright" ID="btninsertarPersona" runat="server"  OnClick="btninsertarPersona_Click" />
            </div>
        </div>
    </div>

    <div id="divGV">
        <asp:GridView Width="85%" ID="gvcompania" CssClass="table table-hover align-center" Style="margin: auto;" runat="server" PageSize="4" AllowPaging="true"
            AutoGenerateColumns="false" DataKeyNames="id_producto" PagerSettings-Position="Bottom" PagerStyle-Height="15px"
            PagerStyle-Width="10" OnPageIndexChanging="gvcompania_PageIndexChanging" OnRowDeleting="gvcompania_RowDeleting"
            OnSelectedIndexChanged="gvcompania_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="id_producto" ItemStyle-CssClass="visible-md-block" ControlStyle-CssClass="visible-md-block" HeaderText="id" HeaderStyle-BackColor="#000000" HeaderStyle-CssClass=" visible-md-block" />
                <asp:BoundField DataField="nombre_producto" HeaderText="Nombre" HeaderStyle-CssClass=" text-center" HeaderStyle-Font-Size="15px" HeaderStyle-BackColor="#006699" />
                <asp:BoundField DataField="Prima" HeaderText="Prima" HeaderStyle-CssClass=" text-center" HeaderStyle-Font-Size="15px" HeaderStyle-BackColor="#006699" />
                <asp:BoundField DataField="cobertura" HeaderText="Cobertura" HeaderStyle-CssClass=" text-center" HeaderStyle-Font-Size="15px" HeaderStyle-BackColor="#006699" />
                <asp:TemplateField ControlStyle-Width="230px" HeaderStyle-Width="230px" HeaderText="Accion" HeaderStyle-BackColor="#006699" HeaderStyle-CssClass=" text-center" HeaderStyle-Font-Size="15px">
                    <ItemTemplate>
                        <asp:Button ID="btn" Text="Ver" runat="server" Style="background-color: #10849a; color: #FFF; border-radius: 10px; width: 80px; display: inline-block" CommandName="Select" />
                        <asp:Button ID="btninahbilitar" Text="inhabilitar" runat="server" Style="background-color: #10849a; color: #FFF; border-radius: 10px; width: 80px; display: inline-block" CommandName="delete" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
