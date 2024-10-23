using System;
using System.Collections.Generic;

namespace ConnectConsolewithDB.Model;

public partial class Tblemployee
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Gender { get; set; }

    public int? Depid { get; set; }

    public int? Managerid { get; set; }

    public decimal? Salary { get; set; }

    public string? Empid { get; set; }
}
