using Microsoft.AspNetCore.Mvc;

namespace Cw5.Controllers;
[ApiController]
//Just /animals by REST
[Route("/animals-controller")]
public class AnimalsController:ControllerBase
{
    [HttpGet]
    public IActionResult GetAnimals()
    {
        return Ok();
    }

    [HttpGet("{id}")]
    public IActionResult GetAnimalById(int id)
    {
        return Ok(id);
    }

    [HttpPost]
    public IActionResult AddAnimals()
    {
        return Created();
    }
}