using WebApi.Models;

public class UserEvent
{
    public int UserEventID { get; set; }
    public string UserID { get; set; }
    public int EventID { get; set; }
    public int Points { get; set; }

    public virtual Event Event { get; set; }
    public virtual User User { get; set; }
}