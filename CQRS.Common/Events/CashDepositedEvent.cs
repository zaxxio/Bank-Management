using CQRS.Core.Events;

namespace CQRS.Common.Events;

public class CashDepositedEvent : BaseEvent
{
    public String AccountHolder { get; set; }
    public Double Balance { get; set; }
    public String AccountType { get; set; }
    public DateTime CreatedAt { get; set; }

    public CashDepositedEvent(string type) : base(nameof(CashDepositedEvent))
    {
    }
}