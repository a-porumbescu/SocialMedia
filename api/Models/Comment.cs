using System.ComponentModel.DataAnnotations.Schema;

namespace api.Models;

[Table("Comments")]
public class Comment
{
    public int CommentId { get; set; }
    public string Text { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
    public DateTime CreatedOn { get; set; } = DateTime.Now.ToUniversalTime();
    public int? StockId { get; set; }
    public Stock? Stock { get; set; }
}