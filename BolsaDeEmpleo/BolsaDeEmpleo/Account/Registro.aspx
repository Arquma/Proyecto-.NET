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
    	      1
    	    </div>
    	    <div class="tab-pane" id="tab2">
    	      2
    	    </div>
    		<div class="tab-pane" id="tab3">
    			3
    	    </div>
    		<div class="tab-pane" id="tab4">
    			4
    	    </div>
    		
    		<ul class="pager wizard">
    			
    			<li class="previous"><a href="javascript:;">Anterior</a></li>
    		  	<li class="next"><a href="javascript:;">Siguiente</a></li>
    			<li class="finish"><a href="javascript:;" class="btn btn-success">Guardar</a></li>
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
    	$('#rootwizard .finish').click(function() {
    		alert('Finished!, Starting over!');
    		$('#rootwizard').find("a[href*='tab1']").trigger('click');
    	});
        });
        </script>


</asp:Content>
