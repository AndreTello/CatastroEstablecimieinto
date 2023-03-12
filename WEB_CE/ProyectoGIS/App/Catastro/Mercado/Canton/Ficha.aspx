<%@ Page Title="Gestión Cantones" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Ficha.aspx.cs" Inherits="ProyectoGIS.App.Catastro.Canton.Ficha" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <div class="table-responsive my-custom-scrollbar table-wrapper-scroll-y">
        <asp:GridView ID="MiTabla" class="table table-sm table-striped table-hover table-bordered table-secondary text-center align-middle" runat="server" AutoGenerateColumns="false" >
            <Columns>
                <asp:BoundField DataField="provincia_nombre" HeaderText="PROVINCIA" />
                <asp:BoundField DataField="canton_codigo" HeaderText="CÓDIGO CANTÓN" />
                <asp:BoundField DataField="canton_nombre" HeaderText="NOMBRE" />
                <asp:TemplateField HeaderText="ESTADO">
                       <ItemTemplate>
                            <asp:Label ID="lblEstado" runat="server" Text='<%# Eval("CANTON_estado").ToString() == "1" ? "Activo" : "Inactivo" %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                <asp:TemplateField HeaderText="OBSERVACIONES">
                    <ItemTemplate>
                        <asp:Label ID="lblObservacion" Text='<%# Eval("CANTON_OBSERVACION").ToString() == "" ? "SIN OBSERVACIONES" : Eval("CANTON_OBSERVACION").ToString() %>' runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="ACCIONES">
                    <ItemTemplate>
                            <a href="./Add?id=<%# Eval("canton_id") %>" class="btn btn-primary">Editar</a>
                        <asp:LinkButton ID="btnEliminar" runat="server" Text="Eliminar" CssClass="btn btn-danger" CommandName="Eliminar" CommandArgument='<%# Eval("canton_id") %>' OnClientClick="return confirm('¿Está seguro que desea eliminar este cantón?');" OnClick="btnEliminar_Click" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
</div>
    <div class="text-end pt-2">
        <a class="btn btn-success end text-center" href="./Add" data-bs-target="#exampleModal">
            Agregar Cantón
        </a>
    </div>

</asp:Content>
