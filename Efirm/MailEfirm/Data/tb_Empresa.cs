//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MailEfirm.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_Empresa
    {
        public int IdEmpresa { get; set; }
        public string RazonSocial { get; set; }
        public string NombreComercial { get; set; }
        public string RUC { get; set; }
        public string DirMatriz { get; set; }
        public string ContribuyenteEspecial { get; set; }
        public string ObligadoAllevarConta { get; set; }
        public string NombreCertificado { get; set; }
        public string Clave_Certificado { get; set; }
        public Nullable<System.DateTime> FechaValidez { get; set; }
        public bool Estado { get; set; }
        public byte[] logo { get; set; }
        public int IdAmbiente { get; set; }
        public int TipoEmision { get; set; }
        public string Alias { get; set; }
        public string IdToquenAFirmar { get; set; }
        public string cod_Ambiente { get; set; }
        public string cod_TipoEmision { get; set; }
        public string url { get; set; }
    }
}
