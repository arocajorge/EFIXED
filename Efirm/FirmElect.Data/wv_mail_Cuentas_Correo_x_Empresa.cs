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
    
    public partial class wv_mail_Cuentas_Correo_x_Empresa
    {
        public int IdEmpresa { get; set; }
        public string IdCuenta { get; set; }
        public string observacion { get; set; }
        public string RazonSocial { get; set; }
        public string Nombre_cuenta { get; set; }
        public string direccion_correo { get; set; }
        public string Password { get; set; }
        public string TipoCuenta { get; set; }
        public string Usuario { get; set; }
        public string ServidorCorreoEntrante { get; set; }
        public string ServidorCorreoSaliente { get; set; }
        public int Port_salida { get; set; }
        public int port_entrada { get; set; }
        public bool cta_predeterminada { get; set; }
        public string tipo_Seguridad { get; set; }
        public Nullable<bool> precisa_conexion_cifrada { get; set; }
        public Nullable<bool> enviar_copia_x_cada_mail_enviado { get; set; }
        public Nullable<bool> enviar_mail_x_cada_cbte_no_auto { get; set; }
        public string cta_mail_para_envio_x_cbte_enviado { get; set; }
        public string cta_mail_para_envio_x_cbte_no_auto { get; set; }
        public Nullable<bool> Usar_Credenciales_x_default_SMTP { get; set; }
        public string Tipo_Authenticacion { get; set; }
        public Nullable<bool> Usa_SSL_Conexion_para_Descarga_correo { get; set; }
        public Nullable<bool> Guardar_1_copia_de_corre_en_server_mail { get; set; }
        public Nullable<int> Borra_server_mail_cada_dias { get; set; }
        public string Usuario_smtp { get; set; }
        public string Password_smtp { get; set; }
        public Nullable<bool> Confirmacion_de_Lectura { get; set; }
        public Nullable<bool> Confirmacion_de_Entrega { get; set; }
    }
}
