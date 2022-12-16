using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace backend.Controllers;


using Model;
using Services;

[ApiController]
[Route("User")]
public class UserController : ControllerBase
{
    [HttpGet("register/{NomeUsuario}/{Email}/{Senha}")]
    public async Task<IActionResult> Register(Usuario user)
    {
        var context = new ExemploContext();
        var errors = new List<string>();

        if(user == null)
            errors.Add("Usuario não pode ser nulo");
        if(user.Nome.Trim() == null || user.Nome.Trim() == "")
            errors.Add("Nome não pode ser nulo.");
        if(user.Nome.Length <= 5)
            errors.Add("Nome tem que ter no minimo 6 caracteres.");
        if(user.Nome.Length > 16)
            errors.Add("Nome tem que ter no maximo 16 caracteres.");
        if(user.Email == "" || user.Email == null)
            errors.Add("Email não pode ser nulo");
        if(user.Senha == "" || user.Senha == null)
            errors.Add("Senha não pode ser nulo");
        if(user.Senha.Length <= 9)
            errors.Add("Senha tem que ter no minimo 6 caracteres.");
        if(user.Senha.Length > 20)
            errors.Add("Senha tem que ter no maximo 20 caracteres.");

        if(errors.Count() > 0)
            return BadRequest(errors);

        try
        {
            await context.AddAsync(user);
            await context.SaveChangesAsync();
            return Ok("Usuario salvo com sucesso.");
        }
        catch
        {
            return BadRequest("Erro no servidor.");
        }
    }
    [HttpGet("Login")]
    public async Task<IActionResult> Login(Usuario user,
        [FromServices]TokenService service)
    {
        var context = new ExemploContext();
        var errors = new List<string>();

        var possibleUser = await context.Usuarios.FirstOrDefaultAsync(u => u.Nome == user.Nome);

        if(possibleUser == null)
            errors.Add("Usuario inexistente.");
        if(user.Senha != possibleUser.Senha)
            errors.Add("Senha invalida.");
        
        if(errors.Count() > 0)
            return BadRequest(errors);

        var token = await service.CreateToken(user);
        return Ok(token.Value);
    }
}