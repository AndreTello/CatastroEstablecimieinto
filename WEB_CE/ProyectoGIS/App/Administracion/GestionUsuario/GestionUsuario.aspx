<%@ Page Title="Gestión de Usuarios" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GestionUsuario.aspx.cs" Inherits="ProyectoGIS.App.GestionUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <div id="tabla">
        <div class="table-responsive my-custom-scrollbar table-wrapper-scroll-y">
            
            <asp:GridView ID="MiTabla" class="table table-sm table-striped table-hover table-bordered table-dark text-center align-middle" runat="server" AutoGenerateColumns="false" >
            <Columns>
                <asp:BoundField DataField="usuario_id" HeaderText="Id" SortExpression="usuario_id" />
                <asp:BoundField DataField="rol_nombre" HeaderText="Rol" SortExpression="rol_id" />
                <asp:BoundField DataField="usuario_login" HeaderText="Usuario" SortExpression="usuario_login" />
                <asp:BoundField DataField="usuario_cedula" HeaderText="Cedula" SortExpression="usuario_cedula" />
                <asp:BoundField DataField="usuario_apellidos" HeaderText="Apellidos" SortExpression="usuario_apellidos" />
                <asp:BoundField DataField="usuario_nombres" HeaderText="Nombres" SortExpression="usuario_nombres" />
                <asp:BoundField DataField="usuario_mail" HeaderText="Correo" SortExpression="usuario_mail" />
                <asp:BoundField DataField="usuario_direccion" HeaderText="Dirección" SortExpression="usuario_direccion" />
                <asp:BoundField DataField="usuario_telefono" HeaderText="Telefono" SortExpression="usuario_telefono" />
                <asp:BoundField DataField="usuario_estado" HeaderText="Estado" SortExpression="usuario_estado" />
                <asp:TemplateField HeaderText="Acciones">
                        <ItemTemplate>
                            <a href="./Add?id=<%# Eval("usuario_id") %>" class="btn btn-primary">Editar</a>
                            <asp:LinkButton ID="btnEliminar" runat="server" Text="Eliminar" CssClass="btn btn-danger" CommandName="Eliminar" CommandArgument='<%# Eval("usuario_id") %>' OnClientClick="return confirm('¿Está seguro que desea eliminar este cantón?');" OnClick="btnEliminar_Click"  />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
               
            </asp:GridView>   
        </div>
        <div class="text-end pt-4">
            <a class="btn btn-success end text-center" href="./Add"
                data-bs-target="#exampleModal">
                Agregar Usuario
            </a>
        </div>
    </div>

</asp:Content>
