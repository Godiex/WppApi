namespace Application.Ports;

public interface IMessageTextSender
{
    Task SendMenssage(string bodyMessage, List<string> cellphoneNumbers);
}