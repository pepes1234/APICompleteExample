using System;
using System.Collections.Generic;

namespace backend.Model;

public partial class Nota
{
    public int Id { get; set; }

    public int? UsuarioId { get; set; }

    public string Nota1 { get; set; }

    public virtual Usuario Usuario { get; set; }
}
