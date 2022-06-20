namespace PolicyLineMicroservice;

public class PolicyLine
{
    /*
    public DateTime Date { get; set; }

    public int TemperatureC { get; set; }

    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    public string? Summary { get; set; }*/

    public int Id { get; set; }
    public decimal WrittenLine { get; set; }
    public DateTime UpdatedDate { get; set; }

    public decimal SignedLine { get; set; }
}
