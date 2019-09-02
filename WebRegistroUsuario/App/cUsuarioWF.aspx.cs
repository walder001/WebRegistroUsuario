using BLL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebRegistroUsuario.App.Consulta
{
    public partial class cUsuarioWF : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Buscar_Click(object sender, EventArgs e)
        {
            Expression<Func<Usuarios, bool>> filtros = x => true;
            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>(new DAL.Contexto());

            DateTime Desde = Convert.ToDateTime(DesdeTextBox.Text);
            DateTime Hasta = Convert.ToDateTime(HastaTextBox.Text);

            int id;
            id = Convert.ToInt32(CriterioTextBox.Text);
            switch (FiltroDropDownList.SelectedIndex)
            {
                case 0: //ID                  
                    filtros = c => c.UsuarioId == id && c.FechaCreacion >= Desde && c.FechaCreacion <= Hasta;
                    break;
                case 1: //Usuario
                    filtros = c => c.Usuario.Contains(CriterioTextBox.Text) && c.FechaCreacion >= Desde && c.FechaCreacion <= Hasta;
                    break;
                case 2: //Nombres
                    filtros = c => c.Nombres.Contains(CriterioTextBox.Text) && c.FechaCreacion >= Desde && c.FechaCreacion <= Hasta;
                    break;
                case 3: //Email
                    filtros = c => c.Email.Contains(CriterioTextBox.Text) && c.FechaCreacion >= Desde && c.FechaCreacion <= Hasta;
                    break;
                case 4: //Todo
                    break;
            }
            UsuarioGridView.DataSource = repositorio.GetList(filtros);
            UsuarioGridView.DataBind();
        }
    }
}