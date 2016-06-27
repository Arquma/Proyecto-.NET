<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Registro.Master" CodeBehind="Registro.aspx.cs" Inherits="BolsaDeEmpleo.Account.Registro" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">

     <h2><%: Title %></h2>

    <div class="row">
         <div class="col-md-8">
             <h4>Registrar una nueva cuenta </h4>
             <br/>
         </div>
            <div class="col-md-8">
      <div id="rootwizard">
    	<div class="navbar">
    	  <div class="navbar-inner">
    	    <div class="container">
    	<ul>
    	  	<li><a href="#tab1" data-toggle="tab">Información Básica</a></li>
    		<li><a href="#tab2" data-toggle="tab">Atestados Académicos</a></li>
    		<li><a href="#tab3" data-toggle="tab">Experiencias Laborales</a></li>
    		<li><a href="#tab4" data-toggle="tab">Finalizar</a></li>
    	
    	</ul>
    	 </div>
    	  </div>
    	</div>
    	<div class="tab-content">
    	    <div class="tab-pane" id="tab1">
    	      <div class="form-horizontal">
                   <hr />
        
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Nombre" CssClass="col-md-2 control-label">Nombre</asp:Label>
            <div class="col-md-6">
                <asp:TextBox runat="server" ID="Nombre" CssClass="form-control" TextMode="Email" />
            </div>
        </div>

                   <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Apellidos" CssClass="col-md-2 control-label">Apellidos</asp:Label>
            <div class="col-md-8">
                <asp:TextBox runat="server" ID="Apellidos" CssClass="form-control" TextMode="Email" />
            </div>
        </div>

                   <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Direccion" CssClass="col-md-2 control-label">Direccion</asp:Label>
            <div class="col-md-8">
                <asp:TextBox runat="server" ID="Direccion" CssClass="form-control" TextMode="Email" />
            </div>
        </div>

                    <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Ciudad" CssClass="col-md-2 control-label">Ciudad</asp:Label>
            <div class="col-md-8">
                <asp:TextBox runat="server" ID="Ciudad" CssClass="form-control" TextMode="Email" />
            </div>
        </div>

                    <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Email" CssClass="col-md-2 control-label">Email</asp:Label>
            <div class="col-md-8">
                <asp:TextBox runat="server" ID="Email" CssClass="form-control" TextMode="Email" />
            </div>
        </div>

                    <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Genero" CssClass="col-md-2 control-label">Genero</asp:Label>
            <div class="col-md-8">
                <asp:TextBox runat="server" ID="Genero" CssClass="form-control" TextMode="Email" />
            </div>
        </div>

              </div>
    	    </div>
    	    <div class="tab-pane" id="tab2">
              
                   <hr />
                     <div class="form-group">
                           <label for="sel1">Nivel de Estudio:</label>
                            <asp:DropDownList ID="ddlNivel" CssClass="form-control" runat="server">
                            </asp:DropDownList>

                     </div>

    	           <div class="form-group">
                       <label for="sel1">Institucion de Estudio:</label>
                        <asp:DropDownList ID="ddlInstitucion" CssClass="form-control" runat="server">
                        </asp:DropDownList>
                      
                      
                  </div>

                

                <div class="form-group">
                      <label for="sel1">Area de Especialidad:</label>
                         <asp:DropDownList ID="ddlArea" CssClass="form-control" runat="server">
                        </asp:DropDownList>
                  </div>
    	    </div>
    		<div class="tab-pane" id="tab3">
                   <hr />
                    <div class="table-responsive">
                        <asp:GridView ID="gvtabla" runat="server" CssClass="table">
                               
                        </asp:GridView>
                       
                    </div>
                 
                
                 <hr />
                <table>
                    <tr>
                        <td><asp:TextBox runat="server" ID="t1" CssClass="form-control"  /></td>
                        <td><asp:TextBox runat="server" ID="t2" CssClass="form-control"  /></td>
                        <td><asp:TextBox runat="server" ID="t3" CssClass="form-control"  /></td>
                        <td><asp:TextBox runat="server" ID="t4" CssClass="form-control"  /></td>

                    </tr>
                        </table>
                <br/>

                    <asp:Button runat="server" OnClick="Agregar" Text="Agregar" CssClass="btn btn-success" ID="btnAgregar" />
                   <%//    <button type="button" id="add" class="btn btn-success">Agregar Fila</button>%>
                 
    	    </div>
    		<div class="tab-pane" id="tab4">
             <div class="form-horizontal">
                   <hr />
    			 <div class="form-group">
                    <asp:Label runat="server" AssociatedControlID="Usuario" CssClass="col-md-2 control-label">Usuario</asp:Label>
                    <div class="col-md-6">
                        <asp:TextBox runat="server" ID="Usuario" CssClass="form-control" />
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label runat="server" AssociatedControlID="Pass" CssClass="col-md-2 control-label">Constraseña</asp:Label>
                    <div class="col-md-6">
                        <asp:TextBox runat="server" ID="Pass" CssClass="form-control" />
                    </div>
                </div>
                  <hr />
                 </div>
    	    </div>
    		
    		<ul class="pager wizard">
    			
    			<li class="previous"><a href="javascript:;">Anterior</a></li>
    		  	<li class="next"><a href="javascript:;">Siguiente</a></li>
    			<li class="finish"> <asp:Button runat="server" OnClick="Guardar" Text="Guardar" CssClass="btn btn-success" ID="btnGuardar" /></li>
               
    		</ul>
    	</div>
    </div>
    </div>
 </div>
    

    
    <script>
        $(document).ready(function() {
      	$('#rootwizard').bootstrapWizard({onTabShow: function(tab, navigation, index) {
    		var $total = navigation.find('li').length;
    		var $current = index+1;
    		var $percent = ($current/$total) * 100;
    		$('#rootwizard').find('.bar').css({width:$percent+'%'});
    	}});
      	$('#rootwizard .finish').click(function () {


    		alert('Finished!, Starting over!');
    		$('#rootwizard').find("a[href*='tab1']").trigger('click');
    	});
        });


        $("#add").click(function () {

            var tds = $("#tabla tr:first td").length;
            var trs = $("#tabla tr").length;
            var nuevaFila = "<tr>";
            
            nuevaFila += "<td><input type=" +'"'+"text" +'"'+" class=" +'"'+"form-control" +'"'+" ></td>";
            nuevaFila += "<td><input type=" + '"' + "text" + '"' + " class=" + '"' + "form-control" + '"' + " ></td>";
            nuevaFila += "<td><input type=" + '"' + "text" + '"' + " class=" + '"' + "form-control" + '"' + " ></td>";
            nuevaFila += "<td><input type=" + '"' + "text" + '"' + " class=" + '"' + "form-control" + '"' + " ></td>";
          
            nuevaFila += "</tr>";
            $("#tabla").append(nuevaFila);

        });



    </script>


</asp:Content>
