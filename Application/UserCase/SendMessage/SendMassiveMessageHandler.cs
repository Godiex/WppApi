using Application.Ports;
using AutoMapper;
using MediatR;

namespace Application.UserCase.SendMessage {

    public class SendMassiveMessageHandler : AsyncRequestHandler<SendMassiveMessageCommand>
    {
        private readonly IMapper _mapper;
        private readonly IMessageTextSender _messageTextSender;

        public SendMassiveMessageHandler(IMessageTextSender messageTextSender, IMapper mapper)
        {
            _mapper = mapper;
            _messageTextSender = messageTextSender;
        }

        protected override Task Handle(SendMassiveMessageCommand request, CancellationToken cancellationToken)
        {
            _ = request ?? throw new ArgumentNullException(nameof(request), "request object needed to handle this task");
            var numbers = request.NumbersCellPhones.Split(";").ToList();
            _messageTextSender.SendMenssage(request.BodyMessage, numbers);
            return Task.CompletedTask;
        }

    }
}