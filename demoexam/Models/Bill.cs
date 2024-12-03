using System;
using System.Collections.Generic;

namespace demoexam.Models;

public partial class Bill
{
    public int Id { get; set; }

    public int? GuestId { get; set; }

    public int? ServiceId { get; set; }

    public int? RentId { get; set; }

    public string? Price { get; set; }

    public string? Sum { get; set; }

    public int? UserId { get; set; }
}
