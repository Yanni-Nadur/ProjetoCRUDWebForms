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
            string Marca = PegaValor_Combo(e.CommandArgument.ToString(), 2, "/");
            string Modelo = PegaValor_Combo(e.CommandArgument.ToString(), 3, "/");
            decimal ValSemanal = decimal.Parse(PegaValor_Combo(e.CommandArgument.ToString(), 4, "/"));

        }

        //private SimulaLogin 

        //private void geraNotaLocacao(int idCarro) {
        //    try {
        //        con.Open();
        //        SqlCommand cmd = con.CreateCommand();
        //        cmd.CommandType = CommandType.Text;
        //        Session["Cadastro"]

        //        cmd.CommandText = $"insert into Locacoes values('{txtBoxNome.Text}','{txtBoxCPF.Text}', '{txtBoxEmail.Text}')";
        //        cmd.ExecuteNonQuery();
        //        con.Close();
        //    }
        //    catch (Exception ex) {
        //        throw new Exception(ex.Message);
        //    }

        //}

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