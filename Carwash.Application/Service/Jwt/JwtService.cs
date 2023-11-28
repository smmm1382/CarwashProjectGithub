using Carwash.Application.Interface;
using Carwash.Common.ResultDto;
using CryptoHelper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Carwash.Application.Service.Jwt;

public class JwtService : IJwtService
{
    private readonly IAppDbContext _context;
    private readonly IConfiguration _configuration; 
    public JwtService(IAppDbContext context, IConfiguration configuration)
    {
        _context = context;
        _configuration = configuration;
    }

    public ResultDto<string> Generate(LoginDto loginDto)
    {

        var manager = _context.Managers.FirstOrDefault(d => d.Email == loginDto.Email);
         
        if (manager == null || !Crypto.VerifyHashedPassword(manager.Password, loginDto.Password))
        {
            return new ResultDto<string>
            {
                IsSuccess = false,
                Message = "نام کاربری یا رمز عبور اشتباه است",
                StatusCode = 404,
            };
        }



        var tokenKey = Encoding.UTF8.GetBytes(_configuration["Autentication:Key"]);
        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Issuer = _configuration["Autentication:Issuer"],
            Audience = _configuration["Autentication:Audience"],
            IssuedAt = DateTime.Now,
            Subject = new ClaimsIdentity(new Claim[]
          {
             new Claim("FullName", manager.FirstName + " " + manager.LastName),
             new Claim(ClaimTypes.Email,manager.Email),
             new Claim ("Password",manager.Password),
             new Claim(ClaimTypes.NameIdentifier, manager.Id.ToString())
          }),
            Expires = DateTime.Now.AddDays(7),
            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenKey), SecurityAlgorithms.HmacSha256Signature)
        };
        var tokenHandler = new JwtSecurityTokenHandler();
        var token = tokenHandler.CreateToken(tokenDescriptor);
        var Jwt = tokenHandler.WriteToken(token);
        return new ResultDto<string>
        {
            IsSuccess = true,
            Message = "توکن با موفقیت ایجاد شد",
            StatusCode = 200,
            Data = Jwt
        };
    }


}
