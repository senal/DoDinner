using DoDinner.Application.Common.Interfaces.Services;

namespace DoDinner.Infrastructure.Services;

public class DateTimeProvider : IDateTimeProvider
{
    public DateTime UtcNow => DateTime.Now;
}