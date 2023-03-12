<%@ Page Title="Gestión de Usuarios" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GestionUsuario.aspx.cs" Inherits="ProyectoGIS.App.GestionUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <div id="tabla">
        <div class="table-responsive my-custom-scrollbar table-wrapper-scroll-y">
            
            <asp:GridView ID="MiTabla" class="table table-sm table-striped table-hover table-bordered table-secondary text-center align-middle" runat="server" AutoGenerateColumns="false" >
            <Columns>
                <asp:BoundField DataField="rol_nombre" HeaderText="ROL" SortExpression="rol_id" />
                <asp:BoundField DataField="usuario_login" HeaderText="USUARIO" SortExpression="usuario_login" />
                <asp:BoundField DataField="usuario_cedula" HeaderText="CÉDULA" SortExpression="usuario_cedula" />
                <asp:BoundField DataField="usuario_apellidos" HeaderText="APELLIDOS" SortExpression="usuario_apellidos" />
                <asp:BoundField DataField="usuario_nombres" HeaderText="NOMBRES" SortExpression="usuario_nombres" />
                <asp:BoundField DataField="usuario_mail" HeaderText="CORREO" SortExpression="usuario_mail" />
                <asp:BoundField DataField="usuario_direccion" HeaderText="DIRECCIÓN" SortExpression="usuario_direccion" />
                <asp:BoundField DataField="usuario_telefono" HeaderText="TELÉFONO" SortExpression="usuario_telefono" />
                <asp:TemplateField HeaderText="ESTADO">

                       <ItemTemplate>
                            <asp:Label ID="lblEstado" runat="server" Text='<%# Eval("usuario_id").ToString() == "1" ? "Activo" : "Inactivo" %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                <asp:TemplateField HeaderText="ACCIONES">
                        <ItemTemplate>
                    <div class=" d-flex ">
                        <div class="col mx-2">

                            <a href="./Add?id=<%# Eval("usuario_id") %>" class="btn btn-primary">Editar</a>
                        </div>
                        <div class="col">

                            <asp:LinkButton ID="btnEliminar" runat="server" Text="Eliminar" CssClass="btn btn-danger px-2" CommandName="Eliminar" CommandArgument='<%# Eval("usuario_id") %>' OnClientClick="return confirm('¿Está seguro que desea eliminar este cantón?');" OnClick="btnEliminar_Click"  />
                        </div>
                    </div>
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
