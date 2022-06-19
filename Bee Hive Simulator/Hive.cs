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
    public class Hive
    {
        const int InitialBees = 6;
        const double InintialHoney = 3.2;
        const double MaximumHoney = 15;
        const double NectarHoneyRatio = 0.25;
        const double MinimumHoneyForCreatingBees = 4;
        const int MaximumBees = 8;
        
        public double Honey { get; set; }
        
        [NonSerialized]
        public BeeMessage MessageSender;

        Dictionary<string, Point> locations;
        int beeCount;
        Random random;

        World world;

        public Hive(World world, BeeMessage MessageSender)
        {
            this.MessageSender = MessageSender;
            Honey = InintialHoney;
            InitializeLocations();
            random = new Random();
            this.world = world;

            for (int i = 0; i < InitialBees; i++)
            {
                AddBee(random);
            }
        }

        void InitializeLocations()
        {
            locations = new Dictionary<string, Point>()
            {
                {"Entrance", new Point(593,87)},
                {"Nursery", new Point(62,148)},
                {"HoneyFactory", new Point(165,71)},
                {"Exit", new Point(206,203)}
            };
        }

        public bool AddHoney(double nectar)
        {
            double honeyToAdd = nectar * NectarHoneyRatio;
            if(honeyToAdd + Honey > MaximumHoney)
            return false;

            Honey += honeyToAdd;
            return true;
        }

        public bool ConsumeHoney(double amount)
        {
            if (amount > Honey) return false;
            else
            {
                Honey -= amount;
                return true;
            }
        }

        public void AddBee(Random random)
        {
            beeCount++;
            int r1 =(random.Next(100) - 50);
            int r2 = random.Next(100) - 50;
            Point startPoint = new Point(locations["Nursery"].X + r1,
                locations["Nursery"].Y + r2);

            Bee newBee = new Bee(beeCount, startPoint, world, this);
            newBee.MessageSender = this.MessageSender;
            world.Bees.Add(newBee);
        }

        public void Go(Random random)
        {
            if (world.Bees.Count < MaximumBees &&
                Honey > MinimumHoneyForCreatingBees
                && random.Next(10) == 1)
                AddBee(random);
        }

        public Point GetLocation(string location)
        {
            if (locations.ContainsKey(location)) return locations[location];
            else throw new ArgumentException("Нет локации с именем :" + location);
        }
    }
}
