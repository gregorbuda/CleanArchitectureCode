using AutoMapper;
using CleanArchitecture.Application.Contracts.Infrastructure;
using CleanArchitecture.Application.Features.Streamers.Commands;
using CleanArchitecture.Application.Mappings;
using CleanArchitecture.Infrastructure.Repositories;
using CleanArchitectureUnitTest.Mocks;
using Microsoft.Extensions.Logging;
using Moq;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CleanArchitectureUnitTest.Features.CreateStreamer
{
    public class CreateStreammerCommandHandlerXUnitTests
    {
        private readonly IMapper _mapper;
        private readonly Mock<UnitOfWork> _unitOfWork;
        private readonly Mock<IEmailService> _emailservice;
        private readonly Mock<ILogger<CreateStreamerCommandHandler>> _logger;

        public CreateStreammerCommandHandlerXUnitTests()
        {
            _unitOfWork = MockUnitOfWork.GetUnitOfWork();

            var mapperConfig = new MapperConfiguration(c =>
            {
                c.AddProfile<MappingProfile>();
            });

            _mapper = mapperConfig.CreateMapper();

            _emailservice = new Mock<IEmailService>();

            _logger = new Mock<ILogger<CreateStreamerCommandHandler>>();

            MockStreamerRepository.AddDataStreamerRepository(_unitOfWork.Object.StreamerDbContext);
        }


        [Fact]
        public async Task CreateStreamerCommand_InputStreamer_ReturnNumber()
        {
            var streamerInput = new CreateStreamerCommand
            {
                Nombre = "Gregor",
                Url = "google.com"
            };

            var streamerOutput = new CreateStreamerCommandHandler(_unitOfWork.Object, _mapper, _emailservice.Object, _logger.Object);

            var result = await streamerOutput.Handle(streamerInput, CancellationToken.None);

            result.ShouldBeOfType<int>();
        }
    }
}
