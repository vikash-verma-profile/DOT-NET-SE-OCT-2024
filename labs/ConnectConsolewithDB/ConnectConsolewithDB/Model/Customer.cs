using System;
using System.Collections.Generic;

namespace ConnectConsolewithDB.Model;

public partial class Customer
{
    public int Customerid { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
