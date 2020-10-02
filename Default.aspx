<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="locadoraCarros1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Locadora Carros Teste</title>

    <!-- Bootstrap core CSS -->
    <link href="Content/bootstrap.min.css" rel="stylesheet" />

    <!-- Custom fonts for this template -->
    <link href="https://fonts.googleapis.com/css?family=Lato:300,400,700,300italic,400italic,700italic" rel="stylesheet" type="text/css" />

    <!-- Custom styles for this template -->
    <link href="css/landing-page.min.css" rel="stylesheet" />

</head>
<body>

    <!-- Navigation -->
    <nav class="navbar navbar-light bg-light static-top">
        <div class="container">
            <a class="navbar-brand" href="Default.aspx">Home</a>
        </div>
    </nav>

    <!-- Masthead -->
    <header class="masthead text-white text-center">
        <div class="overlay"></div>
        <div class="container">
            <div class="row">
                <div class="col-xl-9 mx-auto">
                    <h1 class="mb-5">Alugue carros no melhor preço! Cadastre-se já!</h1>
                </div>
                <div class="col-md-10 col-lg-8 col-xl-7 mx-auto">
                    <form runat="server">
                        <div class="form-row">
                            <div class="col-12 col-md-9 mb-2 mb-md-0">
                                <asp:TextBox ID="txtEmail" runat="server" TextMode="email" CssClass="form-control form-control-lg" placeholder="Digite seu e-mail..." />
                            </div>
                            <div class="col-12 col-md-3">
                                <asp:Button ID="btnCadastrar" runat="server" Text="Cadastrar" CssClass="btn btn-block btn-lg btn-primary" OnCommand="btnCadastrar_Command" />
                            </div>
                        </div>
                    </form>
                </div>
            </div>
        </div>
    </header>

    
    <!-- Footer -->
    <footer class="footer bg-light">
        <div class="container">
            <div class="row">
                <div class="col-lg-6 h-100 text-center text-lg-left my-auto">
                    <ul class="list-inline mb-2">
                        <li class="list-inline-item">
                            <a href="#">About</a>
                        </li>
                        <li class="list-inline-item">&sdot;</li>
                        <li class="list-inline-item">
                            <a href="#">Contact</a>
                        </li>
                        <li class="list-inline-item">&sdot;</li>
                        <li class="list-inline-item">
                            <a href="#">Terms of Use</a>
                        </li>
                        <li class="list-inline-item">&sdot;</li>
                        <li class="list-inline-item">
                            <a href="#">Privacy Policy</a>
                        </li>
                    </ul>
                    <p class="text-muted small mb-4 mb-lg-0">&copy; Your Website 2020. All Rights Reserved.</p>
                </div>
                <div class="col-lg-6 h-100 text-center text-lg-right my-auto">
                    <ul class="list-inline mb-0">
                        <li class="list-inline-item mr-3">
                            <a href="#">
                                <i class="fab fa-facebook fa-2x fa-fw"></i>
                            </a>
                        </li>
                        <li class="list-inline-item mr-3">
                            <a href="#">
                                <i class="fab fa-twitter-square fa-2x fa-fw"></i>
                            </a>
                        </li>
                        <li class="list-inline-item">
                            <a href="#">
                                <i class="fab fa-instagram fa-2x fa-fw"></i>
                            </a>
                        </li>
                    </ul>
                </div>
            </div>
        </div>
    </footer>

    <!-- Bootstrap core JavaScript -->
    <script src="Scripts/jquery-3.0.0.min.js"></script>
    <script src="Scripts/bootstrap.bundle.min.js"></script>

</body>
</html>
