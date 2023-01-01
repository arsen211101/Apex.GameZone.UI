using System.Net.Http.Headers;

namespace Apex.GameZone.UI.Helpers;

public class HttpHelper
{
    public static AuthenticationHeaderValue AuthenticationHeaderValueBuilder(string accessToken)
    {
        AuthenticationHeaderValue authorization = null;
        if (!string.IsNullOrEmpty(accessToken))
            authorization = new AuthenticationHeaderValue("Bearer", accessToken);
        return authorization;
    }
}