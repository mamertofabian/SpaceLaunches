using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceLaunches.Entities
{
    public class Launch
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string WindowStart { get; set; }
        public string WindowEnd { get; set; }
        public string Net { get; set; }
        public string IsoStart { get; set; }
        public string IsoEnd { get; set; }
        public string IsoNet { get; set; }
        public int Status { get; set; }
        public string StatusName { get; set; }
        public string StatusDesc { get; set; }
        public Location Location { get; set; }
        public Rocket Rocket { get; set; }
    }

    public class LaunchList
    {
        public List<Launch> Launches { get; set; }
        public int Total { get; set; }
        public int Offset { get; set; }
        public int Count { get; set; }
    }
}
