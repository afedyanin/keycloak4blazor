namespace BlazorShared.Authorization;
public class ClaimValue
{
    public string Type { get; set; } = string.Empty;

    public string Value { get; set; } = string.Empty;

    public ClaimValue()
    {
    }

    public ClaimValue(string type, string value)
    {
        Type = type;
        Value = value;
    }
}
