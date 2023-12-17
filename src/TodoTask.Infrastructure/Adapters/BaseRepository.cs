using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoTask.Infrastructure.Persistence.Database;

namespace TodoTask.Infrastructure.Adapters
{
    public abstract class BaseRepository
    {
        protected readonly TodoTaskDbContext _dbContext;
        protected readonly IMapper _mapper;

        public BaseRepository(TodoTaskDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
    }
}
