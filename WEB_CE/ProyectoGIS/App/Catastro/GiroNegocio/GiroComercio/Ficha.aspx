<%@ Page Title="Gestión Giro de Negocio" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Ficha.aspx.cs" Inherits="ProyectoGIS.App.Catastro.GiroNegocio.GiroComercio.Ficha" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div id="tabla">
        <div class="table-responsive my-custom-scrollbar table-wrapper-scroll-y">
            <asp:GridView ID="MiTabla" class="table table-sm table-striped table-hover table-bordered table-dark text-center align-middle" runat="server" AutoGenerateColumns="false" >
                <Columns>
                    <asp:BoundField DataField="giro_negocio_id" HeaderText="Id" />
                    <asp:BoundField DataField="tipo_producto_nombre" HeaderText="Tipo de Producto" />
                    <asp:BoundField DataField="giro_negocio_nombre" HeaderText="Nombre" />
                    <asp:BoundField DataField="giro_negocio_subgiro" HeaderText="Sub Giros" />
                    <asp:BoundField DataField="giro_negocio_abastecimiento" HeaderText="Abastecimiento" />
                    <asp:BoundField DataField="giro_negocio_observacion" HeaderText="Observación" />
                    <asp:BoundField DataField="giro_negocio_estado" HeaderText="Estado" />
                    <asp:TemplateField HeaderText="Acciones">
                        <ItemTemplate>
                            <asp:Button ID="btnEditar" runat="server" Text="Editar" CommandName="Editar" CssClass="btn btn-primary" />
                            <asp:LinkButton ID="btnEliminar" runat="server" Text="Eliminar" CssClass="btn btn-danger" CommandName="Eliminar" CommandArgument='<%# Eval("giro_negocio_id") %>' OnClientClick="return confirm('¿Está seguro que desea eliminar este cantón?');" OnClick="btnEliminar_Click"  />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
                
        </div>
         <div class="text-end pt-4">
            <a class="btn btn-success end text-center" href="./Add"
                data-bs-target="#exampleModal">
                Agregar Giro de Negocio
            </a>
        </div>
    </div>
</asp:Content>
