namespace To_Do_List;

public class Task
{
    private string taskName;
    private string dueDate;
    private int priority;
    private bool isTaskDone;

    public Task(string taskName, string dueDate, int priority = 4)
    {
        this.taskName = taskName;
        this.dueDate = dueDate;
        this.priority = priority;
        isTaskDone = false;
    }

    public string GetTaskName
    {
        get { return taskName; }
    }
    public string GetDueDate
    {
        get { return dueDate; }
    }
    public int GetPriority
    {
        get { return priority; }
    }
    public bool TaskStatus
    {
        get { return isTaskDone; }
        set { isTaskDone = value; }
    }
}