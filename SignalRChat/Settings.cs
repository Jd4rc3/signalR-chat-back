namespace SignalRChat;

public class Settings
{
    public const string Section = "Settings";

    public string? SecurityKey { get; set; }

    public string? Issuer { get; set; }

    public string? Audience { get; set; }
}