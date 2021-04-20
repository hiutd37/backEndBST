namespace BookStore.View_Models.BookComment
{
    public class BookCommentViewModel
    {
        public int Id { get; set; }
        public string Comment { get; set; }
        public double Rating { get; set; }
        public int BookId { get; set; }
        public int UserId { get; set; }
    }
}
