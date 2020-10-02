using System;
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
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"insert into Clientes values('{txtBoxNome.Text}','{txtBoxCPF.Text}', '{txtBoxEmail.Text}')";
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}