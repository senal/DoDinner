using DoDinner.Domain.Entities;

namespace DoDinner.Application.Services.Authentication;

public record AuthenticationResult (
    User User,
    string Token
);