﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entity_conexion_efixed : DbContext
    {
        public Entity_conexion_efixed()
            : base("name=Entity_conexion_efixed")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<vwfe_factura_detalle> vwfe_factura_detalle { get; set; }
        public DbSet<vwfe_factura_impuestos> vwfe_factura_impuestos { get; set; }
        public DbSet<vwfe_guia_remision_detalle> vwfe_guia_remision_detalle { get; set; }
        public DbSet<vwfe_guia_remision_x_factura> vwfe_guia_remision_x_factura { get; set; }
        public DbSet<vwfe_nota_credito> vwfe_nota_credito { get; set; }
        public DbSet<vwfe_nota_credito_impuestos> vwfe_nota_credito_impuestos { get; set; }
        public DbSet<vwfe_nota_debito> vwfe_nota_debito { get; set; }
        public DbSet<vwfe_nota_debito_detalle> vwfe_nota_debito_detalle { get; set; }
        public DbSet<vwfe_nota_debito_impuestos> vwfe_nota_debito_impuestos { get; set; }
        public DbSet<vwfe_retencion> vwfe_retencion { get; set; }
        public DbSet<vwfe_retencion_detalle> vwfe_retencion_detalle { get; set; }
        public DbSet<fa_elec_registros_generados> fa_elec_registros_generados { get; set; }
        public DbSet<vwfe_factura> vwfe_factura { get; set; }
        public DbSet<vwfe_nota_credito_detalle> vwfe_nota_credito_detalle { get; set; }
        public DbSet<vwfe_guia_remision> vwfe_guia_remision { get; set; }
        public DbSet<vwfe_liquidacion_compra> vwfe_liquidacion_compra { get; set; }
        public DbSet<vwfe_liquidacion_compra_det> vwfe_liquidacion_compra_det { get; set; }
    }
}
