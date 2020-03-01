namespace TODOApp.Models.db
{
    public class Todo : ITodo
    {
        public int Id { get; set; }
        public string Text { get; set; }
    }
}
