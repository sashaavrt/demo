using System;
using System.Collections.Generic;

namespace demoexam.Models;

public partial class Room
{
    public int Id { get; set; }

    public string? Floor { get; set; }

    public int? Room1 { get; set; }

    public string? Category { get; set; }

    public string? Status { get; set; }

    public virtual ICollection<Rent> Rents { get; set; } = new List<Rent>();

    public virtual ICollection<RoomAccess> RoomAccesses { get; set; } = new List<RoomAccess>();

    public virtual ICollection<Shift> Shifts { get; set; } = new List<Shift>();
}
