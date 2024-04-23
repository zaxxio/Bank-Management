using CQRS.Core.Events;

namespace CQRS.Common.Events;

public class AccountClosedEvent : BaseEvent
{
    public String AccountHolder { get; set; }
    public Double Balance { get; set; }
    public String AccountType { get; set; }
    public DateTime CreatedAt { get; set; }

    public AccountClosedEvent(string type) : base(nameof(AccountClosedEvent))
    {
    }
}