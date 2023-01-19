using MediatR;

namespace Application.UserCase.SendMessage;

public record SendMassiveMessageCommand(string BodyMessage, string NumbersCellPhones) : IRequest;