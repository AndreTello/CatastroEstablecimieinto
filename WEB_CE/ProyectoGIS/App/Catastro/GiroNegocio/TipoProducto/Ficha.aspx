<%@ Page Title="Gestión Tipo de Producto" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Ficha.aspx.cs" Inherits="ProyectoGIS.App.Catastro.GiroNegocio.TipoProducto.Ficha" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div id="tabla">
        <div class="table-responsive my-custom-scrollbar table-wrapper-scroll-y">
            <asp:GridView ID="MiTabla" class="table table-sm text-nowrap table-striped table-hover table-bordered table-secondary text-center align-middle" runat="server" AutoGenerateColumns="false" >
                <Columns>
                    <asp:BoundField DataField="tipo_producto_nombre" HeaderText="NOMBRE" SortExpression="NOMBRE" />
                    <asp:BoundField DataField="tipo_producto_detalle" HeaderText="DETALLE" SortExpression="DETALLW" />
                     <asp:TemplateField HeaderText="OBSERVACIONES">
                        <ItemTemplate>
                            <asp:Label ID="lblObservacion" Text='<%# Eval("tipo_producto_observacion").ToString() == "" ? "SIN OBSERVACIONES" : Eval("tipo_producto_observacion").ToString() %>' runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="ESTADO">
                       <ItemTemplate>
                            <asp:Label ID="lblEstado" runat="server" Text='<%# Eval("tipo_producto_estado").ToString() == "1" ? "Activo" : "Inactivo" %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="ACCIONES">
                           <ItemTemplate>
                                    <a href="./Add?id=<%# Eval("tipo_producto_id") %>" class="btn btn-primary">Editar</a>
                            <asp:LinkButton ID="btnEliminar" runat="server" Text="Eliminar" CssClass="btn btn-danger" CommandName="Eliminar" CommandArgument='<%# Eval("tipo_producto_id") %>' OnClientClick="return confirm('¿Está seguro que desea eliminar este cantón?');" OnClick="btnEliminar_Click"  />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                
           </asp:GridView>
        </div>
         <div class="text-end pt-4">
            <a class="btn btn-success end text-center" href="./Add"
                data-bs-target="#exampleModal">
                Agregar Tipo Producto
            </a>
        </div>
    </div>
</asp:Content>
