using System;
using System.Collections.Generic;

namespace demoexam.Models;

public partial class Shift
{
    public int Id { get; set; }

    public int? RoomId { get; set; }

    public DateOnly? Date { get; set; }

    public string? Cleaner { get; set; }

    public virtual Room? Room { get; set; }
}
