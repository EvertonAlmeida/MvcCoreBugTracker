using System;

namespace MvcCoreBugTracker.Business.Models
{
    public class Status : Entity
    {
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
