namespace Domain.Models;

public class Classroom
{
    public int  Id { get; set; }
    public DateTime Year { get; set; }
    public int GradeId { get; set; }
    public string Section { get; set; }
    public Boolean Status { get; set; }
    public string Remarks { get; set; }
    public int TeacherId { get; set; }
}