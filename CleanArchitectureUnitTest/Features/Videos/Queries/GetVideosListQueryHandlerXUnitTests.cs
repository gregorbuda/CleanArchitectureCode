using AutoFixture;
using AutoMapper;
using CleanArchitecture.Application.Contracts.Persistence;
using CleanArchitecture.Application.Features.Videos.Queries.GetVideosList;
using CleanArchitecture.Application.Mappings;
using CleanArchitecture.Domain;
using CleanArchitecture.Infrastructure.Repositories;
using CleanArchitectureUnitTest.Mocks;
using Moq;
using Shouldly;
using Xunit;

namespace CleanArchitectureUnitTest.Features.Videos.Queries
{
    public  class GetVideosListQueryHandlerXUnitTests
    {
        private readonly IMapper _mapper;
        private readonly Mock<UnitOfWork> _unitOfWork;

        public GetVideosListQueryHandlerXUnitTests()
        {
            _unitOfWork = MockUnitOfWork.GetUnitOfWork();
            var mapperConfig = new MapperConfiguration(c =>
            {
                c.AddProfile<MappingProfile>();
             });
            _mapper = mapperConfig.CreateMapper();

            MockVideoRepository.AddDataVideoRepository(_unitOfWork.Object.StreamerDbContext);
        }

        [Fact]
        public async Task GetVideoListTask()
        {
            var handler = new GetVideosListQueryHandler(_unitOfWork.Object, _mapper);

            var request = new GetVideosListQuery("Gregor");

            var result = await handler.Handle(request, CancellationToken.None);

            result.ShouldBeOfType<List<VideosVm>>();

            result.Count.ShouldBe(1);
        }
    }
}
