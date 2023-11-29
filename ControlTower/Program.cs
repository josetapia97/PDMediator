using ControlTower;
using ControlTower.Elements;
using ControlTower.Elements.Concretes;

IAirTraficControl tower = new Tower();
Aircraft airplane1 = new Airplane(tower, "VuelaVeloz");
Aircraft helicopter1 = new Helicopter(tower, "Tukutuku");
Aircraft airplane2 = new Airplane(tower, "VuelaLentito");

airplane1.SendMessage("Hello from airplane1");