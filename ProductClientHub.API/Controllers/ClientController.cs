using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using ProductClientHub.Communication.Requests;
using ProductClientHub.Communication.Responses;
using ProductClientHub.API.UseCases.Clients.Register;

namespace ProductClientHub.API.Controllers;
[ApiController]
[Route("api/[controller]")]
public class ClientsController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseClientJson), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ResponseClientJson), StatusCodes.Status400BadRequest)]
    public IActionResult Register([FromBody] RequestClientJson request)
    {
        try
        {
            var useCase = new RegisterClientUseCase();

            var response = useCase.Execute(request);

            return Created(string.Empty, response);
        }
        catch (ArgumentException ex)
        {
            return BadRequest(new ResponsesErrorMessagesJson(ex.Message));
        }
        catch
        {
            return StatusCode(
                StatusCodes.Status500InternalServerError,
                new ResponsesErrorMessagesJson("Erro desconhecido")
);

        }
    }

    [HttpPut]
    public IActionResult Update()
    {
        return Ok();
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok();
    }

    [HttpGet]
    [Route("{id}")]
    public IActionResult GetById([FromRoute] Guid id)
    {
        return Ok();
    }

    [HttpDelete]
    public IActionResult Delete()
    {
        return Ok();
    }
}
