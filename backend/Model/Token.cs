using System;
using System.Collections.Generic;

namespace backend.Model;

public partial class Token
{
    public int Id { get; set; }

    public int? UserId { get; set; }

    public string Value { get; set; }

    public virtual Usuario User { get; set; }
}
