//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Comprension_Lectora.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SOLICITUD_CISTAS
    {
        public int CodigoCitas { get; set; }
        public string Cita_Paciente { get; set; }
        public Nullable<System.DateTime> Fecha_Cita { get; set; }
        public Nullable<System.TimeSpan> Hora_Cita { get; set; }
        public string Tipo_Consulta { get; set; }
    }
}
