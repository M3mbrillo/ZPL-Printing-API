using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPL_Server.Services
{
    public class ZebraService
    {

        public ZebraService()
        {
        }


        public void PrintTo(string ipAddress, int port, string zplCommand)
        {
            var printer = new SharpZebra.Printing.NetworkPrinter(new SharpZebra.Printing.PrinterSettings()
            {
                PrinterPort = port,
                PrinterName = ipAddress
            });

            printer.Print(Encoding.ASCII.GetBytes(zplCommand));
        }
    }
}
