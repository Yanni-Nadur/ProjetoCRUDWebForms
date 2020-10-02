using System;
using locadoraCarros1.modelos;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace locadoraCarros1 {
    public partial class Cadastro : System.Web.UI.Page {

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-5O401KG;Initial Catalog=locadoraCarros;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e) {
            if (!IsPostBack) {
                txtBoxEmail.Text = Session["Cadastro"].ToString();
            }
        }

        protected void btnCadastrar_Command(object sender, CommandEventArgs e) {

            try {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"insert into Clientes values('{txtBoxNome.Text}','{txtBoxCPF.Text}', '{txtBoxEmail.Text}')";
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex) {
                throw new Exception(ex.Message);
            }

            logar();
        }

        private void logar() {
            con.Open();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from Clientes where Email='{txtBoxEmail.Text}'";
            SqlDataReader dtr = cmd.ExecuteReader();

            SimulaLogin smLog = new SimulaLogin();

            while (dtr.Read()) {
                smLog.IdCliente = int.Parse(dtr["IdCliente"].ToString());
                smLog.Nome = dtr["Nome"].ToString();
                smLog.CPF = dtr["CPF"].ToString();
                smLog.Email = dtr["Email"].ToString();
            };

            Session["simulaLogin"] = smLog;

            con.Close();

            Response.Redirect("~/Catalogo.aspx");
        }
    }
}