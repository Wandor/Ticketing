using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ticketing.Enum
{
    public enum TicketStatus
    {
        Unassigned = 1,
        Assigned = 2,
        OnHold = 3,
        Escalated = 4,
        Closed = 5
    }
}
