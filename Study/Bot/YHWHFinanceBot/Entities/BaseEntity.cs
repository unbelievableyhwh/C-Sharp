using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YHWHFinanceBot.Entities
{
    public class BaseEntity
    {
        public long Id { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
