namespace ClaimMicroservice;

public class Claim
{
    /*
    public DateTime Date { get; set; }

    public int TemperatureC { get; set; }

    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    public string? Summary { get; set; }
    */

    public int Id { get; set; }
    public int PolicyId { get; set; }
    public DateTime createDate { get; set; }
    public int ClaimHandleId { get; set; }
    public int StatusId { get; set; }
    public decimal CurrentPostion { get; set; }
}
