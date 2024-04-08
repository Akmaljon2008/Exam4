namespace Domain.Models;

public class Parent
{
    public int Id { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string FullName { get; set; }
    public DateTime Dob { get; set; }
    public string PhoneNumber { get; set; }
    public string Mobile { get; set; }
    public DateTime DateOfJoin { get; set; }
    public Boolean Status { get; set; }     
    public DateTime LastLoginDate { get; set; }
    public DateTime LatLoginIp { get; set; }
}