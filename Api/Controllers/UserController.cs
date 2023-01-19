using Application.UserCase.SendMessage;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;


[ApiController]
[Route("api/[controller]")]
public class WhatsappController
{
    private readonly IMediator _mediator;

    public WhatsappController(IMediator mediator) => _mediator = mediator;

    [HttpPost]
    public async Task Post(SendMassiveMessageCommand command) => await _mediator.Send(command);

}
