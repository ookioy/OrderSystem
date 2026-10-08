namespace OrderSystem.Services;

public class TimeService : ITimeService
{
    public string GetCurrentTime()
    {
        return DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss 'UTC'");
    }
}