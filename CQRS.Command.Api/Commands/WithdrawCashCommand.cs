using CQRS.Core.Commands;

namespace CQRS.Command.Api.Commands;

public class WithdrawCashCommand : BaseCommand
{
    public String AccountHolder { get; set; }
    public Double Balance { get; set; }
    public String AccountType { get; set; }
    public DateTime createdAt { get; set; }
}