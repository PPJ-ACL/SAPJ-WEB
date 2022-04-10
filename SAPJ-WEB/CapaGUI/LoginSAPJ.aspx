<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginSAPJ.aspx.cs" Inherits="CapaGUI.LoginSAPJ" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
    <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.10.2/dist/umd/popper.min.js" integrity="sha384-7+zCNj/IqJ95wo16oMtfsKbZ9ccEh31eOz1HGyDuCQ6wgnyJNSYdrPa03rtR1zdB" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.min.js" integrity="sha384-QJHtvGhmr9XOIpI6YVutG+2QOK9T+ZnN4kzFN1RtK3zEFEIsxhlmWl5/YESvpZ13" crossorigin="anonymous"></script>
    <link href="CSS/estilo.css" rel="stylesheet"/>
    <title>Inicio Sesion</title>
</head>
<body id="PanchitoOdiame">
    <form id="form1" runat="server">
        <div ID="BarraSuperior" class="col-md-12" class="container">
            <img src="/Imagenes/ACL.png" alt="Logo ACL" class="col-md-1" />
            <div class="col-md-12"></div>
            
        </div>
        
        <div id="Contenedor">
            <h2>    
                <asp:Label ID="lblUsuario" Text="Usuario:" runat="server" />
                <asp:TextBox ID="tbUsuario" runat="server" CssClass="form-control" />         
            </h2>
            <h2>
                <asp:Label ID="lblPassword" Text="Contraseña:" runat="server" />
                <asp:TextBox ID="tbPassword" runat="server" CssClass="form-control" TextMode="Password" />  
            </h2>
            <br/>
            <div id="CentraTexto">
                <asp:Button ID="BtnIngresar" Text="Ingresar" CssClass="btn btn-primary btn-lg btn-block" runat="server" OnClick="BtnIngresar_Click"/>
            </div>    
        </div>
        
    </form> 
    <footer id="pie" class="col-col-md-12">
        <font class="text-white" class"EstiloIzq">PPJ-ACL</font> <br>
        <font class="text-white" class="EstiloDer">®️ Todos Los Derechos Reservados</font>
    </footer>
</body>
</html>
