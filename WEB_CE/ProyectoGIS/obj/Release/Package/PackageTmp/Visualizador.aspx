<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Visualizador.aspx.cs" Inherits="ProyectoGIS.Visualizador" %>

<!DOCTYPE html>
<html>

<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <!-- The above 3 meta tags *must* come first in the head; any other head content must come *after* these tags -->
    <meta name="description" content="">
    <meta name="author" content="Edwin Benalcàzar E.">
    <title>Visualizador Open Layer - WMS </title>
    <meta name="description" content="">

    <link rel="stylesheet" href="http://openlayers.org/en/v3.2.0/css/ol.css" type="text/css">
    <script src="http://openlayers.org/en/v3.2.0/build/ol.js" type="text/javascript"></script>
    <link rel="stylesheet" href="ol3-layerswitcher-master/src/ol3-layerswitcher.css" type="text/css" />
    <script src="ol3-layerswitcher-master/src/ol3-layerswitcher.js"></script>
    <style>
        #map {
            cursor: default;
            height: 600px;
            margin: 0 !important;
            padding: 0 !important;
            width: 100%;
            z-index: 0;
            border-radius: 5px;
            border-style:dotted;
        }
    </style>
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
                <li><a href="Default.aspx">Ingreso de Datos - POSTGIS</a></li>
                <li class="active"><a href="Visualizador.aspx">Visualizador OPEN LAYER - WMS <span class="sr-only">(current)</a></li>
            </ul>
        </div>
    </nav>
    <div class="container">
        <form id="form1" runat="server">
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
                    </div>
                </div>

            </div>

        </form>
    </div>
    <div class="container">
        <div class="row">
            <div class="col-md-12">
                <div id="map"></div>
                <script>


                    var map = new ol.Map({
                        layers:
                            [new ol.layer.Group({
                                'title': 'Base maps',
                                layers: [
                                    new ol.layer.Tile({
                                        title: 'Water color',
                                        type: 'base',
                                        visible: false,
                                        source: new ol.source.Stamen({
                                            layer: 'watercolor'
                                        })
                                    }),
                                    new ol.layer.Tile({
                                        title: 'OSM',
                                        type: 'base',
                                        visible: false,
                                        source: new ol.source.OSM()
                                    }),
                                    new ol.layer.Tile({
                                        title: 'Satellite',
                                        type: 'base',
                                        visible: true,
                                        visible: false,
                                        source: new ol.source.MapQuest({ layer: 'sat' })
                                    })
                                ]
                            }),
                            new ol.layer.Group({
                                title: 'Overlays',
                                layers: [
                                    new ol.layer.Tile({
                                        title: 'Ecuador',
                                        source: new ol.source.TileWMS({
                                            url: 'http://www.geoportaligm.gob.ec/nacional/wms?service=WMS&request=GetCapabilities',
                                            params: { 'LAYERS': 'igm:Nacional' },
                                            serverType: 'geoserver'
                                        }),
                                        visible: true
                                    }),
                                    new ol.layer.Tile({
                                        title: 'Farmacias',
                                        source: new ol.source.TileWMS({
                                            url: 'http://localhost:8080/geoserver/UISRAEL/wms?',
                                            params: {
                                                'LAYERS': 'UISRAEL:farmacia',
                                                'VERSION': '1.1.1',
                                                'FORMAT': 'image/png',
                                                'TILED': true
                                               // tilesOrigin: -1.45 + "," + -78.52
                                            },
                                            serverType: 'geoserver'
                                        }),
                                        visible: false
                                    }),
                                    new ol.layer.Tile({
                                        title: 'Vias',
                                        source: new ol.source.TileWMS({
                                            url: 'http://www.geoportaligm.gob.ec/nacional/wms?service=WMS&request=GetCapabilities',
                                            params: { 'LAYERS': 'vias' },
                                            serverType: 'geoserver'
                                        }),
                                        visible: false
                                    })
                                ]
                            })
                            ],
                        target: 'map',
                        view: new ol.View({
                            center: ol.proj.transform([-78.52, -2], 'EPSG:4326', 'EPSG:3857'),
                            zoom: 7
                        })
                    });

                    var layerSwitcher = new ol.control.LayerSwitcher({
                        tipLabel: 'Leyenda'
                    });
                    map.addControl(layerSwitcher);
                    layerSwitcher.showPanel();

                </script>
            </div>
        </div>
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
