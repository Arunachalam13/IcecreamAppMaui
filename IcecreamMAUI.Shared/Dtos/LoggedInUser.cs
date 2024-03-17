namespace IcecreamMAUI.Shared.Dtos;

public record LoggedInUser(Guid Id, string Name, string Email, string Address);

// The alternate approach of above one is:
/*
 * public record LoggedInUser
{
    public Guid Id { get; init; }
    public string Name { get; init; }
    public string Email { get; init; }
    public string Address { get; init; }

    public LoggedInUser(Guid id, string name, string email, string address)
    {
        Id = id;
        Name = name;
        Email = email;
        Address = address;
    }
}
*/