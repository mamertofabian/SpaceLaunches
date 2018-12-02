using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceLaunches.Entities
{
    public class Status
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }

    public class StatusList
    {
        public List<Status> Types { get; set; }
        public int Total { get; set; }
        public int Count { get; set; }
        public int Offset { get; set; }
    }
}
