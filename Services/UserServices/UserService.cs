using Apex.GameZone.UI.Models.Auth;
using Apex.GameZone.UI.Services.CommonIdentityServices;

namespace Apex.GameZone.UI.Services.UserServices;

public class UserService : IUserService
{
    private readonly ICommonIdentityService _commonIdentityService;

    public UserService(ICommonIdentityService commonIdentityService)
    {
        _commonIdentityService = commonIdentityService;
    }

    public async Task<UserModel> GetUserById(int id)
    {
        var requestUrl = "user";
        return await _commonIdentityService.HttpRequest<string, UserModel>(HttpMethod.Get, "", requestUrl, null);
    }
}