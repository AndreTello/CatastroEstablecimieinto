<%@ Page Title="Gestión de Zonas" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Ficha.aspx.cs" Inherits="ProyectoGIS.App.Catastro.Zona.Ficha" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <div id="tabla">
        <div class="table-responsive my-custom-scrollbar table-wrapper-scroll-y">
         <asp:GridView ID="MiTabla" class="table table-sm table-striped table-hover table-bordered table-dark text-center align-middle" runat="server" AutoGenerateColumns="false" >
            <Columns> 
                   
                <asp:BoundField DataField="zona_nombre" HeaderText="Id" />
                <asp:BoundField DataField="canton_nombre" HeaderText="Canton" />
                <asp:BoundField DataField="zona_codigo" HeaderText="Codigo Zona" />
                <asp:BoundField DataField="zona_nombre" HeaderText="Nombre" />
                <asp:BoundField DataField="zona_estado" HeaderText="Estado" />
                <asp:BoundField DataField="zona_observacion" HeaderText="Observaciones" />
                <asp:TemplateField HeaderText="Acciones">
                    <ItemTemplate>
                        <asp:Button ID="btnEditar" runat="server" Text="Editar" CommandName="Editar" CssClass="btn btn-primary" />
                        <asp:LinkButton ID="btnEliminar" runat="server" Text="Eliminar" CssClass="btn btn-danger" CommandName="Eliminar" CommandArgument='<%# Eval("zona_id") %>' OnClientClick="return confirm('¿Está seguro que desea eliminar este cantón?');" OnClick="btnEliminar_Click" />
                    </ItemTemplate>
                </asp:TemplateField>
                
               </Columns>
        </asp:GridView>

        </div>
    </div>
         <div class="text-end pt-4">
            <a class="btn btn-success end text-center" href="./Add"
                data-bs-target="#exampleModal">
                Agregar Zona
            </a>
        </div>
</asp:Content>
