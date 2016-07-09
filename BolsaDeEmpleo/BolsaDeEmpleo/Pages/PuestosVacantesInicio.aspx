<%@ Page Title="Puestos Vacantes" Language="C#" AutoEventWireup="true" MasterPageFile="~/Inicio.Master" CodeBehind="PuestosVacantesInicio.aspx.cs" Inherits="BolsaDeEmpleo.Pages.PuestosVacantesInicio" %>



<%@ Register Src="~/Account/OpenAuthProviders.ascx" TagPrefix="uc" TagName="OpenAuthProviders" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h2><%: Title %></h2>
    <div class="form-horizontal">
        <hr />


        <div class="form-group">

            <div class="col-md-3 pull-right">
                <label for="sel1">Buscar </label>
                <asp:DropDownList ID="ddlFiltroCategoria" CssClass="form-control" runat="server" AutoPostBack="True" OnSelectedIndexChanged="buscarPuestos">
                </asp:DropDownList>

            </div>


        </div>
        <div class="form-horizontal" id="paneles">
         


        </div>

    </div>

    <script type="text/javascript">
        function myFunction(lista){
            //<div class="panel panel-primary">...</div>
            var i;
            var salida = ""; 


            // var obj = JSON.parse(lista);
            if (lista.length > 0) {
                var obj = $(JSON.parse(lista));

                for (i = 0; i < obj.length; i++) {
                  
                    salida += "<hr\>"+
                    "<div class=\"panel panel-primary\">" +
                     " <div class=\"panel-heading\">" + obj[i]["DescripcionPuesto"] + "</div>" +
                     " <div class=\"panel-body\">" +
                     obj[i]["ExperienciaRequerida"] +
                     "<div><span class=\"label label-info\"><span style=\"padding-right:5px\" class=\"glyphicon glyphicon-map-marker\"></span>" + obj[i]["Provincia"] + "</span></div>" +
                     
                     "</div>" +

                    "<div class=\"panel-footer\">" +
                    " <div class=\"col-md-2 \">"+
                    "<span style=\"padding-right:5px\" class=\"glyphicon glyphicon-calendar\"></span>" +
                    obj[i]["DiasLaborales"] +
                    "</div>"+
                     " <div class=\"col-md-2 \">" +
                     "<span style=\"padding-right:5px\" class=\"glyphicon glyphicon-credit-card\"></span>Salario " +
                    obj[i]["Sueldo"] +
                    "</div>" +
                     " <div class=\"col-md-2 \">" +
                     "<span style=\"padding-right:5px\" class=\" glyphicon glyphicon-time\"></span>Entrada " +
                    obj[i]["HoraEntrada"] +
                    "</div>" +
                     " <div class=\"col-md-2 \">" +
                     "<span style=\"padding-right:5px\" class=\" glyphicon glyphicon-time\"></span>Salida " +
                    obj[i]["HoraSalida"] +
                    "</div>" +
                    " <div class=\"col-md-2 \">" +
                     "<span style=\"padding-right:5px\" class=\"glyphicon glyphicon-user\"></span>Vacantes " +
                    
                    "</div>" +
                    obj[i]["NumeroVacantes"] +

                    "</div>"+

                    "</div>";//fin panel

                     }
                     }//fin if

        
                    $("#paneles").empty();
                    $("#paneles").append(salida);
                }

      

       

    </script>

</asp:Content>
