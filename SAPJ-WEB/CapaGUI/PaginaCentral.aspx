<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PaginaCentral.aspx.cs" Inherits="CapaGUI.PaginaCentral" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous"/> 
    <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.10.2/dist/umd/popper.min.js" integrity="sha384-7+zCNj/IqJ95wo16oMtfsKbZ9ccEh31eOz1HGyDuCQ6wgnyJNSYdrPa03rtR1zdB" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.min.js" integrity="sha384-QJHtvGhmr9XOIpI6YVutG+2QOK9T+ZnN4kzFN1RtK3zEFEIsxhlmWl5/YESvpZ13" crossorigin="anonymous"></script>
    <link href="CSS/estilo2.css?v=<%=DateTime.Now%>" rel="stylesheet" type="text/css"/>
    <link href="CSS/botones.css?v=<%=DateTime.Now%>" rel="stylesheet" type="text/css"/>
    <link rel="preconnect" href="https://fonts.googleapis.com">
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
    <link href="https://fonts.googleapis.com/css2?family=Poppins:wght@100;400;600;800&display=swap" rel="stylesheet"> 
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <h4 class="titulo">
            Bienvenidos! a {PPJ Academy}
        </h4>


    <div class="container_card">
                <div class="card" style=" border-radius:77px;">
                    <div class="card2" style="background-color:#808080;border-radius:77px;">
                        <div class="tarjetaUser">
                            <h3></h3>
                            <asp:Image ImageUrl="~/Imagenes/avatadef.png" ID="imgClass" CssClass="imgClass"  runat="server" />
                            <h1 class="tarjeta1">Nombre PPJ:</h1>
                            <h1 class="tarjeta1">John Silver</h1>
                            <h1 class="tarjeta1">Area:</h1>
                            <h1 class="tarjeta1">Desarrollador</h1>
                            <h1 class="tarjeta1">Ultimo Plan Visto:</h1>
                            <h1 class="tarjeta1" href="">Click Aqui</h1>
                        </div>
                    </div>
                </div>
                <div class="card" >
                  <div class="card2" >
                        <div class="tarjetaCursos">
                            <h3>Cursos</h3>
                            <asp:Image ImageUrl="~/Imagenes/CursoIcon.png" CssClass="imgClass" runat="server" />
                            <h1 class="tarjetaCursos" style="margin-top:60px"href="">Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna<a href="#">Ver mas ...</a></h1>
                        </div>
                    </div>
                  </div>
    
                <div class="card">
                  <div class="card2">
                        <div class="tarjetaCursos">
                            <h3>Tips</h3>
                            <asp:Image ImageUrl="~/Imagenes/TipsIcon.png" CssClass="imgClass" runat="server" />
                            <h1 class="tarjetaCursos" style="margin-top:50px" href="">Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna<a href="#">Ver mas ...</a></h1>
                        </div>
                  </div>
                </div>
                <div class="card">
                  <div class="card2">
                        <div class="tarjetaCursos">
                            <h3>Trucos</h3>
                            <asp:Image ImageUrl="~/Imagenes/TrucosIcon.png" CssClass="imgClass" runat="server" />
                            <h1 class="tarjetaCursos" href="">Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna <a href="#">Ver mas ...</a></h1>
                        </div>
                  </div>
                </div>
        </div>

    </form>
</body>

<footer>
    <div>
        <div class="cardMin">
            <div class="card2Min">  
                <h2 class="minContact" href="Contactos.aspx"><a style="color:#E02957" href="Contactos.aspx">Contactos ACL</a></h2>

                 
                
            </div>
        </div>

    </div>
</footer>
</html>
