using eventbus.Events;
using MassTransit;
using Microsoft.Extensions.Logging;
using System.Data;

namespace calcservice.EventBusConsumer {
    public class OperationEventsConsumer : IConsumer<OperationEvent> {
        private readonly ILogger<OperationEventsConsumer> logger;

        public OperationEventsConsumer(ILogger<OperationEventsConsumer> logger) {
            this.logger = logger;
        }

        public Task Consume(ConsumeContext<OperationEvent> msg) {
            string operation = $"{msg.Message.N1} {msg.Message.operation} {msg.Message.N2}";
            DataTable dt = new DataTable();
            var r = dt.Compute(operation, "");
            logger.LogInformation($"{operation} = {r}");
            return Task.CompletedTask;
        }
    }
}
