namespace Domain.Models;

public class Attendancy
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public int StudentId  { get; set; }
    public Boolean Status { get; set; }
    public string Remarks { get; set; }
}