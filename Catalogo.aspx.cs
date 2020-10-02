using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using locadoraCarros1.modelos;
using System.Xml;
using System.Globalization;

namespace locadoraCarros1 {
    public partial class Catalogo : System.Web.UI.Page {

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-5O401KG;Initial Catalog=locadoraCarros;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e) {
            if (!IsPostBack) {
                carregarGrid2();
            }
        }
        private void carregarGrid2() {
            try {
                con.Open();

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"select * from carros";
                SqlDataReader dtr = cmd.ExecuteReader();

                gvCatalogo.DataSource = dtr;
                gvCatalogo.DataBind();

                con.Close();
            }
            catch (Exception ex) {
                throw new Exception(ex.Message);
            }

        }

        protected void btnAlugarCarro_Command(object sender, CommandEventArgs e) {
            int IdCarro = int.Parse(PegaValor_Combo(e.CommandArgument.ToString(), 1, "/"));
            decimal ValSemanal = decimal.Parse(PegaValor_Combo(e.CommandArgument.ToString(), 2, "/"));
            geraNotaLocacao(IdCarro, ValSemanal);
            Response.Redirect("~/ReciboLocacao.aspx");

        }

        private SimulaLogin retornaDadosCadastrais() => (SimulaLogin)Session["simulaLogin"];


        private void geraNotaLocacao(int idCarro, decimal valSemanal) {
            try {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                SimulaLogin dadosCadastrais = retornaDadosCadastrais();

                DateTime dtLocacao = DateTime.Now;
                DateTime dtDevolucao = (dtLocacao.AddDays(7));


                cmd.CommandText = $"insert into Locacoes (IdCliente, IdCarro , DtLocacao, DtDevolucao, ValLocacao) values ('{dadosCadastrais.IdCliente}', '{idCarro}', '{dtLocacao}', '{dtDevolucao}', '{valSemanal.ToString("F2", CultureInfo.InvariantCulture)}')";
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex) {
                throw new Exception(ex.Message);
            }

        }

        private static string PegaValor_Combo(string sTexto, int TermoPedido, string sSimbolo = "-") {
            if (sTexto.Length == 0 | TermoPedido == 0) {
                return "";
            }

            int iPos = 0;
            int[] Localizados;
            Localizados = new int[100];

            int iCont = 1;
            while (iPos != -1) {
                iPos = sTexto.IndexOf(sSimbolo, iPos + 1);

                Localizados[iCont] = iPos;
                iCont += 1;
            }
            string sRet = "";
            if ((TermoPedido < 1) | (TermoPedido > iCont) | (TermoPedido > 99)) {
                sRet = "";
            }
            else if ((iCont - 1) == TermoPedido & TermoPedido == 1) {
                sRet = sTexto.Substring(Localizados[TermoPedido] + sSimbolo.Length);
            }
            else if ((iCont - 1) == TermoPedido & TermoPedido > 1) {
                sRet = sTexto.Substring(Localizados[TermoPedido - 1] + sSimbolo.Length);
            }
            else if (TermoPedido == 1) {
                sRet = sTexto.Substring(Localizados[TermoPedido - 1], Localizados[TermoPedido] - Localizados[TermoPedido - 1]);
            }
            else {
                sRet = sTexto.Substring(Localizados[TermoPedido - 1] + sSimbolo.Length, Localizados[TermoPedido] - Localizados[TermoPedido - 1] - 1);
            }
            return sRet.Trim();
        }
    }
}