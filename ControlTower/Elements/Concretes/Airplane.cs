using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlTower.Elements.Concretes
{
    public class Airplane : Aircraft
    {
        public Airplane(IAirTraficControl tower, string name) : base(tower, name)
        {
        }
    }
}
