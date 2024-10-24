using System;
using System.Collections.Generic;

namespace DemoApp.Model;

public partial class Login
{
    public int Id { get; set; }

    public string UserName { get; set; } = null!;

    public string? Password { get; set; }
}
