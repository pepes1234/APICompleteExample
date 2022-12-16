using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace backend.Controllers;

using Model;

[ApiController]
[Route("Note")]
public class NoteController : ControllerBase
{
    [HttpGet("save")]
    public async Task<IActionResult> Save(Anotacao note)
    {
        var context = new ExemploContext();
        var errors = new List<string>();
        
        if(note == null)
            errors.Add("Anotação nula.");
        if((note.Title == null || note.Title.Trim() == "") && 
                (note.Conteudo == null || note.Conteudo.Trim() == ""))
            errors.Add("Anotação sem conteudo.");
        
        if(errors.Count() > 0)
            return BadRequest(errors);
        
        try
        {
            await context.AddAsync(note);
            await context.SaveChangesAsync();
            return Ok("Notas salvas com sucesso.");
        }
        catch
        {
            return Ok("Erro no servidor.");
        }
    }
    [HttpGet("getNotes/{pageNumber}-{notesPerPage}-{search}")]
    public async Task<IActionResult> getNotes(
        int pageNumber = 1,
        int notesPerPage = 10,
        string search = null)
    {
        var context = new ExemploContext();

        try
        {
            var query = search == null ? context.Anotacaos :
                    context.Anotacaos
                    .Where(a => a.Title.Contains(search) || a.Conteudo.Contains(search));

            var pages = query
                .Skip(pageNumber - 1)
                .Take(notesPerPage)
                .ToListAsync();

            return Ok(pages);
        }
        catch
        {
            return Ok("Erro no servidor");
        }
        

    }
    //select Anotacao.Conteudo, Anotacao.Title from Anotacao where Anotacao.Conteudo = 'programacao' or Anotacao.Title = 'programacao'
}