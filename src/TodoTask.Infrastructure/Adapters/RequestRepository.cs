﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoTask.Domain.Enums;
using TodoTask.Domain.Models;
using TodoTask.Domain.Ports.Outbound;
using TodoTask.Infrastructure.Database;
using TodoTask.Infrastructure.Database.Persitence.Entities;

namespace TodoTask.Infrastructure.Adapters
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

        public bool AssignDriver(int requestId, RequestModel requestModel)
        {
            RequestEntity? requestEntity = _dbContext.Requests?.Find(requestId);
            if (requestEntity != null)
            {
                requestEntity.DriverId = requestModel.DriverId;
                requestEntity.UpdatedBy = requestModel.UserId;
                requestEntity.UpdatedAt = DateTime.Now;
                requestEntity.Status = requestModel.Status;
                _dbContext.SaveChanges();
            }
            return requestEntity != null;
        }

        public RequestModel CreateRequest(RequestModel requestModel)
        {
            RequestEntity requestEntity = _mapper.Map<RequestEntity>(requestModel);
            _dbContext.Requests?.Add(requestEntity);
            _dbContext.SaveChanges();
            return _mapper.Map<RequestModel>(requestEntity);
        }

        public bool FindAwaitingRequestsByUser(int userId)
        {
            int? count = _dbContext?.Requests?.Where(c => c.UserId == userId && c.Status == RequestStatusEnum.PENDING).Count();
            return (count > 0);
        }

        public RequestModel GetRequest(int requestId)
        {
            RequestEntity? requestEntity = _dbContext.Requests?.Find(requestId);
            return _mapper.Map<RequestModel>(requestEntity);
        }

        public bool UpdateRequest(int requestId, RequestModel requestModel)
        {
            RequestEntity? requestEntity = _dbContext.Requests?.Find(requestId);
            if (requestEntity != null)
            {
                requestEntity.UpdatedBy = requestModel.UpdatedBy;
                requestEntity.UpdatedAt = requestModel.UpdatedAt;
                _dbContext.SaveChanges();
            }
            return requestEntity != null;
        }

        public bool UpdateRequestStatus(int requestId, RequestModel requestModel)
        {
            RequestEntity? requestEntity = _dbContext.Requests?.Find(requestId);
            if (requestEntity != null)
            {
                requestEntity.UpdatedBy = requestModel.UpdatedBy;
                requestEntity.UpdatedAt = requestModel.UpdatedAt;
                requestEntity.Status = requestModel.Status;
                _dbContext.SaveChanges();
            }
            return requestEntity != null;
        }
    }
}
