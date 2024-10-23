using System;
using System.Collections.Generic;

namespace ConnectConsolewithDB.Model;

public partial class Auditlog
{
    public int? Employeeid { get; set; }

    public string? Action { get; set; }

    public DateTime? Actiondate { get; set; }
}
