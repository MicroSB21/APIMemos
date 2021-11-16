using System;

namespace Dominio
{
    public class Accion
    {
        public int ID { get; set; }
        public string Descripcion { get; set; }

        public bool Estado { get; set; }
        public DateTime SistemaFecha { get; set; }
        public string SistemaUsuario { get; set; }
    }
}