namespace CQRS.Command.Api.Domain;

public class Account
{
    private Guid Id { get; set; }
    public String AccountHolder { get; set; }
    public Double Balance { get; set; }
    public String AccountType { get; set; }
    public DateTime CreatedAt { get; set; }
}