using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio12
{
    public partial class Contact : Page
    {
        static List<Universidad> universidades = new List<Universidad>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if( !IsPostBack )
            {
                string archivo = Server.MapPath("Universidades.json");
                StreamReader rd = File.OpenText(archivo);
                string json = rd.ReadToEnd();
                rd.Close();

                universidades = JsonConvert.DeserializeObject<List<Universidad>>(json);

                GridViewUniversidades.DataSource = universidades;
                GridViewUniversidades.DataBind();
            }

            LabelNombre.Visible = false;
            TextNombre.Visible = false;
            ButtonGuardar.Visible = false;
        }

        protected void guardarTodo()
        {
            string json = JsonConvert.SerializeObject(universidades);
            string archivo = Server.MapPath("Universidades.json");
            System.IO.File.WriteAllText(archivo, json);
        }

        protected void GridViewUniversidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selec = GridViewUniversidades.SelectedIndex;
            GridViewUniversidades.DataSource = universidades[selec].Estudiantes;
            GridViewUniversidades.DataBind();
        }

        protected void ButtonEliminar_Click(object sender, EventArgs e)
        {
            int idUni = GridViewUniversidades.SelectedIndex;
            int idEst = GridViewAlumnos.SelectedIndex;

            universidades[idUni].Estudiantes.RemoveAt(idEst);
            guardarTodo();

            GridViewAlumnos.DataSource = universidades[idUni].Estudiantes;
            GridViewAlumnos.DataBind();
        }

        protected void ButtonEditar_Click(object sender, EventArgs e)
        {
            int idUni = GridViewUniversidades.SelectedIndex;
            int idEst = GridViewAlumnos.SelectedIndex;

            LabelNombre.Visible = true;
            TextNombre.Visible = true;
            ButtonEditar.Visible = true;

            TextNombre.Text = universidades[idUni].Estudiantes[idEst].nombre;
        }

        protected void ButtonGuardar_Click(object sender, EventArgs e)
        {
            int idUni = GridViewUniversidades.SelectedIndex;
            int idEst = GridViewAlumnos.SelectedIndex;

            universidades[idUni].Estudiantes[idEst].nombre = TextNombre.Text;
            guardarTodo();

            GridViewAlumnos.DataSource = universidades[idUni].Estudiantes;
            GridViewAlumnos.DataBind();
        }
    }
}