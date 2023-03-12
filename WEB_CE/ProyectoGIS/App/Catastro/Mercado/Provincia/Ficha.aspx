<%@ Page Title="Gestión de Provincias" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" EnableEventValidation="true" CodeBehind="Ficha.aspx.cs" Inherits="ProyectoGIS.App.Catastro.Provincia.Ficha" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <div class="table-responsive my-custom-scrollbar table-wrapper-scroll-y">
        <asp:GridView ID="MiTabla" class="table table-sm table-striped table-hover table-bordered table-secondary text-center align-middle" runat="server" AutoGenerateColumns="false" >
             <Columns>
                
                 <asp:BoundField DataField="provincia_codigo" HeaderText="CÓDIGO PROVINCIA" />
                 <asp:BoundField DataField="provincia_nombre" HeaderText="NOMBRE" />
                 <asp:TemplateField HeaderText="ESTADO">
                       <ItemTemplate>
                            <asp:Label ID="lblEstado" runat="server" Text='<%# Eval("PROVINCIA_estado").ToString() == "1" ? "Activo" : "Inactivo" %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                 <asp:TemplateField HeaderText="OBSERVACIONES">
                    <ItemTemplate>
                        <asp:Label ID="lblObservacion" Text='<%# Eval("PROVINCIA_OBSERVACION").ToString() == "" ? "SIN OBSERVACIONES" : Eval("PROVINCIA_OBSERVACION").ToString() %>' runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="Acciones">
                    <ItemTemplate>
                            <a href="./Add?id=<%# Eval("provincia_id") %>" class="btn btn-primary">Editar</a>
                        <asp:LinkButton ID="btnEliminar" runat="server" Text="Eliminar" CssClass="btn btn-danger" CommandName="Eliminar" CommandArgument='<%# Eval("provincia_id") %>' OnClientClick="return confirm('¿Está seguro que desea eliminar esta provincia?');" OnClick="btnEliminar_Click" />
                    </ItemTemplate>
                </asp:TemplateField>

            </Columns>
        </asp:GridView>
    </div>
        <div class="text-end pt-2">
            <a class="btn btn-success end text-center" href="./Add"
                data-bs-target="#exampleModal">
                Agregar Provincia
            </a>
        </div>
    


</asp:Content>
