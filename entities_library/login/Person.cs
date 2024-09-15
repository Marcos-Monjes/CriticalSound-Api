namespace entities_library.login;

public class Person 
{
    public long Id { get; set; }

    public required string Name { get; set; } //eliminar estos datos en caso que no esten en el formualrio de registro

    public required string LastName { get; set; }

    public required string Mail { get; set; }

    public DateTime? Birthdate { get; set; }
}