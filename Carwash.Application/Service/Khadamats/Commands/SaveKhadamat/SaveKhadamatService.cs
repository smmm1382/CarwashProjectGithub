using Carwash.Application.Interface;
using Carwash.Common.ResultDto;
using Carwash.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carwash.Application.Service.Khadamats.Commands.SaveKhadamat;

public class SaveKhadamatService : ISaveKhadamatService
{
    private readonly IAppDbContext _context;
    public SaveKhadamatService(IAppDbContext context)
    {
        _context = context;
    }

    public async Task<ResultDto<SaveKhadamatDto>> Execute(SaveKhadamatDto saveKhadamatDto)
    {
        var flag = await _context.Khadamats.AnyAsync(d => d.Name == saveKhadamatDto.Name);

        if (saveKhadamatDto.Id == null && flag == true)
        {
            return new ResultDto<SaveKhadamatDto>
            {
                IsSuccess = true,
                Message = "شما نمیتوانید خدمات تکراری اضافه کنید",
                StatusCode = 404
            };
        }
        else if (saveKhadamatDto.Id == null)
        {
            Khadamat khadamat1 = new Khadamat
            {
                Name = saveKhadamatDto.Name,
                Price = saveKhadamatDto.Price,
            };

            await _context.Khadamats.AddAsync(khadamat1);
            await _context.SaveChangesAsync();

            return new ResultDto<SaveKhadamatDto>
            {
                IsSuccess = true,
                Message = "خدمات با موفقیت اضافه شد",
                StatusCode = 200,
                Data = saveKhadamatDto
            };
        }
        else
        {
            var khadamat = _context.Khadamats.Find(saveKhadamatDto.Id);

            if (khadamat == null)
            {
                return new ResultDto<SaveKhadamatDto>
                {
                    IsSuccess = false,
                    Message = "شناسه ی وارد شده یافت نشد",
                    StatusCode = 404
                };
            }
            else
            {
                khadamat.Name = saveKhadamatDto.Name;
                khadamat.Price = saveKhadamatDto.Price;
            }
            await _context.SaveChangesAsync();

            return new ResultDto<SaveKhadamatDto>
            {
                IsSuccess = true,
                Message = "ویرایش با موفقیت انجام شد",
                StatusCode = 200,
                Data = saveKhadamatDto
            };
        }
    }
}
