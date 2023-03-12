<%@ Page Title="Gestión de Parroquias" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Ficha.aspx.cs" Inherits="ProyectoGIS.App.Catastro.Parroquia.Ficha" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div id="tabla">
        <div class="table-responsive my-custom-scrollbar table-wrapper-scroll-y">
            <asp:GridView ID="MiTabla" class="table table-sm table-striped table-hover table-bordered table-secondary text-center align-middle" runat="server" AutoGenerateColumns="false" >
                 <Columns> 
                    <asp:BoundField DataField="zona_nombre" HeaderText="ZONA" SortExpression="ZONA" />
                    <asp:BoundField DataField="parroquia_codigo" HeaderText="CODIGO PARROQUIA" SortExpression="CODIGOPARROQUIA" />
                    <asp:BoundField DataField="parroquia_nombre" HeaderText="NOMBRE" SortExpression="NOMBRE" />
                    <asp:TemplateField HeaderText="ESTADO">
                       <ItemTemplate>
                            <asp:Label ID="lblEstado" runat="server" Text='<%# Eval("PARROQUIA_ESTADO").ToString() == "1" ? "Activo" : "Inactivo" %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="OBSERVACIONES">
                        <ItemTemplate>
                            <asp:Label ID="lblObservacion" Text='<%# Eval("PARROQUIA_OBSERVACION").ToString() == "" ? "Sin Observaciones" : Eval("PARROQUIA_OBSERVACION").ToString() %>' runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Acciones">
                        <ItemTemplate>
                            <a href="./Add?id=<%# Eval("parroquia_id") %>" class="btn btn-primary">Editar</a>
                            <asp:LinkButton ID="btnEliminar" runat="server" Text="Eliminar" CssClass="btn btn-danger" CommandName="Eliminar" CommandArgument='<%# Eval("parroquia_id") %>' OnClientClick="return confirm('¿Está seguro que desea eliminar este cantón?');" OnClick="btnEliminar_Click"  />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>

            </asp:GridView>

        </div>
         <div class="text-end pt-4">
            <a class="btn btn-success end text-center" href="./Add"
                data-bs-target="#exampleModal">
                Agregar Parroquia
            </a>
        </div>
    </div>
</asp:Content>
