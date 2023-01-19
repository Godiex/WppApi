using Application.Ports;
using RestSharp;

namespace Infrastructure.Adapters;

public class MessageTextSender : IMessageTextSender
{
    public async Task SendMenssage(string bodyMessage, List<string> cellphoneNumbers)
    {
        foreach (var number in cellphoneNumbers)
        {
            const string instanceId = "instance29580";
            const string token = "k04b5avsciiu1qib";
            const string url = "https://api.ultramsg.com/" + instanceId + "/messages/chat";
            var client = new RestClient(url);
            var request = new RestRequest(url, Method.Post);
            request.AddHeader("content-type", "application/x-www-form-urlencoded");
            request.AddParameter("token", token);
            request.AddParameter("to", number);
            request.AddParameter("body", bodyMessage);
            var response = await client.ExecuteAsync(request);
            if (response.ErrorMessage != null)
            {
                Console.WriteLine($"error al enviar el numero {number} - M {response.ErrorMessage}");
            }
        }
    }
}