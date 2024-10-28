using System;
using System.Collections.Generic;

namespace Ecommerce.WebApi.Model;

public partial class Order
{
    public int Id { get; set; }

    public string? OrderId { get; set; }

    public string? UserId { get; set; }

    public string? Address { get; set; }
}
