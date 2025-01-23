using System;
using System.Collections.Generic;

namespace demoexam.Models;

public partial class Guest
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Surname { get; set; }

    public string? Patronym { get; set; }

    public DateOnly? Birthdate { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public string? Passport { get; set; }

    public virtual ICollection<Bill> Bills { get; set; } = new List<Bill>();

    public virtual ICollection<Rent> Rents { get; set; } = new List<Rent>();

    public virtual ICollection<RoomAccess> RoomAccesses { get; set; } = new List<RoomAccess>();
}
