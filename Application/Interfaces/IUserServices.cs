﻿using Application.Models;

namespace Application.Interfaces
{
    public interface IUserServices
    {
        Task<UserResponse> AddUser(UserReq req, Guid authId, int userId, int locationId);

        Task<UserResponse> UpdateUser(int userId, UserUpdReq req, int locationId);

        Task<UserResponse> GetUserById(int userId);

        Task<List<UserResponse>> GetByFirstName(string? userFirstName);

        Task<UserResponse> GetUserByAuthId(Guid authId);

        Task<List<UserResponse>> GetUserByList();

        Task<List<UserResponse>> GetAllUserByIds(List<int> userIds);
    }
}
