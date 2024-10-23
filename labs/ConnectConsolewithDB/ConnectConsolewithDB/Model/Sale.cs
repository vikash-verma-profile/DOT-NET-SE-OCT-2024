using System;
using System.Collections.Generic;

namespace ConnectConsolewithDB.Model;

public partial class Sale
{
    public int Saledid { get; set; }

    public string? Product { get; set; }

    public int? Quantity { get; set; }

    public int? Price { get; set; }

    public DateTime? Saledate { get; set; }
}
