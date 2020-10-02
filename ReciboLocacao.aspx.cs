using locadoraCarros1.modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;
using System.Data.SqlClient;
using System.Data;

namespace locadoraCarros1 {
    public partial class ReciboLocacao : System.Web.UI.Page {

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-5O401KG;Initial Catalog=locadoraCarros;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e) {
            carregaCampos();
        }


        private void carregaCampos() {

            Recibo reciboLocacao = retornaRecibo();

            txtBoxNome.Text = reciboLocacao.Nome;
            txtBoxMarca.Text = reciboLocacao.Marca;
            txtBoxModelo.Text = reciboLocacao.Modelo;
            txtBoxDtLocacao.Text = reciboLocacao.DtLocacao.ToString("dd/MM/yyyy");
            txtBoxDtDevolucao.Text = reciboLocacao.DtDevolucao.ToString("dd/MM/yyyy");
            txtBoxValTotal.Text = reciboLocacao.ValLocacao.ToString("F2", CultureInfo.InvariantCulture);
        }

        private Recibo retornaRecibo() {
            try {
                con.Open();

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                SimulaLogin login = retornaDadosCadastrais();

                cmd.CommandText = $"select Nome, Marca, Modelo, l.DtLocacao, l.DtDevolucao, l.ValLocacao from Locacoes as l " +
                $"inner join Clientes as c on c.IdCliente = l.IdCliente " +
                $"inner join Carros as cr on cr.IdCarro = l.IdCarro " +
                $"where c.IdCliente = {login.IdCliente}";

                SqlDataReader dtr = cmd.ExecuteReader();

                Recibo recibo = new Recibo();

                while (dtr.Read()) {
                    recibo.Nome = dtr["Nome"].ToString();
                    recibo.Marca = dtr["Marca"].ToString();
                    recibo.Modelo = dtr["Modelo"].ToString();
                    recibo.DtLocacao = DateTime.Parse(dtr["DtLocacao"].ToString());
                    recibo.DtDevolucao = DateTime.Parse(dtr["DtDevolucao"].ToString());
                    recibo.ValLocacao = decimal.Parse(dtr["ValLocacao"].ToString());
                };

                con.Close();
                return recibo;
            }
            catch (Exception ex) {

                throw new Exception(ex.Message);
            }
        }
        private SimulaLogin retornaDadosCadastrais() => (SimulaLogin)Session["simulaLogin"];
    }
}