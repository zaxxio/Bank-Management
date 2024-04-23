namespace CQRS.Core.Events;

public class BaseEvent : Messages.Messages
{
    public BaseEvent(String type)
    {
        this.Type = type;
    }

    public int Version { get; set; }
    public String Type { get; set; }
}