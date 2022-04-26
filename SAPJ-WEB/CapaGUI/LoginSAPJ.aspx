<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginSAPJ.aspx.cs" Inherits="CapaGUI.LoginSAPJ" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous"/> 
    <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.10.2/dist/umd/popper.min.js" integrity="sha384-7+zCNj/IqJ95wo16oMtfsKbZ9ccEh31eOz1HGyDuCQ6wgnyJNSYdrPa03rtR1zdB" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.min.js" integrity="sha384-QJHtvGhmr9XOIpI6YVutG+2QOK9T+ZnN4kzFN1RtK3zEFEIsxhlmWl5/YESvpZ13" crossorigin="anonymous"></script>
    <link href="CSS/estilo.css?v=<%=DateTime.Now%>" rel="stylesheet"/>
    <link rel="preconnect" href="https://fonts.googleapis.com">
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
    <link href="https://fonts.googleapis.com/css2?family=Poppins:wght@100;400;600;800&display=swap" rel="stylesheet"> 

    <title>Inicio Sesion</title>
</head>
<body id="background">
   <form id="form1" runat="server">    
         <div>
              <h1 class="titulo1">Bienvenido!</h1>
              <h1 class="titulo2">{PPJ Academy}</h1>

         </div>
       
        <div id="Contenedor">
                <img src="/Imagenes/ACL.png" alt="Logo ACL" style="position:center;"/>

            <h2 class="letras">    
                <asp:Label id="lblUsuario" Text="Correo:" runat="server" />
                <asp:TextBox id="tbUsuario" runat="server" CssClass="form-control" PlaceHolder ="Ingrese su usuario"/>         
            </h2>
            <h2 class="letras">
                <asp:Label id="lblPassword" Text="Contraseña:" runat="server" />
                <asp:TextBox id="tbPassword" runat="server" CssClass="form-control" TextMode="Password" PlaceHolder ="Ingrese su contraseña"/>  
            </h2>
             <asp:Label id="lblError" Text="" runat="server" /><br/>
                      <div class="container py-3 mt-3">
                        <input class="form-check-input ms-auto mt-1" type="checkbox" id="flexSwitchCheckDefault">
                        <label class="form-check-label ms-2" type="checkbox" for="flexSwitchCheckDefault">Recordar Usuario</label>
                      </div>
                    <div class="CentraTexto">
                        <a href="ConfirmacionClave.aspx">¿Olvidaste tu Contraseña?</a> <br/>
                        <asp:Button id="BtnIngresar" Text="Entrar" CssClass="btn  btn-lg btn-block" runat="server" OnClick="BtnIngresar_Click" Height="70px" Width="150px"/>
                    </div>    
        </div>
    </form> 
</body>
</html>
