namespace PolicyMicroservice;

public class Policy
{

    /*
    public DateTime Date { get; set; }

    public int TemperatureC { get; set; }

    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    public string? Summary { get; set; }

    */

    public int Id { get; set; }
    public string? BusinessClass { get; set; }

    public string? EmailAdress { get; set; }
    public int AuthorityLimit { get; set; }
}
