//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Usuarios
    {
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apaterno { get; set; }
        public string Amaterno { get; set; }
        public Nullable<int> IdEspecialidad { get; set; }
        public Nullable<int> IdEstado { get; set; }
        public Nullable<int> IdPais { get; set; }
    
        public virtual Especialidades Especialidades { get; set; }
        public virtual Estados Estados { get; set; }
        public virtual Paises Paises { get; set; }
    }
}