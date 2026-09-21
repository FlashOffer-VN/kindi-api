// src/Kindi.API.Application/Features/OfferRequests/Handlers/GetOfferRequestByIdHandler.cs
using AutoMapper;
using Kindi.API.Application.DTOs.responses;
using Kindi.API.Application.Features.OfferRequests.Queries;
using Kindi.API.Domain.Entities;
using Kindi.API.Domain.Interfaces;
using MediatR;

namespace Kindi.API.Application.Features.OfferRequests.Handlers;

public class GetOfferRequestByIdHandler : IRequestHandler<GetOfferRequestByIdQuery, OfferRequestResponseDto?>
{
	private readonly IRepository<OfferRequest> _repository;
	private readonly IMapper _mapper;

	public GetOfferRequestByIdHandler(IRepository<OfferRequest> repository, IMapper mapper)
	{
		_repository = repository;
		_mapper = mapper;
	}

	public async Task<OfferRequestResponseDto?> Handle(GetOfferRequestByIdQuery request, CancellationToken cancellationToken)
	{
		var entity = await _repository.GetByIdAsync(request.Id, cancellationToken);
		if (entity == null || entity.IsDeleted)
			return null;

		return _mapper.Map<OfferRequestResponseDto>(entity);
	}
}