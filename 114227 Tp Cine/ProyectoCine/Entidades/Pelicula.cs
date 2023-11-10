using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCine.Entidades
{
    public class Pelicula
    {
        public int codPelicula;
        public string titulo { get; set; }
        public string sinopsis { get; set; }
        public int idPg { get; set; }
        public int idGenero { get; set; }
        public int idActor { get; set; }
        public int idDirector { get; set;}
        public DateTime fechaEstreno { get; set; }
    }
}
