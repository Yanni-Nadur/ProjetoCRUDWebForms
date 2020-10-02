using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace locadoraCarros1 {
    public partial class Default : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            Session.Clear();
            
        }

     

        protected void btnCadastrar_Command(object sender, CommandEventArgs e) {
            Session["Cadastro"] = txtEmail.Text;
            Response.Redirect("~/Cadastro.aspx");
        }
    }
}