using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public enum BikeType
    {
        ROAD,
        MOUNTAIN
    }

    public enum BikeSize
    {
        SIZE_26,
        SIZE_32
    }

    public class Bycicle
    {
        public string Name { get; set; }
        public BikeType BikeType { get; set; }
        public bool IsNew { get; set; }
        public BikeSize BikeSize { get; set; }
        
        public List<DistanceEntry> DistanceEntries { get; private set; }

        public Bycicle()
        {
            this.DistanceEntries = new List<DistanceEntry>();
        }

        public void AddDistanceEntry(DistanceEntry distanceEntry)
        {
            this.DistanceEntries.Add(distanceEntry);
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
