﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoTask.Domain.Models;

namespace TodoTask.Domain.Ports.Inbound
{
    public interface IRequestService
    {
        RequestModel CreateRequest(RequestModel requestModel);
        bool UpdateRequest(int requestId, RequestModel requestModel);
        bool AssignDriver(int requestId, RequestModel requestModel);
        RequestModel GetRequest(int requestId);
    }
}
