//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FirmElect.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class mail_Cuentas_Correo_x_Empresa
    {
        public int IdEmpresa { get; set; }
        public string IdCuenta { get; set; }
        public string observacion { get; set; }
    
        public virtual mail_Cuentas_Correo mail_Cuentas_Correo { get; set; }
        public virtual tb_Empresa tb_Empresa { get; set; }
    }
}
