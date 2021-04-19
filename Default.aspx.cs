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
    public partial class _Default : Page
    {
        static List<Universidad> universidades = new List<Universidad>();
        static List<Estudiante> estudiantes = new List<Estudiante>();
        string uniFiles = ""; 
        protected void Page_Load(object sender, EventArgs e)
        {
            if( !IsPostBack )
            {
                uniFiles = Server.MapPath("Universidades.json");
                if (validarArchivos())
                {
                    using (StreamReader rd = new StreamReader(uniFiles))
                        universidades = JsonConvert.DeserializeObject<List<Universidad>>(rd.ReadToEnd());
                }
                else
                    File.Create(uniFiles);
                if (universidades == null)
                    universidades = new List<Universidad>();
            }
        }

        protected bool validarArchivos()
        {
            return File.Exists(uniFiles);
        }

        protected void guardarTodo()
        {
            string json = JsonConvert.SerializeObject(universidades);
            string archivo = Server.MapPath("Universidades.json");
            System.IO.File.WriteAllText(archivo, json);
        }

        protected void ButtonAlumno_Click(object sender, EventArgs e)
        {
            Estudiante estudiante = new Estudiante();
            estudiante.nombre = TextAlumno.Text;
            estudiantes.Add(estudiante);
            TextAlumno.Text = "";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
             Universidad universidad = new Universidad();
             universidad.Universidades = DropDownList1.SelectedValue;
             universidad.Estudiantes = estudiantes.ToList();

             universidades.Add(universidad);
             guardarTodo();
             estudiantes.Clear();
        }
    }
}