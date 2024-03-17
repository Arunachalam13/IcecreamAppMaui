﻿using IcecreamMAUI.Api.Data;
using IcecreamMAUI.Api.Data.Entities;
using IcecreamMAUI.Shared.Dtos;
using Microsoft.EntityFrameworkCore;

namespace IcecreamMAUI.Api.Services
{
    public class AuthService(DataContext dataContext, TokenService tokenService, PasswordService passwordService)
    {
        private readonly DataContext _dataContext = dataContext;
        private readonly TokenService _tokenService = tokenService;
        private readonly PasswordService _passwordService = passwordService;
        public async Task<ResultWithDataDto<AuthResponseDto>> SignupAsync(SignupRequestDto dto)
        {
            if (await _dataContext.Users.AsNoTracking().AnyAsync(u => u.Email == dto.Email))
            {
                return ResultWithDataDto<AuthResponseDto>.Failure("Email already exists");
            }

            var user = new User
            {
                Email = dto.Email,
                Address = dto.Address,
                Name = dto.Name,
            };

            (user.Salt, user.Hash) = _passwordService.GenerateSaltAndHash(dto.Password);

            try
            {
                await _dataContext.Users.AddAsync(user);
                await _dataContext.SaveChangesAsync();
                return GenerateAuthResponse(user);
            }
            catch (Exception ex)
            {
                return ResultWithDataDto<AuthResponseDto>.Failure(ex.Message);
            }
        }

        public async Task<ResultWithDataDto<AuthResponseDto>> SigninAsync(SigninRequestDto dto)
        {
            var dbUser = await _dataContext.Users
                                           .AsNoTracking()
                                           .FirstOrDefaultAsync(u => u.Email == dto.Email);

            if (dbUser == null)
                return ResultWithDataDto<AuthResponseDto>.Failure("User does not exist");

            if (!_passwordService.Compare(dto.Password, dbUser.Salt, dbUser.Hash))
                return ResultWithDataDto<AuthResponseDto>.Failure("Incorrect password");

            return GenerateAuthResponse(dbUser);
        }

        private ResultWithDataDto<AuthResponseDto> GenerateAuthResponse(User user)
        {
            var loggedInUser = new LoggedInUser(user.ID, user.Name, user.Email, user.Address);
            var token = _tokenService.GenarateJwt(loggedInUser);

            var authResponse = new AuthResponseDto(loggedInUser, token);

            return ResultWithDataDto<AuthResponseDto>.Success(authResponse);
        }
    }
}
