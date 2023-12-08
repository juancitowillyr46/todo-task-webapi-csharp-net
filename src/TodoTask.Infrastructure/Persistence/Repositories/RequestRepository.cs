using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoTask.Domain.Models;
using TodoTask.Domain.Ports.Outbound;
using TodoTask.Infrastructure.Persistence.Database;
using TodoTask.Infrastructure.Persistence.Entities;

namespace TodoTask.Infrastructure.Persistence.Repositories
{
    public class RequestRepository : IRequestRepository
    {
        private readonly TodoTaskDbContext _dbContext;
        private readonly IMapper _mapper;

        public RequestRepository(TodoTaskDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public RequestModel CreateRequest(RequestModel requestModel)
        {
            RequestEntity requestEntity = _mapper.Map<RequestEntity>(requestModel);
            _dbContext.Requests?.Add(requestEntity);
            _dbContext.SaveChanges();
            return _mapper.Map<RequestModel>(requestEntity);
        }

        public bool UpdateRequest(int requestId, RequestModel requestModel)
        {
            RequestEntity? requestEntity = _dbContext.Requests?.Find(requestId);
            if (requestEntity != null)
            {
                requestEntity.AssetId = requestModel.AssetId;
                requestEntity.UpdatedBy = requestModel.UpdatedBy;
                requestEntity.UpdatedAt = requestModel.UpdatedAt;
                _dbContext.SaveChanges();
            }
            return requestEntity != null;
        }
    }
}
