using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Bee_Hive_Simulator
{
    [Serializable]
    public class Flower
    {
        const int LifeSpanMin = 15000;
        const int LifeSpanMax = 30000;
        const double InitialNectar = 1.5;
        const double MaxNectar = 5;
        const double NectarAddedPerTurn = 0.01;
        const double NectarGatheredPerTurn = 0.3;
        
        public Point Location { get; private set; }
        public int Age { get; private set; }
        public bool Alive { get; private set; }
        public double Nectar { get; private set; }
        public double NectarHarvested { get; set; }

        int lifespan;

        public Flower(Point Location, Random random)
        {
            this.Location = Location;
            Age = 0;
            Alive = true;
            Nectar = InitialNectar;
            NectarHarvested = 0;
            lifespan = random.Next(LifeSpanMin, LifeSpanMax + 1);
        }

        public double HarvestNectar()
        {
            if (NectarGatheredPerTurn > Nectar) return 0;
            else
            {
                Nectar -= NectarGatheredPerTurn;
                NectarHarvested += NectarGatheredPerTurn;
                return NectarGatheredPerTurn;
            }
        }

        public void Go()
        {
            Age++;
            if (Age > lifespan) { Alive = false;  }
            else
            {
                Nectar += NectarAddedPerTurn;
                if (Nectar > MaxNectar) Nectar = MaxNectar;
            }
        }
    }
}
