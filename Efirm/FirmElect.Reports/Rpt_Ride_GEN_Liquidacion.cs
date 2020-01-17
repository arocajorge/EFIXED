using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmElect.Reports
{
    public class Rpt_Ride_GEN_Liquidacion : IRpt_Ride_liquidacion
    {
       public DevExpress.XtraReports.UI.XtraReport Optener_reporte(Info.class_sri.LiquidacionCompra.liquidacion_compra_Ride_Info InfoFactura)
       {
           try
           {
               xRpt_liquidacion_compraGen Reporte = new xRpt_liquidacion_compraGen();
               Reporte.cargar_reporte(InfoFactura);
               //xRpt_Ride_Gen_Forma_Pago Reporte_FormaPago = new xRpt_Ride_Gen_Forma_Pago();
               //Reporte_FormaPago.cargar_reporte(InfoFactura);

               return Reporte;
           }
           catch (Exception ex)
           {
               return new DevExpress.XtraReports.UI.XtraReport();
           }
       }
       
    }
}
