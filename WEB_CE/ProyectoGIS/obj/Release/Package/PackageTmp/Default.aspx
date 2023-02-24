<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ProyectoGIS.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <title>Ingreso de Datos proyecto GIS</title>
    <!-- Latest compiled and minified CSS -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" crossorigin="anonymous" />

    <!-- Optional theme -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap-theme.min.css" integrity="sha384-rHyoN1iRsVXV4nD0JutlnGaslCJuC7uwjduW9SVrLvRYooPp2bWYgmgJQIXwl/Sp" crossorigin="anonymous" />
</head>
<body>
    <nav class="navbar navbar-default">
        <div class="container-fluid">
            <div class="navbar-header">
                <a class="navbar-brand" href="#">Proyecto GIS</a>
            </div>
            <ul class="nav navbar-nav">
                <li class="active"><a href="Default.aspx">Ingreso de Datos - POSTGIS<span class="sr-only">(current)</a></li>
                <li><a href="Visualizador.aspx">Visualizador OPEN LAYER - WMS</a></li>
            </ul>
        </div>
    </nav>
    <div class="container">
        <form id="form1" runat="server">
            <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePartialRendering="True">
            </asp:ScriptManager>

            <div class="row">
                <div class="col-md-4">
                    <img src="/img/logo_uisrael.jpg" alt="Universidad Israel" />
                </div>
                <div class="col-md-8">
                    <div class="alert alert-success">
                        <h2><strong>CRUD</strong> sobre Base de Datos Postgis/Postgresql</h2>
                        <h4><strong>IDE:</strong> Visual Studio C#<br />
                            <strong>Libreria:</strong> Gmaps Subgurim de Google Maps V3.0
                        </h4>
                        <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control" Width="100px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="True">
                            <asp:ListItem Selected="True">Punto</asp:ListItem>
                            <asp:ListItem>Linea</asp:ListItem>
                            <asp:ListItem>Poligono</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                </div>
                <div class="col-md-12">
                    <div style="width: 100%; height: 100%;">
                        <gmaps:GMap ID="GMap1" runat="server" enableServerEvents="true" serverEventsType="AspNetPostBack"
                            OnMarkerClick="GMap1_MarkerClick"
                            OnClick="GMap1_Click"
                            Height="-100" Width="-100" Language="es" />
                    </div>
                    <br />
                </div>
                <div class="col-md-12">
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
                        <ContentTemplate>
                            <div class="panel panel-primary">
                                <div class="panel-heading">
                                    <asp:Label ID="lblTitulo" runat="server" Text="Farmacias Cercanas"></asp:Label>
                                </div>
                                <div class="panel-body">
                                    <asp:Label ID="lblResultado" runat="server" CssClass="alert-danger"></asp:Label>
                                    <div class="col-md-12">
                                        <div id="punto" class="form-group col-md-3" runat="server">
                                            <asp:Label ID="lblNombre" runat="server" Text="Nombre Farmacia"></asp:Label>
                                            <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" AutoPostBack="True"></asp:TextBox>
                                        </div>
                                        <div id="linea" class="form-group col-md-3" runat="server">
                                            <asp:Label ID="lblRuta" runat="server" Text="Nombre Ruta"></asp:Label>
                                            <asp:TextBox ID="txtRuta" runat="server" CssClass="form-control"></asp:TextBox>
                                        </div>
                                        <div id="poligono" class="form-group col-md-3" runat="server">
                                            <asp:Label ID="lblZona" runat="server" Text="Nombre Zona"></asp:Label>
                                            <asp:TextBox ID="txtZona" runat="server" CssClass="form-control"></asp:TextBox>
                                        </div>
                                        <div class="form-group col-md-3">
                                            <asp:Label ID="lblLongitud" runat="server" Text="Longitud 1"></asp:Label>
                                            <asp:TextBox ID="txtLongitud" runat="server" CssClass="form-control" Enabled="False" AutoPostBack="True"></asp:TextBox>
                                        </div>
                                        <div class="form-group col-md-3">
                                            <asp:Label ID="lblLatitud" runat="server" Text="Latitud 1"></asp:Label>
                                            <asp:TextBox ID="txtLatitud" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
                                        </div>

                                        <div class="form-group col-md-3">
                                            <asp:Label ID="lblLongitud2" runat="server" Text="Longitud 2"></asp:Label>
                                            <asp:TextBox ID="txtLongitud2" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
                                        </div>
                                        <div class="form-group col-md-3">
                                            <asp:Label ID="lblLatitud2" runat="server" Text="Longitud 2"></asp:Label>
                                            <asp:TextBox ID="txtLatitud2" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
                                        </div>
                                        <div class="form-group col-md-3">
                                            <asp:Label ID="lblLongitud3" runat="server" Text="Longitud 3"></asp:Label>
                                            <asp:TextBox ID="txtLongitud3" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
                                        </div>
                                        <div class="form-group col-md-3">
                                            <asp:Label ID="lblLatitud3" runat="server" Text="Latitud 3"></asp:Label>
                                            <asp:TextBox ID="txtLatitud3" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
                                        </div>
                                        <div class="form-group col-md-3">
                                            <asp:Label ID="lblLongitud4" runat="server" Text="Longitud 4"></asp:Label>
                                            <asp:TextBox ID="txtLongitud4" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
                                        </div>
                                        <div class="form-group col-md-3">
                                            <asp:Label ID="lblLatitud4" runat="server" Text="Latitud 4"></asp:Label>
                                            <asp:TextBox ID="txtLatitud4" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
                                        </div>
                                        <div class="form-group col-md-3">
                                            <asp:Label ID="lblLongitud5" runat="server" Text="Longitud 5"></asp:Label>
                                            <asp:TextBox ID="txtLongitud5" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
                                        </div>
                                        <div class="form-group col-md-3">
                                            <asp:Label ID="lblLatitud5" runat="server" Text="Latitud 5"></asp:Label>
                                            <asp:TextBox ID="txtLatitud5" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
                                        </div>
                                        <div class="form-group col-md-3">
                                            <asp:Label ID="lblLongitud6" runat="server" Text="Longitud 6"></asp:Label>
                                            <asp:TextBox ID="txtLongitud6" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
                                        </div>
                                        <div class="form-group col-md-3">
                                            <asp:Label ID="lblLatitud6" runat="server" Text="Latitud 6"></asp:Label>
                                            <asp:TextBox ID="txtLatitud6" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
                                        </div>
                                        <div class="form-group col-md-3">
                                            <asp:Label ID="lblObservacion" runat="server" Text="Observaciones"></asp:Label>
                                            <asp:TextBox ID="txtObservacion" runat="server" CssClass="form-control" Height="169px" TextMode="MultiLine"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="panel-footer">
                                    <br />
                                    <div class="form-group">
                                        <asp:Button ID="btnInsertar" runat="server" Text="Insertar" CssClass="btn btn-success " OnClick="btnInsertar_Click" Enabled="False" />
                                        <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" CssClass="btn btn-danger " Enabled="False" OnClick="btnEliminar_Click" />
                                        <asp:Button ID="btnEditar" runat="server" Text="Editar" CssClass="btn btn-info " Enabled="False" OnClick="btnEditar_Click" />
                                        <asp:Button ID="btnLimpiar" runat="server" Text="Limpiar " CssClass="btn btn-default " Enabled="False" OnClick="btnLimpiar_Click" />
                                    </div>
                                </div>
                            </div>
                        </ContentTemplate>
                        <Triggers>
                            <asp:AsyncPostBackTrigger ControlID="DropDownList1" EventName="SelectedIndexChanged" />
                        </Triggers>
                    </asp:UpdatePanel>
                </div>
            </div>

        </form>
    </div>
    <!-- /.container -->
    <br />
    <br />
    <footer id="footer">
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <div class="alert alert-info" role="alert">
                        Copyright &copy; <%: DateTime.Now.Year %>
                        <br />
                        Por: Edwin Benalcázar Espín, Wilson Salazar, Sebastián Llerena, Robert Granda.
                    </div>
                </div>
            </div>
        </div>

    </footer>

</body>
</html>
