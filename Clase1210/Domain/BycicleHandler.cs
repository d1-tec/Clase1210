using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public static class BycicleHandler
    {
        private static List<Bycicle> bycicles = new List<Bycicle>();

        public static void AddBycicle(Bycicle bycicle)
        {
            bycicles.Add(bycicle);
        }

        public static List<Bycicle> GetBycicles()
        {
            return bycicles;
        }

        public static List<BikeType> GetBikeTypes()
        {
            return new List<BikeType>() { BikeType.MOUNTAIN, BikeType.ROAD };
        }
    }
}
