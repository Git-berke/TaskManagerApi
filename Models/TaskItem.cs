using System.ComponentModel.DataAnnotations.Schema;

namespace TaskManagerApi.Models
{
    public class TaskItem
    {
        public int Id { get; set; } // Primary Key
        public string Title { get; set; }
        public string? Description { get; set; }
        public string Category { get; set; } // örn: Günlük, Haftalık, Aylık
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        // Foreign Key
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public User? User { get; set; }
    }
}
