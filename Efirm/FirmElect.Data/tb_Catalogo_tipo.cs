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
    
    public partial class tb_Catalogo_tipo
    {
        public tb_Catalogo_tipo()
        {
            this.tb_Catalogo = new HashSet<tb_Catalogo>();
        }
    
        public int IdTipoCatalogo { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }
    
        public virtual ICollection<tb_Catalogo> tb_Catalogo { get; set; }
    }
}