namespace api.DTOs.Comment;

public class CommentDto
{
    public int CommentId { get; set; }
    public string Text { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
    public DateTime CreatedOn { get; set; } = DateTime.Now;
    public int? StockId { get; set; }
}