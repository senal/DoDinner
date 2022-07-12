namespace DoDinner.Application.Services.Authentication;

public class AuthenticationService: IAuthenticationService
{
    public AuthenticationResult Login(string email, string password)
    {
        return new AuthenticationResult( Guid.NewGuid(), "First Name", "Last Name", email, password);
    }

    public AuthenticationResult Register(string firstName, string lastName, string email, string password)
    {
        return new AuthenticationResult(Guid.NewGuid(), firstName, lastName, email, password);
    }
}