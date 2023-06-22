namespace Lab2.Data;

/// <summary>
/// Simple POCO class for work with Data
/// </summary>
public class DataClass
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string type { get; set; }
    public int reiting { get; set; }
    public string toString() 
        => Name + " " + type + " " + reiting;
    
    // TODO: Add attributes here
}
