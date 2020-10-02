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

        //private void carregarGrid() {
        //    gvCatalogo.DataSource = retornaListaCarros();
        //    gvCatalogo.DataBind();
        //}

        //private List<Carro> retornaListaCarros() {

        //    con.Open();

        //    SqlCommand cmd = con.CreateCommand();
        //    // cmd.Connection = con;
        //    cmd.CommandType = CommandType.Text;
        //    cmd.CommandText = $"select * from carros";
        //    SqlDataReader dtr = cmd.ExecuteReader();

        //    Carro carro;
        //    List<Carro> Carros = new List<Carro>();
        //    while (dtr.Read()) {
        //        carro = new Carro();
        //        carro.IdCarro = int.Parse(dtr["IdCarro"].ToString());
        //        carro.Marca = dtr["Marca"].ToString();
        //        carro.Modelo = dtr["Modelo"].ToString();
        //        carro.Placa = dtr["Placa"].ToString();
        //        // carro.ValSemanal = decimal.Parse(dtr["ValSemanal"].ToString());
        //        Carros.Add(carro);
        //    }

        //    con.Close();
        //    return Carros;
        //}


        private void carregarGrid2() {
            try {
                con.Open();

                SqlCommand cmd = con.CreateCommand();
                // cmd.Connection = con;
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
    }
}