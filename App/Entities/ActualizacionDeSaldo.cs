using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ActualizacionDeSaldo : EventArgs
    {
        public decimal SaldoFinal { get; set; }

        public decimal PermitidoFinal { get; set; }

        public decimal SaldoDeEmergencia { get; set; }
        public decimal SaldoDeCritico { get; set; }
        public decimal SaldoPermitido { get; set; }

    }
}
