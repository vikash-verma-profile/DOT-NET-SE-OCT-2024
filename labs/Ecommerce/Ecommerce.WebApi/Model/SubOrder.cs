using System;
using System.Collections.Generic;

namespace Ecommerce.WebApi.Model;

public partial class SubOrder
{
    public int Id { get; set; }

    public int? OrderId { get; set; }

    public int? ProductId { get; set; }

    public int? Quantity { get; set; }
}
