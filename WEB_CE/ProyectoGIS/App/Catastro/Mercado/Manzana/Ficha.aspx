<%@ Page Title="Gestión de Manzanas" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Ficha.aspx.cs" Inherits="ProyectoGIS.App.Catastro.Manzana.Ficha" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div id="tabla">
        <div class="table-responsive my-custom-scrollbar table-wrapper-scroll-y">
            <asp:GridView ID="MiTabla" class="table table-sm table-striped table-hover table-bordered table-dark text-center align-middle" runat="server" AutoGenerateColumns="false" >
                <Columns>
                    <asp:BoundField DataField="manzana_id" HeaderText="Id" />
                    <asp:BoundField DataField="parroquia_nombre" HeaderText="Parroquia" />
                    <asp:BoundField DataField="manzana_codigo" HeaderText="Codigo Manzana" />
                    <asp:BoundField DataField="manzana_nombre" HeaderText="Nombre" />
                    <asp:BoundField DataField="manzana_estado" HeaderText="Estado" />
                    <asp:BoundField DataField="manzana_observacion" HeaderText="Observaciones" />
                    <asp:TemplateField HeaderText="Acciones">
                        <ItemTemplate>
                            <asp:Button ID="btnEditar" runat="server" Text="Editar" CommandName="Editar" CssClass="btn btn-primary" />
                            <asp:LinkButton ID="btnEliminar" runat="server" Text="Eliminar" CssClass="btn btn-danger" CommandName="Eliminar" CommandArgument='<%# Eval("manzana_id") %>' OnClientClick="return confirm('¿Está seguro que desea eliminar este cantón?');" OnClick="btnEliminar_Click"  />
                        </ItemTemplate>
                    </asp:TemplateField>

                </Columns>

            
            </asp:GridView>
        </div>
         <div class="text-end pt-4">
            <a class="btn btn-success end text-center" href="./Add"
                data-bs-target="#exampleModal">
                Agregar Manzana
            </a>
        </div>
    </div>
</asp:Content>
