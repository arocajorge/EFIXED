using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirmElect.Info.class_sri.LiquidacionCompra;
namespace FirmElect.Data
{
    public interface fx_GeneradorXML_ILiquidacionComp_Data
    {
        List<liquidacionCompra> GenerarXmlFactura(DateTime FechaIni, DateTime FechaFin, string ConexionDBCliente,string OconEfirm, string FormatoFechaSRI, string formatoFechaDB);
       
    }
}
