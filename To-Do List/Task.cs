namespace To_Do_List;

public class Task
{
    private string taskName;
    private DateTime dueDate;
    private int priority;
    private bool isTaskDone;

    public Task(string taskName, DateTime dueDate, int priority = 4)
    {
        TaskName = taskName;
        DueDate = dueDate;
        Priority = priority;
        IsTaskDone = false;
    }

    public string TaskName
    {
        get { return taskName; }
        set
        {
            if (value == null)
            {
                taskName = "";
            }
            else
            {
                taskName = value;
            }
        }
    }
    public DateTime DueDate
    {
        get { return dueDate; }
        set { dueDate = value; }
    }
    public int Priority
    {
        get { return priority; }
        set
        {
            if (value < 1 || value > 4)
            {
                priority = 4;
            }
            else
            {
                priority = value;
            }
        }
    }
    public bool IsTaskDone
    {
        get { return isTaskDone; }
        set { isTaskDone = value; }
    }
}