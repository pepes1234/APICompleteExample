using System;
using System.Collections.Generic;

namespace backend.Model;

public partial class Usuario
{
    public int Id { get; set; }

    public string Nome { get; set; }

    public string Email { get; set; }

    public string Senha { get; set; }

    public virtual ICollection<Anotacao> Anotacaos { get; } = new List<Anotacao>();

    public virtual ICollection<Nota> Nota { get; } = new List<Nota>();

    public virtual ICollection<Token> Tokens { get; } = new List<Token>();
}
