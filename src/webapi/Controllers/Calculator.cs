using AutoMapper;
using distributed_calculator.Models.DTOs;
using eventbus.Events;
using Microsoft.AspNetCore.Mvc;
using MassTransit;

namespace distributed_calculator.Controllers {
    [Route("api/calc")]
    [ApiController]
    public class Calculator : ControllerBase {
        private readonly IMapper mapper;
        private readonly ILogger<Calculator> logger;
        private readonly IPublishEndpoint publishEndPoint;

        public Calculator(IMapper mapper, IPublishEndpoint publishEndPoint, ILogger<Calculator> logger) {
            this.mapper = mapper;
            this.publishEndPoint = publishEndPoint;
            this.logger = logger;
        }

        [HttpPost]
        public async Task<IActionResult> sendOperation([FromBody] OperationDTO operationDTO) {
            var operationEvent = mapper.Map<OperationEvent>(operationDTO);
            logger.LogInformation(operationDTO.ToString());
            await publishEndPoint.Publish(operationEvent);
            return Ok();
        }
    }
}
