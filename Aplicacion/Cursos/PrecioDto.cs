using System;

namespace Aplicacion.Cursos
{
    public class PrecioDto
    {
        public Guid PrecioId { get; set; }
        public double PrecioActual { get; set; }
        public double Promocion { get; set; }
        public Guid CursoId { get; set; }
    }
}