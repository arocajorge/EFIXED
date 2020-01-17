using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirmElect.Info.class_sri.LiquidacionCompra;
using System.Data.SqlClient;
using FirmElect.Info;
namespace FirmElect.Data.Proceso_efixed
{
    public class fx_Generador_XML_LiquidacionComp_Fixed :fx_GeneradorXML_ILiquidacionComp_Data
    {

        List<liquidacionCompra> fx_GeneradorXML_ILiquidacionComp_Data.GenerarXmlFactura(DateTime FechaIni, DateTime FechaFin, string ConexionDBCliente, string OconEfirm, string FormatoFechaSRI, string formatoFechaDB)
        {
            DateTime Fi = Convert.ToDateTime(FechaIni.ToShortDateString());
            DateTime Ff = Convert.ToDateTime(FechaFin.ToShortDateString());
            //string sFi, sFf;
            //sFi = string.Format(formatoFechaDB, Fi);
            //sFf = string.Format(formatoFechaDB, Ff);


            try
            {
                List<liquidacionCompra> lista = new List<liquidacionCompra>();
                using (Entity_conexion_efixed context = new Entity_conexion_efixed())
                {
                    var liquidacion_og = context.vwfe_liquidacion_compra.Where(v => v.co_FechaFactura >= Fi && v.co_FechaFactura <= Ff);
                    foreach (var item in liquidacion_og)
                    {


                        liquidacionCompra myObject = new liquidacionCompra();
                        myObject.version = "1.1.0";
                        myObject.id = liquidacionCompraID.comprobante;
                        myObject.idSpecified = true;
                        infoTributaria info = new infoTributaria();
                        myObject.infoLiquidacionCompra = new liquidacionCompraInfoLiquidacionCompra();
                        myObject.infoLiquidacionCompra.totalConImpuestos = new List<liquidacionCompraInfoLiquidacionCompraTotalImpuesto>();
                        myObject.infoLiquidacionCompra.pagos = new List<pagosPago>();
                        pagosPago Pago = new pagosPago();
                        myObject.infoTributaria = info;
                        myObject.detalles = new List<liquidacionCompraDetalle>();
                        liquidacionCompraInfoLiquidacionCompraTotalImpuesto impuesto = null;
                        info.ambiente = "1";
                        myObject.infoTributaria.tipoEmision = "1";
                        myObject.infoTributaria.razonSocial = item.RazonSocial;
                        myObject.infoTributaria.nombreComercial = item.NombreComercial;
                        myObject.infoTributaria.ruc = item.em_ruc;
                        myObject.infoTributaria.claveAcceso = "0000000000000000000000000000000000000000000000000";
                        //*********************************************************************************
                        myObject.infoTributaria.codDoc = "03";
                        myObject.infoTributaria.estab = item.co_serie.Substring(0,3);
                        myObject.infoTributaria.ptoEmi = item.co_serie.Substring(4, 3);
                        myObject.infoTributaria.secuencial = item.co_factura;
                        myObject.infoTributaria.dirMatriz = item.em_direccion;
                        myObject.infoLiquidacionCompra.fechaEmision = string.Format("{0:dd/MM/yyyy}", item.co_FechaFactura);
                        myObject.infoLiquidacionCompra.dirEstablecimiento = item.em_direccion;
                        if (item.ContribuyenteEspecial != "")
                        {
                           // myObject.infoLiquidacionCompra.contribuyenteEspecial = item.ContribuyenteEspecial;
                        }
                       
                        myObject.infoLiquidacionCompra.obligadoContabilidadSpecified = true;
                        myObject.infoLiquidacionCompra.obligadoContabilidad = obligadoContabilidad.SI;
                        if (item.IdTipoDocumento == "RUC")
                            myObject.infoLiquidacionCompra.tipoIdentificacionProveedor = "04";

                        if (item.IdTipoDocumento == "PAS")
                            myObject.infoLiquidacionCompra.tipoIdentificacionProveedor = "06";

                        if (item.IdTipoDocumento == "CED")
                            myObject.infoLiquidacionCompra.tipoIdentificacionProveedor = "05";
                        myObject.infoLiquidacionCompra.identificacionProveedor = item.pe_cedulaRuc;
                        myObject.infoLiquidacionCompra.razonSocialProveedor = (item.pe_nombreCompleto.ToString()).Trim();
                        myObject.infoLiquidacionCompra.identificacionProveedor = item.pe_cedulaRuc;
                        myObject.infoLiquidacionCompra.direccionProveedor = item.pe_direccion;
                        myObject.infoLiquidacionCompra.totalSinImpuestos = Convert.ToDecimal(item.co_subtotal_iva+item.co_subtotal_siniva);


                        //valor total de la factura
                        myObject.infoLiquidacionCompra.importeTotal = Convert.ToDecimal(item.co_total);
                        myObject.infoLiquidacionCompra.moneda = "DOLAR";

                        //forma de pago quemada por decisión del cliente, siempre va a usar esta forma de pago
                        Pago.formaPago = "20";
                        Pago.total = Convert.ToDecimal(item.co_total);
                        Pago.plazoSpecified = true;
                        Pago.plazo = item.co_plazo;
                        Pago.unidadTiempo = "Días";
                        myObject.infoLiquidacionCompra.pagos.Add(Pago);
                        
                        
                           
                            if (item.co_subtotal_siniva != 0)
                            {
                                myObject.infoLiquidacionCompra.totalConImpuestos.Add(
                                    new liquidacionCompraInfoLiquidacionCompraTotalImpuesto
                                    {
                                        codigo="2",
                                        baseImponible = Convert.ToDecimal(item.co_subtotal_iva),
                                        codigoPorcentaje = "1",
                                        valor = Convert.ToDecimal(item.co_valoriva)

                                    });
                            }
                            if (item.co_subtotal_iva != 0)
                            {
                                myObject.infoLiquidacionCompra.totalConImpuestos.Add(
                                    new liquidacionCompraInfoLiquidacionCompraTotalImpuesto
                                    {
                                        codigo = "2",
                                        baseImponible = Convert.ToDecimal(item.co_subtotal_iva),
                                        codigoPorcentaje = "2",
                                        valor = Convert.ToDecimal(item.co_valoriva)
                                         

                                    });
                                

                            }
                        var facturas_detalle = context.vwfe_liquidacion_compra_det.Where(v => v.IdEmpresa == item.IdEmpresa
                            && v.IdTipoCbte_Ogiro == item.IdTipoCbte_Ogiro
                            && v.IdCbteCble_Ogiro == item.IdCbteCble_Ogiro 
                             && v.IdSucursal==item.IdSucursal
                             && v.IdBodega==item.IdBodega
                            );
                        decimal totalDescuento = 0;
                        foreach (var item_det in facturas_detalle)
                        {

                            impuesto imp = new impuesto();
                            liquidacionCompraDetalle fDetalle = new liquidacionCompraDetalle();
                            fDetalle.codigoPrincipal = item_det.pr_codigo;
                            fDetalle.codigoAuxiliar = item_det.pr_codigo;
                            fDetalle.descripcion = item_det.pr_descripcion;
                            fDetalle.cantidad = Convert.ToDecimal(item_det.Cantidad);
                            fDetalle.precioUnitario = Convert.ToDecimal(item_det.CostoUni);
                            fDetalle.descuento = Convert.ToDecimal(Convert.ToDouble( item_det.Cantidad)*item_det.DescuentoUni);
                            totalDescuento = totalDescuento + fDetalle.descuento;
                            fDetalle.precioTotalSinImpuesto = Convert.ToDecimal(item_det.Subtotal   );
                          
                            if (item_det.PorIva == 12)
                            {
                                imp.codigo = "2";
                                imp.codigoPorcentaje = "2";
                                imp.tarifa = Convert.ToDecimal(item_det.PorIva);
                                imp.baseImponible = Convert.ToDecimal(item_det.Subtotal);
                                imp.valor = Convert.ToDecimal(item_det.ValorIva);

                            }
                            if (item_det.PorIva == 0)
                            {
                                imp.codigo = "2";
                                imp.codigoPorcentaje = "0";
                                imp.tarifa = Convert.ToDecimal(item_det.PorIva);
                                imp.baseImponible = Convert.ToDecimal(item_det.Subtotal);
                                imp.valor = Convert.ToDecimal(item_det.ValorIva);

                            }

                            fDetalle.impuestos = new List<impuesto>();
                            fDetalle.impuestos.Add(imp);
                            myObject.detalles.Add(fDetalle);
                        }
                        myObject.infoLiquidacionCompra.totalDescuento = Convert.ToDecimal(totalDescuento);
                        myObject.infoLiquidacionCompra.totalDescuento = totalDescuento;
                        // campos adicionales 

                        fx_GeneradorXML_ValidarEmail_Info datosAdc = new fx_GeneradorXML_ValidarEmail_Info();
                        if (item.pe_correo != null && item.pe_correo != "")
                        {
                            if (myObject.infoAdicional == null)
                                myObject.infoAdicional = new List<liquidacionCompraCampoAdicional>();
                                liquidacionCompraCampoAdicional compoadicional = new liquidacionCompraCampoAdicional();
                                compoadicional.nombre = "MAIL";
                                compoadicional.Value = item.pe_correo;
                                myObject.infoAdicional.Add(compoadicional);
                            
                        }

                        if (item.co_observacion != null && item.co_observacion != "")
                        {
                            if (myObject.infoAdicional==null)
                                myObject.infoAdicional = new List<liquidacionCompraCampoAdicional>();
                                liquidacionCompraCampoAdicional compoadicional = new liquidacionCompraCampoAdicional();
                                compoadicional.nombre = "NOTA: ";
                                compoadicional.Value = item.co_observacion;
                                myObject.infoAdicional.Add(compoadicional);
                            
                        }
                      
                        lista.Add(myObject);


                       

                    }

                   
                }

                return lista;
            }
            catch (Exception ex)
            {
                return new List<liquidacionCompra>();
            }
        
           


        }




    }
}