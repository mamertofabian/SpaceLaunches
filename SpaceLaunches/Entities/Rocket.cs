using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceLaunches.Entities
{
    public class Rocket
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FamilyName { get; set; }
        public string Configuration { get; set; }
        public string DefaultPads { get; set; }
        public string ImageUrl { get; set; }
        public List<int> ImageSizes { get; set; }
        public string WikiUrl { get; set; }
        public string SmallImageUrl { get; set; }
    }

    public class RocketList
    {
        public List<Rocket> Rockets { get; set; }
        public int Total { get; set; }
        public int Count { get; set; }
        public int Offset { get; set; }
    }
}
