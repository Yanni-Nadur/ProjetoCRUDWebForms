<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReciboLocacao.aspx.cs" Inherits="locadoraCarros1.ReciboLocacao" %>

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

    <!-- Catalogo -->
    <div class="container" style="margin-top: 2%; margin-bottom: 2%; text-align: center;">
        <form runat="server">

            <div class="row">
                <div class="col-md-6">
                    <label for="txtBoxNome">Nome: </label>
                    <asp:TextBox ID="txtBoxNome" readonly runat="server" CssClass="form-control" />
                </div>
                <div class="col-md-6">
                    <label for="txtBoxMarca">Marca: </label>
                    <asp:TextBox ID="txtBoxMarca" readonly runat="server" CssClass="form-control" />
                </div>
            </div>

            <div class="row">
                <div class="col-md-6">
                    <label for="txtBoxModelo">Modelo: </label>
                    <asp:TextBox ID="txtBoxModelo" readonly runat="server" CssClass="form-control" />
                </div>
                <div class="col-md-6">
                    <label for="txtBoxDtLocacao">Data de Locação: </label>
                    <asp:TextBox ID="txtBoxDtLocacao" readonly runat="server" CssClass="form-control" />
                </div>
            </div>

            <div class="row">
                <div class="col-md-6">
                    <label for="txtBoxDtDevolucao">Data de Devolução: </label>
                    <asp:TextBox ID="txtBoxDtDevolucao" readonly runat="server" CssClass="form-control" />
                </div>
                <div class="col-md-6">
                    <label for="txtBoxValTotal">Valor Total: </label>
                    <asp:TextBox ID="txtBoxValTotal" readonly runat="server" CssClass="form-control" />
                </div>
            </div>

        </form>
    </div>

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
