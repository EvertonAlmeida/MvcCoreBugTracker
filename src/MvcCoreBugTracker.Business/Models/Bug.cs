using System;

namespace MvcCoreBugTracker.Business.Models
{
    public class Bug : Entity
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public Guid StatusId { get; set; }
        public Guid SeverityId { get; set; }

        /* EF Relations */
        public Status Status { get; set; }
        public Severity Severity { get; set; }
    }
}
