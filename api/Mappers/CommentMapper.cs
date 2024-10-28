using api.DTOs.Comment;
using api.Models;

namespace api.Mappers;

public static class CommentMapper
{
    public static CommentDto ToCommentDto(this Comment commentModel)
    {
        return new CommentDto
        {
            CommentId = commentModel.CommentId,
            Title = commentModel.Text,
            Content = commentModel.Content,
            CreatedOn = commentModel.CreatedOn,
            StockId = commentModel.StockId
        };
    }
    
    public static Comment ToCommentFromCreate(this CreateCommentDto commentDto, int stockId)
    {
        return new Comment
        {
            Text = commentDto.Title,
            Content = commentDto.Content,
            StockId = stockId
        };
    }
    
    public static Comment ToCommentFromUpdate(this UpdateCommentRequestDto commentDto)
    {
        return new Comment
        {
            Text = commentDto.Title,
            Content = commentDto.Content
        };
    }
}