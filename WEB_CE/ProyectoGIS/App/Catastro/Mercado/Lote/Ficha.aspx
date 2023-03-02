<%@ Page Title="Gestión de Lotes" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Ficha.aspx.cs" Inherits="ProyectoGIS.App.Catastro.Lote.Ficha" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div id="tabla">
        <div class="table-responsive my-custom-scrollbar table-wrapper-scroll-y">
            <asp:GridView ID="MiTabla" class="table table-sm table-striped table-hover table-bordered table-dark text-center align-middle" runat="server" AutoGenerateColumns="false" >
                <Columns>
                    <asp:BoundField DataField="lote_id" HeaderText="Id" SortExpression="Id" />
                    <asp:BoundField DataField="manzana_nombre" HeaderText="Manzana" SortExpression="Manzana" />
                    <asp:BoundField DataField="lote_codigo" HeaderText="Codigo Lote" SortExpression="CodigoLote" />
                    <asp:BoundField DataField="lote_nombre" HeaderText="Nombre" SortExpression="Nombre" />
                    <asp:BoundField DataField="lote_estado" HeaderText="Estado" SortExpression="Estado" />
                    <asp:BoundField DataField="lote_observacion" HeaderText="Observaciones" SortExpression="Observaciones" />
                    <asp:TemplateField HeaderText="Acciones">
                        <ItemTemplate>
                            <asp:Button ID="btnEditar" runat="server" Text="Editar" CommandName="Editar" CssClass="btn btn-primary" />
                            <asp:LinkButton ID="btnEliminar" runat="server" Text="Eliminar" CssClass="btn btn-danger" CommandName="Eliminar" CommandArgument='<%# Eval("lote_id") %>' OnClientClick="return confirm('¿Está seguro que desea eliminar este cantón?');" OnClick="btnEliminar_Click"  />
                        </ItemTemplate>
                    </asp:TemplateField>
                    
                </Columns>

                
            </asp:GridView>
        </div>
         <div class="text-end pt-4">
            <a class="btn btn-success end text-center" href="./Add"
                data-bs-target="#exampleModal">
                Agregar Lote
            </a>
        </div>
    </div>
</asp:Content>
