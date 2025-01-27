using System;
using System.Collections.Generic;

namespace demoexam.Models;

public partial class User
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Role { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }

    public bool IsFirstLogin { get; set; }

    public int FalledLoginAttempts { get; set; }

    public bool IsLocked { get; set; }

    public DateTime? LastLoginDate { get; set; }
    
}
