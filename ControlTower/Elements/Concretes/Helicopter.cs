using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlTower.Elements.Concretes
{
    public class Helicopter : Aircraft
    {
        public Helicopter(IAirTraficControl tower, string name) : base(tower, name)
        {
        }
    }
}
