<%@ Page Title="" Language="C#" MasterPageFile="~/Forms.Master" AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="ProyectoGIS.App.Catastro.Puesto.Ayudante.Add" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <label>Cedula del Ayudante</label>
    <asp:TextBox CssClass="form-control mb-4 mt-2" MaxLength="10" runat="server" ID="AYUDANTE_CEDULA" />
    <label>Apellidos del Ayudante</label>
    <asp:TextBox CssClass="form-control mb-4 mt-2" MaxLength="50" runat="server" ID="AYUDANTE_APELLIDOS" />
    <label>Nombres del Ayudante</label>
    <asp:TextBox CssClass="form-control mb-4 mt-2" MaxLength="50" runat="server" ID="AYUDANTE_NOMBRES" />
    <label>Parentezco del Ayudente</label>
    <asp:TextBox CssClass="form-control mb-4 mt-2" MaxLength="50" runat="server" ID="AYUDANTE_PARENTEZCO" />
    <label>Autorización del Ayudante</label>
    <asp:TextBox CssClass="form-control mb-4 mt-2" MaxLength="10" runat="server" ID="AYUDANTE_AUTORIZACION" />
    <label>Numero de Oficio del Ayudante</label>
    <asp:TextBox CssClass="form-control mb-4 mt-2" MaxLength="20" runat="server" ID="AYUDANTE_NUMERO_OFICIO" />
    
    <label>Fecha del Oficio</label>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:Calendar CssClass="form-control " runat="server" ID="AYUDANTE_FECHA_OFICIO" />
        </ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="AYUDANTE_FECHA_OFICIO" EventName="SelectionChanged" />
        </Triggers>
    </asp:UpdatePanel>
    <label>Estado</label>
    <asp:DropDownList CssClass="form-select mb-3 mt-2" runat="server" ID="AYUDANTE_ESTADO"  />

    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
        <ContentTemplate>
            <asp:Button CssClass="btn btn-primary mt-3" runat="server" ID="btnGuardar" OnClick="btnGuardar_Click" Text="Guardar"/>
            <a class="btn btn-danger mt-3" href="./Ficha" >Cancelar</a>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
