using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlTower.Elements
{
    public class Tower : IAirTraficControl
    {
        private List<Aircraft> _aircrafts = new List<Aircraft>();

        public void RegisterAircraft(Aircraft aircraft)
        {
            if (!_aircrafts.Contains(aircraft))
                _aircrafts.Add(aircraft);
            
        }
        public void SendMessage(Aircraft sender, string message)
        {
            foreach (var aircraft in _aircrafts)
            {
                if (aircraft != sender)
                {
                    aircraft.ReceiveMessage(message);
                }
            }
        }
    }
}
