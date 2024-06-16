namespace WebApplication1.Models;

public class Artist
{
    public string Name { get; set; }
    public string Role { get; set; }

    public Artist(string name, string role)
    {
        Name = name;
        Role = role;
    }

    public Artist()
    {
    }

    public string DisplayText => Name + ": " + Role;

}