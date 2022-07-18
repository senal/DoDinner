using DoDinner.Domain.Entities;

namespace DoDinner.Application.Common.Interfaces.Authentication;

public interface IJwtTokenGenerator 
{
    string GenerateToken(User user);
}