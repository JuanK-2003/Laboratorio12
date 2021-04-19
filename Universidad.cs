using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio12
{
    public class Estudiante
    {
        public string nombre { get; set; }
    }

    public class Universidad
    {
        string universidades;

        List<Estudiante> estudiantes = new List<Estudiante>();
        public List<Estudiante> Estudiantes { get => estudiantes; set => estudiantes = value; }
        public string Universidades { get => universidades; set => universidades = value; }

        public Universidad()
        {
            Estudiantes = new List<Estudiante>();
        }
    }
}