namespace ProjectApp.Model;

public record Profile
{
    public int At { get; init; }
    public string Title { get; init; }
    public string Position { get; init; }
    public Status Status { get; init; }
}