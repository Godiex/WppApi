using Application.Ports;
using Infrastructure.Adapters;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Extensions;

public static class MessageSenderExtensions
{
    public static IServiceCollection AddMessage(this IServiceCollection servicios)
    {
        servicios.AddTransient<IMessageTextSender, MessageTextSender>();
        return servicios;
    }
}