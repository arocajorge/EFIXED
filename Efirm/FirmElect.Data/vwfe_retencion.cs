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
    
    public partial class vwfe_retencion
    {
        public int IdEmpresa { get; set; }
        public decimal IdRetencion { get; set; }
        public string CodDocumentoTipo { get; set; }
        public string serie1 { get; set; }
        public string serie2 { get; set; }
        public string NumRetencion { get; set; }
        public string NAutorizacion { get; set; }
        public Nullable<System.DateTime> Fecha_Autorizacion { get; set; }
        public System.DateTime fecha { get; set; }
        public string observacion { get; set; }
        public decimal IdCbteCble_Ogiro { get; set; }
        public int IdTipoCbte_Ogiro { get; set; }
        public System.DateTime co_fechaOg { get; set; }
        public string co_serie { get; set; }
        public string co_factura { get; set; }
        public System.DateTime co_FechaFactura { get; set; }
        public string Num_Autorizacion { get; set; }
        public string Num_Autorizacion_Imprenta { get; set; }
        public string pe_Naturaleza { get; set; }
        public string IdTipoDocumento { get; set; }
        public string pe_cedulaRuc { get; set; }
        public string pe_nombreCompleto { get; set; }
        public string pe_direccion { get; set; }
        public string pe_telfono_Contacto { get; set; }
        public string pe_celular { get; set; }
        public string pe_correo { get; set; }
        public string pe_razonSocial { get; set; }
        public string em_nombre { get; set; }
        public string RazonSocial { get; set; }
        public string NombreComercial { get; set; }
        public string ContribuyenteEspecial { get; set; }
        public string ObligadoAllevarConta { get; set; }
        public string em_ruc { get; set; }
        public string em_direccion { get; set; }
        public string em_telefonos { get; set; }
        public string em_Email { get; set; }
        public string IdOrden_giro_Tipo { get; set; }
        public Nullable<bool> es_Documento_Electronico { get; set; }
    }
}
