using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlTower.Elements
{
    public abstract class Aircraft
    {
        protected IAirTraficControl _tower;
        protected string _name;

        public Aircraft(IAirTraficControl tower, string name)
        {
            _name = name;
            _tower = tower;

            if (_tower is Tower concreteTower)
                concreteTower.RegisterAircraft(this);
        }

        public void SendMessage(string message)
        {
            _tower.SendMessage(this, message);
        }
        public void ReceiveMessage(string message)
        {
            Console.WriteLine($"{_name} received message: {message}");
        }
    }
}
