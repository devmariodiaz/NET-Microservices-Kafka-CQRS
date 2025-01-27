namespace CQRS.Core.Events;
public abstract class BaseEvent : Message
{
    public BaseEvent(string type)
    {
        Type = type;
    }
    public int Version { get; set; }
    public string Type { get; set; }
}