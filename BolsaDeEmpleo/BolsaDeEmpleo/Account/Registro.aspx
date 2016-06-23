<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Login.Master" CodeBehind="Registro.aspx.cs" Inherits="BolsaDeEmpleo.Account.Registro" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">


      <div id="rootwizard">
    	<div class="navbar">
    	  <div class="navbar-inner">
    	    <div class="container">
    	<ul>
    	  	<li><a href="#tab1" data-toggle="tab">First</a></li>
    		<li><a href="#tab2" data-toggle="tab">Second</a></li>
    		<li><a href="#tab3" data-toggle="tab">Third</a></li>
    		<li><a href="#tab4" data-toggle="tab">Forth</a></li>
    		<li><a href="#tab5" data-toggle="tab">Fifth</a></li>
    		<li><a href="#tab6" data-toggle="tab">Sixth</a></li>
    		<li><a href="#tab7" data-toggle="tab">Seventh</a></li>
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
    		<div class="tab-pane" id="tab5">
    			5
    	    </div>
    		<div class="tab-pane" id="tab6">
    			6
    	    </div>
    		<div class="tab-pane" id="tab7">
    			7
    	    </div>
    		<ul class="pager wizard">
    			<li class="previous first"><a href="javascript:;">First</a></li>
    			<li class="previous"><a href="javascript:;">Previous</a></li>
    			<li class="next last"><a href="javascript:;">Last</a></li>
    		  	<li class="next"><a href="javascript:;">Next</a></li>
    			<li class="finish"><a href="javascript:;">Finish</a></li>
    		</ul>
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
