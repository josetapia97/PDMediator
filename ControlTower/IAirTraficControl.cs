using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlTower.Elements;

namespace ControlTower
{
    public interface IAirTraficControl
    {
        void SendMessage(Aircraft aircraft, string message);
    }
}
