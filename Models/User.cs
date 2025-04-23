namespace TaskManagerApi.Models
{
    public class User
    {
        public int Id { get; set; } // Primary Key
        public string Username { get; set; }
        public string Email { get; set; }
        public byte[] PasswordHash { get; set; } // şifrelenmiş hali
        public byte[] PasswordSalt { get; set; } // şifreleme için tuz
        public ICollection<TaskItem>? Tasks { get; set; } // 1 kullanıcı, çok görev
    }
}
