using Carwash.Application.Interface;
using Carwash.Common.ResultDto;
using Carwash.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carwash.Application.Service.Workers.Queries.SearchWorker
{
    public class SearchWorkerService : ISearchWorkerService
    {
        private readonly IAppDbContext _context;
        public SearchWorkerService(IAppDbContext context)
        {
            _context = context;
        }

        public async Task<ResultDto<List<Worker>>> Execute(SearchWorkerDto searchWorkerDto)
        {
            var worker = await _context.Workers.Where(d => d.LastName.Contains(searchWorkerDto.lastName) || d.Age == searchWorkerDto.Age).ToListAsync();

            return new ResultDto<List<Worker>>
            {
                IsSuccess = true,
                Message = "با موفقیت انجام شد",
                StatusCode = 200,
                Data = worker
            };
        }
    }
}
