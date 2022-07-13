namespace DoDinner.Infrastructure.Authentication;

public class JwtSettings
{
    public string Secret { get; set; } = default!;
    public int ExpiryMinutes { get; set; }
    public string Issuer { get; set; } = default!;
    public string Audience { get; set; } = default!;
    
}