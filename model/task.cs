class Task
{
    public int Id { get; set; }
    public string? TaskTitle { get; set; }
    public DateTime DueDate { get; set; }
    public enum Taskprority
    {
        Low,
        Medium,
        High,
    }
    public Taskprority Priority { get; set; } = Taskprority.Medium;
}