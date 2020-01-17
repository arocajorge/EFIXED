using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraReports.UI;
using FirmElect.Info.class_sri.LiquidacionCompra;



namespace FirmElect.Reports
{
    public interface IRpt_Ride_liquidacion
    {

       DevExpress.XtraReports.UI.XtraReport Optener_reporte(liquidacion_compra_Ride_Info InfoFactura);


    }
}
