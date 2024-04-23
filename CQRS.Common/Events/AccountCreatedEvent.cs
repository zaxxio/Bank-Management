using CQRS.Core.Events;

namespace CQRS.Common.Events;

public class AccountCreatedEvent : BaseEvent
{
    public String AccountHolder { get; set; }
    public Double Balance { get; set; }
    public String AccountType { get; set; }
    public DateTime CreatedAt { get; set; }
    
    public AccountCreatedEvent(string type) : base(nameof(AccountCreatedEvent))
    {
    }
}