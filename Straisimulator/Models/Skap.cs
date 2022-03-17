namespace Straisimulator.Models;

public class Skap
{
    public string OrderNumber { get; set; }
    public string ItemCom { get; set; }
    public decimal Height { get; set; }
    public decimal Length { get; set; }
    public int QueTimeLeft { get; set; }
    public int QueTimeRight { get; set; }
}