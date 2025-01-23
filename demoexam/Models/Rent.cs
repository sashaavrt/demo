using System;
using System.Collections.Generic;

namespace demoexam.Models;

public partial class Rent
{
    public int Id { get; set; }

    public int? RoomId { get; set; }

    public int? GuestId { get; set; }

    public DateOnly? Checkin { get; set; }

    public DateOnly? Checkout { get; set; }

    public virtual ICollection<Bill> Bills { get; set; } = new List<Bill>();

    public virtual Guest? Guest { get; set; }

    public virtual Room? Room { get; set; }
}
