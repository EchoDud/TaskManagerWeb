using TaskManagerWeb.Models;

namespace TaskManagerWeb
{
    public class User
    {
        public int Id { get; set; }
        public string TabNumber { get; set; }
        public string Department { get; set; }
        public IEnumerable<TaskItem> TaskItems { get; set; }
    }
}
