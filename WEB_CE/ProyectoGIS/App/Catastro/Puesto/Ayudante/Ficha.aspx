<%@ Page Title="Gestión del Ayudante" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Ficha.aspx.cs" Inherits="ProyectoGIS.App.Catastro.Puesto.Ayudante.Ficha" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div id="tabla">
        <div class="table-responsive my-custom-scrollbar table-wrapper-scroll-y">
            <asp:GridView ID="MiTabla" class="table table-sm table-striped table-hover table-bordered table-dark text-center align-middle" runat="server" AutoGenerateColumns="false" >
                <Columns>
                    <asp:BoundField DataField="ayudante_id" HeaderText="Id" SortExpression="Id" />
                    <asp:BoundField DataField="ayudante_cedula" HeaderText="Cedula" SortExpression="Cedula" />
                    <asp:BoundField DataField="ayudante_apellidos" HeaderText="Apellidos" SortExpression="Apellidos" />
                    <asp:BoundField DataField="ayudante_nombres" HeaderText="Nombres" SortExpression="Nombres" />
                    <asp:BoundField DataField="ayudante_parentezco" HeaderText="Parentezco" SortExpression="Parentezco" />
                    <asp:BoundField DataField="ayudante_autorizacion" HeaderText="Autorizacion" SortExpression="Autorizacion" />
                    <asp:BoundField DataField="ayudante_numero_oficio" HeaderText="Numero de Oficio" SortExpression="NumeroOficio" />
                    <asp:BoundField DataField="ayudante_fecha_oficio" HeaderText="Fecha de Oficio" SortExpression="FechaOficio" />
                    <asp:BoundField DataField="ayudante_estado" HeaderText="Estado" SortExpression="Estado" />
                    <asp:TemplateField HeaderText="Acciones">
                        <ItemTemplate>
                             <asp:Button ID="btnEditar" runat="server" Text="Editar" CommandName="Editar" CssClass="btn btn-primary" CommandArgument='<%# Eval("ayudante_id") %>' />
                             <asp:LinkButton ID="btnEliminar" runat="server" Text="Eliminar" CssClass="btn btn-danger" CommandName="Eliminar" CommandArgument='<%# Eval("ayudante_id") %>' OnClientClick="return confirm('¿Está seguro que desea eliminar este cantón?');" OnClick="btnEliminar_Click" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                
            </asp:GridView>
        </div>
         <div class="text-end pt-4">
            <a class="btn btn-success end text-center" href="./Add"
                data-bs-target="#exampleModal">
                Agregar Ayudante
            </a>
        </div>
    </div>
</asp:Content>
