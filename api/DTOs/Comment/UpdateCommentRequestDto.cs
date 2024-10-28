using System.ComponentModel.DataAnnotations;

namespace api.DTOs.Comment;

public class UpdateCommentRequestDto
{
    [Required]
    [MinLength(3, ErrorMessage = "Title min length is 3")]
    [MaxLength(100, ErrorMessage = "Title max length is 100")]
    public string Title { get; set; } = string.Empty;
    [Required]
    [MinLength(3, ErrorMessage = "Content min length is 3")]
    [MaxLength(100, ErrorMessage = "Content max length is 100")]
    public string Content { get; set; } = string.Empty;
}