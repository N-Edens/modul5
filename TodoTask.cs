namespace Model
{
    public class TodoTask
    {
        public long TodoTaskId { get; set; }
        public string? Text { get; set; }
        public bool Done { get; set; }

        // Fremmednøgle til User
        public long UserId { get; set; }
        public User User { get; set; } // Navigationsegenskab til User

        public TodoTask(string text, bool done, long userId)
        {
            this.Text = text;
            this.Done = done;
            this.UserId = userId;
        }
    }
}
