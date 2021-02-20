
using System;

namespace MvcCoreBugTracker.Business.Models
{
    public class Severity : Entity
    {
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
