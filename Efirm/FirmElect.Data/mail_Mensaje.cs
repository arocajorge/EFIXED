//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FirmElect.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class mail_Mensaje
    {
        public mail_Mensaje()
        {
            this.mail_Mensaje_Archi_Adjunto = new HashSet<mail_Mensaje_Archi_Adjunto>();
        }
    
        public decimal IdMensaje { get; set; }
        public System.DateTime Fecha { get; set; }
        public string Para { get; set; }
        public string Asunto { get; set; }
        public string Asunto_texto_mostrado { get; set; }
        public bool Tiene_Adjunto { get; set; }
        public int Prioridad { get; set; }
        public bool Leido { get; set; }
        public bool Respondido { get; set; }
        public bool No_Leido { get; set; }
        public string Texto_mensaje { get; set; }
        public string IdTipo_Mensaje { get; set; }
        public bool Eliminado { get; set; }
        public Nullable<decimal> IdContribuyente { get; set; }
        public string mail_remitente { get; set; }
        public string Para_CC { get; set; }
        public string codMensajeId { get; set; }
        public string IdCuenta { get; set; }
        public byte[] Archivo_correo { get; set; }
        public string Para_CCO { get; set; }
    
        public virtual ICollection<mail_Mensaje_Archi_Adjunto> mail_Mensaje_Archi_Adjunto { get; set; }
        public virtual mail_Mensaje_Tipo mail_Mensaje_Tipo { get; set; }
        public virtual tb_Contribuyente tb_Contribuyente { get; set; }
    }
}