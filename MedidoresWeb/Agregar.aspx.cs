
using MedidoresModel;
using MedidoresModel.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MedidoresWeb
{
    public partial class Agregar : System.Web.UI.Page
    {
        private IUsuarioDAL usuariosDAL = new UsuarioDALDB();
        private IMedidorDAL MedidorDAL = new MedidorDALDB();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ingresarBtn_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario
            {
                rut = this.rutTxt.Text.Trim(),
                username = this.nombreTxt.Text.Trim(),
                passwd = this.passwdTxt.Text.Trim(),
                mail = this.correoTxt.Text.Trim()
            };

            this.usuariosDAL.AddUsuario(usuario);
            Response.Redirect("Listado.aspx");
        }
    }
}