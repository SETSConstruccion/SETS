using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SETS.Models
{
    public class Administrador
    {
        public string Id { get; set; }
        public string Correo { get; set; }
        public int nombre { get; set; }
        public string IdTipoUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public int Edad { get; set; }
        public string Password { get; set; }
    }
}
