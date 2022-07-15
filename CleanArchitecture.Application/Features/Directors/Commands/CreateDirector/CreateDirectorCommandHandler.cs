﻿using AutoMapper;
using CleanArchitecture.Application.Contracts.Persistence;
using MediatR;
using Microsoft.Extensions.Logging;
using CleanArchitecture.Domain;

namespace CleanArchitecture.Application.Features.Directors.Commands.CreateDirector
{
    public class CreateDirectorCommandHandler : IRequestHandler<CreateDirectorCommand, int>
    {
        private readonly ILogger<CreateDirectorCommandHandler> _logger;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public CreateDirectorCommandHandler(ILogger<CreateDirectorCommandHandler> logger, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<int> Handle(CreateDirectorCommand request, CancellationToken cancellationToken)
        {
            var directorEntity = _mapper.Map<Director>(request);

            _unitOfWork.Repository<Director>().AddEntity(directorEntity);

            var result = await _unitOfWork.Complete();

            if(result <= 0)
            {
                _logger.LogError("no se insertó el registro del director");
                throw new Exception("No se puede insertar el record del director");
            }

            return directorEntity.Id;
        }
    }
}
