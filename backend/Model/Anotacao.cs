using System;
using System.Collections.Generic;

namespace backend.Model;

public partial class Anotacao
{
    public int Id { get; set; }

    public int? UsuarioId { get; set; }

    public string Title { get; set; }

    public string Conteudo { get; set; }

    public virtual Usuario Usuario { get; set; }
}
