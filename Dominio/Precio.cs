using System;

namespace Dominio
{
    public class Precio
    {
        public Guid PrecioId {get;set;}
        public double PrecioActual {get;set;}
        public double Promocion {get; set;}
        public Guid CursoId {get;set;}
        public Curso Curso{get;set;}
    }
}