using System;
using System.Collections.Generic;

namespace demoexam.Models;

public partial class RoomAccess
{
    public int Id { get; set; }

    public int? GuestId { get; set; }

    public int? RoomId { get; set; }

    public string? Code { get; set; }

    public string? Status { get; set; }

    public virtual Guest? Guest { get; set; }

    public virtual Room? Room { get; set; }
}
