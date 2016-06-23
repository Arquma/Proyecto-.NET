<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InstructoresPorCarrera.aspx.cs" Inherits="SchoolSysAppB05027.InstructoresPorCarrera" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 392px">
    <center>
    <form id="form1" runat="server">
    <div style="height: 49px">
    
        <br />
        <br />
    
        <asp:Label ID="Label1" runat="server" Text="Seleccione una Carrera"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="ddlCarreras" runat="server" Height="39px" Width="208px" AutoPostBack="True" OnSelectedIndexChanged="ddlCarreras_SelectedIndexChanged">
        </asp:DropDownList>
    
    &nbsp;&nbsp;&nbsp;
    
    </div>
        <br />
        <br />
        <br />
        <br />
        <asp:GridView ID="gvInstructores" runat="server" Width="493px" OnPageIndexChanged="gvInstructores_PageIndexChanged">
            <Columns>
                <asp:HyperLinkField NavigateUrl="EliminarInstructor.aspx" Text="Eliminar" />
            </Columns>
        </asp:GridView>
    </form>
</body>
    </center>
</html>
