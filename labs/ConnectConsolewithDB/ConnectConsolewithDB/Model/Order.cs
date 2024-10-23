using System;
using System.Collections.Generic;

namespace ConnectConsolewithDB.Model;

public partial class Order
{
    public int Orderid { get; set; }

    public int? Customerid { get; set; }

    public virtual Customer? Customer { get; set; }
}
