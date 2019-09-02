using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuarios
    {
        public int UsuarioId { get; set; }
        public string Nombres { get; set; }
        public string Email { get; set; }
        public int NivelUsuario { get; set; }
        public string Usuario { get; set; }
        public string Clave { get; set; }
        public DateTime FechaCreacion { get; set; }
        public Usuarios()
        {
            UsuarioId = 0;
            Nombres = string.Empty;
            Email = string.Empty;
            NivelUsuario = 0;
            Usuario = string.Empty;
            Clave = string.Empty;
            FechaCreacion = DateTime.Now;
        }

        public Usuarios(int usuarioId, string nombres, string email, int nivelUsuario, string usuario, string clave, DateTime fechaCreacion)
        {
            UsuarioId = usuarioId;
            Nombres = nombres;
            Email = email;
            NivelUsuario = nivelUsuario;
            Usuario = usuario;
            Clave = clave;
            FechaCreacion = fechaCreacion;
        }
    }
}
