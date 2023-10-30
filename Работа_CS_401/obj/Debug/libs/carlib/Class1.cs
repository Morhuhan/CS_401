using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carlib
{
    public enum EngineState
    {
        engineAlive,
        engineDead,
    }

    public abstract class Car
    {
        public string name = "noname";
        public short maxpeed;
        public short speed;
        public EngineState state = EngineState.engineAlive;

        public Car() { }

        public Car(string name, short maxspeed, short speed)
        {
            this.name = name;
            this.maxpeed = maxspeed;
            this.speed = speed;
        }

        public abstract void TurboBoost();
    }

    public class SportCar : Car
    {
        public SportCar() { }

        public SportCar(string name, short maxspeed, short speed) : base(name, maxspeed, speed) { }

        public override void TurboBoost()
        {
            Console.WriteLine("Faster is better");
        }
    }

    public class MiniVan : Car
    {
        public MiniVan() { }

        public MiniVan(string name, short maxspeed, short speed) : base(name, maxspeed, speed) { }

        public override void TurboBoost()
        {
            Console.WriteLine("The car is dead");
        }
    }

    public class VWmininVan : MiniVan
    {
        public VWmininVan() { }

        public VWmininVan(string name, short maxspeed, short speed) : base(name, maxspeed, speed) { }

        public void IsVersion()
        {
            Console.WriteLine("Version is 2.0.0.0.");
        }
    }
}
