using Microsoft.AspNetCore.Identity;

namespace CodePulse.API.Repositories.Inteface
{
    public interface ITokenRespository
    {
        string CreateJwtToken(IdentityUser user, List<string> roles);

    }
}
