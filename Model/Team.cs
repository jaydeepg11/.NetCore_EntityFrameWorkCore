public class Team
{
    public int TeamID { get; set; }
    public string? TeamName{get;set;}

    public ICollection<Employee>? employees{get;set;}
}