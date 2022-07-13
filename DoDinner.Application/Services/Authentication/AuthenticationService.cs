using DoDinner.Application.Common.Interfaces.Authentication;

namespace DoDinner.Application.Services.Authentication;

public class AuthenticationService: IAuthenticationService
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator;

    public AuthenticationService(IJwtTokenGenerator jwtTokenGenerator)
    {
        _jwtTokenGenerator = jwtTokenGenerator;
    }
    public AuthenticationResult Login(string email, string password)
    {
        return new AuthenticationResult( Guid.NewGuid(), "First Name", "Last Name", email, password);
    }

    public AuthenticationResult Register(string firstName, string lastName, string email, string password)
    {
        // -- registration steps
        // 1. Check if user exists
        // 2. Create user (generate unique ID)
        // 3. Create JWT token
        var userId = Guid.NewGuid();
        var token = _jwtTokenGenerator.GenerateToken(userId, firstName, lastName);
        return new AuthenticationResult(Guid.NewGuid(), firstName, lastName, email, token);
    }
}