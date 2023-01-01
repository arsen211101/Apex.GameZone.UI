using Apex.GameZone.UI.Models.Auth;

namespace Apex.GameZone.UI.Services.UserServices;

public interface IUserService
{
    Task<UserModel> GetUserById(int id);
}